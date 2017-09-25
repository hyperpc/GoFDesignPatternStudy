using System;
using System.Collections;

namespace ch0509_Strategy.SortStrategy
{
    class ShellSort : SortStrategy
    {
        public override void Sort(ArrayList list)
        {
            //list.ShellSort();
            Console.WriteLine("外壳排序");
        }
    }
}
