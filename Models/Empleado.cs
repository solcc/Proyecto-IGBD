using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_IGBD.Models
{
    public class Empleado
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public int Dni { get; set; }

        public string   Direccion { get; set; }
                public int Telefono { get; set; }
                public DateTime FechaContratacion { get; set; }
       


    }
}