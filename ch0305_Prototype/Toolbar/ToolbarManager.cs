using System.Collections;

namespace Toolbar
{
    class ToolbarManager
    {
        Hashtable toolbars = new Hashtable();
        public IToolbar this[string key]
        {
            get
            {
                return (IToolbar)toolbars[key];
            }
            set
            {
                toolbars.Add(key, value);
            }
        }
    }
}
