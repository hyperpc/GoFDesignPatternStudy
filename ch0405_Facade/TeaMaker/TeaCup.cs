using System;

namespace ch0405_Facade.TeaMaker
{
    public class TeaCup
    {
        bool teaBagIsSteeped;
        Water water;
        TeaBag teabag;
        public TeaCup()
        {
            setTeaBagIsSteeped(false);
            Console.WriteLine("茶杯准备好了");
        }

        public void setTeaBagIsSteeped(bool isTeaBagSteeped)
        {
            teaBagIsSteeped = isTeaBagSteeped;
        }
        public bool getTeaBagIsSteeped()
        {
            return teaBagIsSteeped;
        }
        public void addTeaBag(TeaBag teaBag)
        {
            this.teabag = teaBag;
            Console.WriteLine("茶包放在茶杯了");
        }
        public void AddWater(Water water)
        {
            this.water = water;
            Console.WriteLine("水倒入杯子了");
        }
        public void steepTeaBag()
        {
            if ((teabag != null) && (water != null) && (water.getIsBoiling()))
            {
                Console.WriteLine("茶渗透到杯子中");
                setTeaBagIsSteeped(true);
            }
            else
            {
                Console.WriteLine("茶没有渗透到杯子中");
                setTeaBagIsSteeped(false);
            }
        }

        public override string ToString()
        {
            if (this.getTeaBagIsSteeped())
            {
                return "一杯香浓的茶泡好了";
            }
            else
            {
                string result = "一个杯子";
                if (water != null)
                {
                    if (water.getIsBoiling())
                        result += "放有沸腾的水";
                    else
                        result += "放有冻水";
                }
                else
                {
                    result += "没有放水";
                    if (teabag != null)
                        result += "有一个茶包";
                    else
                        result += "没有茶包";
                }
                return result;
            }
        }
    }
}
