using RegistroDeAnalisisMedicos.Entidades;
using System.Data.Entity;

namespace RegistroDeAnalisisMedicos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Analisis> Analisis { get; set; }
        public DbSet<TipoAnalisis> TipoAnalisis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public Contexto () : base("ConStr")
        { }

    }
}
