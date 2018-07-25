using Creational.AbstractFactory.Example1.Models.Entities;
using Creational.AbstractFactory.Example1.Models.Entities.Abstracts;

namespace Creational.AbstractFactory.Example1.Models.Factories
{
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
