namespace ch0507_Observer.TomAndJerry
{
    class Client
    {
        public static void Test()
        {
            CatTom tom = new CatTom();
            MouseJerry jerry1 = new MouseJerry("小老鼠", tom);
            MouseJerry jerry2 = new MouseJerry("大老鼠", tom);
            tom.Cry();
        }
    }
}
