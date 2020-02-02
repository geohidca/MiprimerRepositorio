using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    interface ICrud <T>
    {
        void insertar(int T);
        void eliminar(int T);
        void buscar(int T);
    }
}
