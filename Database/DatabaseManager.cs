using FitnessApp.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Database
{
    class DatabaseManager
    {
        private static string connPath = InitialStartController.checkServerPath();//conection string
        private static SqlConnection conn = new SqlConnection(connPath);

        public static void ConnOpen()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        public static void ConnClosed()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }

        public static SqlConnection SqlConnection()
        {
            return conn;
        }
    }
}
