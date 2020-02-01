using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Consola : Equipo
    {
        int numero=0;
        string dispositivo="NADA";
        string valor = "";

        Equipo equipo = new Equipo();

        public void Menu() 
        {
            Console.WriteLine("Seleccione el tipo de Reproductor: 1- VHS / 2- DVD / 3- Netflix");
            dispositivo = Console.ReadLine();
            numero = int.Parse(dispositivo);
            if (numero == 1)
            {
                dispositivo = "VHS";
                seleccion();
                VHS_opcion();
            } else
            { if (numero == 2)
                {
                    dispositivo = "DVD";
                    seleccion();
                    DVD_opcion();

                }
                dispositivo = "Netflix";
                seleccion();
                NetFlix_opcion();
            }
        }
        public void  seleccion()
        {
            equipo.ID = numero;
            equipo.Nombre = dispositivo;
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
