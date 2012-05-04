using System;
using System.Windows.Forms;
using CapaComunes;
using CapaNegocios;

namespace Pasteleria
{
    public partial class LoginForm : Form
    {
        Logica logica = new Logica();
        public static string guardarIdEmpleado;
        public static Empleado empleado = new Empleado();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            bool confirmado;

            if ((textBoxIDEmpleado.Text == string.Empty) || (textBoxContrasenaEmpleado.Text == string.Empty))
            {
                MessageBox.Show("Hay campos vacíos.");
            }

            else
            {
                try
                {
                    guardarIdEmpleado = textBoxIDEmpleado.Text;
                   
                    confirmado = logica.Login(Convert.ToInt32(guardarIdEmpleado), textBoxContrasenaEmpleado.Text);
                    empleado = logica.ObtenerEmpleado(guardarIdEmpleado);

                    if (confirmado)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("Intente de nuevo");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }      
        }

        private void linkLabelCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevaCuenta nuevacuenta = new NuevaCuenta();
            nuevacuenta.Show();          
        }

        private void linkLabelProblemasContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecordarContraseña recordarcontraseña = new RecordarContraseña();
            recordarcontraseña.Show();
        }
    }
}
