using System;

namespace ch0404_Decorator.Library
{
    class Client
    {
        public static void Test()
        {
            Book book = new Book("Schnell", "My Home", 10);
            Video video = new Video("Spielberg", "Schindler's list", 20, 60);
            book.Display();
            video.Display();
            Console.WriteLine("\n影响增加可借属性:");
            Borrowable bv = new Borrowable(video);
            bv.BorrowItem("张三");
            bv.BorrowItem("李四");
            bv.Display();
            
        }
    }
}
