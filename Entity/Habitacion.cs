using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Habitacion
    {
        public Habitacion(int id, string nombre, int tipo ,string estado)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Estado = estado;
        }

        public Habitacion() { }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public string Estado { get; set; }
       
        
    }
}
