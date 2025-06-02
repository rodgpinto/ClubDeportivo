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
            picCerrar = new PictureBox();
            picAtras = new PictureBox();
            btnRegistrarPagoNoSocio = new Button();
            btnRegistrarPagoSocio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAtras).BeginInit();
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
            // picCerrar
            // 
            picCerrar.BackgroundImage = (Image)resources.GetObject("picCerrar.BackgroundImage");
            picCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            picCerrar.Location = new Point(293, 21);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(41, 30);
            picCerrar.TabIndex = 29;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picAtras
            // 
            picAtras.BackgroundImage = (Image)resources.GetObject("picAtras.BackgroundImage");
            picAtras.BackgroundImageLayout = ImageLayout.Zoom;
            picAtras.Location = new Point(246, 21);
            picAtras.Name = "picAtras";
            picAtras.Size = new Size(41, 30);
            picAtras.TabIndex = 28;
            picAtras.TabStop = false;
            picAtras.Click += picAtras_Click;
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
            // 
            // RegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(340, 257);
            Controls.Add(pictureBox1);
            Controls.Add(lblRegistrarPago);
            Controls.Add(picCerrar);
            Controls.Add(picAtras);
            Controls.Add(btnRegistrarPagoNoSocio);
            Controls.Add(btnRegistrarPagoSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR PAGO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblRegistrarPago;
        private PictureBox picCerrar;
        private PictureBox picAtras;
        private Button btnRegistrarPagoNoSocio;
        private Button btnRegistrarPagoSocio;
    }
}