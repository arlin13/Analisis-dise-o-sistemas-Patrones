﻿using System;
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
            CorreoContext correo = new CorreoContext(new CorreoRecordarContraseña());
            correo.CorreoContextInterface(txtCorreoRecordarContraseña.Text);

            //Llamar la funcion RegresaContraseña en sql
            //string Mensaje = "Haz pedido que te recordáramos tu contraseña de Repostería."
            //    + "\n\nUsuario: " //+ nuevacuenta.txtUsuario.Text
            //    + "\nCorreo: " + txtCorreoRecordarContraseña.Text
            //    + "\nContraseña: " + logica.ObtenerContrasena(txtCorreoRecordarContraseña.Text)
            //    + "\n\nGracias,\nEl equipo de Repostería\nContáctanos en equiporeposteria@gmail.com";

            Hide();
        }

        private void txtCorreoRecordarContraseña_TextChanged(object sender, EventArgs e)
        {
            btnRecordarContraseña.Enabled = true;
        }
    }
}
