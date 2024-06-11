using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Reservas_Motel
{
    //Esta clase realiza un Dto de la clase de reservas
    public class ReservasDTO
    {

        public ReservasDTO(int id, string habitacion, string cliente, DateTime fecha_reserva, int duracion, double costo, double total )
        {
            Id = id;
            Habitacion = habitacion;
            Cliente = cliente;
            Fecha_Reserva = fecha_reserva;
            Duracion = duracion;
            Costo = costo;
            Total = total;
        }

        public ReservasDTO() { }

        public int Id { get; set; }
        public string Habitacion { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha_Reserva { get; set; }
        public int Duracion { get; set; }
        public double Costo { get; set; }
        public double Total { get; set; }
    }
}
