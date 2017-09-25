using System;
using System.Collections;

namespace ch0509_Strategy.SortStrategy
{
    class SortedList
    {
        private ArrayList list = new ArrayList();
        private SortStrategy sortStrategy;
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }
        public void Sort()
        {
            sortStrategy.Sort(list);
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Display()
        {
            foreach (var name in list)
                Console.WriteLine(" " + name);
        }
    }
}
