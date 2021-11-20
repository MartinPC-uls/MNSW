using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Conexion
{
    class Consulta
    {
        Connection cn = new Connection();

        public bool comprobarUsuario(String usuario, String password)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE email = '" + usuario + "' AND password = '" + password + "'", cn.getConnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cn.close();
                return true;
            }
            cn.close();
            return false;
        }

    }
}
