using Creational.AbstractFactory.Example1.Models.Entities.Abstracts;

namespace Creational.AbstractFactory.Example1.Models.Factories
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
