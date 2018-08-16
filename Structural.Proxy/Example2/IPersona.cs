using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Proxy.Example2
{
    interface IPersona
    {
        void Delete();
        void Agregar(string nombre);
        void Editar(string nombre);
    }
}
