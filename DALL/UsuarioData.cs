using MySql.Data.MySqlClient;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class UsuarioData
    {

        //Esta clase es utilizada por la capa de negocios para realizar operaciones sobre los Usuarios
        public UsuarioData() { }    

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            MySqlDataReader reader = null;
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBd = conexion.ConectarBd();

            try
            {
                string consulta = "SELECT * From usuarios";

                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBd;
                conexionBd.Open();
                reader = comando.ExecuteReader();

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nombre = reader.GetString(1);   
                    usuario.Telefono = reader.GetString(2); 
                    usuario.Genero = reader.GetString(3);   
                    usuario.Contraseña = reader.GetString(4);   
                    usuarios.Add(usuario);  
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR", ex.Message);
            }
            finally
            {
                conexionBd.Close();
            }

            return usuarios;
        }
        public Usuario GetByUsuarioyContraseña(string nombre, string contraseña)
        {
            Usuario usuario = null;
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBd = conexion.ConectarBd();

            try
            {
                string consulta = "SELECT * FROM usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBd);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                conexionBd.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        Genero = reader.GetString(3),
                        Contraseña = reader.GetString(4)
                    };
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR: " + ex.Message);
            }
            finally
            {
                conexionBd.Close();
            }

            return usuario;
        }

        public void Add(Usuario usuario)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "INSERT INTO usuarios (Nombre, Telefono, Genero, Contraseña) VALUES (@Nombre, @Telefono, @Genero, @Contraseña)";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                comando.Parameters.AddWithValue("@genero", usuario.Genero);
                comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                conexionBD.Open();
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void Update(Usuario usuario)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "UPDATE usuarios SET Nombre = @Nombre Telefono = @Telefono Genero = @Genero Contraseña = @Contraseña WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                comando.Parameters.AddWithValue("@Genero", usuario.Genero);
                comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                comando.Parameters.AddWithValue("@Id", usuario.Id);
                conexionBD.Open();
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void Delete(int id)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "DELETE FROM usuarios WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Id", id);
                conexionBD.Open();
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


    }
    
}
