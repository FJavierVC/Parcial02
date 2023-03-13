using System.Data.Entity;

namespace Practica02.Data
{
    public class DataContextBase
    {
        DbSet<Automovil> Automovils { get; set; }
        DbSet<MarcaAutomovil> MarcaAutomovils { get; set; }
        DbSet<DocumentoControl> DocumentoControls { get; set; }
        DbSet<DocumentoMantenimiento> DocumentoMantenimientos { get; set; }
        DbSet<Mantenimiento> Mantenimientos { get; set; }
    }
}