namespace ch0403_Composite.Document
{
    class Client
    {
        public static void Test()
        {
            Page page = new Page();
            Character c1 = new Character(1,1);
            Image img1 = new Image(2, 2);
            Column col = new Column();
            Character c2 = new Character(1, 3);
            Image img2 = new Image(2, 3);
            col.Add(c2);
            col.Add(img2);
            page.Add(c1);
            page.Add(img1);
            page.Add(col);
            page.Draw();
        }
    }
}
