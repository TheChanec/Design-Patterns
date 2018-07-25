using System;
using Structural.Adapter.Example1.Models;

namespace Structural.Adapter.Example1
{
    class Class1

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        Class1()
        {
            // Non-adapted chemical compound

            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user

            Console.ReadKey();
        }
    }
}
