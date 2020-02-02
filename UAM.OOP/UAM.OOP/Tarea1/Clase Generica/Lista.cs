using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    class Lista<T> : ICrud<T>
    {
        public void buscar(int T)
        {
            Console.WriteLine("Buscando la posición {0}",T);
        }

        public void eliminar(int T)
        {
            Console.WriteLine("Eliminando el indice {0}",T);
        }

        public void insertar(int T)
        {
            Console.WriteLine("Insertando en la lista {0}",T);
        }
    }
}
