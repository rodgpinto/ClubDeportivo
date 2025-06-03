namespace ClubDeportivo
{
    partial class fListarSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListarSocios));
            dtgvRegistros = new DataGridView();
            label1 = new Label();
            btnCerrar = new Button();
            btnAtras = new Button();
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgvRegistros
            // 
            dtgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRegistros.Location = new Point(14, 59);
            dtgvRegistros.Name = "dtgvRegistros";
            dtgvRegistros.Size = new Size(944, 379);
            dtgvRegistros.TabIndex = 10;
            dtgvRegistros.CellClick += dtgvRegistros_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(54, 116, 181);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(416, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 11;
            label1.Text = "Socios Registrados";
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
            btnCerrar.Location = new Point(920, 13);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 29);
            btnCerrar.TabIndex = 35;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
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
            btnAtras.Location = new Point(879, 13);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 34;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(38, 8);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(122, 21);
            lblRegistrar.TabIndex = 46;
            lblRegistrar.Text = "LISTAR SOCIOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // fListarSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(970, 450);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(dtgvRegistros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fListarSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarSocios";
            Load += fListarSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgvRegistros;
        private Label label1;
        private Button btnCerrar;
        private Button btnAtras;
        private Label lblRegistrar;
        private PictureBox pictureBox1;
    }
}