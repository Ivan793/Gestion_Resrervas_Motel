using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        

        public Usuario(int id, string nombre, string telefono, string genero, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Genero = genero;
            Contraseña = contraseña;
        }
        public Usuario()
        {

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public string Contraseña { get; set; }
    }
}
