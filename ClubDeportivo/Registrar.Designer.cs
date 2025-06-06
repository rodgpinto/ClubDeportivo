namespace ClubDeportivo
{
    partial class fRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegistrar));
            btnRegistrarSocio = new Button();
            btnRegistrarNoSocio = new Button();
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrarSocio.Cursor = Cursors.Hand;
            btnRegistrarSocio.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrarSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarSocio.Font = new Font("Segoe UI", 10F);
            btnRegistrarSocio.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarSocio.ImeMode = ImeMode.NoControl;
            btnRegistrarSocio.Location = new Point(114, 68);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(100, 61);
            btnRegistrarSocio.TabIndex = 4;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrarNoSocio.Cursor = Cursors.Hand;
            btnRegistrarNoSocio.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrarNoSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 10F);
            btnRegistrarNoSocio.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarNoSocio.ImeMode = ImeMode.NoControl;
            btnRegistrarNoSocio.Location = new Point(114, 171);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(100, 58);
            btnRegistrarNoSocio.TabIndex = 5;
            btnRegistrarNoSocio.Text = "Registrar No Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(35, 9);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(94, 21);
            lblRegistrar.TabIndex = 24;
            lblRegistrar.Text = "REGISTRAR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
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
            btnAtras.Location = new Point(295, 7);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 34;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // fRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(340, 257);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox1);
            Controls.Add(lblRegistrar);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private Label lblRegistrar;
        private PictureBox pictureBox1;
        private Button btnAtras;
    }
}