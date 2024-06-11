using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DALL;
using Entity;
using MySql.Data.MySqlClient;

namespace DALL
{
    public class HabitacionData
    {

        //Esta clase es utilizada por la capa de negocios para realizar operaciones sobre las Habitaciones
        public HabitacionData()
        {
        
        }

        public List<Habitacion> GetAll()
        {
           List<Habitacion> habitacions = new List<Habitacion>();   
           MySqlDataReader reader = null;   
           ConexionBD conexion = new ConexionBD();
           MySqlConnection conexionBd = conexion.ConectarBd();

            try 
            {
                string consulta = "SELECT * From habitaciones";

                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBd;
                conexionBd.Open();  
                reader = comando.ExecuteReader();

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.Id = reader.GetInt32(0);
                    habitacion.Nombre = reader.GetString(1);
                    habitacion.Estado = reader.GetString(2);
                    habitacion.Tipo = reader.GetInt32(3);
                    habitacions.Add(habitacion);
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR", ex.Message);
            }
            finally
            {
                conexionBd.Close(); 
            }

            return habitacions;
        }

        public string GetById(int id)
        {

            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            //string datos = null; //Variable para almacenar el resultado

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            string nombreHabitacion = "";
            try
            {

                string consulta = "SELECT * FROM habitaciones WHERE id = " + id; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader



                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    nombreHabitacion = reader.GetString(1);

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

            return nombreHabitacion;
            
        }

        public Habitacion GetByName(string name)
        {

            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            //string datos = null; //Variable para almacenar el resultado

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            Habitacion habitacion = new Habitacion();   
            
            try
            {

                string consulta = "SELECT * FROM habitaciones WHERE nombre = " + "'" + name + "'"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader



                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    habitacion.Id = reader.GetInt32(0); 
                    habitacion.Nombre = reader.GetString(1);
                    

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


            return habitacion;
        }
        public void Add(Habitacion habitacion)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "INSERT INTO habitaciones (Nombre, id_Categoria, Estado) VALUES (@Nombre, @id_Categoria, @Estado)";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", habitacion.Nombre);
                comando.Parameters.AddWithValue("@id_Categoria", habitacion.Tipo);
                comando.Parameters.AddWithValue("@Estado", habitacion.Estado);
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

        public void Update(Habitacion habitacion)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "UPDATE habitaciones SET Nombre = @Nombre, id_Categoria = @id_Categoria, Estado = @Estado WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", habitacion.Nombre);
                comando.Parameters.AddWithValue("@id_Categoria", habitacion.Tipo);
                comando.Parameters.AddWithValue("@Estado", habitacion.Estado);
                comando.Parameters.AddWithValue("@Id", habitacion.Id);
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
                string consulta = "DELETE FROM habitaciones WHERE Id = @Id";
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
