using Creational.AbstractFactory.Example1.Models.Entities;
using Creational.AbstractFactory.Example1.Models.Entities.Abstracts;

namespace Creational.AbstractFactory.Example1.Models.Factories
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
