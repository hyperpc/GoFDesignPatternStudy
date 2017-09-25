using System;

namespace ch0402_Bridge.OSImage
{
    public class WinImg : IImageImp
    {
        public void DoPaint(string str)
        {
            Console.WriteLine(str + " at WinOS");
        }
    }
}
