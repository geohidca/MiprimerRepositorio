using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Colecciones
    {

        public void ListasString<T>()
        {

            //var salmons = new List<T>();
            //salmons.Add("chinook");
            //salmons.Add("coho");
            //salmons.Add("pink");
            //salmons.Add("sockeye");
            var salmons = new List<string>(); //Lista de string

            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Recore la lista
            Imprimir(salmons);
            Console.WriteLine("--------------");
            //Remover
            salmons.Remove("coho");
            Console.WriteLine("--------------");
            Imprimir(salmons);
            //Insertar
            salmons.Insert(1, "Kyoma");
            Console.WriteLine("--------------");
            Imprimir(salmons);
            //Remover posicion
            salmons.RemoveAt(2);
            Console.WriteLine("--------------");
            Imprimir(salmons);
            //Asignacion
            Console.WriteLine("--------------");
            Console.WriteLine("[]");
            var salmon = salmons[0];
            Console.WriteLine("Salmon = {0}", salmon);
            //Saber el index
            Console.WriteLine("--------------");
            Console.WriteLine("Indes-----");
            var index = salmons.IndexOf("sockeye");
            Console.WriteLine("Index= {0}", index);
            //Contar
            Console.WriteLine("--------------");
            Console.WriteLine("contador-----");
            var contar = salmons.Count;
            Console.WriteLine("Numero de itens= {0}", contar);

        }
           
    }   

}
