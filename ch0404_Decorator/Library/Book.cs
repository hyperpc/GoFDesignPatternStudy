using System;

namespace ch0404_Decorator.Library
{
    class Book : LibraryItem
    {
            private string author;
        private string title;
        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("\n书 ---------- ");
            Console.WriteLine("     作者：{0}", author);
            Console.WriteLine("     书名：{0}", title);
            Console.WriteLine("     #数量：{0}", NumCopies);
        }
    }
}
