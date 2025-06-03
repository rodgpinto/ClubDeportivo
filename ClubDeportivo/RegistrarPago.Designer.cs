namespace ClubDeportivo
{
    partial class RegistrarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPago));
            pictureBox1 = new PictureBox();
            lblRegistrarPago = new Label();
            btnRegistrarPagoNoSocio = new Button();
            btnRegistrarPagoSocio = new Button();
            btnAtras = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // lblRegistrarPago
            // 
            lblRegistrarPago.AutoSize = true;
            lblRegistrarPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrarPago.Location = new Point(32, 21);
            lblRegistrarPago.Name = "lblRegistrarPago";
            lblRegistrarPago.Size = new Size(141, 21);
            lblRegistrarPago.TabIndex = 30;
            lblRegistrarPago.Text = "REGISTRAR PAGO";
            // 
            // btnRegistrarPagoNoSocio
            // 
            btnRegistrarPagoNoSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPagoNoSocio.Cursor = Cursors.Hand;
            btnRegistrarPagoNoSocio.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPagoNoSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarPagoNoSocio.Font = new Font("Segoe UI", 10F);
            btnRegistrarPagoNoSocio.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarPagoNoSocio.ImeMode = ImeMode.NoControl;
            btnRegistrarPagoNoSocio.Location = new Point(111, 183);
            btnRegistrarPagoNoSocio.Name = "btnRegistrarPagoNoSocio";
            btnRegistrarPagoNoSocio.Size = new Size(109, 49);
            btnRegistrarPagoNoSocio.TabIndex = 27;
            btnRegistrarPagoNoSocio.Text = "Registrar Pago No Socio";
            btnRegistrarPagoNoSocio.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPagoSocio
            // 
            btnRegistrarPagoSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPagoSocio.Cursor = Cursors.Hand;
            btnRegistrarPagoSocio.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPagoSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarPagoSocio.Font = new Font("Segoe UI", 10F);
            btnRegistrarPagoSocio.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarPagoSocio.ImeMode = ImeMode.NoControl;
            btnRegistrarPagoSocio.Location = new Point(111, 80);
            btnRegistrarPagoSocio.Name = "btnRegistrarPagoSocio";
            btnRegistrarPagoSocio.Size = new Size(109, 52);
            btnRegistrarPagoSocio.TabIndex = 26;
            btnRegistrarPagoSocio.Text = "Registrar Pago Socio";
            btnRegistrarPagoSocio.UseVisualStyleBackColor = false;
            btnRegistrarPagoSocio.Click += btnRegistrarPagoSocio_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(201, 241, 253);
            btnAtras.BackgroundImage = (Image)resources.GetObject("btnAtras.BackgroundImage");
            btnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Location = new Point(254, 22);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 32;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(201, 241, 253);
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(295, 22);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 29);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // RegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(340, 257);
            Controls.Add(btnCerrar);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox1);
            Controls.Add(lblRegistrarPago);
            Controls.Add(btnRegistrarPagoNoSocio);
            Controls.Add(btnRegistrarPagoSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR PAGO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblRegistrarPago;
        private Button btnRegistrarPagoNoSocio;
        private Button btnRegistrarPagoSocio;
        private Button btnAtras;
        private Button btnCerrar;
    }
}