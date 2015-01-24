using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FaceRecognitionSystem
{
    class DBConnection
    {
        public static MySqlConnection GetDBConnection()
        {
            MySqlConnection con = null;
            String connectionStr = @"server = localhost;database = record;user = root;password = ;";

            try
            {
                con = new MySqlConnection(connectionStr);
                con.Open();
            }

            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }

            return con;
        }
    }
}
