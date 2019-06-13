using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class AnalisisDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int AnalisisId { get; set; }
        public int TipoAnalisisId { get; set; }
        public string Detalle { get; set; }
        public decimal Resultado { get; set; }

        public AnalisisDetalle()
        {
            DetalleId = 0;
            AnalisisId = 0;
            TipoAnalisisId = 0;
            Detalle = string.Empty;
            Resultado = 0;
        }
        public AnalisisDetalle(int detalleId, int analisisId, int tipoAnalisisId, string detalle, decimal resultado)
        {
            DetalleId = detalleId;
            AnalisisId = analisisId;
            TipoAnalisisId = tipoAnalisisId;
            Detalle = detalle;
            Resultado = resultado;
        }
    }
}
