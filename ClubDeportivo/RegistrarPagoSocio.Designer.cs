namespace ClubDeportivo
{
    partial class RegistrarPagoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPagoSocio));
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtDNI = new TextBox();
            lblAvisoDNI = new Label();
            btnBuscar = new Button();
            grpbPago = new GroupBox();
            dtpFechaVencimiento = new DateTimePicker();
            lblFormaPago = new Label();
            lblCuota = new Label();
            txtCuota = new TextBox();
            label9 = new Label();
            label11 = new Label();
            lblFechaPago = new Label();
            dtpFechaPago = new DateTimePicker();
            lbFechalVencimiento = new Label();
            label12 = new Label();
            label10 = new Label();
            cboFormaDePago = new ComboBox();
            lblIngresarDNI = new Label();
            lblSocioID = new Label();
            lblSocioID2 = new Label();
            btnAtras = new Button();
            btnIngresarPago = new Button();
            btnLimpiar = new Button();
            btnConsultarPagos = new Button();
            label15 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpbPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(38, 20);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(193, 21);
            lblRegistrar.TabIndex = 54;
            lblRegistrar.Text = "REGISTRAR PAGO SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(89, 123);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 55;
            label4.Text = "Documento:";
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(252, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "1234";
            txtDNI.Size = new Size(128, 23);
            txtDNI.TabIndex = 0;
            // 
            // lblAvisoDNI
            // 
            lblAvisoDNI.AutoSize = true;
            lblAvisoDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvisoDNI.ForeColor = Color.Red;
            lblAvisoDNI.Location = new Point(386, 127);
            lblAvisoDNI.Name = "lblAvisoDNI";
            lblAvisoDNI.Size = new Size(15, 19);
            lblAvisoDNI.TabIndex = 57;
            lblAvisoDNI.Text = "*";
            lblAvisoDNI.MouseLeave += lblAvisoDNI_MouseLeave;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(54, 116, 181);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(252, 152);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // grpbPago
            // 
            grpbPago.Controls.Add(dtpFechaVencimiento);
            grpbPago.Controls.Add(lblFormaPago);
            grpbPago.Controls.Add(lblCuota);
            grpbPago.Controls.Add(txtCuota);
            grpbPago.Controls.Add(label9);
            grpbPago.Controls.Add(label11);
            grpbPago.Controls.Add(lblFechaPago);
            grpbPago.Controls.Add(dtpFechaPago);
            grpbPago.Controls.Add(lbFechalVencimiento);
            grpbPago.Controls.Add(label12);
            grpbPago.Controls.Add(label10);
            grpbPago.Controls.Add(cboFormaDePago);
            grpbPago.Font = new Font("Segoe UI", 10F);
            grpbPago.Location = new Point(83, 284);
            grpbPago.Name = "grpbPago";
            grpbPago.Size = new Size(342, 180);
            grpbPago.TabIndex = 59;
            grpbPago.TabStop = false;
            grpbPago.Text = "Pago";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Cursor = Cursors.Hand;
            dtpFechaVencimiento.Location = new Point(168, 104);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(129, 25);
            dtpFechaVencimiento.TabIndex = 41;
            dtpFechaVencimiento.Value = new DateTime(2025, 5, 30, 12, 13, 25, 0);
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormaPago.Location = new Point(5, 142);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(116, 19);
            lblFormaPago.TabIndex = 38;
            lblFormaPago.Text = "Forma de pago:";
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCuota.Location = new Point(6, 30);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(52, 19);
            lblCuota.TabIndex = 27;
            lblCuota.Text = "Cuota:";
            // 
            // txtCuota
            // 
            txtCuota.BorderStyle = BorderStyle.FixedSingle;
            txtCuota.Cursor = Cursors.IBeam;
            txtCuota.Location = new Point(169, 30);
            txtCuota.Name = "txtCuota";
            txtCuota.PlaceholderText = "5000";
            txtCuota.Size = new Size(128, 25);
            txtCuota.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(303, 34);
            label9.Name = "label9";
            label9.Size = new Size(15, 19);
            label9.TabIndex = 29;
            label9.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(146, 30);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 40;
            label11.Text = "$";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPago.Location = new Point(6, 66);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(111, 19);
            lblFechaPago.TabIndex = 30;
            lblFechaPago.Text = "Fecha de pago:";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Cursor = Cursors.Hand;
            dtpFechaPago.Location = new Point(169, 66);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(129, 25);
            dtpFechaPago.TabIndex = 4;
            dtpFechaPago.Value = new DateTime(2025, 5, 30, 12, 13, 25, 0);
            // 
            // lbFechalVencimiento
            // 
            lbFechalVencimiento.AutoSize = true;
            lbFechalVencimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbFechalVencimiento.Location = new Point(5, 104);
            lbFechalVencimiento.Name = "lbFechalVencimiento";
            lbFechalVencimiento.Size = new Size(158, 19);
            lbFechalVencimiento.TabIndex = 32;
            lbFechalVencimiento.Text = "Fecha de vencimiento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(303, 146);
            label12.Name = "label12";
            label12.Size = new Size(15, 19);
            label12.TabIndex = 37;
            label12.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(304, 70);
            label10.Name = "label10";
            label10.Size = new Size(15, 19);
            label10.TabIndex = 34;
            label10.Text = "*";
            // 
            // cboFormaDePago
            // 
            cboFormaDePago.Cursor = Cursors.Hand;
            cboFormaDePago.FormattingEnabled = true;
            cboFormaDePago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cboFormaDePago.Location = new Point(169, 142);
            cboFormaDePago.Name = "cboFormaDePago";
            cboFormaDePago.Size = new Size(128, 25);
            cboFormaDePago.TabIndex = 5;
            // 
            // lblIngresarDNI
            // 
            lblIngresarDNI.AutoSize = true;
            lblIngresarDNI.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIngresarDNI.Location = new Point(195, 70);
            lblIngresarDNI.Name = "lblIngresarDNI";
            lblIngresarDNI.Size = new Size(116, 20);
            lblIngresarDNI.TabIndex = 60;
            lblIngresarDNI.Text = "INGRESAR DNI";
            // 
            // lblSocioID
            // 
            lblSocioID.AutoSize = true;
            lblSocioID.Location = new Point(88, 238);
            lblSocioID.Name = "lblSocioID";
            lblSocioID.Size = new Size(53, 15);
            lblSocioID.TabIndex = 61;
            lblSocioID.Text = "Socio ID:";
            // 
            // lblSocioID2
            // 
            lblSocioID2.AutoSize = true;
            lblSocioID2.Location = new Point(252, 238);
            lblSocioID2.Name = "lblSocioID2";
            lblSocioID2.Size = new Size(18, 15);
            lblSocioID2.TabIndex = 62;
            lblSocioID2.Text = "ID";
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
            btnAtras.Location = new Point(451, 11);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 8;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnIngresarPago
            // 
            btnIngresarPago.BackColor = Color.FromArgb(231, 76, 60);
            btnIngresarPago.Cursor = Cursors.Hand;
            btnIngresarPago.FlatAppearance.BorderSize = 0;
            btnIngresarPago.FlatStyle = FlatStyle.Flat;
            btnIngresarPago.Font = new Font("Segoe UI", 10F);
            btnIngresarPago.ForeColor = SystemColors.ButtonHighlight;
            btnIngresarPago.Location = new Point(83, 479);
            btnIngresarPago.Name = "btnIngresarPago";
            btnIngresarPago.Size = new Size(128, 29);
            btnIngresarPago.TabIndex = 6;
            btnIngresarPago.Text = "INGRESAR";
            btnIngresarPago.UseVisualStyleBackColor = false;
            btnIngresarPago.Click += btnIngresarPago_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(54, 116, 181);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(297, 479);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConsultarPagos
            // 
            btnConsultarPagos.BackColor = Color.FromArgb(54, 116, 181);
            btnConsultarPagos.Cursor = Cursors.Hand;
            btnConsultarPagos.FlatAppearance.BorderSize = 0;
            btnConsultarPagos.FlatStyle = FlatStyle.Flat;
            btnConsultarPagos.Font = new Font("Segoe UI", 10F);
            btnConsultarPagos.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarPagos.Location = new Point(252, 187);
            btnConsultarPagos.Name = "btnConsultarPagos";
            btnConsultarPagos.Size = new Size(128, 29);
            btnConsultarPagos.TabIndex = 2;
            btnConsultarPagos.Text = "CONSULTAR";
            btnConsultarPagos.UseVisualStyleBackColor = false;
            btnConsultarPagos.Click += btnConsultarPagos_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(240, 533);
            label15.Name = "label15";
            label15.Size = new Size(21, 16);
            label15.TabIndex = 80;
            label15.Text = " * ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label5.Location = new Point(83, 535);
            label5.Name = "label5";
            label5.Size = new Size(154, 13);
            label5.TabIndex = 79;
            label5.Text = "CAMPOS OBLIGATORIOS";
            // 
            // RegistrarPagoSocio
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(496, 583);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(btnConsultarPagos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarPago);
            Controls.Add(btnAtras);
            Controls.Add(lblSocioID2);
            Controls.Add(lblSocioID);
            Controls.Add(lblIngresarDNI);
            Controls.Add(grpbPago);
            Controls.Add(btnBuscar);
            Controls.Add(lblAvisoDNI);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarPagoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR PAGO SOCIO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpbPago.ResumeLayout(false);
            grpbPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRegistrar;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtDNI;
        private Label lblAvisoDNI;
        private Button btnBuscar;
        private GroupBox grpbPago;
        private Label lblFormaPago;
        private Label lblCuota;
        private TextBox txtCuota;
        private Label label9;
        private Label label11;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private Label lbFechalVencimiento;
        private Label label12;
        private Label label10;
        private ComboBox cboFormaDePago;
        private Label lblIngresarDNI;
        private Label lblSocioID;
        private Label lblSocioID2;
        private Button btnAtras;
        private Button btnIngresarPago;
        private Button btnLimpiar;
        private Button btnConsultarPagos;
        private DateTimePicker dtpFechaVencimiento;
        private Label label15;
        private Label label5;
    }
}