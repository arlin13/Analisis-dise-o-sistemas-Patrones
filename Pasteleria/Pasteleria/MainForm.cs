using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Pasteleria
{
    public partial class MainForm : Form
    {
        List<string> listaPasteles = new List<string>();
        List<double> listaCostoPasteles = new List<double>();

        public MainForm()
        {
            InitializeComponent();
            listaPasteles.Add("Precio\tSabor\t\tForma\t\tTamaño\t\t\tExtras");
        }

        #region Menu
        //Ventana
        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }
        //Persona
        private void mantenimientoDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Show();
        }
        //Ventas
        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El reporte de ventas se ha creado.");
            //Convertir a CSV
            //StreamWriter sw = new StreamWriter("Ventas Totales.csv");
            //string strHeader = datagridview.Columns[0].HeaderText;

            //for (int i = 1; i < datagridview.Columns.Count; i++)
            //{
            //    strHeader += "," + datagridview.Columns[i].HeaderText;
            //}

            //sw.WriteLine(strHeader);


            //for (int m = 0; m < datagridview.Rows.Count; m++)
            //{
            //    string strRowValue = "";
            //    strRowValue += datagridview.Rows[m].Cells[0].Value;

            //    for (int n = 0; n < datagridview.Columns.Count; n++)
            //    {
            //        strRowValue += "," + datagridview.Rows[m].Cells[n].Value;
            //    }

            //    sw.WriteLine(strRowValue);
            //}

            //sw.Close();
        }
        //Ayuda
        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ayuda = new AcercaDe();
            ayuda.Show();
        }
        #endregion Menu

        #region Eventos radiobuttons
        private void checkBoxExtrasFruta_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasFruta.Checked)
            {
                comboBoxPastelExtrasFruta.Enabled = false;
                comboBoxPastelExtrasFruta.SelectedIndex = -1;
            }
            else
            {
                comboBoxPastelExtrasFruta.Enabled = true;
                comboBoxPastelExtrasFruta.SelectedIndex = 0;
            }
        }
        private void checkBoxExtrasRelleno_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasRelleno.Checked)
            {
                comboBoxPastelExtrasRelleno.Enabled = false;
                comboBoxPastelExtrasRelleno.SelectedIndex = -1;
            }
            else
            {
                comboBoxPastelExtrasRelleno.Enabled = true;
                comboBoxPastelExtrasRelleno.SelectedIndex = 0;
            }
        }
        private void checkBoxExtrasNieve_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasNieve.Checked)
            {
                comboBoxPastelExtrasNieve.Enabled = false;
                comboBoxPastelExtrasNieve.SelectedIndex = -1;
            }
            else
            {
                comboBoxPastelExtrasNieve.Enabled = true;
                comboBoxPastelExtrasNieve.SelectedIndex = 0;
            }
        }
        private void checkBoxExtrasDibujo_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasDibujo.Checked)
            {
                textBoxPastelExtrasDibujo.Enabled = false;
            }
            else
                textBoxPastelExtrasDibujo.Enabled = true;
        }
        #endregion Eventos radiobuttons

        #region Botones
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pastel pastel;

                if (radioButtonTamañoChico.Checked)
                    pastel = new PastelChico();
                else if (radioButtonTamañoMediano.Checked)
                    pastel = new PastelMediano();
                else
                    pastel = new PastelGrande();

                if (radioButtonSaborChocolate.Checked)
                    pastel.Sabor = Sabor.Chocolate;
                else if (radioButtonSaborVainilla.Checked)
                    pastel.Sabor = Sabor.Vainilla;
                else
                    pastel.Sabor = Sabor.TresLeches;

                if (radioButtonFormaCircular.Checked)
                    pastel.Forma = Forma.Circular;
                else if (radioButtonFormaCorazon.Checked)
                    pastel.Forma = Forma.Corazon;
                else
                    pastel.Forma = Forma.Cuadrado;

                if (checkBoxExtrasFruta.Checked)
                {
                    pastel = new Fruta(pastel);
                }
                if (checkBoxExtrasNieve.Checked)
                {
                    pastel = new Nieve(pastel);
                }
                if (checkBoxExtrasRelleno.Checked)
                {
                    pastel = new Relleno(pastel);
                }

                listaPasteles.Add(pastel.CalculaPrecio() + "\t" + pastel.Sabor + "\t" + pastel.Forma + "\t\t" + pastel.ObtieneDescripcion());
                listboxCompraRealizada.DataSource = null;
                listboxCompraRealizada.DataSource = listaPasteles;

                listaCostoPasteles.Add(pastel.CalculaPrecio());
                double total = 0.00;
                foreach (var item in listaCostoPasteles)
                {
                    total += item;
                }
                textBoxTotal.Text = total.ToString();
            }
            catch (Exception ex)
            { 
            }
        }
        private void buttonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Context context;

                double total = double.Parse(textBoxTotal.Text);

                if (radioButtonTarjetaClienteDistinguido.Checked)
                {
                    context = new Context(new TarjetaClienteDistinguido());
                    MessageBox.Show("Total a pagar con tarjeta de cliente distinguido: "
                        + context.ContextInterface(total, .20));
                }
                else
                {
                    string descuento = "5";
                    double descuentoCupon = .05;
                    context = new Context(new Cupon());

                    if (radioButtonCupon10.Checked)
                    {
                        descuento = "10";
                        descuentoCupon = .10;
                    }
                    else if (radioButtonCupon15.Checked)
                    {
                        descuento = "15";
                        descuentoCupon = .15;
                    }
                    MessageBox.Show("Total a pagar con cupón del " + descuento + "%"
                        + context.ContextInterface(total, descuentoCupon));
                }
            }
            catch (Exception error)
            { }
        }
        #endregion Botones

        private void lbCompraRealizada_DoubleClick(object sender, EventArgs e)
        {
            int remove = listboxCompraRealizada.SelectedIndex;
            listaPasteles.RemoveAt(remove);
            listboxCompraRealizada.DataSource = null;
            listboxCompraRealizada.DataSource = listaPasteles;

            listaCostoPasteles.RemoveAt(remove);

            double total = 0.00;
            foreach (var item in listaCostoPasteles)
            {
                total += item;
            }
            textBoxTotal.Text = total.ToString();

        }
    }
}
