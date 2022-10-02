namespace CSVQueryCSharp
{
    public interface ICsvFileProcessor
    {
        public IAsyncEnumerable<List<string>> ProcessLineByLine();
    }
}