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
        public bool verificarUsuario(string usuario)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuarios WHERE email = '" + usuario + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return true;

            cn.close();
            return false;
        }
        public void agregarUsuario(string usuario, string password)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO usuarios(email, password) VALUES (@email, @password)";
            cmd.Parameters.AddWithValue("@email", usuario);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void addNino(string email, string nombre, int edad, int altura, int peso, string sexo)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO nino_usuario(email, nombre, edad, altura, peso, sexo)" +
                " VALUES(@email, @nombre, @edad, @altura, @peso, @sexo)";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@edad", edad);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@sexo", sexo);
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
        public void addRecomendacion(string user, string recomendacion)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM recomendaciones WHERE email = '" + user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            string text = "";

            while (reader.Read())
            {
                for (int i = 1; i <= 15; i++)
                {
                    if (reader.GetString(i) == "0")
                    {
                        text = "UPDATE recomendaciones SET r" + i + " = '" + recomendacion + "'" +
                            " WHERE email = '" + user + "'";
                        break;
                    }
                }
            }
            cn.close();

            cn.open();
            MySqlCommand cmd2 = cn.CreateCommand();
            cmd2.CommandText = text;
            cmd2.ExecuteNonQuery();
            cn.close();

        }

        public List<Recomendacion> getRecomendaciones(string user)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM recomendaciones WHERE email = '" + user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Recomendacion> recomendaciones = new List<Recomendacion>();
            while (reader.Read())
            {
                for (int i = 1; i <= 15; i++)
                {
                    if (reader.GetString(i) != "0")
                    {
                        recomendaciones.Add(new Recomendacion("", reader.GetString(i)));
                    } else
                    {
                        break;
                    }
                }
            }
            cn.close();
            return recomendaciones;
        }
        public void updtNombreUsuario(string nombreNuevo)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE usuarios SET nombre_usuario = '" + nombreNuevo + "' WHERE email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void updtEdadUsuario(int edadNueva)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE usuarios SET edad_usuario = '" + edadNueva + "' WHERE email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void updtEmailUsuario(string emailNuevo)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE usuarios SET email = '" + emailNuevo + "' WHERE email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void updtPasswordUsuario(string passwordNuevo)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE usuarios SET password = '" + passwordNuevo + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public string getNombreUsuario(string email)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT nombre_usuario FROM usuarios WHERE email = '" + email + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string _s = reader.GetString(0);
                cn.close();
                return _s;
            }
            cn.close();
            return "";
        }
        public int getEdadUsuario(string email)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT edad_usuario FROM usuarios WHERE email = '" + email + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public string getNombreNino()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT nombre FROM nino_usuario WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string _s = reader.GetString(0);
                cn.close();
                return _s;
            }
            cn.close();
            return "";
        }
        public int getEdadNino()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT edad FROM nino_usuario WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public int getAlturaNino()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT altura FROM nino_usuario WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public int getPesoNino()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT peso FROM nino_usuario WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public string getSexoNino()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT sexo FROM nino_usuario WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string _s = reader.GetString(0);
                cn.close();
                return _s;
            }
            cn.close();
            return "";
        }
        public int getIntLM()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT lm FROM ninos_puntajes WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public int getIntES()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT es FROM ninos_puntajes WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public int getIntEM()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT em FROM ninos_puntajes WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int _i = reader.GetInt16(0);
                cn.close();
                return _i;
            }
            cn.close();
            return 0;
        }
        public bool verificarNinoRegistrado()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT email FROM nino_usuario WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(0) == null)
                {
                    cn.close();
                    return false;
                }
                cn.close();
                return true;
            }
            cn.close();
            return false;
        }
    }
}
