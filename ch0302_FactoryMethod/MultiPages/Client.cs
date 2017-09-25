using System;

namespace MultiPages
{
    class Client
    {
        public static void Test()
        {
            Document[] docs = new Document[2];
            docs[0] = new Resume();
            docs[1] = new Report();
            foreach (var doc in docs)
            {
                Console.WriteLine(string.Format("\n {0} ------- ", doc));
                foreach (var page in doc.Pages)
                    Console.WriteLine(string.Format("   {0}", page));
            }
        }
    }
}
