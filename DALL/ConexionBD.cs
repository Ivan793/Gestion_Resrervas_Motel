using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DALL;

namespace DALL
{
    public class ConexionBD
    {
        //Esta clase maneja la conexión con la base de datos
        public MySqlConnection ConectarBd()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "gestionreservasmotel"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = "2205"; //Contraseña de usuario de acceso a MySQL
           

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

           return conexionBD;
        }
    }
}
