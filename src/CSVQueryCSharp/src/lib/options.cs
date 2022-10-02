using System;
using System.Diagnostics.Metrics;
using System.IO;
using CommandLine;
using CommandLine.Text;

namespace CSVQueryCSharp
{
    public class Options
    {
        [Value(1, Required = true, MetaName = "FilePath", HelpText = "Csv file to query")]
        public string FilePath { get; set; }

        [Value(2, Required = true, MetaName = "ColumnIndex", HelpText = "Column to query should be an integer")]
        public int ColumnIndex { get; set; }

        [Value(3, Required = true, MetaName = "SearchValue", HelpText = "Value to query")]
        public string SearchValue { get; set; }

        public static void RunOptions(Options opts)
        {                     
            if (!File.Exists(opts.FilePath))
                throw new FileNotFoundException("File does not exist: " + opts.FilePath);

            if(!Path.HasExtension(opts.FilePath) || 
                Path.HasExtension(opts.FilePath) && 
                Path.GetExtension(opts.FilePath) != ".csv")
                    throw new FileLoadException("Invalid File Extension: " + Path.GetExtension(opts.FilePath));                        
        }
        public static void HandleParseError(IEnumerable<Error> errors)
        {
            var sentenceBuilder = SentenceBuilder.Create();
            foreach (var error in errors)
                throw new Exception(sentenceBuilder.FormatError(error));
        }
    }
}