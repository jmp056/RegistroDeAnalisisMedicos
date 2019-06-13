using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class AnalisisDetalle
    {
        [Key]
        public int AnalisisId { get; set; }
        public int TipoAnalisisId { get; set; }
        public string Detalle { get; set; }
        public decimal Resultado { get; set; }

        public AnalisisDetalle()
        {
            AnalisisId = 0;
            TipoAnalisisId = 0;
            Detalle = string.Empty;
            Resultado = 0;
        }
        public AnalisisDetalle(int analisisId, int tipoAnalisisId, string detalle, decimal resultado)
        {
            AnalisisId = analisisId;
            TipoAnalisisId = tipoAnalisisId;
            Detalle = detalle;
            Resultado = resultado;
        }
    }
}
