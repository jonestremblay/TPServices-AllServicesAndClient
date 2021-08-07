using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BirthEntryServiceDAO_WCF.Connections
{
    class Database
    {
        private static MySqlConnection cnx = null;
        //private static String connectionString = "Server=jonesdb.me;Uid=profbdeb;PWd=bdeb;Database=TPA15";
        private static String connectionString = "Server=192.168.2.29;Uid=profbdeb;PWd=bdeb;Database=TPA15";
        public static MySqlConnection GetConnection()
        {
            if (cnx == null)
            {
                cnx = new MySqlConnection();
                cnx.ConnectionString = connectionString;
                cnx.Open();
            }
            else if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.Open();
            }
            return cnx;
        }
        public static void Close() 
        {
            if (cnx != null)
            {
                cnx.Close();
            }
        
        }
    }
}
