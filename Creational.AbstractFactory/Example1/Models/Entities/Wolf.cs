using System;
using Creational.AbstractFactory.Example1.Models.Entities.Abstracts;

namespace Creational.AbstractFactory.Example1.Models.Entities
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
