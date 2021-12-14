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
            //cn.getConnection();
        }

        public bool comprobarUsuario(string usuario, string password)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios WHERE email = '" + usuario + "' AND password = '" + password + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cn.Close();
                        return true;
                    }
                    cn.Close();
                    return false;
                }
            }
        }
        public bool verificarUsuario(string usuario)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios WHERE email = '" + usuario + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cn.Close();
                        return true;
                    }
                }

                cn.Close();
                return false;
            }
        }
        public void agregarUsuario(string usuario, string password)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios(email, password) VALUES (@email, @password)";
                cmd.Parameters.AddWithValue("@email", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public int addNino(string email, string nombre, int edad, int altura, int peso, string sexo)
        {
            // 0 = error; 1 = NIÑO NUEVO; 2 = UPDATE NIÑO
            int state = 0;
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                try
                {
                    cn.Open();
                    //MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "INSERT INTO nino_usuario(email, nombre, edad, altura, peso, sexo)" +
                        " VALUES(@email, @nombre, @edad, @altura, @peso, @sexo)";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@edad", edad);
                    cmd.Parameters.AddWithValue("@altura", altura);
                    cmd.Parameters.AddWithValue("@peso", peso);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    state = 1;
                } catch (MySqlException e)
                {
                    var temp = cn.State.ToString();
                    if (cn.State == System.Data.ConnectionState.Open && temp == "Open")
                    {
                        cn.Close();
                        cn.Open();
                    }
                    else
                        cn.Open();
                    cmd.CommandText = "UPDATE nino_usuario SET nombre = '" + nombre + "', edad = " + edad +
                        ", altura = " + altura + ", peso = " + peso + ", sexo = " + sexo + " WHERE email = '" + email + "'";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    state = 2;
                }
            }
            return state;
        }
        public List<string> addSintomas(List<string> sintomas)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                // Raro ???????
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT sintoma FROM sintomas";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sintomas.Add(reader.GetString(0));
                    }
                }
                cn.Close();
                return sintomas;
            }
        }
        public List<Pregunta> addPreguntas()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM testci_1_preguntas";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
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
                    return preguntas;
                }
                cn.Close();
            }
        }
        public List<Alternativas> addAlternativas()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM testci_1_alternativas";

                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    List<Alternativas> alternativas = new List<Alternativas>();
                    while (reader.Read())
                    {
                        alternativas.Add(new Alternativas(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                            reader.GetString(7), reader.GetString(8)));
                    }
                    cn.Close();
                    return alternativas;
                }
            }
        }
        public List<RespuestasCorrectas> addRespuestasCorrectas()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM testci_1_respuesta";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    List<RespuestasCorrectas> respuestasCorrectas = new List<RespuestasCorrectas>();
                    while (reader.Read())
                    {
                        respuestasCorrectas.Add(new RespuestasCorrectas(reader.GetInt16(0), reader.GetString(1)));
                    }
                    cn.Close();
                    return respuestasCorrectas;
                }
            }
        }
        public void registrarPuntajesNino(string email, int ptj_lm, int ptj_es, int ptj_em)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                try
                {
                    cmd.CommandText = "INSERT INTO ninos_puntajes(email, lm, es, em)" +
                        " VALUES(@email, @lm, @es, @em)";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@lm", ptj_lm);
                    cmd.Parameters.AddWithValue("@es", ptj_es);
                    cmd.Parameters.AddWithValue("@em", ptj_em);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    cmd.CommandText = "UPDATE ninos_puntajes SET lm = " + ptj_lm + ", es = " + ptj_es + ", em = " + ptj_em
                        + " WHERE email = '" + email + "'";
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }
        public void reiniciarRecomendaciones()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE recomendaciones SET r1 = 0, r2 = 0, r3 = 0, r4 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0," +
                    " r9 = 0, r10 = 0, r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0 WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void addRecomendacion(string user, string recomendacion = "")
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                string text = "";
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM recomendaciones WHERE email = '" + user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();

                    text = "INSERT recomendaciones SET email = '" + user + "'";

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
                }
                cn.Close();

                using (var cn2 = new MySqlConnection(Connection.connString))
                using (var cmd2 = cn2.CreateCommand())
                {
                    try
                    {
                        cn2.Open();
                        //MySqlCommand cmd2 = cn.CreateCommand();
                        cmd2.CommandText = text;
                        cmd2.ExecuteNonQuery();
                        cn2.Close();
                    } catch (Exception e)
                    {
                        var temp = cn2.State.ToString();
                        if (cn2.State == System.Data.ConnectionState.Open && temp == "Open")
                        {
                            cn2.Close();
                        }
                    }
                }
            }

        }

        public void addTestStatus(bool value = false)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                int v = 0;
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO tests_realizados(email, test_realizado)" +
                    " VALUES(@email, @test_realizado)";
                cmd.Parameters.AddWithValue("@email", Utils.user);
                if (value)
                    v = 1;
                cmd.Parameters.AddWithValue("@test_realizado", v);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void updtTestStatus(bool value = false)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                int v = 0;
                //MySqlCommand cmd = cn.CreateCommand();
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
                cn.Close();
            }
        }
        public string getTestDate(string sd_ed)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                // sd = start date
                // ed = end date
                try
                {
                    cn.Open();
                    //MySqlCommand cmd = cn.CreateCommand();
                    string s = "";
                    if (sd_ed == "sd")
                        s = "date";
                    else if (sd_ed == "ed")
                        s = "date_final";
                    cmd.CommandText = "SELECT " + s + " FROM tests_realizados WHERE email = '" + Utils.user + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        //MySqlDataReader reader = cmd.ExecuteReader();
                        string _s = null;
                        if (reader.Read())
                        {
                            _s = reader.GetString(0);
                        }
                        cn.Close();
                        return _s;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public void updtTestRealizado()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE tests_realizados SET test_realizado = 0, date = '" + DBNull.Value + "', date_final = '" +
                    DBNull.Value + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void addFechaInicioRecomendacionSemanal()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                DateTime today = DateTime.Parse(todays_date);
                today.AddDays(7);
                string s = today.Year + "-" + today.Month + "-" + today.Day;

                cmd.CommandText = "UPDATE usuarios SET recomendacion_recibida = '" + s +
                    "' WHERE email = '" + Utils.user + "'";

                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public string getFechaRecomendacionSemanal()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                try
                {
                    //MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "SELECT recomendacion_recibida FROM usuarios WHERE email = '" + Utils.user + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        //MySqlDataReader reader = cmd.ExecuteReader();
                        string s;
                        if (reader.Read())
                        {
                            s = reader.GetString(0);
                            cn.Close();
                            return s;
                        }
                        cn.Close();
                        return null;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public void updtFechaInicioRecomendacionSemanal()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                DateTime today = DateTime.Parse(todays_date);
                DateTime nextWeek = today.AddDays(7);
                string s = nextWeek.Year + "-" + nextWeek.Month + "-" + nextWeek.Day;
                cmd.CommandText = "UPDATE usuarios SET recomendacion_recibida = '" + s + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public string getRecomendacionSemanal_RelacionIMC(int imc)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT recomendacion FROM recomendaciones_semanales WHERE imc = " + imc;

                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    string s;
                    if (reader.Read())
                    {
                        s = reader.GetString(0);
                        cn.Close();
                        return s;
                    }
                    cn.Close();
                    return null;
                }
            }
        }
        public string getRecomendacionSemanal()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                Random rnd = new Random();
                int rand_id = rnd.Next(3, 23);
                cmd.CommandText = "SELECT recomendacion FROM recomendaciones_semanales WHERE ID = " + rand_id;
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    string s;
                    if (reader.Read())
                    {
                        s = reader.GetString(0);
                        cn.Close();
                        return s;
                    }
                    cn.Close();
                    return null;
                }
            }
        }
        public void addUsuarioTablaTestsRealizados()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT tests_realizados SET email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public bool getTestStatus()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT test_realizado FROM tests_realizados WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetInt16(0) == 0)
                        {
                            cn.Close();
                            return false;
                        }
                        else if (reader.GetInt16(0) == 1)
                        {
                            cn.Close();
                            return true;
                        }
                    }
                }
                cn.Close();
                return false;
            }
        }
        public List<Recomendacion> getRecomendaciones(string user)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM recomendaciones WHERE email = '" + user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    List<Recomendacion> recomendaciones = new List<Recomendacion>();
                    while (reader.Read())
                    {
                        for (int i = 1; i <= 15; i++)
                        {
                            if (reader.GetString(i) != "0")
                            {
                                recomendaciones.Add(new Recomendacion("", reader.GetString(i)));
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    return recomendaciones;
                }

                cn.Close();
            }
        }
        public void updtNombreUsuario(string nombreNuevo)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET nombre_usuario = '" + nombreNuevo + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void updtEdadUsuario(int edadNueva)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET edad_usuario = '" + edadNueva + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void updtEmailUsuario(string emailNuevo)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET email = '" + emailNuevo + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            try
            {
                using (var cn2 = new MySqlConnection(Connection.connString))
                using (var cmd2 = cn2.CreateCommand())
                {
                    cn2.Open();
                    cmd2.CommandText = "UPDATE tests_realizados SET email = '" + emailNuevo + "' WHERE email = '" + Utils.user + "'";
                    cmd2.ExecuteNonQuery();
                    cn2.Close();
                }
            } catch (Exception e) { }
            try
            {
                using (var cn3 = new MySqlConnection(Connection.connString))
                using (var cmd3 = cn3.CreateCommand())
                {
                    cn3.Open();
                    cmd3.CommandText = "UPDATE recomendaciones SET email = '" + emailNuevo + "' WHERE email = '" + Utils.user + "'";
                    cmd3.ExecuteNonQuery();
                    cn3.Close();
                }
            } catch (Exception e) { }
            try
            {
                using (var cn4 = new MySqlConnection(Connection.connString))
                using (var cmd4 = cn4.CreateCommand())
                {
                    cn4.Open();
                    cmd4.CommandText = "UPDATE ninos_puntajes SET email = '" + emailNuevo + "' WHERE email = '" + Utils.user + "'";
                    cmd4.ExecuteNonQuery();
                    cn4.Close();
                }
            } catch (Exception e) { }
            try
            {
                using (var cn5 = new MySqlConnection(Connection.connString))
                using (var cmd5 = cn5.CreateCommand())
                {
                    cn5.Open();
                    cmd5.CommandText = "UPDATE nino_usuario SET email = '" + emailNuevo + "' WHERE email = '" + Utils.user + "'";
                    cmd5.ExecuteNonQuery();
                    cn5.Close();
                }
            } catch (Exception e) { }
        }
        public void updtPasswordUsuario(string passwordNuevo)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET password = '" + passwordNuevo + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public string getNombreUsuario(string email)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT nombre_usuario FROM usuarios WHERE email = '" + email + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string _s = reader.GetString(0);
                        cn.Close();
                        return _s;
                    }
                    cn.Close();
                    return "";
                }
            }
        }
        public int getEdadUsuario(string email)
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT edad_usuario FROM usuarios WHERE email = '" + email + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public string getNombreNino()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT nombre FROM nino_usuario WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string _s = reader.GetString(0);
                        cn.Close();
                        return _s;
                    }
                    cn.Close();
                    return "";
                }
            }
        }
        public int getEdadNino()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT edad FROM nino_usuario WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public int getAlturaNino()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT altura FROM nino_usuario WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public int getPesoNino()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT peso FROM nino_usuario WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public string getSexoNino()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT sexo FROM nino_usuario WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string _s = reader.GetString(0);
                        cn.Close();
                        return _s;
                    }
                    cn.Close();
                    return "";
                }
            }
        }
        public int getIntLM()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT lm FROM ninos_puntajes WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public int getIntES()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT es FROM ninos_puntajes WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public int getIntEM()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT em FROM ninos_puntajes WHERE email = '" + Utils.user + "'";

                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int _i = reader.GetInt16(0);
                        cn.Close();
                        return _i;
                    }
                    cn.Close();
                    return 0;
                }
            }
        }
        public bool verificarNinoRegistrado()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT email FROM nino_usuario WHERE email = '" + Utils.user + "'";
                using (var reader = cmd.ExecuteReader())
                {
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetString(0) == null)
                        {
                            cn.Close();
                            return false;
                        }
                        cn.Close();
                        return true;
                    }
                }
                cn.Close();
                return false;
            }
        }
        public void updtFechaInicioCambiarDatos() // añade o cambia
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                //MySqlCommand cmd = cn.CreateCommand();
                string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                DateTime today = DateTime.Parse(todays_date);
                DateTime nextWeek = today.AddDays(30);
                string s = nextWeek.Year + "-" + nextWeek.Month + "-" + nextWeek.Day;
                cmd.CommandText = "UPDATE usuarios SET recordatorio_cambiar_datos = '" + s + "' WHERE email = '" + Utils.user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public string getFechaRecordatorioCambiarDatos()
        {
            using (var cn = new MySqlConnection(Connection.connString))
            using (var cmd = cn.CreateCommand())
            {
                cn.Open();
                try
                {
                    //MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "SELECT recordatorio_cambiar_datos FROM usuarios WHERE email = '" + Utils.user + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        //MySqlDataReader reader = cmd.ExecuteReader();
                        string s;
                        if (reader.Read())
                        {
                            s = reader.GetString(0);
                            cn.Close();
                            return s;
                        }
                        cn.Close();
                        return null;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
