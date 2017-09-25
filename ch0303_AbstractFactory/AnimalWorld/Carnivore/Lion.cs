﻿using System;

namespace AnimalWorld
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(string.Format("{0} eats {1}", this, h));
        }
    }
}
