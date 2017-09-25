namespace ch0509_Strategy.ExportTable
{
    abstract class TableExporter
    {
        public abstract string GetExported(string[] data);
    }
}
