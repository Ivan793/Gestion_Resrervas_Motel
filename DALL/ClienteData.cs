using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class ClienteData
    {

        //Esta clase es utilizada por la capa de negocios para realizar operaciones sobre los clientes
        public ClienteData() { }

        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            //string datos = null; //Variable para almacenar el resultado

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {

                string consulta = "SELECT * FROM clientes"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader



                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Nombre = reader.GetString(1);
                    cliente.Telefono = reader.GetString(2);
                    cliente.Genero = reader.GetString(3);
                    cliente.Cedula = reader.GetString(4);
                    clientes.Add(cliente);
                }


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR", ex.Message);
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }


            return clientes;
        }

        public Cliente GetByCedula(string cedula)
        {

            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            //string datos = null; //Variable para almacenar el resultado

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            Cliente cliente = new Cliente();
            try
            {

                string consulta = "SELECT * FROM clientes WHERE cedula = "+ cedula ; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader



                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    cliente.Id = reader.GetInt32(0);  
                    
                    cliente.Cedula = reader.GetString(3);

                   

                }


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR", ex.Message);
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }


            return cliente;
        }

        public string GetById(int id)
        {

            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            //string datos = null; //Variable para almacenar el resultado

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            string cedulaCliente = "";
            try
            {

                string consulta = "SELECT * FROM clientes WHERE id = " + id; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader



                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    cedulaCliente = reader.GetString(4);

                }


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR", ex.Message);
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }


            return cedulaCliente;
        }


        public void Add(Cliente cliente)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "INSERT INTO clientes (Nombre, Telefono, Genero, Cedula) VALUES (@Nombre, @Telefono, @Genero, @Cedula)";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@Genero", cliente.Genero);
                comando.Parameters.AddWithValue("@Cedula", cliente.Cedula);
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

        public void Update(Cliente cliente)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "UPDATE clientes SET Nombre = @Nombre, Telefono = @Telefono, Genero = @Genero, Cedula = @Cedula WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@Genero", cliente.Genero);
                comando.Parameters.AddWithValue("Cedula", cliente.Cedula);
                comando.Parameters.AddWithValue("@Id", cliente.Id);
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
                string consulta = "DELETE FROM clientes WHERE Id = @Id";
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
