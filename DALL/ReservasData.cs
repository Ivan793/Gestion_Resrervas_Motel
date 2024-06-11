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
    public class ReservasData
    {

        //Esta clase es utilizada por la capa de negocios para realizar operaciones sobre las Reservas
        public ReservasData() { }

        public List<Reserva> GetAll()
        {
            List<Reserva> reservas = new List<Reserva>();
            MySqlDataReader reader = null;
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBd = conexion.ConectarBd();

            try
            {
                string consulta = "SELECT * From reservas";

                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBd;
                conexionBd.Open();
                reader = comando.ExecuteReader();

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    Reserva reserva = new Reserva();
                    reserva.Id = reader.GetInt32(0);
                    reserva.Habitacion = reader.GetInt32(1);
                    reserva.Cliente = reader.GetInt32(2);
                    reserva.Fecha_Reserva = reader.GetDateTime(3);
                    reserva.Duracion = reader.GetInt32(4);
                    reserva.Costo = reader.GetDouble(5);
                    reservas.Add(reserva);

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

            return reservas;
        }

        public void Add(Reserva reserva)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "INSERT INTO reservas (id_Habitacion, id_Cliente, fecha_Reserva, Duracion, Costo) VALUES (@id_Habitacion, @id_Cliente, @fecha_Reserva, @Duracion, @Costo)";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@id_Habitacion", reserva.Habitacion);
                comando.Parameters.AddWithValue("@id_Cliente", reserva.Cliente);
                comando.Parameters.AddWithValue("@fecha_Reserva", reserva.Fecha_Reserva);
                comando.Parameters.AddWithValue("@Duracion", reserva.Duracion);
                comando.Parameters.AddWithValue("@Costo", reserva.Costo);
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

        public void Update(Reserva reserva)
        {
            ConexionBD conexion = new ConexionBD();
            MySqlConnection conexionBD = conexion.ConectarBd();

            try
            {
                string consulta = "UPDATE reservas SET id_Habitacion = @id_Habitacion, id_Cliente = @id_Cliente, fecha_Reserva = @fecha_Reserva, Duracion = @Duracion, Costo = @Costo, WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@id_Habitacion", reserva.Habitacion);
                comando.Parameters.AddWithValue("@id_Cliente", reserva.Cliente);
                comando.Parameters.AddWithValue("@fecha_Reserva", reserva.Fecha_Reserva);
                comando.Parameters.AddWithValue("@Duracion", reserva.Duracion);
                comando.Parameters.AddWithValue("@Costo", reserva.Costo);
                comando.Parameters.AddWithValue("@Id", reserva.Id);
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
                string consulta = "DELETE FROM reservas WHERE Id = @Id";
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
