namespace ClubDeportivo
{
    partial class fMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainMenu));
            lblIngreso = new Label();
            btnCerrar = new Button();
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnModificarRegistros = new Button();
            btnListarSocios = new Button();
            btnRegistrar = new Button();
            btnRegistrarPago = new Button();
            btnListarVencimientos = new Button();
            btnListarNoSocios = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(38, 52);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(56, 15);
            lblIngreso.TabIndex = 8;
            lblIngreso.Text = "USUARIO";
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
            btnCerrar.Location = new Point(426, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 29);
            btnCerrar.TabIndex = 34;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(38, 12);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(144, 21);
            lblRegistrar.TabIndex = 46;
            lblRegistrar.Text = "MENU PRINCIPAL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 249);
            panel1.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnListarNoSocios, 1, 1);
            tableLayoutPanel1.Controls.Add(btnModificarRegistros, 0, 2);
            tableLayoutPanel1.Controls.Add(btnListarSocios, 0, 1);
            tableLayoutPanel1.Controls.Add(btnRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRegistrarPago, 1, 0);
            tableLayoutPanel1.Controls.Add(btnListarVencimientos, 1, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(447, 249);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // btnModificarRegistros
            // 
            btnModificarRegistros.Anchor = AnchorStyles.None;
            btnModificarRegistros.AutoSize = true;
            btnModificarRegistros.BackColor = Color.FromArgb(54, 116, 181);
            btnModificarRegistros.Cursor = Cursors.Hand;
            btnModificarRegistros.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnModificarRegistros.FlatStyle = FlatStyle.Popup;
            btnModificarRegistros.Font = new Font("Segoe UI", 10F);
            btnModificarRegistros.ForeColor = SystemColors.ButtonHighlight;
            btnModificarRegistros.ImeMode = ImeMode.NoControl;
            btnModificarRegistros.Location = new Point(31, 173);
            btnModificarRegistros.Name = "btnModificarRegistros";
            btnModificarRegistros.Size = new Size(161, 69);
            btnModificarRegistros.TabIndex = 47;
            btnModificarRegistros.Text = "Modificar registros";
            btnModificarRegistros.UseVisualStyleBackColor = false;
            btnModificarRegistros.Click += btnModificarRegistros_Click;
            // 
            // btnListarSocios
            // 
            btnListarSocios.Anchor = AnchorStyles.None;
            btnListarSocios.AutoSize = true;
            btnListarSocios.BackColor = Color.FromArgb(54, 116, 181);
            btnListarSocios.Cursor = Cursors.Hand;
            btnListarSocios.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnListarSocios.FlatStyle = FlatStyle.Popup;
            btnListarSocios.Font = new Font("Segoe UI", 10F);
            btnListarSocios.ForeColor = SystemColors.ButtonHighlight;
            btnListarSocios.ImeMode = ImeMode.NoControl;
            btnListarSocios.Location = new Point(29, 90);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(165, 69);
            btnListarSocios.TabIndex = 5;
            btnListarSocios.Text = "Listar socios";
            btnListarSocios.UseVisualStyleBackColor = false;
            btnListarSocios.Click += btnListarSocios_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.AutoSize = true;
            btnRegistrar.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.ImeMode = ImeMode.NoControl;
            btnRegistrar.Location = new Point(29, 7);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(165, 69);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Anchor = AnchorStyles.None;
            btnRegistrarPago.AutoSize = true;
            btnRegistrarPago.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPago.Cursor = Cursors.Hand;
            btnRegistrarPago.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPago.FlatStyle = FlatStyle.Popup;
            btnRegistrarPago.Font = new Font("Segoe UI", 10F);
            btnRegistrarPago.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarPago.ImeMode = ImeMode.NoControl;
            btnRegistrarPago.Location = new Point(252, 7);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(165, 69);
            btnRegistrarPago.TabIndex = 4;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // btnListarVencimientos
            // 
            btnListarVencimientos.Anchor = AnchorStyles.None;
            btnListarVencimientos.AutoSize = true;
            btnListarVencimientos.BackColor = Color.FromArgb(54, 116, 181);
            btnListarVencimientos.Cursor = Cursors.Hand;
            btnListarVencimientos.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnListarVencimientos.FlatStyle = FlatStyle.Popup;
            btnListarVencimientos.Font = new Font("Segoe UI", 10F);
            btnListarVencimientos.ForeColor = SystemColors.ButtonHighlight;
            btnListarVencimientos.ImeMode = ImeMode.NoControl;
            btnListarVencimientos.Location = new Point(252, 173);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(165, 69);
            btnListarVencimientos.TabIndex = 6;
            btnListarVencimientos.Text = "Listar vencimientos";
            btnListarVencimientos.UseVisualStyleBackColor = false;
            btnListarVencimientos.Click += btnListarVencimientos_Click;
            // 
            // btnListarNoSocios
            // 
            btnListarNoSocios.Anchor = AnchorStyles.None;
            btnListarNoSocios.AutoSize = true;
            btnListarNoSocios.BackColor = Color.FromArgb(54, 116, 181);
            btnListarNoSocios.Cursor = Cursors.Hand;
            btnListarNoSocios.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnListarNoSocios.FlatStyle = FlatStyle.Popup;
            btnListarNoSocios.Font = new Font("Segoe UI", 10F);
            btnListarNoSocios.ForeColor = SystemColors.ButtonHighlight;
            btnListarNoSocios.ImeMode = ImeMode.NoControl;
            btnListarNoSocios.Location = new Point(252, 90);
            btnListarNoSocios.Name = "btnListarNoSocios";
            btnListarNoSocios.Size = new Size(165, 69);
            btnListarNoSocios.TabIndex = 48;
            btnListarNoSocios.Text = "Listar no socios";
            btnListarNoSocios.UseVisualStyleBackColor = false;
            btnListarNoSocios.Click += btnListarNoSocios_Click;
            // 
            // fMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(471, 354);
            Controls.Add(panel1);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            Controls.Add(lblIngreso);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            Load += fMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIngreso;
        private Button btnCerrar;
        private Label lblRegistrar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnModificarRegistros;
        private Button btnListarSocios;
        private Button btnRegistrar;
        private Button btnRegistrarPago;
        private Button btnListarVencimientos;
        private Button btnListarNoSocios;
    }
}