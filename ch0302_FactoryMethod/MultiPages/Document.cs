using System.Collections;

namespace MultiPages
{
    //工厂抽象类
    abstract class Document
    {
        protected ArrayList pages = new ArrayList();
        public Document()
        {
            this.CreatePages();
        }
        public ArrayList Pages
        {
            get { return pages; }
        }
        //工厂方法
        public abstract void CreatePages();
    }
}
