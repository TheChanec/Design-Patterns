using Creational.Prototype.Example1.Models.Prototypes;
using System.Collections.Generic;

namespace Creational.Prototype.Example1.Models.Entities
{
    class ColorManager

    {
        private Dictionary<string, ColorPrototype> _colors =
            new Dictionary<string, ColorPrototype>();

        // Indexer

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
