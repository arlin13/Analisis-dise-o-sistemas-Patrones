using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            
            Pastel pastelMediano = new PastelMediano();
            pastelMediano = new Fruta(pastelMediano);

            MessageBox.Show(pastelMediano.ObtieneDescripcion() + "\n\r" + pastelMediano.CalculaPrecio());
        }
    }
}
