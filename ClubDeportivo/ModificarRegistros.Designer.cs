namespace ClubDeportivo
{
    partial class ModificarRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarRegistros));
            btnModificarSocio = new Button();
            lblModificarRegistro = new Label();
            pictureBox1 = new PictureBox();
            btnModificarNoSocio = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnModificarSocio
            // 
            btnModificarSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnModificarSocio.Cursor = Cursors.Hand;
            btnModificarSocio.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnModificarSocio.FlatStyle = FlatStyle.Popup;
            btnModificarSocio.Font = new Font("Segoe UI", 10F);
            btnModificarSocio.ForeColor = SystemColors.ButtonHighlight;
            btnModificarSocio.ImeMode = ImeMode.NoControl;
            btnModificarSocio.Location = new Point(115, 60);
            btnModificarSocio.Name = "btnModificarSocio";
            btnModificarSocio.Size = new Size(100, 69);
            btnModificarSocio.TabIndex = 48;
            btnModificarSocio.Text = "Modificar Socio";
            btnModificarSocio.UseVisualStyleBackColor = false;
            btnModificarSocio.Click += btnModificarSocio_Click;
            // 
            // lblModificarRegistro
            // 
            lblModificarRegistro.AutoSize = true;
            lblModificarRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblModificarRegistro.Location = new Point(38, 12);
            lblModificarRegistro.Name = "lblModificarRegistro";
            lblModificarRegistro.Size = new Size(177, 21);
            lblModificarRegistro.TabIndex = 50;
            lblModificarRegistro.Text = "MODIFICAR REGISTRO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // btnModificarNoSocio
            // 
            btnModificarNoSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnModificarNoSocio.Cursor = Cursors.Hand;
            btnModificarNoSocio.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnModificarNoSocio.FlatStyle = FlatStyle.Popup;
            btnModificarNoSocio.Font = new Font("Segoe UI", 10F);
            btnModificarNoSocio.ForeColor = SystemColors.ButtonHighlight;
            btnModificarNoSocio.ImeMode = ImeMode.NoControl;
            btnModificarNoSocio.Location = new Point(115, 163);
            btnModificarNoSocio.Name = "btnModificarNoSocio";
            btnModificarNoSocio.Size = new Size(100, 69);
            btnModificarNoSocio.TabIndex = 51;
            btnModificarNoSocio.Text = "Modificar No Socio";
            btnModificarNoSocio.UseVisualStyleBackColor = false;
            btnModificarNoSocio.Click += btnModificarNoSocio_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(236, 240, 241);
            btnAtras.BackgroundImage = (Image)resources.GetObject("btnAtras.BackgroundImage");
            btnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Location = new Point(280, 10);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 52;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // ModificarRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(340, 257);
            Controls.Add(btnAtras);
            Controls.Add(btnModificarNoSocio);
            Controls.Add(lblModificarRegistro);
            Controls.Add(pictureBox1);
            Controls.Add(btnModificarSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MODIFICAR REGISTRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarSocio;
        private Label lblModificarRegistro;
        private PictureBox pictureBox1;
        private Button btnModificarNoSocio;
        private Button btnAtras;
    }
}