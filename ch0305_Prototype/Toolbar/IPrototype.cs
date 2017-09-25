using System;

namespace Toolbar
{
    public interface IPrototype:ICloneable
    {
        string GetName();
    }
}
