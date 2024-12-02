using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReescriviendoCSharp.Scripts.Concesionaria.Data
{
    internal class DataBase
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "conexion";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;
        //private string server = "localhost";

        public DataBase() 
        {
            cadenaConexion = "Server" + server +
                ";Database=" + database +
                ";User ID =" + user +
                ";Password = " + password + ";";
            
                
        }
        public MySqlConnection getConexion() 
        {
            if (conexion == null) 
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }

    }
}