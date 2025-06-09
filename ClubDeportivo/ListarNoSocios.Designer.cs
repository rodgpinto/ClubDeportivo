namespace ClubDeportivo
{
    partial class ListarNoSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarNoSocios));
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            btnAtras = new Button();
            label1 = new Label();
            dtgvRegistroNoSocio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroNoSocio).BeginInit();
            SuspendLayout();
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(36, 8);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(151, 21);
            lblRegistrar.TabIndex = 51;
            lblRegistrar.Text = "LISTAR NO SOCIOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
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
            btnAtras.Location = new Point(923, 9);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 49;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(54, 116, 181);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(414, 21);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 48;
            label1.Text = "No Socios Registrados";
            // 
            // dtgvRegistroNoSocio
            // 
            dtgvRegistroNoSocio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvRegistroNoSocio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvRegistroNoSocio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRegistroNoSocio.Location = new Point(12, 59);
            dtgvRegistroNoSocio.Name = "dtgvRegistroNoSocio";
            dtgvRegistroNoSocio.Size = new Size(944, 379);
            dtgvRegistroNoSocio.TabIndex = 47;
            // 
            // ListarNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(970, 450);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(dtgvRegistroNoSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarNoSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarNoSocios";
            Load += ListarNoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroNoSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistrar;
        private PictureBox pictureBox1;
        private Button btnAtras;
        private Label label1;
        private DataGridView dtgvRegistroNoSocio;
    }
}