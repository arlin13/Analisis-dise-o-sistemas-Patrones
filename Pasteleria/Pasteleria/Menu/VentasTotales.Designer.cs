namespace Pasteleria
{
    partial class VentasTotales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.btnVentasEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdVentasEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMontoTotal = new System.Windows.Forms.Button();
            this.btnVentasTotales = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditaVentaIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnActualizarVenta = new System.Windows.Forms.Button();
            this.txtEditaVentaMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(23, 71);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewVentas.Size = new System.Drawing.Size(360, 227);
            this.dataGridViewVentas.TabIndex = 0;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(246, 304);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(75, 23);
            this.buttonReporte.TabIndex = 3;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // btnVentasEmpleado
            // 
            this.btnVentasEmpleado.Enabled = false;
            this.btnVentasEmpleado.Location = new System.Drawing.Point(308, 42);
            this.btnVentasEmpleado.Name = "btnVentasEmpleado";
            this.btnVentasEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnVentasEmpleado.TabIndex = 4;
            this.btnVentasEmpleado.Text = "Ver";
            this.btnVentasEmpleado.UseVisualStyleBackColor = true;
            this.btnVentasEmpleado.Click += new System.EventHandler(this.btnVentasEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ver ventas por empleado";
            // 
            // txtIdVentasEmpleado
            // 
            this.txtIdVentasEmpleado.Location = new System.Drawing.Point(165, 42);
            this.txtIdVentasEmpleado.Name = "txtIdVentasEmpleado";
            this.txtIdVentasEmpleado.Size = new System.Drawing.Size(137, 20);
            this.txtIdVentasEmpleado.TabIndex = 6;
            this.txtIdVentasEmpleado.TextChanged += new System.EventHandler(this.txtIdVentasEmpleado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(138, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // btnMontoTotal
            // 
            this.btnMontoTotal.Location = new System.Drawing.Point(165, 304);
            this.btnMontoTotal.Name = "btnMontoTotal";
            this.btnMontoTotal.Size = new System.Drawing.Size(75, 23);
            this.btnMontoTotal.TabIndex = 9;
            this.btnMontoTotal.Text = "Monto Total";
            this.btnMontoTotal.UseVisualStyleBackColor = true;
            this.btnMontoTotal.Click += new System.EventHandler(this.btnMontoTotal_Click);
            // 
            // btnVentasTotales
            // 
            this.btnVentasTotales.Location = new System.Drawing.Point(84, 304);
            this.btnVentasTotales.Name = "btnVentasTotales";
            this.btnVentasTotales.Size = new System.Drawing.Size(75, 23);
            this.btnVentasTotales.TabIndex = 10;
            this.btnVentasTotales.Text = "Ventas";
            this.btnVentasTotales.UseVisualStyleBackColor = true;
            this.btnVentasTotales.Click += new System.EventHandler(this.btnVentasTotales_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(23, 40);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(80, 20);
            this.txtMontoTotal.TabIndex = 13;
            this.txtMontoTotal.Text = "$";
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(207, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID Empleado:";
            // 
            // txtEditaVentaIdEmpleado
            // 
            this.txtEditaVentaIdEmpleado.Enabled = false;
            this.txtEditaVentaIdEmpleado.Location = new System.Drawing.Point(210, 32);
            this.txtEditaVentaIdEmpleado.Name = "txtEditaVentaIdEmpleado";
            this.txtEditaVentaIdEmpleado.Size = new System.Drawing.Size(97, 20);
            this.txtEditaVentaIdEmpleado.TabIndex = 20;
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Enabled = false;
            this.btnActualizarVenta.Location = new System.Drawing.Point(232, 104);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarVenta.TabIndex = 19;
            this.btnActualizarVenta.Text = "Actualizar";
            this.btnActualizarVenta.UseVisualStyleBackColor = true;
            this.btnActualizarVenta.Click += new System.EventHandler(this.btnActualizarVenta_Click);
            // 
            // txtEditaVentaMonto
            // 
            this.txtEditaVentaMonto.Enabled = false;
            this.txtEditaVentaMonto.Location = new System.Drawing.Point(210, 80);
            this.txtEditaVentaMonto.Name = "txtEditaVentaMonto";
            this.txtEditaVentaMonto.Size = new System.Drawing.Size(97, 20);
            this.txtEditaVentaMonto.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(207, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Monto:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(28, 55);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(97, 20);
            this.txtIdVenta.TabIndex = 16;
            this.txtIdVenta.TextChanged += new System.EventHandler(this.txtIdVenta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(25, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID de Venta:";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Enabled = false;
            this.btnBuscarVenta.Location = new System.Drawing.Point(28, 81);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVenta.TabIndex = 14;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarVenta);
            this.groupBox1.Controls.Add(this.txtEditaVentaIdEmpleado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnActualizarVenta);
            this.groupBox1.Controls.Add(this.txtIdVenta);
            this.groupBox1.Controls.Add(this.txtEditaVentaMonto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 133);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Venta";
            // 
            // VentasTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.btnVentasTotales);
            this.Controls.Add(this.btnMontoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdVentasEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVentasEmpleado);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.dataGridViewVentas);
            this.Name = "VentasTotales";
            this.Text = "Información de Ventas ";
            this.Load += new System.EventHandler(this.VentasTotales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReporte;
        public System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Button btnVentasEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdVentasEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMontoTotal;
        private System.Windows.Forms.Button btnVentasTotales;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditaVentaIdEmpleado;
        private System.Windows.Forms.Button btnActualizarVenta;
        private System.Windows.Forms.TextBox txtEditaVentaMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}