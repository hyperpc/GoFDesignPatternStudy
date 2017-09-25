using System;

namespace ch0405_Facade.TeaMaker
{
    public class Water
    {
        bool IsBoiling;
        public Water()
        {
            setBoiling(false);
            Console.WriteLine("纯净的水准备好了");
        }
        public void boilWater()
        {
            setBoiling(true);
            Console.WriteLine("水在沸腾了");
        }

        public void setBoiling(bool isBoiling)
        {
            this.IsBoiling = isBoiling;
        }

        public bool getIsBoiling()
        {
            return IsBoiling;
        }
    }
}
