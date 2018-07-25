﻿using Creational.Builder.Example1.Models.Entities;

namespace Creational.Builder.Example1.Models.Builders
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        // Gets vehicle instance

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
