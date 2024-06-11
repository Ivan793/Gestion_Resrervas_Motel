using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Reservas_Motel
{
    //Esta clase realiza un DTO de la clase de habitacion
    public class HabitacionDTO
    {
        public HabitacionDTO(int id, string nombre, string tipo, string estado)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Estado = estado;
        }

        public HabitacionDTO() { }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
    }
}
