using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class Equipo
	{

        #region Atributos
        private int _ID;
        private string _nombre;
        #endregion;

        #region Propiedades
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        #endregion

        #region Constructor
        public Equipo()
        {

        }

        public Equipo(int ID, string Nombre)
        {
            _ID = ID;
            _nombre = Nombre;
        }
        #endregion;

        #region Metodo
        public string TipoEquipo()
        {
            return string.Format("El equipo utilizado es un {0}, y corresponde al ID #: {1} ", _nombre, _ID);
        }
        #endregion;
    }
}
