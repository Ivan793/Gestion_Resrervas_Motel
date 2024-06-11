using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public Cliente(int id, string nombre, string cedula, string telefono, string genero)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Genero = genero;
           
        }

        public Cliente() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        
    }
}
