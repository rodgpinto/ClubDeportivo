namespace ClubDeportivo
{
    partial class RegistrarPagoNoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPagoNoSocio));
            btnConsultarPagos = new Button();
            btnLimpiar = new Button();
            btnIngresarPago = new Button();
            btnAtras = new Button();
            lblNoSocioID2 = new Label();
            lblNoSocioID = new Label();
            lblIngresarDNI = new Label();
            grpbPago = new GroupBox();
            label2 = new Label();
            cboActividad = new ComboBox();
            label1 = new Label();
            lblFormaPago = new Label();
            lblCuota = new Label();
            txtCuota = new TextBox();
            label9 = new Label();
            label11 = new Label();
            lblFechaPago = new Label();
            txtFechaVencimiento = new TextBox();
            dtpFechaPago = new DateTimePicker();
            lbFechalVencimiento = new Label();
            lblDescuento = new Label();
            label10 = new Label();
            cboFormaDePago = new ComboBox();
            btnBuscar = new Button();
            lblAvisoDNI = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label5 = new Label();
            btnVolver = new Button();
            grpbPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultarPagos
            // 
            btnConsultarPagos.BackColor = Color.FromArgb(54, 116, 181);
            btnConsultarPagos.Cursor = Cursors.Hand;
            btnConsultarPagos.FlatAppearance.BorderSize = 0;
            btnConsultarPagos.FlatStyle = FlatStyle.Flat;
            btnConsultarPagos.Font = new Font("Segoe UI", 10F);
            btnConsultarPagos.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarPagos.Location = new Point(251, 187);
            btnConsultarPagos.Name = "btnConsultarPagos";
            btnConsultarPagos.Size = new Size(128, 29);
            btnConsultarPagos.TabIndex = 3;
            btnConsultarPagos.Text = "CONSULTAR";
            btnConsultarPagos.UseVisualStyleBackColor = false;
            btnConsultarPagos.Click += btnConsultarPagos_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(54, 116, 181);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(296, 508);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresarPago
            // 
            btnIngresarPago.BackColor = Color.FromArgb(231, 76, 60);
            btnIngresarPago.Cursor = Cursors.Hand;
            btnIngresarPago.FlatAppearance.BorderSize = 0;
            btnIngresarPago.FlatStyle = FlatStyle.Flat;
            btnIngresarPago.Font = new Font("Segoe UI", 10F);
            btnIngresarPago.ForeColor = SystemColors.ButtonHighlight;
            btnIngresarPago.Location = new Point(87, 546);
            btnIngresarPago.Name = "btnIngresarPago";
            btnIngresarPago.Size = new Size(128, 29);
            btnIngresarPago.TabIndex = 10;
            btnIngresarPago.Text = "INGRESAR";
            btnIngresarPago.UseVisualStyleBackColor = false;
            btnIngresarPago.Click += btnIngresarPago_Click;
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
            btnAtras.TabIndex = 13;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblNoSocioID2
            // 
            lblNoSocioID2.AutoSize = true;
            lblNoSocioID2.Location = new Point(251, 238);
            lblNoSocioID2.Name = "lblNoSocioID2";
            lblNoSocioID2.Size = new Size(18, 15);
            lblNoSocioID2.TabIndex = 76;
            lblNoSocioID2.Text = "ID";
            // 
            // lblNoSocioID
            // 
            lblNoSocioID.AutoSize = true;
            lblNoSocioID.Location = new Point(87, 238);
            lblNoSocioID.Name = "lblNoSocioID";
            lblNoSocioID.Size = new Size(71, 15);
            lblNoSocioID.TabIndex = 75;
            lblNoSocioID.Text = "No socio ID:";
            // 
            // lblIngresarDNI
            // 
            lblIngresarDNI.AutoSize = true;
            lblIngresarDNI.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIngresarDNI.Location = new Point(194, 70);
            lblIngresarDNI.Name = "lblIngresarDNI";
            lblIngresarDNI.Size = new Size(116, 20);
            lblIngresarDNI.TabIndex = 74;
            lblIngresarDNI.Text = "INGRESAR DNI";
            // 
            // grpbPago
            // 
            grpbPago.Controls.Add(label2);
            grpbPago.Controls.Add(cboActividad);
            grpbPago.Controls.Add(label1);
            grpbPago.Controls.Add(lblFormaPago);
            grpbPago.Controls.Add(lblCuota);
            grpbPago.Controls.Add(txtCuota);
            grpbPago.Controls.Add(label9);
            grpbPago.Controls.Add(label11);
            grpbPago.Controls.Add(lblFechaPago);
            grpbPago.Controls.Add(txtFechaVencimiento);
            grpbPago.Controls.Add(dtpFechaPago);
            grpbPago.Controls.Add(lbFechalVencimiento);
            grpbPago.Controls.Add(lblDescuento);
            grpbPago.Controls.Add(label10);
            grpbPago.Controls.Add(cboFormaDePago);
            grpbPago.Font = new Font("Segoe UI", 10F);
            grpbPago.Location = new Point(82, 284);
            grpbPago.Name = "grpbPago";
            grpbPago.Size = new Size(342, 218);
            grpbPago.TabIndex = 4;
            grpbPago.TabStop = false;
            grpbPago.Text = "Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(304, 33);
            label2.Name = "label2";
            label2.Size = new Size(15, 19);
            label2.TabIndex = 43;
            label2.Text = "*";
            // 
            // cboActividad
            // 
            cboActividad.AutoCompleteMode = AutoCompleteMode.Append;
            cboActividad.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboActividad.Cursor = Cursors.Hand;
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(170, 27);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(128, 25);
            cboActividad.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 41;
            label1.Text = "Actividad:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormaPago.Location = new Point(5, 173);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(116, 19);
            lblFormaPago.TabIndex = 38;
            lblFormaPago.Text = "Forma de pago:";
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCuota.Location = new Point(6, 61);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(52, 19);
            lblCuota.TabIndex = 27;
            lblCuota.Text = "Cuota:";
            // 
            // txtCuota
            // 
            txtCuota.BorderStyle = BorderStyle.FixedSingle;
            txtCuota.Cursor = Cursors.IBeam;
            txtCuota.Location = new Point(169, 61);
            txtCuota.Name = "txtCuota";
            txtCuota.PlaceholderText = "5000";
            txtCuota.Size = new Size(128, 25);
            txtCuota.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(304, 67);
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
            label11.Location = new Point(146, 61);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 40;
            label11.Text = "$";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPago.Location = new Point(6, 97);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(111, 19);
            lblFechaPago.TabIndex = 30;
            lblFechaPago.Text = "Fecha de pago:";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.BorderStyle = BorderStyle.FixedSingle;
            txtFechaVencimiento.Cursor = Cursors.No;
            txtFechaVencimiento.Location = new Point(169, 135);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.ReadOnly = true;
            txtFechaVencimiento.Size = new Size(128, 25);
            txtFechaVencimiento.TabIndex = 8;
            txtFechaVencimiento.TabStop = false;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Cursor = Cursors.Hand;
            dtpFechaPago.Location = new Point(169, 97);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(129, 25);
            dtpFechaPago.TabIndex = 7;
            dtpFechaPago.Value = new DateTime(2025, 5, 30, 12, 13, 25, 0);
            // 
            // lbFechalVencimiento
            // 
            lbFechalVencimiento.AutoSize = true;
            lbFechalVencimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbFechalVencimiento.Location = new Point(5, 135);
            lbFechalVencimiento.Name = "lbFechalVencimiento";
            lbFechalVencimiento.Size = new Size(158, 19);
            lbFechalVencimiento.TabIndex = 32;
            lbFechalVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescuento.ForeColor = Color.Red;
            lblDescuento.Location = new Point(303, 179);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(15, 19);
            lblDescuento.TabIndex = 37;
            lblDescuento.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(304, 103);
            label10.Name = "label10";
            label10.Size = new Size(15, 19);
            label10.TabIndex = 34;
            label10.Text = "*";
            // 
            // cboFormaDePago
            // 
            cboFormaDePago.AutoCompleteMode = AutoCompleteMode.Append;
            cboFormaDePago.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboFormaDePago.Cursor = Cursors.Hand;
            cboFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaDePago.FormattingEnabled = true;
            cboFormaDePago.Location = new Point(169, 173);
            cboFormaDePago.Name = "cboFormaDePago";
            cboFormaDePago.Size = new Size(128, 25);
            cboFormaDePago.TabIndex = 9;
            cboFormaDePago.SelectedIndexChanged += cboFormaDePago_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(54, 116, 181);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(251, 152);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblAvisoDNI
            // 
            lblAvisoDNI.AutoSize = true;
            lblAvisoDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvisoDNI.ForeColor = Color.Red;
            lblAvisoDNI.Location = new Point(385, 127);
            lblAvisoDNI.Name = "lblAvisoDNI";
            lblAvisoDNI.Size = new Size(15, 19);
            lblAvisoDNI.TabIndex = 71;
            lblAvisoDNI.Text = "*";
            lblAvisoDNI.MouseLeave += lblAvisoDNI_MouseLeave;
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Font = new Font("Segoe UI", 10F);
            txtDNI.Location = new Point(251, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "1234";
            txtDNI.Size = new Size(128, 25);
            txtDNI.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(88, 123);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 69;
            label4.Text = "Documento:";
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(38, 11);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(222, 21);
            lblRegistrar.TabIndex = 68;
            lblRegistrar.Text = "REGISTRAR PAGO NO SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(239, 599);
            label15.Name = "label15";
            label15.Size = new Size(21, 16);
            label15.TabIndex = 78;
            label15.Text = " * ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label5.Location = new Point(82, 601);
            label5.Name = "label5";
            label5.Size = new Size(154, 13);
            label5.TabIndex = 77;
            label5.Text = "CAMPOS OBLIGATORIOS";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 76, 60);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(296, 546);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(128, 29);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnAtras_Click;
            // 
            // RegistrarPagoNoSocio
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            CancelButton = btnVolver;
            ClientSize = new Size(496, 653);
            Controls.Add(btnVolver);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(btnConsultarPagos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarPago);
            Controls.Add(btnAtras);
            Controls.Add(lblNoSocioID2);
            Controls.Add(lblNoSocioID);
            Controls.Add(lblIngresarDNI);
            Controls.Add(grpbPago);
            Controls.Add(btnBuscar);
            Controls.Add(lblAvisoDNI);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarPagoNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR PAGO NO SOCIO";
            grpbPago.ResumeLayout(false);
            grpbPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultarPagos;
        private Button btnLimpiar;
        private Button btnIngresarPago;
        private Button btnAtras;
        private Label lblNoSocioID2;
        private Label lblNoSocioID;
        private Label lblIngresarDNI;
        private GroupBox grpbPago;
        private Label label1;
        private Label lblFormaPago;
        private Label lblCuota;
        private TextBox txtCuota;
        private Label label9;
        private Label label11;
        private Label lblFechaPago;
        private TextBox txtFechaVencimiento;
        private DateTimePicker dtpFechaPago;
        private Label lbFechalVencimiento;
        private Label lblDescuento;
        private Label label10;
        private ComboBox cboFormaDePago;
        private Button btnBuscar;
        private Label lblAvisoDNI;
        private TextBox txtDNI;
        private Label label4;
        private Label lblRegistrar;
        private PictureBox pictureBox1;
        private ComboBox cboActividad;
        private Label label2;
        private Label label15;
        private Label label5;
        private Button btnVolver;
    }
}