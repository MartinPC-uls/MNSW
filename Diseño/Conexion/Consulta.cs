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
        public List<Pregunta> addPreguntas()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM testci_1_preguntas";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Pregunta> preguntas = new List<Pregunta>();
            while (reader.Read())
            {
                if (reader.GetString(1) == " ")
                {
                    preguntas.Add(new Pregunta(reader.GetInt16(0), reader.GetString(2), reader.GetString(3)));
                }
                else
                {
                    preguntas.Add(new Pregunta(reader.GetInt16(0), reader.GetString(2), reader.GetString(3), reader.GetString(1)));
                }
            }
            cn.close();
            return preguntas;
        }
        public List<Alternativas> addAlternativas()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM testci_1_alternativas";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Alternativas> alternativas = new List<Alternativas>();
            while (reader.Read())
            {
                alternativas.Add(new Alternativas(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                    reader.GetString(7), reader.GetString(8)));
            }
            cn.close();
            return alternativas;
        }
        public List<RespuestasCorrectas> addRespuestasCorrectas()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM testci_1_respuesta";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<RespuestasCorrectas> respuestasCorrectas = new List<RespuestasCorrectas>();
            while (reader.Read())
            {
                respuestasCorrectas.Add(new RespuestasCorrectas(reader.GetInt16(0), reader.GetString(1)));
            }
            cn.close();
            return respuestasCorrectas;
        }
        public void registrarPuntajesNino(string email, int ptj_lm, int ptj_es, int ptj_em)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO ninos_puntajes(email, lm, es, em)" +
                " VALUES(@email, @lm, @es, @em)";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@lm", ptj_lm);
            cmd.Parameters.AddWithValue("@es", ptj_es);
            cmd.Parameters.AddWithValue("@em", ptj_em);
            cmd.ExecuteNonQuery();
            cn.close();
        }

    }
}
