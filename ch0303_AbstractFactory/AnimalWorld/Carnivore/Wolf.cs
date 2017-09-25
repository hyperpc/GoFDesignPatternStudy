using System;

namespace AnimalWorld
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(string.Format("{0} eats {1}", this, h));
        }
    }
}
