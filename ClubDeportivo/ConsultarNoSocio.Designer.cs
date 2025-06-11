namespace ClubDeportivo
{
    partial class ConsultarNoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarNoSocio));
            lblConsultarSocio = new Label();
            pictureBox1 = new PictureBox();
            btnAtras = new Button();
            groupBox1 = new GroupBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            txtDNI = new TextBox();
            txtID = new TextBox();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            lblID = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblConsultarSocio
            // 
            lblConsultarSocio.AutoSize = true;
            lblConsultarSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConsultarSocio.Location = new Point(37, 9);
            lblConsultarSocio.Name = "lblConsultarSocio";
            lblConsultarSocio.Size = new Size(183, 21);
            lblConsultarSocio.TabIndex = 62;
            lblConsultarSocio.Text = "CONSULTAR NO SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(11, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 61;
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
            btnAtras.Location = new Point(343, 1);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 60;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(lblFechaNacimiento);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(11, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 290);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Socio";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblApellido.Location = new Point(6, 101);
            lblApellido.Name = "lblApellido";
            lblApellido.Padding = new Padding(0, 0, 0, 20);
            lblApellido.Size = new Size(67, 40);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(168, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(191, 29);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(168, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(191, 29);
            txtApellido.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 12F);
            dtpFechaNacimiento.Location = new Point(168, 224);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(191, 29);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(6, 231);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Padding = new Padding(0, 0, 0, 20);
            lblFechaNacimiento.Size = new Size(156, 40);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 12F);
            txtDNI.Location = new Point(168, 139);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(191, 29);
            txtDNI.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(168, 16);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(191, 29);
            txtID.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(168, 183);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(191, 29);
            txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDireccion.Location = new Point(6, 183);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Padding = new Padding(0, 0, 0, 20);
            lblDireccion.Size = new Size(74, 40);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblID.Location = new Point(6, 19);
            lblID.Name = "lblID";
            lblID.Padding = new Padding(0, 0, 0, 20);
            lblID.Size = new Size(29, 40);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDNI.Location = new Point(6, 142);
            lblDNI.Name = "lblDNI";
            lblDNI.Padding = new Padding(0, 0, 0, 20);
            lblDNI.Size = new Size(37, 40);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombre.Location = new Point(6, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Padding = new Padding(0, 0, 0, 20);
            lblNombre.Size = new Size(71, 40);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // ConsultarNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            CancelButton = btnAtras;
            ClientSize = new Size(388, 384);
            Controls.Add(lblConsultarSocio);
            Controls.Add(pictureBox1);
            Controls.Add(btnAtras);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultarNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONSULTAR NO SOCIO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultarSocio;
        private PictureBox pictureBox1;
        private Button btnAtras;
        private GroupBox groupBox1;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtDNI;
        private TextBox txtID;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Label lblID;
        private Label lblDNI;
        private Label lblNombre;
    }
}