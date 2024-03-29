﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeAnalisisMedicos.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Sexo = string.Empty;
            Edad = 0;
            FechaDeNacimiento = DateTime.Now;
            Telefono = string.Empty;
            Email = string.Empty;
        }
    }
}
