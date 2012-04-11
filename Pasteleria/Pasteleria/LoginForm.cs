using System;
using System.Windows.Forms;


namespace Pasteleria
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Pastel pastelGrande = new PastelGrande();
            pastelGrande = new Fruta(pastelGrande);
            
            MessageBox.Show(pastelGrande.ObtieneDescripcion() + "\n\r" + pastelGrande.CalculaPrecio());

            MainForm mainForm = new MainForm();
            mainForm.Show();

            //Pastel pastelMediano = new PastelMediano();
            //pastelMediano = new Fruta(pastelMediano);

            //MessageBox.Show(pastelMediano.ObtieneDescripcion() + "\n\r" + pastelMediano.CalculaPrecio());
        }

        private void linkLabelCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevaCuenta nuevaCuenta = new NuevaCuenta();
            nuevaCuenta.Show();
        }
    }
}
