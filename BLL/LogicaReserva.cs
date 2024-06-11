using DALL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Esta clase maneja toda la lógica de Reservas
    public class LogicaReserva
    {
        private ReservasData reservaData;

        public LogicaReserva()
        {
           reservaData = new ReservasData();    
        }

        public List<Reserva> ObtenerReservas()
        {
            return reservaData.GetAll();
        }

        public void AgregarReservas(Reserva reserva)
        {
            reservaData.Add(reserva);
        }

        public void ActualizarHabitaciones(Reserva reserva)
        {
            reservaData.Update(reserva);
        }

        public void EliminarReservas(int id)
        {
            reservaData.Delete(id);
        }
    }
}
