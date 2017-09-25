namespace ch0402_Bridge.OSImage
{
    public class BMPImage : Image
    {
        public override void Method(string str)
        {
            string s1=str+"\nBMP Image";
            this.imptouse.DoPaint(s1);
        }
    }
}
