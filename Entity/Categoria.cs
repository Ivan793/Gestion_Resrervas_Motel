using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria
    {
        public Categoria(int id, string nombre) 
        {
            Id = id;
            Nombre = nombre;
            
        }

        public Categoria() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        
    }
}
