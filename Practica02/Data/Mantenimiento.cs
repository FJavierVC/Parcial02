using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Data
{
    internal class Mantenimiento
    {
        #region:Propiedades

        public int id;
        public int LastMaintenance;
        public string resultLastMaintenance;
        public DateTime dateLastMaintenance;
        public string currentDiagnosis;
        public int maintenanceTime;

        #endregion

        #region:Constructor

        public Mantenimiento(int id, int lastMaintenance, string resultLastMaintenance, DateTime dateLastMaintenance, string currentDiagnosis, int maintenanceTime)
        {
            this.id = id;
            LastMaintenance = lastMaintenance;
            this.resultLastMaintenance = resultLastMaintenance;
            this.dateLastMaintenance = dateLastMaintenance;
            this.currentDiagnosis = currentDiagnosis;
            this.maintenanceTime = maintenanceTime;
        }
        #endregion
    }
}
