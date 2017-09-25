using System;

namespace ComputerWorld
{
    public class MSIK7N2G : IMainBoard
    {
        public void Attach(ICPU cpu)
        {
            try
            {
                if (cpu.GetType().ToString().EndsWith("AMD"))
                    Console.WriteLine("MSIK7N2G");
                else
                    Console.WriteLine("主板MSIK7N2G只能配AMD的CPU");
            }
            catch (Exception ex)
            {
                Console.WriteLine("主板MSIK7N2G只能配AMD的CPU");
                Console.WriteLine("With Exception : {0}", ex.Message);
            }
        }
    }
}
