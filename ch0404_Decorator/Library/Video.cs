using System;

namespace ch0404_Decorator.Library
{
    class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playTime;
        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            this.NumCopies = numCopies;
            this.playTime = playTime;
        }
        public override void Display()
        {
            Console.WriteLine("\n影像 ---------- ");
            Console.WriteLine("     导演：{0}", director);
            Console.WriteLine("     片名：{0}", title);
            Console.WriteLine("     #数量：{0}", NumCopies);
            Console.WriteLine("     播放时间：{0}", playTime);
        }
    }
}
