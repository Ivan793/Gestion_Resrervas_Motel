using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reserva
    {
        public Reserva(int id, int habitacion, int cliente, DateTime fecha_reserva, int duracion, double costo )
        {
            Id = id;
            Habitacion = habitacion;
            Cliente = cliente;
            Fecha_Reserva = fecha_reserva;
            Duracion = duracion;
            Costo = costo;
        }

        public Reserva() { }    

        public int Id { get; set; }
        public int Habitacion { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha_Reserva { get; set; }
        public int Duracion { get; set; }
        public double Costo { get; set; }
    }
}
