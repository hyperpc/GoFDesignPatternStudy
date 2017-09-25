namespace ch0402_Bridge.OSImage
{
    public abstract class Image
    {
        protected IImageImp imptouse;
        public void setImageImg(IImageImp ip)
        {
            imptouse = ip;
        }
        public abstract void Method(string str);
    }
}
