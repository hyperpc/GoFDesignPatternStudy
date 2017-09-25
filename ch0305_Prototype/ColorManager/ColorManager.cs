using System.Collections;

namespace ColorManager
{
    class ColorManager
    {
        Hashtable colors = new Hashtable();
        public ColorPrototype this[string name]
        {
            get
            {
                return (ColorPrototype)colors[name];
            }
            set
            {
                colors.Add(name, value);
            }
        }
    }
}
