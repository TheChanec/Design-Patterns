using System.Collections.Generic;

namespace Creational.FactoryMethod.Example1.Models.Entities
{
    abstract class Document

    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method

        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method

        public abstract void CreatePages();
    }
}
