using System;

namespace Proyecto_IGBD.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string   Direccion { get; set; }
                public int Telefono { get; set; }
                public DateTime FechaNacimiento { get; set; }
                //fk tipo cliente

    }
}