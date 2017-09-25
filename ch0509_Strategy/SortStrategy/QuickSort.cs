using System;
using System.Collections;

namespace ch0509_Strategy.SortStrategy
{
    class QuickSort : SortStrategy
    {
        public override void Sort(ArrayList list)
        {
            list.Sort();
            Console.WriteLine("快速排序");
        }
    }
}
