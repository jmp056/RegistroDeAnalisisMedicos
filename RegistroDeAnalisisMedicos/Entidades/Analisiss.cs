using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class Analisiss
    {
        [Key]
        public int AnalisisId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<AnalisisDetalle> Detalle { get; set; }

        public Analisiss()
        {
            AnalisisId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
            Detalle = new List<AnalisisDetalle>();
        }
    }
}
