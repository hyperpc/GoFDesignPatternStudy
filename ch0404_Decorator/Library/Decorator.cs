﻿namespace ch0404_Decorator.Library
{
    abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
