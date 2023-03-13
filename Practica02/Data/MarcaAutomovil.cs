using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Data
{
    public class MarcaAutomovil
    {
        
		 #region:Propiedades\

		public int id;
        public string marca;
        public string color;
        public int version;
        public string tipoEquipamiento;
        public double tipo;

        public MarcaAutomovil(int id, string marca, string color, int version, string tipoEquipamiento, double tipo)
        {
            this.id = id;
            this.marca = marca;
            this.color = color;
            this.version = version;
            this.tipoEquipamiento = tipoEquipamiento;
            this.tipo = tipo;
        }

        #endregion
    }
}

