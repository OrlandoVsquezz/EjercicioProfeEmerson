namespace Vista.Formularios
{
    partial class frmPrincipalRegistro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.btnCrearCuenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 545);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.meme;
            this.pictureBox1.Location = new System.Drawing.Point(28, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(166, 395);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(95, 50);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar sesion\r\n";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(28, 395);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(95, 50);
            this.btnCrearCuenta.TabIndex = 0;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(294, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(546, 545);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // frmPrincipalRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 545);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipalRegistro";
            this.Text = "frmPrincipalRegistro";
            this.Load += new System.EventHandler(this.frmPrincipalRegistro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnCrearCuenta;
    }
}