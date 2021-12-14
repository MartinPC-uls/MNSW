using Diseño.Conexion;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace Diseño
{
    public partial class F_InicioSesion : Form
    {

        Consulta consulta = new Consulta();

        public F_InicioSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (consulta.comprobarUsuario(txtUser.Text, txtPassword.Text))
            {
                this.Hide();
                string user = txtUser.Text;
                Utils.user = user;

                // carga los datos necesarios para el uso óptimo del programa
                cargarDatosNecesarios();

                F_MenuPrincipal form1 = new F_MenuPrincipal(user);
                form1.ShowDialog();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains(".com") || txtUser.Text.Contains(".cl"))
            {
                barUser.BackColor = Color.Green;
                if (barPassword.BackColor == Color.Green)
                {
                    healthIcon_green.Show();
                    healthIcon_red.Hide();
                }
            } else
            {
                healthIcon_red.Show();
                healthIcon_green.Hide();
                barUser.BackColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                healthIcon_red.Show();
                healthIcon_green.Hide();
                barPassword.BackColor = Color.Red;
            }
            else
            {
                barPassword.BackColor = Color.Green;
                if (barUser.BackColor == Color.Green)
                {
                    healthIcon_green.Show();
                    healthIcon_red.Hide();
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Registro registro = new F_Registro();
            registro.ShowDialog();
        }

        private void cargarDatosNecesarios()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            // datos del niño
            Thread t1, t2, t3, t4, t5, t6, t7, t8; // la base de datos está recibiendo hasta un máximo de 6 conexiones.

            //t1 = new Thread(new ThreadStart(getAltura));
            //t2 = new Thread(new ThreadStart(getNombre));
            //t3 = new Thread(new ThreadStart(getInt_LM));
            //t4 = new Thread(new ThreadStart(getInt_ES));
            //t5 = new Thread(new ThreadStart(getInt_EM));
            //t6 = new Thread(new ThreadStart(getSexo));
            //t7 = new Thread(new ThreadStart(getEdad));
            //t8 = new Thread(new ThreadStart(getPeso));
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();
            //t6.Start();
            //t7.Start();
            //t8.Start();
            int altura = consulta.getAlturaNino();
            int edad = consulta.getEdadNino();
            string nombre = consulta.getNombreNino();
            int int_lm = consulta.getIntLM();
            int int_es = consulta.getIntES();
            int int_em = consulta.getIntEM();
            string sexo = consulta.getSexoNino();
            int peso = consulta.getPesoNino();

            // se almacenan en memoria estática utilizando la clase Utils
            Utils.peso_nino = peso;
            Utils.altura_nino = altura;
            Utils.edad_nino = edad;
            Utils.nombre_nino = nombre;
            Utils.int_lm = int_lm;
            Utils.int_es = int_es;
            Utils.int_em = int_em;
            Utils.sexo_nino = sexo;

            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());
        }
        public void getAltura()
        {
            int altura = consulta.getAlturaNino();
            Utils.altura_nino = altura;
        }
        public void getEdad()
        {
            int edad = consulta.getEdadNino();
            Utils.edad_nino = edad;
        }
        public void getNombre()
        {
            string nombre = consulta.getNombreNino();
            Utils.nombre_nino = nombre;
        }
        public void getInt_LM()
        {
            int int_lm = consulta.getIntLM();
            Utils.int_lm = int_lm;
        }
        public void getInt_ES()
        {
            int int_es = consulta.getIntES();
            Utils.int_es = int_es;
        }
        public void getInt_EM()
        {
            int int_em = consulta.getIntEM();
            Utils.int_em = int_em;
        }
        public void getSexo()
        {
            string sexo = consulta.getSexoNino();
            Utils.sexo_nino = sexo;
        }
        public void getPeso()
        {
            int peso = consulta.getPesoNino();
            Utils.peso_nino = peso;
        }
    }
}
