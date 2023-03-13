using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Data
{
    public class DataContext : DbContext
    {
        DbSet<Automovil> Automovils { get; set; }
        DbSet<MarcaAutomovil> MarcaAutomovils { get; set; }
        DbSet<DocumentoControl> DocumentoControls { get; set; }
        DbSet<DocumentoMantenimiento> DocumentoMantenimientos { get; set; }
        DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DataContext() : base("name=con")
        {
        }
        
    }
    
}
