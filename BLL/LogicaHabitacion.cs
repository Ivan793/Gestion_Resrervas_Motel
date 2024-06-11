using DALL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // //Esta clase maneja toda la lógica de Habitaciones
    public class LogicaHabitacion{

       private HabitacionData habitacionData; 
       
        public  LogicaHabitacion()
        {
           habitacionData = new HabitacionData();
        }  

        public List<Habitacion> ObtenerHabitaciones()
        {
           return habitacionData.GetAll();
        }

        public void AgregarHabitaciones(Habitacion habitacion)
        {
           habitacionData.Add(habitacion);  
        }

        public void ActualizarHabitaciones(Habitacion habitacion)
        {
            habitacionData.Update(habitacion);  
        }

        public void EliminarHabitaciones(int id)
        {
            habitacionData.Delete(id);  
        }

         public Habitacion ObtenerPorNombre(string nombre)
        {
            return habitacionData.GetByName(nombre);
        }

        public string ObtenerPorId(int id)
        {
            return habitacionData.GetById(id);
        }
    }
}
   
