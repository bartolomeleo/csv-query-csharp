using CommandLine;

namespace CSVQueryCSharp
{
    public partial class Search
    {       
        public static void Main(string[] args)
        {                    
            try
            {
                ParserResult<Options> opts = Parser.Default.ParseArguments<Options>(args).WithParsed(Options.RunOptions).WithNotParsed(Options.HandleParseError);
                List<string?> matchedValues = new CsvFileProcessor(opts).ProcessLineByLine();
                
                foreach (var value in matchedValues)
                    Console.WriteLine(value);
            }
            catch(Exception err)
            {
               Console.WriteLine(err.Message); 
            }             
        }       
    }
}