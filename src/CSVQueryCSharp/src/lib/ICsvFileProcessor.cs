namespace CSVQueryCSharp
{
    public interface ICsvFileProcessor
    {
        public List<string?> ProcessLineByLine();
    }
}