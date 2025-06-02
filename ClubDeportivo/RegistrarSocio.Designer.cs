namespace ClubDeportivo
{
    partial class fRegistrarSocio
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
            ComboBox cboTipo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegistrarSocio));
            lblNombre = new Label();
            lblApellido = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnIngresarDato = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            label8 = new Label();
            picFoto = new PictureBox();
            chkFicha = new CheckBox();
            lblApto = new Label();
            lblFichaInscripcion = new Label();
            chkApto = new CheckBox();
            lblCuota = new Label();
            txtCuota = new TextBox();
            label9 = new Label();
            lblFechaPago = new Label();
            dtpFechaPago = new DateTimePicker();
            lbFechalVencimiento = new Label();
            label10 = new Label();
            cboFormaDePago = new ComboBox();
            label12 = new Label();
            lblFormaPago = new Label();
            txtFechaVencimiento = new TextBox();
            label11 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            lblRegistrar = new Label();
            grpbDatos = new GroupBox();
            btnSubirFoto = new Button();
            grpbPago = new GroupBox();
            btnCarnet = new Button();
            btnCerrar = new Button();
            cboTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpbDatos.SuspendLayout();
            grpbPago.SuspendLayout();
            SuspendLayout();
            // 
            // cboTipo
            // 
            cboTipo.Cursor = Cursors.Hand;
            cboTipo.DisplayMember = "0";
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(169, 92);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(128, 25);
            cboTipo.TabIndex = 3;
            cboTipo.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(5, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(5, 54);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 19);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 2;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 3;
            label4.Text = "Documento:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(169, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 25);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(169, 55);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(128, 25);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Cursor = Cursors.IBeam;
            txtDocumento.Location = new Point(169, 126);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(128, 25);
            txtDocumento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(303, 24);
            label1.Name = "label1";
            label1.Size = new Size(15, 19);
            label1.TabIndex = 8;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(303, 59);
            label2.Name = "label2";
            label2.Size = new Size(15, 19);
            label2.TabIndex = 9;
            label2.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(303, 130);
            label5.Name = "label5";
            label5.Size = new Size(15, 19);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(303, 96);
            label6.Name = "label6";
            label6.Size = new Size(15, 19);
            label6.TabIndex = 11;
            label6.Text = "*";
            // 
            // btnIngresarDato
            // 
            btnIngresarDato.BackColor = Color.FromArgb(54, 116, 181);
            btnIngresarDato.Cursor = Cursors.Hand;
            btnIngresarDato.FlatAppearance.BorderSize = 0;
            btnIngresarDato.FlatStyle = FlatStyle.Flat;
            btnIngresarDato.Font = new Font("Segoe UI", 10F);
            btnIngresarDato.ForeColor = SystemColors.ButtonHighlight;
            btnIngresarDato.Location = new Point(94, 648);
            btnIngresarDato.Name = "btnIngresarDato";
            btnIngresarDato.Size = new Size(134, 29);
            btnIngresarDato.TabIndex = 12;
            btnIngresarDato.Text = "INGRESAR";
            btnIngresarDato.UseVisualStyleBackColor = false;
            btnIngresarDato.Click += btnIngresarDato_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(54, 116, 181);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(302, 613);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(54, 116, 181);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(302, 648);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(134, 29);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(6, 164);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(150, 19);
            lblFechaNacimiento.TabIndex = 15;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Cursor = Cursors.Hand;
            dtpFechaNacimiento.Location = new Point(169, 160);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(128, 25);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDireccion.Location = new Point(6, 196);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(76, 19);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(169, 195);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(129, 25);
            txtDireccion.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(303, 164);
            label7.Name = "label7";
            label7.Size = new Size(15, 19);
            label7.TabIndex = 19;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(303, 199);
            label8.Name = "label8";
            label8.Size = new Size(15, 19);
            label8.TabIndex = 20;
            label8.Text = "*";
            // 
            // picFoto
            // 
            picFoto.BackgroundImage = (Image)resources.GetObject("picFoto.BackgroundImage");
            picFoto.BackgroundImageLayout = ImageLayout.Zoom;
            picFoto.Location = new Point(230, 42);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(64, 67);
            picFoto.TabIndex = 21;
            picFoto.TabStop = false;
            // 
            // chkFicha
            // 
            chkFicha.AutoSize = true;
            chkFicha.Cursor = Cursors.Hand;
            chkFicha.Location = new Point(148, 238);
            chkFicha.Name = "chkFicha";
            chkFicha.Size = new Size(15, 14);
            chkFicha.TabIndex = 7;
            chkFicha.UseVisualStyleBackColor = true;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Cursor = Cursors.Hand;
            lblApto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApto.Location = new Point(169, 233);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(96, 19);
            lblApto.TabIndex = 24;
            lblApto.Text = "Apto médico";
            lblApto.Click += lblApto_Click;
            // 
            // lblFichaInscripcion
            // 
            lblFichaInscripcion.AutoSize = true;
            lblFichaInscripcion.Cursor = Cursors.Hand;
            lblFichaInscripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFichaInscripcion.Location = new Point(6, 233);
            lblFichaInscripcion.Name = "lblFichaInscripcion";
            lblFichaInscripcion.Size = new Size(140, 19);
            lblFichaInscripcion.TabIndex = 26;
            lblFichaInscripcion.Text = "Ficha de inscripción";
            lblFichaInscripcion.Click += lblFichaInscripcion_Click;
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.Cursor = Cursors.Hand;
            chkApto.Location = new Point(282, 236);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(15, 14);
            chkApto.TabIndex = 8;
            chkApto.UseVisualStyleBackColor = true;
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCuota.Location = new Point(6, 30);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(99, 19);
            lblCuota.TabIndex = 27;
            lblCuota.Text = "Cuota inicial: ";
            // 
            // txtCuota
            // 
            txtCuota.BorderStyle = BorderStyle.FixedSingle;
            txtCuota.Cursor = Cursors.IBeam;
            txtCuota.Location = new Point(169, 30);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(128, 25);
            txtCuota.TabIndex = 9;
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
            dtpFechaPago.TabIndex = 10;
            dtpFechaPago.Value = new DateTime(2025, 5, 30, 12, 13, 25, 0);
            dtpFechaPago.ValueChanged += dtpFechaPago_ValueChanged;
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
            cboFormaDePago.TabIndex = 11;
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
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.BorderStyle = BorderStyle.FixedSingle;
            txtFechaVencimiento.Cursor = Cursors.No;
            txtFechaVencimiento.Location = new Point(169, 104);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.ReadOnly = true;
            txtFechaVencimiento.Size = new Size(128, 25);
            txtFechaVencimiento.TabIndex = 0;
            txtFechaVencimiento.TabStop = false;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(303, 236);
            label14.Name = "label14";
            label14.Size = new Size(15, 19);
            label14.TabIndex = 42;
            label14.Text = "*";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(38, 11);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(146, 21);
            lblRegistrar.TabIndex = 44;
            lblRegistrar.Text = "REGISTRAR SOCIO";
            // 
            // grpbDatos
            // 
            grpbDatos.Controls.Add(btnSubirFoto);
            grpbDatos.Controls.Add(label4);
            grpbDatos.Controls.Add(lblNombre);
            grpbDatos.Controls.Add(lblApellido);
            grpbDatos.Controls.Add(label14);
            grpbDatos.Controls.Add(label3);
            grpbDatos.Controls.Add(txtNombre);
            grpbDatos.Controls.Add(txtApellido);
            grpbDatos.Controls.Add(txtDocumento);
            grpbDatos.Controls.Add(cboTipo);
            grpbDatos.Controls.Add(label1);
            grpbDatos.Controls.Add(label2);
            grpbDatos.Controls.Add(label5);
            grpbDatos.Controls.Add(label6);
            grpbDatos.Controls.Add(lblFechaNacimiento);
            grpbDatos.Controls.Add(dtpFechaNacimiento);
            grpbDatos.Controls.Add(lblDireccion);
            grpbDatos.Controls.Add(txtDireccion);
            grpbDatos.Controls.Add(lblFichaInscripcion);
            grpbDatos.Controls.Add(label7);
            grpbDatos.Controls.Add(chkApto);
            grpbDatos.Controls.Add(label8);
            grpbDatos.Controls.Add(lblApto);
            grpbDatos.Controls.Add(chkFicha);
            grpbDatos.Font = new Font("Segoe UI", 10F);
            grpbDatos.Location = new Point(94, 115);
            grpbDatos.Name = "grpbDatos";
            grpbDatos.Size = new Size(342, 306);
            grpbDatos.TabIndex = 1;
            grpbDatos.TabStop = false;
            grpbDatos.Text = "Datos";
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.BackColor = Color.FromArgb(54, 116, 181);
            btnSubirFoto.Cursor = Cursors.Hand;
            btnSubirFoto.FlatAppearance.BorderSize = 0;
            btnSubirFoto.FlatStyle = FlatStyle.Flat;
            btnSubirFoto.Font = new Font("Segoe UI", 10F);
            btnSubirFoto.ForeColor = SystemColors.ButtonHighlight;
            btnSubirFoto.Location = new Point(103, 271);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(134, 29);
            btnSubirFoto.TabIndex = 46;
            btnSubirFoto.Text = "SUBIR FOTO";
            btnSubirFoto.UseVisualStyleBackColor = false;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // grpbPago
            // 
            grpbPago.Controls.Add(lblFormaPago);
            grpbPago.Controls.Add(lblCuota);
            grpbPago.Controls.Add(txtCuota);
            grpbPago.Controls.Add(label9);
            grpbPago.Controls.Add(label11);
            grpbPago.Controls.Add(lblFechaPago);
            grpbPago.Controls.Add(txtFechaVencimiento);
            grpbPago.Controls.Add(dtpFechaPago);
            grpbPago.Controls.Add(lbFechalVencimiento);
            grpbPago.Controls.Add(label12);
            grpbPago.Controls.Add(label10);
            grpbPago.Controls.Add(cboFormaDePago);
            grpbPago.Font = new Font("Segoe UI", 10F);
            grpbPago.Location = new Point(94, 427);
            grpbPago.Name = "grpbPago";
            grpbPago.Size = new Size(342, 180);
            grpbPago.TabIndex = 9;
            grpbPago.TabStop = false;
            grpbPago.Text = "Pago";
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.FromArgb(54, 116, 181);
            btnCarnet.Cursor = Cursors.Hand;
            btnCarnet.FlatAppearance.BorderSize = 0;
            btnCarnet.FlatStyle = FlatStyle.Flat;
            btnCarnet.Font = new Font("Segoe UI", 10F);
            btnCarnet.ForeColor = SystemColors.ButtonHighlight;
            btnCarnet.Location = new Point(94, 613);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(134, 29);
            btnCarnet.TabIndex = 45;
            btnCarnet.Text = "MOSTRAR CARNET";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
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
            btnCerrar.Location = new Point(451, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 29);
            btnCerrar.TabIndex = 52;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // fRegistrarSocio
            // 
            AcceptButton = btnIngresarDato;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(496, 724);
            Controls.Add(btnCerrar);
            Controls.Add(btnCarnet);
            Controls.Add(grpbPago);
            Controls.Add(grpbDatos);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Controls.Add(picFoto);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarDato);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRegistrarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR SOCIO";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpbDatos.ResumeLayout(false);
            grpbDatos.PerformLayout();
            grpbPago.ResumeLayout(false);
            grpbPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button btnIngresarDato;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label label7;
        private Label label8;
        private PictureBox picFoto;
        private CheckBox chkFicha;
        private Label lblApto;
        private Label lblFichaInscripcion;
        private CheckBox chkApto;
        private Label lblCuota;
        private TextBox txtCuota;
        private Label label9;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private Label lbFechalVencimiento;
        private Label label10;
        private ComboBox cboFormaDePago;
        private Label label12;
        private Label lblFormaPago;
        private TextBox txtFechaVencimiento;
        private Label label11;
        private Label label14;
        private PictureBox pictureBox1;
        private Label lblRegistrar;
        private GroupBox grpbDatos;
        private GroupBox grpbPago;
        private Button btnCarnet;
        private Button btnSubirFoto;
        private Button btnCerrar;
    }
}