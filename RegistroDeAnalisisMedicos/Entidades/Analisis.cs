using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<AnalisisDetalle> Detalle { get; set; }

        public Analisis()
        {
            AnalisisId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
            Detalle = new List<AnalisisDetalle>();
        }
    }
}
