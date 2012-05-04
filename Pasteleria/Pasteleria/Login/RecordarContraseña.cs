using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaComunes;
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
            Correo correoContraseña = new Correo();
            //NuevaCuenta nuevacuenta = new NuevaCuenta();

            string Aviso;
            //Llamar la funcion RegresaContraseña en sql
            string Mensaje = "Haz pedido que te recordáramos tu contraseña de Repostería."
                + "\n\nUsuario: " //+ nuevacuenta.txtUsuario.Text
                + "\nCorreo: " + txtCorreoRecordarContraseña.Text
                + "\nContraseña: " + logica.ObtenerContrasena(txtCorreoRecordarContraseña.Text)
                + "\n\nGracias,\nEl equipo de Repostería\nContáctanos en equiporeposteria@gmail.com";

            Aviso = correoContraseña.MandarCorreo(txtCorreoRecordarContraseña.Text, "Recordar contraseña", Mensaje);

            MessageBox.Show(Aviso);
            Hide();
        }

        private void txtCorreoRecordarContraseña_TextChanged(object sender, EventArgs e)
        {
            btnRecordarContraseña.Enabled = true;
        }
    }
}
