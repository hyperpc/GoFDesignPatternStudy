using System;

namespace ch0402_Bridge.OSImage
{
    public class UnixImg : IImageImp
    {
        public void DoPaint(string str)
        {
            Console.WriteLine(str + " at UnixOS");
        }
    }
}
