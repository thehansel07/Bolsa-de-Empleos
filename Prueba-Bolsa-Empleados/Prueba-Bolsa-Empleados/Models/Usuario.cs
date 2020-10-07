using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba_Bolsa_Empleados.Models
{
    public class Usuario
    {
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public int idCategoria { get; set; }
        [Required]
        public string Interes { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Puesto { get; set; }







    }
}