using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Consola : Equipo
    {
        Equipo equipo = new Equipo();

        public void  seleccion()
        {
            equipo.ID = 1;
            equipo.Nombre = "Hola";
            String resultado = equipo.TipoEquipo();
            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        public void VHS_opcion() 
        {
            Console.WriteLine("-----VHS----");
            equipo.play();
            equipo.FW();
            equipo.RW();
            equipo.stop();
        }
        public void DVD_opcion()
        {
            Console.WriteLine("-----DVD----");
            equipo.play();
            equipo.FW();
            equipo.RW();
            equipo.stop();
        }
        public void NetFlix_opcion()
        {
            Console.WriteLine("-----NetFlix----");
            equipo.play();
            equipo.FW();
            equipo.RW();
            equipo.stop();
        }



    }
}
