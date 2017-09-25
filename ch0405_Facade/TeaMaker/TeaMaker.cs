using System;

namespace ch0405_Facade.TeaMaker
{
    public class TeaMaker
    {
        //bool teaBagIsSteeped;
        public TeaMaker()
        {
            Console.WriteLine("TeaMaker准备好为您冲茶了");
        }

        public TeaCup makeTeaCup()
        {
            TeaCup cup = new TeaCup();
            TeaBag bag = new TeaBag();
            Water water = new Water();
            cup.addTeaBag(bag);
            water.boilWater();
            cup.AddWater(water);
            cup.steepTeaBag();
            return cup;
        }
    }
}
