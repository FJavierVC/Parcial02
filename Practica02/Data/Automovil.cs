using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Data
{
    public class Automovil
	{
        
		 #region:Propiedades\

		public int id;
		public string marca;
		public string modelo;
		public int km;
        public string version;
		public double precio;

		#endregion

		#region:Construuctor
		public Automovil(int id, string marca, string modelo, int km, string version, double precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.version= version;
            this.precio = precio;
        }
        #endregion
	}
}
    