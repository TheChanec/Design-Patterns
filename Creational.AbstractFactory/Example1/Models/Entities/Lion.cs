using System;
using Creational.AbstractFactory.Example1.Models.Entities.Abstracts;

namespace Creational.AbstractFactory.Example1.Models.Entities
{
    public class Lion : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
