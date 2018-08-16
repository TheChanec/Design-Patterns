using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Example1
{
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements =
      new List<DrawingElement>();

        CompositeElement(string name) : base(name) { }

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
