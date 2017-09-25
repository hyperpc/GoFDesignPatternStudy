namespace ch0509_Strategy.SortStrategy
{
    class Client
    {
        public static void Test()
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Anna");
            studentRecords.Add("Vivek");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.Display();

        }
    }
}
