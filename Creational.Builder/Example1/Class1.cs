using System;
using Creational.Builder.Example1.Models;
using Creational.Builder.Example1.Models.Builders;

namespace Creational.Builder.Example1
{
    public class Class1

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public Class1()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
