using System;

namespace Proyecto_IGBD.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public int Duracion { get; set; }
        public int SubTotal { get; set; }
        //cliente/empleado/canlaCom
    }
}