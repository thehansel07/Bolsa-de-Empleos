using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_Bolsa_Empleados.Models
{
    public class Publicacion
    {
        public int idPublicaciones { get; set; }
        public Nullable<int> idpais { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> idEmpleado { get; set; }
        public Nullable<int> idAdministrador { get; set; }
        public string Nombre_Compañia { get; set; }
        public string Tipo_Horario { get; set; }
        public Nullable<System.DateTime> Fecha_Publicacion { get; set; }
        public string Correo { get; set; }
        public string Logo { get; set; }
        public string Url_Pagina { get; set; }
        public string Posicion { get; set; }
        public string Dirreccion { get; set; }
    }
}