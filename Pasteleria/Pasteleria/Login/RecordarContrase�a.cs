using System;
using System;
using System.Windows.Forms;
using CapaNegocios;

namespace Pasteleria
{
    public partial class RecordarContraseña : Form
    {
        Logica logica = new Logica();

        public RecordarContraseña()
        {
            InitializeComponent();
        }

        private void btnRecordarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                Correo correoContraseña = new Correo();

                string Mensaje = "Haz pedido que te recordáramos tu contraseña de Repostería."
                    + "\n\nUsuario: " //+ nuevacuenta.txtUsuario.Text
                    + "\nCorreo: " + textboxRecordarCorreo.Text
                    + "\nContraseña: " + logica.ObtenerContrasena(textboxRecordarCorreo.Text)
                    + "\n\nGracias,\nEl equipo de Repostería\nContáctanos en equiporeposteria@gmail.com";

                string Aviso = correoContraseña.MandarCorreo(textboxRecordarCorreo.Text, "Recordar contraseña", Mensaje);
                MessageBox.Show(Aviso);
                Hide();
            }
            catch (Exception error)
            { 
            }
        }

        private void txtCorreoRecordarContraseña_TextChanged(object sender, EventArgs e)
        {
            btnRecordarContraseña.Enabled = true;
        }
    }
}
