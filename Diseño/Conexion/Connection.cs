using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diseño.Conexion
{
    class Connection
    {
        private static readonly string server    = "remotemysql.com";
        private static readonly string database  = "hHPJESvwNO";
        private static readonly string user      = "hHPJESvwNO";
        private static readonly string password  = "TLmGMF0w7V";
        private static readonly string port      = "3306";
        private static readonly string sslM      = "none";

        private static readonly string connString = String.Format("server={0};port={1};user id={2};password={3};database={4};SslMode={5}",
            server, port, user, password, database, sslM);
        MySqlConnection cn = null;

        public MySqlConnection getConnection()
        {
            cn = new MySqlConnection(connString);
            //cn.Open();
            return cn;
        }
        public void close()
        {
            cn.Close();
        }
        public void open()
        {
            cn.Open();
        }
        public MySqlCommand CreateCommand()
        {
            return cn.CreateCommand();
        }
    }
}
