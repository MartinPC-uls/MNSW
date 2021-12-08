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

        public Consulta()
        {
            cn.getConnection();
        }

        public bool comprobarUsuario(string usuario, string password)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuarios WHERE email = '" + usuario + "' AND password = '" + password + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cn.close();
                return true;
            }
            cn.close();
            return false;
        }
        public void addNino(string email, string nombre, int edad, int altura, int peso, string sexo, int ci = 0)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO nino_usuario(email, nombre, edad, altura, peso, sexo, ci)" +
                " VALUES(@email, @nombre, @edad, @altura, @peso, @sexo, @ci)";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@edad", edad);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@ci", ci);
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public List<string> addSintomas(List<string> sintomas)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT sintoma FROM sintomas";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sintomas.Add(reader.GetString(0));
            }
            cn.close();
            return sintomas;
        }

    }
}
