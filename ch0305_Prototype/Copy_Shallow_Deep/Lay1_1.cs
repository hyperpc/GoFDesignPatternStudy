using System;

namespace CopyShallow1
{
    //class Lay1_1
    //{
    //    public int x;
    //    public Lay1_2 lay2;
    //    public Lay1_1 Clone()
    //    {
    //        return (Lay1_1)this.MemberwiseClone();
    //    }
    //}

    class Lay1_1 : ICloneable
    {
        public int x;
        public Lay1_2 lay2;

        #region IClonable成员
        public virtual Lay1_1 Clone()
        {
            Lay1_1 lay1 = this.MemberwiseClone() as Lay1_1;
            lay1.lay2 = this.lay2.Copy();
            return lay1;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
        #endregion
    }
}
