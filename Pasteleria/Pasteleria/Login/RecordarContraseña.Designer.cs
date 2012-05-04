namespace Pasteleria
{
    partial class RecordarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordarContraseña));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCorreoRecordarContraseña = new System.Windows.Forms.TextBox();
            this.btnRecordarContraseña = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreoRecordarContraseña);
            this.groupBox1.Controls.Add(this.btnRecordarContraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(132, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 112);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtCorreoRecordarContraseña
            // 
            this.txtCorreoRecordarContraseña.Location = new System.Drawing.Point(29, 44);
            this.txtCorreoRecordarContraseña.Name = "txtCorreoRecordarContraseña";
            this.txtCorreoRecordarContraseña.Size = new System.Drawing.Size(179, 20);
            this.txtCorreoRecordarContraseña.TabIndex = 22;
            this.txtCorreoRecordarContraseña.TextChanged += new System.EventHandler(this.txtCorreoRecordarContraseña_TextChanged);
            // 
            // btnRecordarContraseña
            // 
            this.btnRecordarContraseña.Enabled = false;
            this.btnRecordarContraseña.Location = new System.Drawing.Point(29, 76);
            this.btnRecordarContraseña.Name = "btnRecordarContraseña";
            this.btnRecordarContraseña.Size = new System.Drawing.Size(61, 27);
            this.btnRecordarContraseña.TabIndex = 23;
            this.btnRecordarContraseña.Text = "Recordar";
            this.btnRecordarContraseña.UseVisualStyleBackColor = true;
            this.btnRecordarContraseña.Click += new System.EventHandler(this.btnRecordarContraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Escriba su correo electrónico:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Pasteleria.Properties.Resources.Ventana;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // RecordarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(382, 129);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordarContraseña";
            this.Text = "RecordarContraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCorreoRecordarContraseña;
        private System.Windows.Forms.Button btnRecordarContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}