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
            picCerrar = new PictureBox();
            picAtras = new PictureBox();
            dtgvRegistros = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // picCerrar
            // 
            picCerrar.BackgroundImage = (Image)resources.GetObject("picCerrar.BackgroundImage");
            picCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            picCerrar.Location = new Point(917, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(41, 30);
            picCerrar.TabIndex = 8;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picAtras
            // 
            picAtras.BackgroundImage = (Image)resources.GetObject("picAtras.BackgroundImage");
            picAtras.BackgroundImageLayout = ImageLayout.Zoom;
            picAtras.Location = new Point(12, 12);
            picAtras.Name = "picAtras";
            picAtras.Size = new Size(41, 30);
            picAtras.SizeMode = PictureBoxSizeMode.Zoom;
            picAtras.TabIndex = 9;
            picAtras.TabStop = false;
            picAtras.Click += picAtras_Click;
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
            // fListarSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(970, 450);
            Controls.Add(label1);
            Controls.Add(dtgvRegistros);
            Controls.Add(picAtras);
            Controls.Add(picCerrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fListarSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarSocios";
            Load += fListarSocios_Load;
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCerrar;
        private PictureBox picAtras;
        private DataGridView dtgvRegistros;
        private Label label1;
    }
}