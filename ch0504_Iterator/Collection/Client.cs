using System;

namespace ch0504_Iterator.Collection
{
    public class Client
    {
        public static void Test()
        {
            Collection collection = new Collection();
            for (int i = 0; i < 9; i++)
            {
                collection[i] = new Item(string.Format("Item {0}", i));
            }
            
            Iterator iterator = new Iterator(collection);
            iterator.Step = 2;
            for (Item item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
                Console.WriteLine(item.Name);
        }
    }
}
