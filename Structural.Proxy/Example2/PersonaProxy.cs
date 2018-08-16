using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Proxy.Example2
{
    class PersonaProxy : IPersona
    {
        private Persona _persona = new Persona();
        public void Agregar(string nombre)
        {
            _persona.Agregar(nombre);

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Editar(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
