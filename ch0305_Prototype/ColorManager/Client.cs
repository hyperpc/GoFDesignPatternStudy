namespace ColorManager
{
    class Client
    {
        public static void Test()
        {
            ColorManager colorMannager = new ColorManager();
            colorMannager["red"] = new Color(255, 0, 0);
            colorMannager["green"] = new Color(0, 255, 0);
            colorMannager["blue"] = new Color(0, 0, 255);
            colorMannager["angry"] = new Color(255, 54, 0);
            colorMannager["peace"] = new Color(128, 211, 128);
            colorMannager["flame"] = new Color(211, 34, 20);

            string colorname = "red";
            Color c1 = (Color)colorMannager[colorname].Clone();
            c1.Display();

            colorname = "peace";
            Color c2 = (Color)colorMannager[colorname].Clone();
            c2.Display();

            colorname = "flame";
            Color c3 = (Color)colorMannager[colorname].Clone();
            c3.Display();
        }
    }
}
