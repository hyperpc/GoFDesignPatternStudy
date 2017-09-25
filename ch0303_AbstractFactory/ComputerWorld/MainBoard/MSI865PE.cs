using System;

namespace ComputerWorld
{
    public class MSI865PE : IMainBoard
    {
        public void Attach(ICPU cpu)
        {
            try
            {
                if (cpu.GetType().ToString().EndsWith("Intel"))
                    Console.WriteLine("MSI865PE");
                else
                    Console.WriteLine("主板MSI865PE只能配Intel的CPU");
            }
            catch (Exception ex)
            {
                Console.WriteLine("主板MSI865PE只能配Intel的CPU");
                Console.WriteLine("With Exception : {0}", ex.Message);
            }
        }
    }
}
