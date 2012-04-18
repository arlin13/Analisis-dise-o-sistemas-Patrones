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
            try
            {
                if (textboxContrasena.Text == txtConfirmaContraseña.Text)
                {
                    Empleado emp = new Empleado
                    {
                        Usuario = textboxUsuario.Text,
                        Nombre = txtNombre.Text,
                        Apellido = textboxApellido.Text,
                        Correo = textboxCorreo.Text,
                        Contraseña = textboxContrasena.Text,
                        Genero = comboboxGenero.Text
                    };

                    MessageBox.Show("" + logica.CapturarEmpleado(emp));

                    Correo correoCuenta = new Correo();
                    string Aviso;
                    string Mensaje = "Tu Nueva Cuenta\n\nGracias por haber creado una cuenta en Reposteria."
                        + "Aquí puedes encontrar información de tu cuenta:"
                        + "\n\nID: " + logica.ObtenerEmpleadoID(textboxCorreo.Text)
                        + "\nUsuario: " + textboxUsuario.Text
                        + "\nCorreo: " + textboxCorreo.Text
                        + "\n\nGuarda esta información para uso futuro.\n\nGracias,"
                        + "\nEl equipo de Repostería\nContáctanos en equiporeposteria@gmail.com";

                    Aviso = correoCuenta.MandarCorreo(textboxCorreo.Text, "Nueva Cuenta", Mensaje);

                    MessageBox.Show(Aviso);
                    Hide();
                }

                else
                    MessageBox.Show("Su contraseña es incorrecta, confirme de nuevo.");
            }
            catch (Exception error)
            {
            }
        }

    }
}
