using Entity;
using DALL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Esta clase maneja toda la lógica de categoría
    public class LogicaCategoria
    {
       
        private CategoriaData categoriaData;

        public LogicaCategoria()
        {
            categoriaData = new CategoriaData();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return categoriaData.GetAll();
        }

        public void AgregarCategoria(Categoria categoria)
        {
             categoriaData.Add(categoria);  
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            categoriaData.Update(categoria);
        }

        public void EliminarCategoria(int id)
        {
            categoriaData.Delete(id);
        }

        public Categoria ObtenerPorNombre(string nombre)
        {
            return categoriaData.GetByName(nombre);
        }

        public string ObtenerPorId(int id)
        {
            return categoriaData.GetById(id);
        }
    }
}
