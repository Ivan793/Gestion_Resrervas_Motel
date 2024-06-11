using DALL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Esta clase maneja toda la lógica de clientes
    public class LogicaCliente
    {
        private ClienteData clienteData;

        public LogicaCliente()
        {
            clienteData = new ClienteData();
        }

        public List<Cliente> ObtenerClientes()
        {
            return clienteData.GetAll();
        }

        public void AgregarClientes(Cliente cliente )
        {
            clienteData.Add(cliente);
        }

        public void ActualizarClientes(Cliente cliente)
        {
            clienteData.Update(cliente);
        }

        public void EliminarClientes(int id)
        {
            clienteData.Delete(id);
        }

        public Cliente ObtenerPorCedula(string cedula)
        {
            return clienteData.GetByCedula(cedula);
        }

        public string ObtenerPorId(int id)
        {
            return clienteData.GetById(id);
        }
    }
}
