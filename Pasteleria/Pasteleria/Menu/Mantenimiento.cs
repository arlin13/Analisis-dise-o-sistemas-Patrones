using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CapaNegocios;
using CapaComunes;

namespace Pasteleria
{
    public partial class Mantenimiento : Form
    {
        Logica logica = new Logica();

        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {     
            txtUsuario.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtContraseña.Enabled = true;
            cbxGenero.Enabled = true;
            btnActualizaEmpleado.Enabled = true;
            txtIdEmpleado.Enabled = false;
           
            Empleado emp = logica.ObtenerEmpleado(txtIdEmpleado.Text);
          
            txtUsuario.Text = emp.Usuario;
            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;
            txtCorreo.Text = emp.Correo;
            txtContraseña.Text = emp.Contraseña;
            cbxGenero.Text = emp.Genero;
        }

        private void btnActualizaEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Usuario = txtUsuario.Text;
            emp.Nombre = txtNombre.Text;
            emp.Apellido = txtApellido.Text;
            emp.Correo = txtCorreo.Text;
            emp.Contraseña = txtContraseña.Text;
            emp.Genero = cbxGenero.Text;

           MessageBox.Show(logica.ActualizarEmpleado(txtIdEmpleado.Text, emp));
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            logica.BorraEmpleado(Convert.ToInt32(txtIdEmpleadoEliminar.Text));
            MessageBox.Show("El empleado se ha dado de baja.");
        }

        private void txtIdEditaEmpleado_TextChanged(object sender, EventArgs e)
        {
            btnBuscarEmpleado.Enabled = true;
        }

        private void txtIdEmpleadoEliminar_TextChanged(object sender, EventArgs e)
        {
            btnEliminarEmpleado.Enabled = true;
        }
    }
}
