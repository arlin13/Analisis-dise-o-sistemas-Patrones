using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using CapaComunes;
using CapaNegocios;

namespace Pasteleria
{
    public partial class VentasTotales : Form
    {
        Logica logica = new Logica();
        Venta venta = new Venta();
        
        public VentasTotales()
        {
            InitializeComponent();
        }

        #region Genera Reporte
        private void buttonReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaReporte = File.GetLastWriteTime("VentasTotales.csv");
            StreamWriter sw = new StreamWriter("VentasTotales.csv");
            string strHeader = dataGridViewVentas.Columns[0].HeaderText;

            for (int i = 1; i < dataGridViewVentas.Columns.Count; i++)
            {
                strHeader += "," + dataGridViewVentas.Columns[i].HeaderText;
            }

            sw.WriteLine("\nREPORTE DE VENTAS TOTALES           Fecha: " + fechaReporte + "\n");
            sw.WriteLine(strHeader);

            for (int m = 0; m < dataGridViewVentas.Rows.Count; m++)
            {
                string strRowValue = "";
                strRowValue += dataGridViewVentas.Rows[m].Cells[0].Value;

                for (int n = 1; n < dataGridViewVentas.Columns.Count; n++)
                {
                    strRowValue += "," + dataGridViewVentas.Rows[m].Cells[n].Value;
                }

                sw.WriteLine(strRowValue);
            }

            sw.Close();
            Process.Start("VentasTotales.csv");
        }
        #endregion

        #region Buscar Venta
        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            txtEditaVentaIdEmpleado.Enabled = false;
            txtEditaVentaMonto.Enabled = true;
            btnActualizarVenta.Enabled = true;

            Venta ven = logica.ObtenerVentas(Convert.ToInt32(txtIdVenta.Text));

            txtEditaVentaMonto.Text = Convert.ToString(ven.Monto);
            txtEditaVentaIdEmpleado.Text = Convert.ToString(ven.idEmpleado);
        }
        #endregion
        
        #region Buscar Ventas por Empleado
        private void btnVentasEmpleado_Click(object sender, EventArgs e)
        {
            dataGridViewVentas.DataSource = logica.ObtenerVentasEmpleado(Convert.ToInt32(txtIdVentasEmpleado.Text));
        }
        #endregion

        #region Actualizar Venta
        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            Venta ven = new Venta();
            ven.Monto = Convert.ToInt32(txtEditaVentaMonto.Text);

            MessageBox.Show(logica.ActualizarVenta(txtIdVenta.Text, ven));
        }
        #endregion 
        
        #region Monto Total
        private void btnMontoTotal_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < dataGridViewVentas.Rows.Count; ++i)
            {
                suma += Convert.ToInt32(dataGridViewVentas.Rows[i].Cells[2].Value);
            }

            txtMontoTotal.Text = ("$" + suma.ToString());

        }
        #endregion
        
        #region Refresh datagrid
        private void btnVentasTotales_Click(object sender, EventArgs e)
        {
            dataGridViewVentas.DataSource = logica.MostrarDGVVentas();
        }
        #endregion   
      
        #region Eventos
        private void VentasTotales_Load(object sender, EventArgs e)
        {
           dataGridViewVentas.DataSource = logica.MostrarDGVVentas();
        }

        private void txtIdVentasEmpleado_TextChanged(object sender, EventArgs e)
        {
            btnVentasEmpleado.Enabled = true;
        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {
            btnBuscarVenta.Enabled = true;
        }
        #endregion
    }
}
