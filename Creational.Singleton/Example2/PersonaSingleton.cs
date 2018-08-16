using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton.Example2
{
    class PersonaSingleton
    {
        private static PersonaSingleton singleton;

        public PersonaSingleton GetSongleton() {
            if (singleton == null)
            {
                singleton = new PersonaSingleton();
                return singleton;
            }
            else {
                return singleton;
            }
        }
    }
}
