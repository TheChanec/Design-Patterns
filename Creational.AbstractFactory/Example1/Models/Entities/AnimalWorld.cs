using Creational.AbstractFactory.Example1.Models.Entities.Abstracts;
using Creational.AbstractFactory.Example1.Models.Factories;

namespace Creational.AbstractFactory.Example1.Models.Entities
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
