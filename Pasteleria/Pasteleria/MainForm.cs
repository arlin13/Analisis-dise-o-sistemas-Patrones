using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using CapaNegocios;
using CapaComunes;
using System.IO;

namespace Pasteleria
{
    public partial class MainForm : Form
    {
        List<double> listaCostoProducto = new List<double>();
        List<string> listaProducto = new List<string>();
        Logica logica = new Logica();
        LoginForm login = new LoginForm();
        Empleado emp;
        
        public MainForm()
        {
            InitializeComponent();
            listaProducto.Add("Precio\tSabor\t\tForma\t\tTamaño\t\t\tExtras");
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
        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasTotales ventastotales = new VentasTotales();
            ventastotales.Show();
        }

        //Acerca de
        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            AcercaDe ayuda = new AcercaDe();
            ayuda.Show();
        }

        #endregion Menu

        #region Eventos radiobuttons [Pasteles]
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
        #endregion 

        #region Botón Agregar [Pasteles]
       
        private void buttonAgregar_Click(object sender, EventArgs e)
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

            listaProducto.Add(pastel.CalculaPrecio() + "\t" + pastel.Sabor + "\t" + pastel.Forma + "\t\t" + pastel.ObtieneDescripcion());
            lbCompraRealizada.DataSource = null;
            lbCompraRealizada.DataSource = listaProducto;

            listaCostoProducto.Add(pastel.CalculaPrecio());
            double total = 0.00;
           
            foreach (var item in listaCostoProducto)
            {
                total += item;
            }

            textBoxTotal.Text = total.ToString();
        }
        #endregion

        #region Eventos radiobuttons [Cupcakes]
        private void checkBoxExtrasCases_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasCases.Checked)
            {
                comboBoxExtrasCases.Enabled = false;
                comboBoxExtrasCases.SelectedIndex = -1;
            }
            else
            {
                comboBoxExtrasCases.Enabled = true;
                comboBoxExtrasCases.SelectedIndex = 0;
            }
        }

        private void checkBoxExtrasFrosting_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasFrosting.Checked)
            {
                comboBoxExtrasFrosting.Enabled = false;
                comboBoxExtrasFrosting.SelectedIndex = -1;
            }
            else
            {
                comboBoxExtrasFrosting.Enabled = true;
                comboBoxExtrasFrosting.SelectedIndex = 0;
            }
        }

        private void checkBoxExtrasSprinkles_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxExtrasSprinkles.Checked)
            {
                comboBoxExtrasSprinkles.Enabled = false;
                comboBoxExtrasSprinkles.SelectedIndex = -1;
            }
            else 
            {
                comboBoxExtrasSprinkles.Enabled = true;
                comboBoxExtrasSprinkles.SelectedIndex = 0;
            }
        }
        #endregion

        #region Botón Agregar [Cupcakes]
        private void buttonAgregarCupcake_Click(object sender, EventArgs e)
        {
            Cupcake cupcake;

            if (radioButtonCupcakeMini.Checked)
                cupcake = new CupcakeMini();
            else if (radioButtonCupcakeMediano.Checked)
                cupcake = new CupcakeMediano();
            else
                cupcake = new CupcakeJumbo();

            if (radioButtonCupcakeChocolate.Checked)
            cupcake.SaborCupcake = SaborCupcake.Chocolate;
            else if(radioButtonCupcakeVainilla.Checked)
                cupcake.SaborCupcake = SaborCupcake.Vainilla;
            else 
                cupcake.SaborCupcake = SaborCupcake.TresLeches;

            if (checkBoxExtrasCases.Checked) 
            {
                cupcake = new Cases(cupcake);
            }
            if (checkBoxExtrasFrosting.Checked)
            {
                cupcake = new Frosting (cupcake);
            }
            if (checkBoxExtrasSprinkles.Checked)
            {
                cupcake = new Sprinkles (cupcake);
            }

            listaProducto.Add(cupcake.CalculaPrecio() + "\t" + cupcake.SaborCupcake + "\t-----\t\t" + cupcake.ObtieneDescripcion());
            lbCompraRealizada.DataSource = null;
            lbCompraRealizada.DataSource = listaProducto;

            listaCostoProducto.Add(cupcake.CalculaPrecio());
            double total = 0.00;

            foreach (var item in listaCostoProducto)
            {
                total += item;
            }

            textBoxTotal.Text = total.ToString();
        }
        #endregion
       
        #region Pagar
        private void buttonPagar_Click(object sender, EventArgs e)
        {
            DateTime fechaRecibo = File.GetLastWriteTime("Recibo.txt");
            Context context;

            if (textBoxTotal.Text.Equals(""))
            {
                MessageBox.Show("No ha agregado artículos a la lista de compra.");
            }
            
            else
            {
                try 
                {
                    double total = double.Parse(textBoxTotal.Text);

                    if (radioButtonTarjetaClienteDistinguido.Checked)
                    {
                        context = new Context(new TarjetaClienteDistinguido());
                        MessageBox.Show("Total a pagar con tarjeta de cliente distinguido: "
                            + context.ContextInterface(total, .20));
                    }
                    else
                    {
                        context = new Context(new Cupon());
                        string descuento = "5";
                        double descuentoCupon = .05;                       
                        string tarjeta = null;

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

                        if (radioButtonMasterCard.Checked)
                        {
                            tarjeta = "MASTERCARD \nNúmero de cuenta: \n4000 0012 3456 7899";
                        }

                        else if (radioButtonVisa.Checked)
                        {
                            tarjeta = "VISA \nNúmero de cuenta: \n4552 7204 1234 5678";
                        }

                        Venta ven = new Venta
                        {
                            idEmpleado = LoginForm.empleado.idEmpleado,
                            Monto = Convert.ToInt32(textBoxTotal.Text),
                        };

                        logica.CapturarVenta(ven);

                       string recibo = "\t\t\tREPOSTERÍA\n\tequiporeposteria@gmail.com\nTIJUANA BAJA CALIFORNIA C.P 22500" +
                                        "\n--------------------------------------\nEmpleado: " +
                                        LoginForm.empleado.Nombre + "\nID: " +
                                        LoginForm.empleado.idEmpleado +
                                        "\n--------------------------------------\nRecibo de cliente\n" +
                                        tarjeta + "\n\nSUBTOTAL:\t\t\t\t\t$\t" +
                                        textBoxTotal.Text + "\nDESCUENTO:\t\t\t" + descuento + "%\t\t$\t-" +
                                        (descuentoCupon * Convert.ToDouble(textBoxTotal.Text)) +
                                        "\nTOTAL:\t\t\t\t\t\t$\t" + context.ContextInterface(total, descuentoCupon) +
                                        "\n--------------------------------------\n\t\tGracias por su compra!\n\t   " +
                                        fechaRecibo;

                        File.WriteAllText("Recibo.txt", recibo);
                    }

                    Process.Start("Recibo.txt");
                }

                catch(Exception exc)
                {
                     string debug = exc.Message;
                }               
            }

        }                
        #endregion 

        #region Lista de Compras
        private void lbCompraRealizada_DoubleClick(object sender, EventArgs e)
        {
            int remove = lbCompraRealizada.SelectedIndex;
            listaProducto.RemoveAt(remove);
            lbCompraRealizada.DataSource = null;
            lbCompraRealizada.DataSource = listaProducto;

            listaCostoProducto.RemoveAt(remove);

            double total = 0.00;
            foreach (var item in listaCostoProducto)
            {
                total += item;
            }

            textBoxTotal.Text = total.ToString();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {      
            emp = LoginForm.empleado;
            labelIdEmpleado.Text = emp.idEmpleado.ToString();
            labelEmpleado.Text = emp.Nombre;
        }

    }
}
