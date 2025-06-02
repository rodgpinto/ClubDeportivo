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
            btnRegistrar = new Button();
            btnRegistrarPago = new Button();
            btnListarSocios = new Button();
            btnListarVencimientos = new Button();
            lblIngreso = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.ImeMode = ImeMode.NoControl;
            btnRegistrar.Location = new Point(83, 74);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 69);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.BackColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPago.Cursor = Cursors.Hand;
            btnRegistrarPago.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnRegistrarPago.FlatStyle = FlatStyle.Popup;
            btnRegistrarPago.Font = new Font("Segoe UI", 10F);
            btnRegistrarPago.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarPago.ImeMode = ImeMode.NoControl;
            btnRegistrarPago.Location = new Point(279, 74);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(100, 69);
            btnRegistrarPago.TabIndex = 4;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.FromArgb(54, 116, 181);
            btnListarSocios.Cursor = Cursors.Hand;
            btnListarSocios.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnListarSocios.FlatStyle = FlatStyle.Popup;
            btnListarSocios.Font = new Font("Segoe UI", 10F);
            btnListarSocios.ForeColor = SystemColors.ButtonHighlight;
            btnListarSocios.ImeMode = ImeMode.NoControl;
            btnListarSocios.Location = new Point(83, 171);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(100, 69);
            btnListarSocios.TabIndex = 5;
            btnListarSocios.Text = "Listar socios";
            btnListarSocios.UseVisualStyleBackColor = false;
            btnListarSocios.Click += btnListarSocios_Click;
            // 
            // btnListarVencimientos
            // 
            btnListarVencimientos.BackColor = Color.FromArgb(54, 116, 181);
            btnListarVencimientos.Cursor = Cursors.Hand;
            btnListarVencimientos.FlatAppearance.BorderColor = Color.FromArgb(54, 116, 181);
            btnListarVencimientos.FlatStyle = FlatStyle.Popup;
            btnListarVencimientos.Font = new Font("Segoe UI", 10F);
            btnListarVencimientos.ForeColor = SystemColors.ButtonHighlight;
            btnListarVencimientos.ImeMode = ImeMode.NoControl;
            btnListarVencimientos.Location = new Point(279, 171);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(100, 69);
            btnListarVencimientos.TabIndex = 6;
            btnListarVencimientos.Text = "Listar vencimientos";
            btnListarVencimientos.UseVisualStyleBackColor = false;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 12);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 15);
            lblIngreso.TabIndex = 8;
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
            // fMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(471, 348);
            Controls.Add(btnCerrar);
            Controls.Add(lblIngreso);
            Controls.Add(btnListarVencimientos);
            Controls.Add(btnListarSocios);
            Controls.Add(btnRegistrarPago);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            Load += fMainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnRegistrarPago;
        private Button btnListarSocios;
        private Button btnListarVencimientos;
        private Label lblIngreso;
        private Button btnCerrar;
    }
}