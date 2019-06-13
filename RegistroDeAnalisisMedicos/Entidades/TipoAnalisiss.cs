using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class TipoAnalisiss
    {
        [Key]
        public int TipoAnalisisId { get; set; }
        public string Descripcion { get; set; }
        public TipoAnalisiss()
        {
            TipoAnalisisId = 0;
            Descripcion = string.Empty;
        }
        public TipoAnalisiss(int tipoAnalisisId, string descripcion)
        {
            TipoAnalisisId = tipoAnalisisId;
            Descripcion = descripcion;
        }
    }
}
