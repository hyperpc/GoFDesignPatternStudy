﻿using System;

namespace ch0401_Adapter.Cleanor
{
    public class Office : IClean
    {
        public void makeClean()
        {
            Console.WriteLine("Clean Office");
        }
    }
}
