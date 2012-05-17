using System;
using System.Windows.Forms;
using CapaNegocios;
using CapaComunes;

namespace Pasteleria
{
    public partial class NuevaCuenta : Form
    {
        Logica logica = new Logica();

        public NuevaCuenta()
        {
            InitializeComponent();
        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmaContraseña.Text)
            {
                try
                {
                    Empleado emp = new Empleado
                    {
                        Usuario = txtUsuario.Text,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Correo = txtCorreo.Text,
                        Contraseña = txtContraseña.Text,
                        Genero = cbxGenero.Text
                    };

                    MessageBox.Show("" + logica.CapturarEmpleado(emp));
                }

                catch (Exception exc)
                {
                    string debug = exc.Message;
                }

                CorreoContext correo = new CorreoContext(new CorreoNuevaCuenta());
                correo.CorreoContextInterface(txtCorreo.Text);

                //string Mensaje = "Tu Nueva Cuenta\n\nGracias por haber creado una cuenta en Reposteria."
                //    + "Aquí puedes encontrar información de tu cuenta:"
                //    + "\n\nID: " + logica.ObtenerEmpleadoID(txtCorreo.Text)
                //    + "\nUsuario: " + txtUsuario.Text
                //    + "\nCorreo: " + txtCorreo.Text
                //    + "\n\nGuarda esta información para uso futuro.\n\nGracias,"
                //    + "\nEl equipo de Repostería\nContáctanos en equiporeposteria@gmail.com";

                //Aviso = correoCuenta.MandarCorreo(txtCorreo.Text, "Nueva Cuenta", Mensaje);

                //MessageBox.Show(Aviso);
                Hide();
            }

            else
                MessageBox.Show("Su contraseña es incorrecta, confirme de nuevo.");

        }

    }
}
