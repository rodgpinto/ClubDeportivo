namespace ClubDeportivo
{
    partial class ConsultarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarSocio));
            lblID = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            groupBox1 = new GroupBox();
            lblConsultarSocio = new Label();
            pictureBox1 = new PictureBox();
            btnAtras = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(168, 16);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(190, 29);
            txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(168, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(190, 29);
            txtNombre.TabIndex = 3;
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
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(168, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(190, 29);
            txtApellido.TabIndex = 5;
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
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 12F);
            txtDNI.Location = new Point(168, 139);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(190, 29);
            txtDNI.TabIndex = 7;
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
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(168, 183);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(190, 29);
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
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 12F);
            dtpFechaNacimiento.Location = new Point(168, 228);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(190, 29);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(6, 235);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Padding = new Padding(0, 0, 0, 20);
            lblFechaNacimiento.Size = new Size(156, 40);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
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
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 290);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Socio";
            // 
            // lblConsultarSocio
            // 
            lblConsultarSocio.AutoSize = true;
            lblConsultarSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConsultarSocio.Location = new Point(38, 12);
            lblConsultarSocio.Name = "lblConsultarSocio";
            lblConsultarSocio.Size = new Size(154, 21);
            lblConsultarSocio.TabIndex = 58;
            lblConsultarSocio.Text = "CONSULTAR SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 57;
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
            btnAtras.Location = new Point(306, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 56;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // ConsultarSocio
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
            Name = "ConsultarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONSULTAR SOCIO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private TextBox txtID;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private GroupBox groupBox1;
        private Label lblConsultarSocio;
        private PictureBox pictureBox1;
        private Button btnAtras;
    }
}