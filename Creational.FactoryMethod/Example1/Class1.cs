using System;
using Creational.FactoryMethod.Example1.Models.Entities;

namespace Creational.FactoryMethod
{
    /// <summary>
    /// 
    /// </summary>
    class Class1

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        Class1()
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
