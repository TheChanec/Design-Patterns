using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Example1
{
    class PrimitiveElement : DrawingElement
    {
        PrimitiveElement(string name):base(name) { }


        public override void Add(DrawingElement d)
        {
            throw new NotImplementedException();
        }

        public override void Display(int indent)
        {
            throw new NotImplementedException();
        }

        public override void Remove(DrawingElement d)
        {
            throw new NotImplementedException();
        }
    }
}
