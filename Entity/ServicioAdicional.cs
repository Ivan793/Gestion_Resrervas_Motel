using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioAdicional
    {
        public ServicioAdicional(string nombreServicio, double Precio,  string idServicio)
        {
            NombreServicio = nombreServicio;
            this.Precio = Precio;
            IdServicio = idServicio;
        }

        public string NombreServicio { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public string IdServicio { get; set; }
    }
}
