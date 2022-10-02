using CommandLine;

namespace CSVQueryCSharp
{
    public class CsvFileProcessor : ICsvFileProcessor
    {
        private readonly string _filePath;
        private readonly int _columnIndex;
        private readonly string? _searchValue;          

        public CsvFileProcessor(ParserResult<Options> options)
        {
            _filePath = options.Value.FilePath;
            _columnIndex = options.Value.ColumnIndex;
            _searchValue = options.Value.SearchValue;            
        }
        public List<string?> ProcessLineByLine()
        {            
            List<string?> matchedValues = new List<string?>();
            List<int> numberOfColumnsPerLine = new List<int> { };

            using (var streamReader = new StreamReader(_filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string? line = streamReader.ReadLine();
                    string row = line != null ? line.Split(';')[0] : " ";

                    var columns = row.Split(',');

                    numberOfColumnsPerLine.Add(columns.Length);

                    if (columns[_columnIndex] == _searchValue)
                        matchedValues.Add(line);
                }
            }

            if (numberOfColumnsPerLine.Max() != numberOfColumnsPerLine.Min())
                throw new Exception("Invalid csv format");

            return matchedValues;
        }

    }
}
