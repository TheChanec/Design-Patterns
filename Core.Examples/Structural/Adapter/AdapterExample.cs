using System;
 
namespace Core.Examples.Structural.Adapter
{
    /// <summary>

    /// MainApp startup class for Structural

    /// Adapter Design Pattern.

    /// </summary>

    class AdapterExample

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        AdapterExample()
        {
            // Create adapter and place a request

            Target target = new Adapter();
            target.Request();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Target' class

    /// </summary>

    class Target

    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    /// <summary>

    /// The 'Adapter' class

    /// </summary>

    class Adapter : Target

    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work

            //  and then call SpecificRequest

            _adaptee.SpecificRequest();
        }
    }

    /// <summary>

    /// The 'Adaptee' class

    /// </summary>

    class Adaptee

    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}