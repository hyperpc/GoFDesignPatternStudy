using System;

namespace ch0510_TemplateMethod.BubbleSorter
{
    class Client
    {
        public static void Test()
        {
            int[] array = { 20, 14, 16, 9, 10, 13, 18 };
            double[] dArray = { 20.50, 20.43, 20.88, 20.45, 20.72 };
            int i;
            IntBubbleSorter ibs = new IntBubbleSorter();
            ibs.sort(array);
            Console.WriteLine("整型冒泡排序:");
            for (i = 0; i < array.Length - 1; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine();
            DoubleBubbleSorter dbs = new DoubleBubbleSorter();
            dbs.sort(dArray);
            Console.WriteLine("双精度型冒泡排序:");
            for (i = 0; i < dArray.Length - 1; i++)
            {
                Console.Write("{0}, ", dArray[i]);
            }
            Console.WriteLine();
        }
    }
}
