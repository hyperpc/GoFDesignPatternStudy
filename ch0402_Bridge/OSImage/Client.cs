namespace ch0402_Bridge.OSImage
{
    public class Client
    {
        public static void Test()
        {
            BMPImage bmp = new BMPImage();
            IImageImp winImp = new WinImg();
            bmp.setImageImg(winImp);
            bmp.Method("BMP begin to paint");
            IImageImp unixImp = new UnixImg();
            bmp.setImageImg(unixImp);
            bmp.Method("BMP begin to paint");

        }
    }
}
