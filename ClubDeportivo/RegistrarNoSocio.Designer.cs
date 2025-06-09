namespace ClubDeportivo
{
    partial class RegistrarNoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarNoSocio));
            grpbDatos = new GroupBox();
            label4 = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            label14 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblAvisoDNI = new Label();
            label6 = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblFichaInscripcion = new Label();
            label7 = new Label();
            chkFicha = new CheckBox();
            label8 = new Label();
            lblRegistrar = new Label();
            pictureBox1 = new PictureBox();
            grpbPago = new GroupBox();
            dtpFechaVencimiento = new DateTimePicker();
            label13 = new Label();
            cboActividad = new ComboBox();
            lblActividad = new Label();
            lblFormaPago = new Label();
            lblCuotaActividad = new Label();
            txtActividad = new TextBox();
            label9 = new Label();
            label11 = new Label();
            lblFechaPago = new Label();
            dtpFechaPago = new DateTimePicker();
            lbFechalVencimiento = new Label();
            label12 = new Label();
            label10 = new Label();
            cboFormaDePago = new ComboBox();
            btnIngresarDato = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            picFoto = new PictureBox();
            cboTipo = new ComboBox();
            grpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpbPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
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
            cboTipo.TabIndex = 4;
            cboTipo.Text = "DNI";
            // 
            // grpbDatos
            // 
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
            grpbDatos.Controls.Add(lblAvisoDNI);
            grpbDatos.Controls.Add(label6);
            grpbDatos.Controls.Add(lblFechaNacimiento);
            grpbDatos.Controls.Add(dtpFechaNacimiento);
            grpbDatos.Controls.Add(lblDireccion);
            grpbDatos.Controls.Add(txtDireccion);
            grpbDatos.Controls.Add(lblFichaInscripcion);
            grpbDatos.Controls.Add(label7);
            grpbDatos.Controls.Add(chkFicha);
            grpbDatos.Controls.Add(label8);
            grpbDatos.Font = new Font("Segoe UI", 10F);
            grpbDatos.Location = new Point(77, 130);
            grpbDatos.Name = "grpbDatos";
            grpbDatos.Size = new Size(342, 274);
            grpbDatos.TabIndex = 1;
            grpbDatos.TabStop = false;
            grpbDatos.Text = "Datos";
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
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(169, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Joe";
            txtNombre.Size = new Size(128, 25);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(169, 55);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Doe";
            txtApellido.Size = new Size(128, 25);
            txtApellido.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Cursor = Cursors.IBeam;
            txtDocumento.Location = new Point(169, 126);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "1234";
            txtDocumento.Size = new Size(128, 25);
            txtDocumento.TabIndex = 5;
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
            // lblAvisoDNI
            // 
            lblAvisoDNI.AutoSize = true;
            lblAvisoDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvisoDNI.ForeColor = Color.Red;
            lblAvisoDNI.Location = new Point(303, 130);
            lblAvisoDNI.Name = "lblAvisoDNI";
            lblAvisoDNI.Size = new Size(15, 19);
            lblAvisoDNI.TabIndex = 10;
            lblAvisoDNI.Text = "*";
            lblAvisoDNI.MouseLeave += lblAvisoDNI_MouseLeave;
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
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(169, 160);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(128, 25);
            dtpFechaNacimiento.TabIndex = 6;
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
            txtDireccion.PlaceholderText = "Calle Falsa 123";
            txtDireccion.Size = new Size(129, 25);
            txtDireccion.TabIndex = 7;
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
            // chkFicha
            // 
            chkFicha.AutoSize = true;
            chkFicha.Cursor = Cursors.Hand;
            chkFicha.Location = new Point(169, 238);
            chkFicha.Name = "chkFicha";
            chkFicha.Size = new Size(15, 14);
            chkFicha.TabIndex = 8;
            chkFicha.UseVisualStyleBackColor = true;
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
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrar.Location = new Point(32, 20);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(175, 21);
            lblRegistrar.TabIndex = 46;
            lblRegistrar.Text = "REGISTRAR NO SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // grpbPago
            // 
            grpbPago.Controls.Add(dtpFechaVencimiento);
            grpbPago.Controls.Add(label13);
            grpbPago.Controls.Add(cboActividad);
            grpbPago.Controls.Add(lblActividad);
            grpbPago.Controls.Add(lblFormaPago);
            grpbPago.Controls.Add(lblCuotaActividad);
            grpbPago.Controls.Add(txtActividad);
            grpbPago.Controls.Add(label9);
            grpbPago.Controls.Add(label11);
            grpbPago.Controls.Add(lblFechaPago);
            grpbPago.Controls.Add(dtpFechaPago);
            grpbPago.Controls.Add(lbFechalVencimiento);
            grpbPago.Controls.Add(label12);
            grpbPago.Controls.Add(label10);
            grpbPago.Controls.Add(cboFormaDePago);
            grpbPago.Font = new Font("Segoe UI", 10F);
            grpbPago.Location = new Point(77, 410);
            grpbPago.Name = "grpbPago";
            grpbPago.Size = new Size(342, 226);
            grpbPago.TabIndex = 9;
            grpbPago.TabStop = false;
            grpbPago.Text = "Pago de actividad";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Cursor = Cursors.Hand;
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(171, 147);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(129, 25);
            dtpFechaVencimiento.TabIndex = 44;
            dtpFechaVencimiento.Value = new DateTime(2025, 5, 30, 12, 13, 25, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(305, 42);
            label13.Name = "label13";
            label13.Size = new Size(15, 19);
            label13.TabIndex = 43;
            label13.Text = "*";
            // 
            // cboActividad
            // 
            cboActividad.Cursor = Cursors.Hand;
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "Boxeo", "Clases de TRX", "CrossFit", "Musculación", "Pilates", "Spinning", "Yoga", "Zumba" });
            cboActividad.Location = new Point(171, 39);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(128, 25);
            cboActividad.TabIndex = 10;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActividad.Location = new Point(9, 39);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(73, 19);
            lblActividad.TabIndex = 41;
            lblActividad.Text = "Actividad";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormaPago.Location = new Point(6, 185);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(116, 19);
            lblFormaPago.TabIndex = 38;
            lblFormaPago.Text = "Forma de pago:";
            // 
            // lblCuotaActividad
            // 
            lblCuotaActividad.AutoSize = true;
            lblCuotaActividad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCuotaActividad.Location = new Point(7, 73);
            lblCuotaActividad.Name = "lblCuotaActividad";
            lblCuotaActividad.Size = new Size(122, 19);
            lblCuotaActividad.TabIndex = 27;
            lblCuotaActividad.Text = "Cuota actividad: ";
            // 
            // txtActividad
            // 
            txtActividad.BorderStyle = BorderStyle.FixedSingle;
            txtActividad.Cursor = Cursors.IBeam;
            txtActividad.Location = new Point(170, 73);
            txtActividad.Name = "txtActividad";
            txtActividad.PlaceholderText = "5000";
            txtActividad.Size = new Size(128, 25);
            txtActividad.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(304, 77);
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
            label11.Location = new Point(147, 73);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 40;
            label11.Text = "$";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPago.Location = new Point(7, 109);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(111, 19);
            lblFechaPago.TabIndex = 30;
            lblFechaPago.Text = "Fecha de pago:";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Cursor = Cursors.Hand;
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(170, 109);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(129, 25);
            dtpFechaPago.TabIndex = 12;
            dtpFechaPago.Value = new DateTime(2025, 5, 30, 12, 13, 25, 0);
            // 
            // lbFechalVencimiento
            // 
            lbFechalVencimiento.AutoSize = true;
            lbFechalVencimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbFechalVencimiento.Location = new Point(6, 147);
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
            label12.Location = new Point(304, 189);
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
            label10.Location = new Point(305, 113);
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
            cboFormaDePago.Location = new Point(170, 185);
            cboFormaDePago.Name = "cboFormaDePago";
            cboFormaDePago.Size = new Size(128, 25);
            cboFormaDePago.TabIndex = 14;
            // 
            // btnIngresarDato
            // 
            btnIngresarDato.BackColor = Color.FromArgb(231, 76, 60);
            btnIngresarDato.Cursor = Cursors.Hand;
            btnIngresarDato.FlatAppearance.BorderSize = 0;
            btnIngresarDato.FlatStyle = FlatStyle.Flat;
            btnIngresarDato.Font = new Font("Segoe UI", 10F);
            btnIngresarDato.ForeColor = SystemColors.ButtonHighlight;
            btnIngresarDato.Location = new Point(77, 683);
            btnIngresarDato.Name = "btnIngresarDato";
            btnIngresarDato.Size = new Size(134, 29);
            btnIngresarDato.TabIndex = 48;
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
            btnLimpiar.Location = new Point(285, 642);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 29);
            btnLimpiar.TabIndex = 49;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 76, 60);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(285, 683);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(134, 29);
            btnVolver.TabIndex = 50;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // picFoto
            // 
            picFoto.BackgroundImage = (Image)resources.GetObject("picFoto.BackgroundImage");
            picFoto.BackgroundImageLayout = ImageLayout.Zoom;
            picFoto.Location = new Point(213, 57);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(64, 67);
            picFoto.TabIndex = 51;
            picFoto.TabStop = false;
            // 
            // RegistrarNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(496, 744);
            Controls.Add(picFoto);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarDato);
            Controls.Add(grpbPago);
            Controls.Add(lblRegistrar);
            Controls.Add(pictureBox1);
            Controls.Add(grpbDatos);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR NO SOCIO";
            grpbDatos.ResumeLayout(false);
            grpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpbPago.ResumeLayout(false);
            grpbPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbDatos;
        private Label label4;
        private Label lblNombre;
        private Label lblApellido;
        private Label label14;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Label label1;
        private Label label2;
        private Label lblAvisoDNI;
        private Label label6;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblFichaInscripcion;
        private Label label7;
        private CheckBox chkFicha;
        private Label label8;
        private Label lblRegistrar;
        private PictureBox pictureBox1;
        private GroupBox grpbPago;
        private ComboBox cboActividad;
        private Label lblActividad;
        private Label lblFormaPago;
        private Label lblCuotaActividad;
        private TextBox txtActividad;
        private Label label9;
        private Label label11;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private Label lbFechalVencimiento;
        private Label label12;
        private Label label10;
        private ComboBox cboFormaDePago;
        private Button btnIngresarDato;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label label13;
        private DateTimePicker dtpFechaVencimiento;
        private PictureBox picFoto;
    }
}