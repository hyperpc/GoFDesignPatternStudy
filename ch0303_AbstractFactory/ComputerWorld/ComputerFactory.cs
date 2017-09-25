using System;

namespace ComputerWorld
{
    public abstract class ComputerFactory
    {
        public ICPU cpu;
        public IHardDisk hd;
        public IMainBoard mb;

        public void Show()
        {
            try
            {
                Console.WriteLine(this.GetType().ToString() + "生产的电脑配置");
                Console.WriteLine("     CPU : " + cpu.GetCPU());
                Console.WriteLine("     HardDisk : " + hd.GetSize());
                Console.Write("     MainBoard : ");
                mb.Attach(cpu);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
