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
    //Esta clase es utilizada por la capa de negocios para realizar operaciones sobre las Categorias
    public class CategoriaData
    {
       

        public CategoriaData()
        {
            
        }

        public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            
            try
            {
                
                string consulta = "SELECT * FROM categorias"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = reader.GetInt32(0);
                    categoria.Nombre = reader.GetString(1);
                    
                    categorias.Add(categoria); 
                }

               
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("OCURRIÓ UN ERROR",ex.Message );
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }

          
            return categorias;
        }


        public Categoria GetByName(string name)
        {
            
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
            

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            Categoria categoria = new Categoria();
            try
            {

                string consulta = "SELECT * FROM categorias WHERE nombre = " + "'"+ name+"'"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader


                
                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                   
                    categoria.Id = reader.GetInt32(0);
                    categoria.Nombre = reader.GetString(1);
                    
               
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


            return categoria;
        }

        public string GetById(int id)
        {

            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();
           

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            string nombreCategoria = "";
            try
            {

                string consulta = "SELECT * FROM categorias WHERE id = " + id; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)

                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader



                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    nombreCategoria = reader.GetString(1);

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


            return nombreCategoria;
        }


        public void Add(Categoria categoria)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "INSERT INTO categorias (Nombre) VALUES (@Nombre)";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
               
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

        public void Update(Categoria categoria)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "UPDATE categorias SET Nombre = @Nombre WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                
                comando.Parameters.AddWithValue("@Id", categoria.Id);
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
                string consulta = "DELETE FROM categorias WHERE Id = @Id";
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

