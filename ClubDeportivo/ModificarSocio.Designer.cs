namespace ClubDeportivo
{
    partial class ModificarSocio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarSocio));
            btnAtras = new Button();
            lblModificarSocio = new Label();
            pictureBox1 = new PictureBox();
            btnConsultar = new Button();
            lblIngresarDNI = new Label();
            btnBuscar = new Button();
            lblAvisoDNI = new Label();
            txtDNI = new TextBox();
            lblDocumento = new Label();
            grpbDatos = new GroupBox();
            picFoto = new PictureBox();
            btnSubirFoto = new Button();
            lblDocumento2 = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI2 = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            btnCarnet = new Button();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            lblSocioID = new Label();
            lblSocioID2 = new Label();
            btnEliminarSocio = new Button();
            toolTip1 = new ToolTip(components);
            lblAviso = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
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
            btnAtras.Location = new Point(493, 9);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(33, 29);
            btnAtras.TabIndex = 15;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblModificarSocio
            // 
            lblModificarSocio.AutoSize = true;
            lblModificarSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblModificarSocio.Location = new Point(39, 11);
            lblModificarSocio.Name = "lblModificarSocio";
            lblModificarSocio.Size = new Size(150, 21);
            lblModificarSocio.TabIndex = 55;
            lblModificarSocio.Text = "MODIFICAR SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(54, 116, 181);
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 10F);
            btnConsultar.ForeColor = SystemColors.ButtonHighlight;
            btnConsultar.Location = new Point(105, 186);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(134, 29);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultarSocio_Click;
            // 
            // lblIngresarDNI
            // 
            lblIngresarDNI.AutoSize = true;
            lblIngresarDNI.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIngresarDNI.Location = new Point(204, 65);
            lblIngresarDNI.Name = "lblIngresarDNI";
            lblIngresarDNI.Size = new Size(116, 20);
            lblIngresarDNI.TabIndex = 75;
            lblIngresarDNI.Text = "INGRESAR DNI";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(54, 116, 181);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(279, 151);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 29);
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
            lblAvisoDNI.Location = new Point(417, 124);
            lblAvisoDNI.Name = "lblAvisoDNI";
            lblAvisoDNI.Size = new Size(15, 19);
            lblAvisoDNI.TabIndex = 74;
            lblAvisoDNI.Text = "*";
            lblAvisoDNI.Click += lblAvisoDNI_Click;
            lblAvisoDNI.MouseLeave += lblAvisoDNI_MouseLeave;
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Font = new Font("Segoe UI", 10F);
            txtDNI.Location = new Point(279, 120);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "1234";
            txtDNI.Size = new Size(134, 25);
            txtDNI.TabIndex = 1;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDocumento.Location = new Point(105, 124);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(90, 19);
            lblDocumento.TabIndex = 73;
            lblDocumento.Text = "Documento:";
            // 
            // grpbDatos
            // 
            grpbDatos.Controls.Add(picFoto);
            grpbDatos.Controls.Add(btnSubirFoto);
            grpbDatos.Controls.Add(lblDocumento2);
            grpbDatos.Controls.Add(lblNombre);
            grpbDatos.Controls.Add(lblApellido);
            grpbDatos.Controls.Add(txtNombre);
            grpbDatos.Controls.Add(txtApellido);
            grpbDatos.Controls.Add(txtDNI2);
            grpbDatos.Controls.Add(lblFechaNacimiento);
            grpbDatos.Controls.Add(dtpFechaNacimiento);
            grpbDatos.Controls.Add(lblDireccion);
            grpbDatos.Controls.Add(txtDireccion);
            grpbDatos.Font = new Font("Segoe UI", 10F);
            grpbDatos.Location = new Point(105, 235);
            grpbDatos.Name = "grpbDatos";
            grpbDatos.Size = new Size(308, 271);
            grpbDatos.TabIndex = 5;
            grpbDatos.TabStop = false;
            grpbDatos.Text = "Datos";
            // 
            // picFoto
            // 
            picFoto.BackgroundImage = (Image)resources.GetObject("picFoto.BackgroundImage");
            picFoto.BackgroundImageLayout = ImageLayout.Zoom;
            picFoto.Location = new Point(5, 181);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(64, 67);
            picFoto.TabIndex = 47;
            picFoto.TabStop = false;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.BackColor = Color.FromArgb(54, 116, 181);
            btnSubirFoto.Cursor = Cursors.Hand;
            btnSubirFoto.FlatAppearance.BorderSize = 0;
            btnSubirFoto.FlatStyle = FlatStyle.Flat;
            btnSubirFoto.Font = new Font("Segoe UI", 10F);
            btnSubirFoto.ForeColor = SystemColors.ButtonHighlight;
            btnSubirFoto.Location = new Point(174, 219);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(134, 29);
            btnSubirFoto.TabIndex = 11;
            btnSubirFoto.Text = "SUBIR FOTO";
            btnSubirFoto.UseVisualStyleBackColor = false;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // lblDocumento2
            // 
            lblDocumento2.AutoSize = true;
            lblDocumento2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDocumento2.Location = new Point(5, 89);
            lblDocumento2.Name = "lblDocumento2";
            lblDocumento2.Size = new Size(90, 19);
            lblDocumento2.TabIndex = 3;
            lblDocumento2.Text = "Documento:";
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
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(174, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Joe";
            txtNombre.Size = new Size(134, 25);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(174, 55);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Doe";
            txtApellido.Size = new Size(134, 25);
            txtApellido.TabIndex = 7;
            // 
            // txtDNI2
            // 
            txtDNI2.BorderStyle = BorderStyle.FixedSingle;
            txtDNI2.Cursor = Cursors.IBeam;
            txtDNI2.Location = new Point(174, 89);
            txtDNI2.Name = "txtDNI2";
            txtDNI2.PlaceholderText = "1234";
            txtDNI2.Size = new Size(134, 25);
            txtDNI2.TabIndex = 8;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(5, 127);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(150, 19);
            lblFechaNacimiento.TabIndex = 15;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Cursor = Cursors.Hand;
            dtpFechaNacimiento.Location = new Point(174, 123);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(134, 25);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDireccion.Location = new Point(5, 159);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(76, 19);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(174, 158);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Calle Falsa 123";
            txtDireccion.Size = new Size(134, 25);
            txtDireccion.TabIndex = 10;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.FromArgb(54, 116, 181);
            btnCarnet.Cursor = Cursors.Hand;
            btnCarnet.FlatAppearance.BorderSize = 0;
            btnCarnet.FlatStyle = FlatStyle.Flat;
            btnCarnet.Font = new Font("Segoe UI", 10F);
            btnCarnet.ForeColor = SystemColors.ButtonHighlight;
            btnCarnet.Location = new Point(105, 512);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(134, 29);
            btnCarnet.TabIndex = 12;
            btnCarnet.Text = "MOSTRAR CARNET";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 76, 60);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(279, 547);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(134, 29);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(54, 116, 181);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(279, 512);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(231, 76, 60);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(105, 547);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(134, 29);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblSocioID
            // 
            lblSocioID.AutoSize = true;
            lblSocioID.Location = new Point(105, 157);
            lblSocioID.Name = "lblSocioID";
            lblSocioID.Size = new Size(21, 15);
            lblSocioID.TabIndex = 83;
            lblSocioID.Text = "ID:";
            // 
            // lblSocioID2
            // 
            lblSocioID2.AutoSize = true;
            lblSocioID2.Location = new Point(129, 157);
            lblSocioID2.Name = "lblSocioID2";
            lblSocioID2.Size = new Size(18, 15);
            lblSocioID2.TabIndex = 84;
            lblSocioID2.Text = "ID";
            // 
            // btnEliminarSocio
            // 
            btnEliminarSocio.BackColor = Color.FromArgb(54, 116, 181);
            btnEliminarSocio.Cursor = Cursors.Hand;
            btnEliminarSocio.FlatAppearance.BorderSize = 0;
            btnEliminarSocio.FlatStyle = FlatStyle.Flat;
            btnEliminarSocio.Font = new Font("Segoe UI", 10F);
            btnEliminarSocio.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarSocio.Location = new Point(279, 186);
            btnEliminarSocio.Name = "btnEliminarSocio";
            btnEliminarSocio.Size = new Size(134, 29);
            btnEliminarSocio.TabIndex = 4;
            btnEliminarSocio.Text = "ELIMINAR SOCIO";
            btnEliminarSocio.UseVisualStyleBackColor = false;
            btnEliminarSocio.Click += btnEliminarSocio_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 0;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Cursor = Cursors.Help;
            lblAviso.FlatStyle = FlatStyle.Flat;
            lblAviso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAviso.ForeColor = Color.Red;
            lblAviso.Location = new Point(417, 186);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(12, 15);
            lblAviso.TabIndex = 86;
            lblAviso.Text = "?";
            lblAviso.Click += lblAviso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(419, 326);
            label1.Name = "label1";
            label1.Size = new Size(15, 19);
            label1.TabIndex = 87;
            label1.Text = "*";
            label1.MouseLeave += lblAvisoDNI_Click;
            // 
            // ModificarSocio
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            CancelButton = btnAtras;
            ClientSize = new Size(538, 613);
            Controls.Add(label1);
            Controls.Add(lblAviso);
            Controls.Add(btnEliminarSocio);
            Controls.Add(lblSocioID2);
            Controls.Add(lblSocioID);
            Controls.Add(btnCarnet);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(grpbDatos);
            Controls.Add(btnConsultar);
            Controls.Add(lblIngresarDNI);
            Controls.Add(btnBuscar);
            Controls.Add(lblAvisoDNI);
            Controls.Add(txtDNI);
            Controls.Add(lblDocumento);
            Controls.Add(lblModificarSocio);
            Controls.Add(pictureBox1);
            Controls.Add(btnAtras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MODIFICAR SOCIO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpbDatos.ResumeLayout(false);
            grpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblModificarSocio;
        private PictureBox pictureBox1;
        private Button btnSubirFoto;
        private Label lblDocumento2;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI2;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private PictureBox picFoto;
        private Button btnConsultar;
        
        private Label lblIngresarDNI;
        private Button btnBuscar;
        private Label lblAvisoDNI;
        private TextBox txtDNI;
        private Label lblDocumento;
        private GroupBox grpbDatos;
        
        
        
        
        
        private Button btnCarnet;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnIngresar;
        private Label lblSocioID;
        private Label lblSocioID2;
        private Button btnEliminarSocio;
        private ToolTip toolTip1;
        private Label lblAviso;
        private Label label1;
    }
}