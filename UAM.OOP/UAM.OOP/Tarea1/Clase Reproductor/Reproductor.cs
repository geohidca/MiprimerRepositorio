using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Reproductor : IReproductores
    {
        public void FW()
        {
            Console.WriteLine("Esta Adelantando");
        }

        public void play()
        {
            Console.WriteLine("Reproduciendo");
        }

        public void RW()
        {
            Console.WriteLine("Esta Retrocediento");
        }

        public void stop()
        {
            Console.WriteLine("Esta Detenido");
        }
    }

}

