﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0405_Facade.Mortgage
{
    class Bank
    {
        public bool SufficientSavings(Customer customer)
        {
            Console.WriteLine("Check bank for {0}", customer.Name);
            return true;
        }
    }
}
