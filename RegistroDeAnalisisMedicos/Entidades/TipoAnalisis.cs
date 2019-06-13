using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class TipoAnalisis
    {
        [Key]
        public int TipoAnalisisId { get; set; }
        public string Descripcion { get; set; }
        public TipoAnalisis()
        {
            TipoAnalisisId = 0;
            Descripcion = string.Empty;
        }
    }
}
