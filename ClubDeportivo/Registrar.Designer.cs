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
            picBack = new PictureBox();
            picAtras = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAtras).BeginInit();
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
            btnRegistrarSocio.Location = new Point(114, 43);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(100, 52);
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
            btnRegistrarNoSocio.Location = new Point(114, 146);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(100, 52);
            btnRegistrarNoSocio.TabIndex = 5;
            btnRegistrarNoSocio.Text = "Registrar No Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            // 
            // picBack
            // 
            picBack.BackgroundImage = (Image)resources.GetObject("picBack.BackgroundImage");
            picBack.BackgroundImageLayout = ImageLayout.Zoom;
            picBack.Location = new Point(12, 12);
            picBack.Name = "picBack";
            picBack.Size = new Size(41, 30);
            picBack.TabIndex = 8;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // picAtras
            // 
            picAtras.BackgroundImage = (Image)resources.GetObject("picAtras.BackgroundImage");
            picAtras.BackgroundImageLayout = ImageLayout.Zoom;
            picAtras.Location = new Point(287, 12);
            picAtras.Name = "picAtras";
            picAtras.Size = new Size(41, 30);
            picAtras.TabIndex = 23;
            picAtras.TabStop = false;
            picAtras.Click += picAtras_Click;
            // 
            // fRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(340, 294);
            Controls.Add(picAtras);
            Controls.Add(picBack);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR";
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAtras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private PictureBox picBack;
        private PictureBox picAtras;
    }
}