using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Proxy.Example3
{
    class PerroProxy : IPerro
    {
        private Perro perro;

        public PerroProxy()
        {
            perro = new Perro();
        }

        public void Comer()
        {
            perro.Comer();
        }

        public void Correr()
        {
            perro.Correr();
        }

        public void Dormir()
        {
            perro.Dormir();
        }

        public void Ladrar()
        {
            perro.Ladrar();
        }

        public void Morder()
        {
            perro.Morder();
        }
    }
}
