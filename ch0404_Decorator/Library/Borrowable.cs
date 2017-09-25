using System;
using System.Collections;

namespace ch0404_Decorator.Library
{
    class Borrowable : Decorator
    {
        protected ArrayList borrowers = new ArrayList();
        public Borrowable(LibraryItem libraryItem) : base(libraryItem) { }
        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }
        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }
        public override void Display()
        {
            base.Display();
            foreach (string borrower in borrowers)
                Console.WriteLine("     借出人: {0}", borrower);
        }
    }
}
