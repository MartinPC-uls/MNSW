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
            {
                cn.close();
                return true;
            }

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
            // Raro ???????
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
            try
            {
                cmd.CommandText = "INSERT INTO ninos_puntajes(email, lm, es, em)" +
                    " VALUES(@email, @lm, @es, @em)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@lm", ptj_lm);
                cmd.Parameters.AddWithValue("@es", ptj_es);
                cmd.Parameters.AddWithValue("@em", ptj_em);
                cmd.ExecuteNonQuery();
            } catch (MySqlException e)
            {
                cmd.CommandText = "UPDATE ninos_puntajes SET lm = " + ptj_lm + ", es = " + ptj_es + ", em = " + ptj_em
                    + " WHERE email = '" + email + "'";
                cmd.ExecuteNonQuery();
            }
            cn.close();
        }
        public void reiniciarRecomendaciones()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE recomendaciones SET r1 = 0, r2 = 0, r3 = 0, r4 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0," +
                " r9 = 0, r10 = 0, r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0 WHERE email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void addRecomendacion(string user, string recomendacion = "")
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM recomendaciones WHERE email = '" + user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            string text = "INSERT recomendaciones SET email = '" + user + "'";

            while (reader.Read())
            {
                for (int i = 1; i <= 15; i++)
                {
                    if (reader.GetString(i) == "0")
                    {
                        if (recomendacion == "")
                        {
                            recomendacion = "0";
                        }
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

        public void addTestStatus(bool value = false)
        {
            cn.open();
            int v = 0;
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO tests_realizados(email, test_realizado)" +
                " VALUES(@email, @test_realizado)";
            cmd.Parameters.AddWithValue("@email", Utils.user);
            if (value)
                v = 1;
            cmd.Parameters.AddWithValue("@test_realizado", v);
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void updtTestStatus(bool value = false)
        {
            cn.open();
            int v = 0;
            MySqlCommand cmd = cn.CreateCommand();
            if (value)
            {
                string date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                DateTime date_start = DateTime.Parse(date);
                DateTime date_end = date_start.AddDays(30);
                string _data_end = date_end.Year + "-" + date_end.Month + "-" + date_end.Day;
                cmd.CommandText = "UPDATE tests_realizados SET test_realizado = 1, date = '" + date
                    + "', date_final = '" + _data_end + "' WHERE email = '" + Utils.user + "'";
            }
            else
            {
                cmd.CommandText = "UPDATE tests_realizados SET test_realizado = 0, date = " + DBNull.Value +
                    " WHERE email = '" + Utils.user + "'";
            }
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public string getTestDate(string sd_ed)
        {
            // sd = start date
            // ed = end date
            try
            {
                cn.open();
                MySqlCommand cmd = cn.CreateCommand();
                string s = "";
                if (sd_ed == "sd")
                    s = "date";
                else if (sd_ed == "ed")
                    s = "date_final";
                cmd.CommandText = "SELECT " + s + " FROM tests_realizados WHERE email = '" + Utils.user + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                string _s = null;
                if (reader.Read())
                {
                    _s = reader.GetString(0);
                }
                cn.close();
                return _s;
            } catch (Exception e)
            {
                return null;
            }
        }
        public void updtTestRealizado()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE tests_realizados SET test_realizado = 0, date = '" + DBNull.Value + "', date_final = '" +
                DBNull.Value + "' WHERE email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public void addFechaInicioRecomendacionSemanal()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            DateTime today = DateTime.Parse(todays_date);
            today.AddDays(7);
            string s = today.Year + "-" + today.Month + "-" + today.Day;

            cmd.CommandText = "UPDATE usuarios SET recomendacion_recibida = '" + s +
                "' WHERE email = '" + Utils.user + "'";

            cmd.ExecuteNonQuery();
            cn.close();
        }
        public string getFechaRecomendacionSemanal()
        {
            cn.open();
            try
            {
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT recomendacion_recibida FROM usuarios WHERE email = '" + Utils.user + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                string s;
                if (reader.Read())
                {
                    s = reader.GetString(0);
                    cn.close();
                    return s;
                }
                cn.close();
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public void updtFechaInicioRecomendacionSemanal()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            DateTime today = DateTime.Parse(todays_date);
            DateTime nextWeek = today.AddDays(7);
            string s = nextWeek.Year + "-" + nextWeek.Month + "-" + nextWeek.Day;
            cmd.CommandText = "UPDATE usuarios SET recomendacion_recibida = '" + s + "' WHERE email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public string getRecomendacionSemanal_RelacionIMC(int imc)
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT recomendacion FROM recomendaciones_semanales WHERE imc = " + imc;
            MySqlDataReader reader = cmd.ExecuteReader();
            string s;
            if (reader.Read())
            {
                s = reader.GetString(0);
                cn.close();
                return s;
            }
            cn.close();
            return null;
        }
        public string getRecomendacionSemanal()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            Random rnd = new Random();
            int rand_id = rnd.Next(3, 23);
            cmd.CommandText = "SELECT recomendacion FROM recomendaciones_semanales WHERE ID = " + rand_id;
            MySqlDataReader reader = cmd.ExecuteReader();
            string s;
            if (reader.Read())
            {
                s = reader.GetString(0);
                cn.close();
                return s;
            }
            cn.close();
            return null;
        }
        public void addUsuarioTablaTestsRealizados()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT tests_realizados SET email = '" + Utils.user + "'";
            cmd.ExecuteNonQuery();
            cn.close();
        }
        public bool getTestStatus()
        {
            cn.open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT test_realizado FROM tests_realizados WHERE email = '" + Utils.user + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetInt16(0) == 0)
                {
                    cn.close();
                    return false;
                } else if (reader.GetInt16(0) == 1)
                {
                    cn.close();
                    return true;
                }
            }
            cn.close();
            return false;
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
