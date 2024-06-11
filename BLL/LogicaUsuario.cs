using DALL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // //Esta clase maneja toda la lógica de Usuarios
    public class LogicaUsuario
    {
        private UsuarioData usuarioData;

        public LogicaUsuario()
        {
            usuarioData = new UsuarioData();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioData.GetAll();
        }

        public void AgregarUsuarios(Usuario usuario)
        {
            usuarioData.Add(usuario);
        }

        public void ActualizarUsuarios(Usuario usuario)
        {
            usuarioData.Update(usuario);
        }

        public void EliminarUsuarios(int id)
        {
            usuarioData.Delete(id);
        }

        public bool ValidarUsuario(string nombre, string contraseña)
        {
            Usuario usuario = usuarioData.GetByUsuarioyContraseña(nombre, contraseña);
            return usuario != null;
        }
    }
}

