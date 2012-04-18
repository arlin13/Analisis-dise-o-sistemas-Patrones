namespace Pasteleria
{
    partial class Mantenimiento
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCambio = new System.Windows.Forms.TabPage();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.btnActualizaEmpleado = new System.Windows.Forms.Button();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.txtIdEmpleadoEliminar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.txtDespliegaEmpleadoBorrar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCambio.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCambio);
            this.tabControl1.Controls.Add(this.tabEliminar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCambio
            // 
            this.tabCambio.Controls.Add(this.btnBuscarEmpleado);
            this.tabCambio.Controls.Add(this.txtIdEmpleado);
            this.tabCambio.Controls.Add(this.label7);
            this.tabCambio.Controls.Add(this.label6);
            this.tabCambio.Controls.Add(this.label5);
            this.tabCambio.Controls.Add(this.label4);
            this.tabCambio.Controls.Add(this.label3);
            this.tabCambio.Controls.Add(this.label2);
            this.tabCambio.Controls.Add(this.label1);
            this.tabCambio.Controls.Add(this.txtNombre);
            this.tabCambio.Controls.Add(this.txtUsuario);
            this.tabCambio.Controls.Add(this.txtContraseña);
            this.tabCambio.Controls.Add(this.txtCorreo);
            this.tabCambio.Controls.Add(this.txtApellido);
            this.tabCambio.Controls.Add(this.cbxGenero);
            this.tabCambio.Controls.Add(this.btnActualizaEmpleado);
            this.tabCambio.Location = new System.Drawing.Point(4, 22);
            this.tabCambio.Name = "tabCambio";
            this.tabCambio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCambio.Size = new System.Drawing.Size(551, 285);
            this.tabCambio.TabIndex = 1;
            this.tabCambio.Text = "Actualizar";
            this.tabCambio.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Enabled = false;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(455, 34);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmpleado.TabIndex = 16;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(266, 37);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(173, 20);
            this.txtIdEmpleado.TabIndex = 14;
            this.txtIdEmpleado.TextChanged += new System.EventHandler(this.txtIdEditaEmpleado_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(263, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID de Empleado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(19, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(19, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(127, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(22, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(98, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(22, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(22, 175);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(206, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(22, 128);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(206, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(130, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(98, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.Enabled = false;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbxGenero.Location = new System.Drawing.Point(22, 221);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(202, 21);
            this.cbxGenero.TabIndex = 1;
            // 
            // btnActualizaEmpleado
            // 
            this.btnActualizaEmpleado.Enabled = false;
            this.btnActualizaEmpleado.Location = new System.Drawing.Point(149, 256);
            this.btnActualizaEmpleado.Name = "btnActualizaEmpleado";
            this.btnActualizaEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnActualizaEmpleado.TabIndex = 0;
            this.btnActualizaEmpleado.Text = "Actualizar";
            this.btnActualizaEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizaEmpleado.Click += new System.EventHandler(this.btnActualizaEmpleado_Click);
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.txtDespliegaEmpleadoBorrar);
            this.tabEliminar.Controls.Add(this.txtIdEmpleadoEliminar);
            this.tabEliminar.Controls.Add(this.label8);
            this.tabEliminar.Controls.Add(this.btnEliminarEmpleado);
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(551, 285);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Borrar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // txtIdEmpleadoEliminar
            // 
            this.txtIdEmpleadoEliminar.Location = new System.Drawing.Point(39, 56);
            this.txtIdEmpleadoEliminar.Name = "txtIdEmpleadoEliminar";
            this.txtIdEmpleadoEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleadoEliminar.TabIndex = 2;
            this.txtIdEmpleadoEliminar.TextChanged += new System.EventHandler(this.txtIdEmpleadoEliminar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID de Empleado:";
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(64, 82);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEmpleado.TabIndex = 0;
            this.btnEliminarEmpleado.Text = "Dar de Baja";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // txtDespliegaEmpleadoBorrar
            // 
            this.txtDespliegaEmpleadoBorrar.Enabled = false;
            this.txtDespliegaEmpleadoBorrar.Location = new System.Drawing.Point(193, 39);
            this.txtDespliegaEmpleadoBorrar.Multiline = true;
            this.txtDespliegaEmpleadoBorrar.Name = "txtDespliegaEmpleadoBorrar";
            this.txtDespliegaEmpleadoBorrar.Size = new System.Drawing.Size(315, 188);
            this.txtDespliegaEmpleadoBorrar.TabIndex = 3;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 335);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento de Personal";
            this.tabControl1.ResumeLayout(false);
            this.tabCambio.ResumeLayout(false);
            this.tabCambio.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCambio;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizaEmpleado;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbxGenero;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleadoEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        public System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtDespliegaEmpleadoBorrar;
    }
}