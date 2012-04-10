namespace Pasteleria
{
    partial class LoginForm
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
            this.textBoxIDEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxContrasenaEmpleado = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.linkLabelProblemasContrasena = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabelCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.groupBoxLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIDEmpleado
            // 
            this.textBoxIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDEmpleado.Location = new System.Drawing.Point(69, 55);
            this.textBoxIDEmpleado.Name = "textBoxIDEmpleado";
            this.textBoxIDEmpleado.Size = new System.Drawing.Size(170, 20);
            this.textBoxIDEmpleado.TabIndex = 1;
            // 
            // textBoxContrasenaEmpleado
            // 
            this.textBoxContrasenaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenaEmpleado.Location = new System.Drawing.Point(69, 95);
            this.textBoxContrasenaEmpleado.Name = "textBoxContrasenaEmpleado";
            this.textBoxContrasenaEmpleado.PasswordChar = '*';
            this.textBoxContrasenaEmpleado.Size = new System.Drawing.Size(170, 20);
            this.textBoxContrasenaEmpleado.TabIndex = 2;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Location = new System.Drawing.Point(103, 135);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(100, 23);
            this.buttonIniciarSesion.TabIndex = 5;
            this.buttonIniciarSesion.Text = "Iniciar Sesión";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.linkLabelProblemasContrasena);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.buttonIniciarSesion);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.textBoxIDEmpleado);
            this.groupBoxLogin.Controls.Add(this.textBoxContrasenaEmpleado);
            this.groupBoxLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(175, 75);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(306, 197);
            this.groupBoxLogin.TabIndex = 6;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Log In";
            // 
            // linkLabelProblemasContrasena
            // 
            this.linkLabelProblemasContrasena.AutoSize = true;
            this.linkLabelProblemasContrasena.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelProblemasContrasena.Location = new System.Drawing.Point(66, 118);
            this.linkLabelProblemasContrasena.Name = "linkLabelProblemasContrasena";
            this.linkLabelProblemasContrasena.Size = new System.Drawing.Size(174, 15);
            this.linkLabelProblemasContrasena.TabIndex = 8;
            this.linkLabelProblemasContrasena.TabStop = true;
            this.linkLabelProblemasContrasena.Text = "¿Problemas con tu contraseña?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID de empelado";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.panelLogin.Controls.Add(this.linkLabelCrearCuenta);
            this.panelLogin.Controls.Add(this.groupBoxLogin);
            this.panelLogin.Location = new System.Drawing.Point(14, 8);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(657, 347);
            this.panelLogin.TabIndex = 7;
            // 
            // linkLabelCrearCuenta
            // 
            this.linkLabelCrearCuenta.AutoSize = true;
            this.linkLabelCrearCuenta.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelCrearCuenta.Location = new System.Drawing.Point(544, 10);
            this.linkLabelCrearCuenta.Name = "linkLabelCrearCuenta";
            this.linkLabelCrearCuenta.Size = new System.Drawing.Size(101, 13);
            this.linkLabelCrearCuenta.TabIndex = 9;
            this.linkLabelCrearCuenta.TabStop = true;
            this.linkLabelCrearCuenta.Text = "Crear nueva cuenta";
            this.linkLabelCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCrearCuenta_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.panelLogin);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDEmpleado;
        private System.Windows.Forms.TextBox textBoxContrasenaEmpleado;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabelProblemasContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkLabelCrearCuenta;
    }
}

