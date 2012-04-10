namespace Pasteleria
{
    partial class NuevaCuenta
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCrearCuenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxCorreo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.panelLogin.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.panelLogin.Controls.Add(this.groupBoxLogin);
            this.panelLogin.Location = new System.Drawing.Point(14, 8);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(657, 347);
            this.panelLogin.TabIndex = 8;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.comboBoxGenero);
            this.groupBoxLogin.Controls.Add(this.label6);
            this.groupBoxLogin.Controls.Add(this.label5);
            this.groupBoxLogin.Controls.Add(this.textBoxConfirmarContrasena);
            this.groupBoxLogin.Controls.Add(this.comboBoxCorreo);
            this.groupBoxLogin.Controls.Add(this.label4);
            this.groupBoxLogin.Controls.Add(this.textBox2);
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.textBoxApellidoPaterno);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.buttonCrearCuenta);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.textBoxNombre);
            this.groupBoxLogin.Controls.Add(this.textBoxCorreo);
            this.groupBoxLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(175, 10);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(306, 332);
            this.groupBoxLogin.TabIndex = 6;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Nueva cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // buttonCrearCuenta
            // 
            this.buttonCrearCuenta.Location = new System.Drawing.Point(103, 270);
            this.buttonCrearCuenta.Name = "buttonCrearCuenta";
            this.buttonCrearCuenta.Size = new System.Drawing.Size(100, 23);
            this.buttonCrearCuenta.TabIndex = 7;
            this.buttonCrearCuenta.Text = "Crear cuenta";
            this.buttonCrearCuenta.UseVisualStyleBackColor = true;
            this.buttonCrearCuenta.Click += new System.EventHandler(this.buttonCrearCuenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(52, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(52, 97);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCorreo.TabIndex = 2;
            // 
            // textBoxApellidoPaterno
            // 
            this.textBoxApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoPaterno.Location = new System.Drawing.Point(158, 57);
            this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
            this.textBoxApellidoPaterno.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidoPaterno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(155, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(49, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(52, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBoxCorreo
            // 
            this.comboBoxCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCorreo.FormattingEnabled = true;
            this.comboBoxCorreo.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@yahoo.com"});
            this.comboBoxCorreo.Location = new System.Drawing.Point(159, 95);
            this.comboBoxCorreo.Name = "comboBoxCorreo";
            this.comboBoxCorreo.Size = new System.Drawing.Size(100, 23);
            this.comboBoxCorreo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(49, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirmar contraseña";
            // 
            // textBoxConfirmarContrasena
            // 
            this.textBoxConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmarContrasena.Location = new System.Drawing.Point(52, 177);
            this.textBoxConfirmarContrasena.Name = "textBoxConfirmarContrasena";
            this.textBoxConfirmarContrasena.PasswordChar = '*';
            this.textBoxConfirmarContrasena.Size = new System.Drawing.Size(206, 20);
            this.textBoxConfirmarContrasena.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(49, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.comboBoxGenero.Location = new System.Drawing.Point(52, 217);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(206, 23);
            this.comboBoxGenero.TabIndex = 6;
            // 
            // NuevaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.panelLogin);
            this.Name = "NuevaCuenta";
            this.Text = "NuevaCuenta";
            this.panelLogin.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCrearCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellidoPaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxConfirmarContrasena;
        private System.Windows.Forms.ComboBox comboBoxCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGenero;
    }
}