namespace Toolbar
{
    class Client
    {
        public static void Test()
        {
            ToolbarManager toolbarManager = new ToolbarManager();
            toolbarManager["circle"] = new Circle();
            toolbarManager["rectangle"] = new Rectangle();

            string toolbarname = "circle";
            Circle circle = (Circle)toolbarManager[toolbarname].Clone();
            circle.Draw();

            toolbarname = "rectangle";
            Rectangle rectangle = (Rectangle)toolbarManager[toolbarname].Clone();
            rectangle.Draw();
        }
    }
}
