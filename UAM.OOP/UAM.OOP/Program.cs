using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM.OOP.Tarea1;

namespace UAM.OOP
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Persona persona = new Persona();
			//int telefono = 88221672;
			//persona.Telefono = telefono;
			//int telefono2 = persona.Telefono;

			//int id = persona.Identificacion;
			////persona.Identificacion = 12324;

			//persona._correo = "@";

			//Estudiante estudiante = new Estudiante();
			//Persona persona1 = new Estudiante();
			//persona1.Telefono = 1;

			//PersonaDeportesCAbst personaDeportesC = new DeporteCR();

			//DeporteCR deporteCR = new DeporteCR();
			//DeporteUSA deporteUSA = new DeporteUSA();

			//deporteCR.Basket();
			//deporteUSA.Basket();

			//deporteCR.Futbol();
			//deporteUSA.Futbol();

			//deporteCR.Tennis();
			//deporteUSA.Tennis();

			//deporteCR.BaseBall();
			//deporteUSA.BaseBall();


			Equipo equipo = new Equipo();
			int ID = 01;
			string Nombre = "Netflix";

			equipo.ID = ID;
			equipo.Nombre = Nombre;

			string TipoEquipo = equipo.TipoEquipo();

			Console.WriteLine(TipoEquipo);
			Console.ReadKey();

           
		}
	}
}
