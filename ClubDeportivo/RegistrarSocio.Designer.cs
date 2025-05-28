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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegistrarSocio));
            lblNombre = new Label();
            lblApellido = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
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
            pictureBoxSocio = new PictureBox();
            picCerrar = new PictureBox();
            chkApto = new CheckBox();
            lblApto = new Label();
            lblFichaInscripcion = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSocio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(69, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(69, 119);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 19);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(70, 156);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 2;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(70, 191);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 3;
            label4.Text = "Documento:";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(181, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(181, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Cursor = Cursors.IBeam;
            txtDocumento.Location = new Point(181, 191);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(160, 23);
            txtDocumento.TabIndex = 4;
            // 
            // cboTipo
            // 
            cboTipo.Cursor = Cursors.IBeam;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(181, 157);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(160, 23);
            cboTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(347, 89);
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
            label2.Location = new Point(347, 124);
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
            label5.Location = new Point(347, 194);
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
            label6.Location = new Point(347, 161);
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
            btnIngresarDato.Location = new Point(50, 657);
            btnIngresarDato.Name = "btnIngresarDato";
            btnIngresarDato.Size = new Size(96, 29);
            btnIngresarDato.TabIndex = 7;
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
            btnLimpiar.Location = new Point(181, 657);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 29);
            btnLimpiar.TabIndex = 8;
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
            btnVolver.Location = new Point(311, 657);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(96, 29);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(70, 229);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(150, 19);
            lblFechaNacimiento.TabIndex = 15;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(222, 225);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(119, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDireccion.Location = new Point(70, 261);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(76, 19);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(182, 260);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(160, 23);
            txtDireccion.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(347, 225);
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
            label8.Location = new Point(347, 260);
            label8.Name = "label8";
            label8.Size = new Size(15, 19);
            label8.TabIndex = 20;
            label8.Text = "*";
            // 
            // pictureBoxSocio
            // 
            pictureBoxSocio.BackgroundImage = (Image)resources.GetObject("pictureBoxSocio.BackgroundImage");
            pictureBoxSocio.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSocio.Location = new Point(205, 12);
            pictureBoxSocio.Name = "pictureBoxSocio";
            pictureBoxSocio.Size = new Size(73, 67);
            pictureBoxSocio.TabIndex = 21;
            pictureBoxSocio.TabStop = false;
            // 
            // picCerrar
            // 
            picCerrar.BackgroundImage = (Image)resources.GetObject("picCerrar.BackgroundImage");
            picCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            picCerrar.Location = new Point(389, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(41, 30);
            picCerrar.TabIndex = 22;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.Location = new Point(195, 329);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(15, 14);
            chkApto.TabIndex = 23;
            chkApto.UseVisualStyleBackColor = true;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApto.Location = new Point(266, 298);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(96, 19);
            lblApto.TabIndex = 24;
            lblApto.Text = "Apto médico";
            // 
            // lblFichaInscripcion
            // 
            lblFichaInscripcion.AutoSize = true;
            lblFichaInscripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFichaInscripcion.Location = new Point(70, 298);
            lblFichaInscripcion.Name = "lblFichaInscripcion";
            lblFichaInscripcion.Size = new Size(140, 19);
            lblFichaInscripcion.TabIndex = 26;
            lblFichaInscripcion.Text = "Ficha de inscripción";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(347, 329);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 25;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // fRegistrarSocio
            // 
            AcceptButton = btnIngresarDato;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 241, 253);
            ClientSize = new Size(452, 712);
            Controls.Add(lblFichaInscripcion);
            Controls.Add(checkBox1);
            Controls.Add(lblApto);
            Controls.Add(chkApto);
            Controls.Add(picCerrar);
            Controls.Add(pictureBoxSocio);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresarDato);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fRegistrarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR SOCIO";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSocio).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
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
        private ComboBox cboTipo;
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
        private PictureBox pictureBoxSocio;
        private PictureBox picCerrar;
        private CheckBox chkApto;
        private Label lblApto;
        private Label lblFichaInscripcion;
        private CheckBox checkBox1;
    }
}