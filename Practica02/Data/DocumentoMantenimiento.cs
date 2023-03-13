using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Data
{
    internal class DocumentoMantenimiento
    {
        #region:Propiedades

        public int id;
        public string propietarioFirstName;
        public string propietarioLastName;
        public DateTime arrivalDate;
        public string description;
        public string comments;

        #endregion

        #region:Constructor

        public DocumentoMantenimiento(int id, string propietarioFirstName, string propietarioLastName, DateTime arrivalDate, string description, string comments)
        {
            this.id = id;
            this.propietarioFirstName = propietarioFirstName;
            this.propietarioLastName = propietarioLastName;
            this.arrivalDate = arrivalDate;
            this.description = description;
            this.comments = comments;
        }

        #endregion
    }
}
