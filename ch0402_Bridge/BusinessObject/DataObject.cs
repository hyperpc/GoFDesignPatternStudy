namespace ch0402_Bridge.BusinessObject
{
    abstract class DataObject
    {
        public abstract void PriorRecord();
        public abstract void NextRecord();
        public abstract void NewRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}
