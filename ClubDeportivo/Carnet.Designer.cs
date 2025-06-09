namespace ClubDeportivo
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            panelSuperior = new Panel();
            lblTituloClub = new Label();
            lblNombre = new Label();
            lblNombre2 = new Label();
            lblDNI = new Label();
            lblDNI2 = new Label();
            lblSocioDesde = new Label();
            lblSocioDesde2 = new Label();
            grpbDatos = new GroupBox();
            lblIdSocio2 = new Label();
            lblIdSocio = new Label();
            lblFechaNacimiento2 = new Label();
            lblFechaNacimiento = new Label();
            picFoto = new PictureBox();
            btnImprimir = new Button();
            panelSuperior.SuspendLayout();
            grpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(lblTituloClub);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(427, 37);
            panelSuperior.TabIndex = 0;
            // 
            // lblTituloClub
            // 
            lblTituloClub.AutoSize = true;
            lblTituloClub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloClub.Location = new Point(142, 9);
            lblTituloClub.Name = "lblTituloClub";
            lblTituloClub.Size = new Size(144, 21);
            lblTituloClub.TabIndex = 0;
            lblTituloClub.Text = "CLUB DEPORTIVO";
            lblTituloClub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(6, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblNombre2
            // 
            lblNombre2.AutoSize = true;
            lblNombre2.Font = new Font("Segoe UI", 10F);
            lblNombre2.Location = new Point(148, 19);
            lblNombre2.Name = "lblNombre2";
            lblNombre2.Size = new Size(59, 19);
            lblNombre2.TabIndex = 2;
            lblNombre2.Text = "Nombre";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F);
            lblDNI.Location = new Point(6, 38);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(36, 19);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblDNI2
            // 
            lblDNI2.AutoSize = true;
            lblDNI2.Font = new Font("Segoe UI", 10F);
            lblDNI2.Location = new Point(148, 38);
            lblDNI2.Name = "lblDNI2";
            lblDNI2.Size = new Size(33, 19);
            lblDNI2.TabIndex = 4;
            lblDNI2.Text = "DNI";
            // 
            // lblSocioDesde
            // 
            lblSocioDesde.AutoSize = true;
            lblSocioDesde.Font = new Font("Segoe UI", 10F);
            lblSocioDesde.Location = new Point(6, 76);
            lblSocioDesde.Name = "lblSocioDesde";
            lblSocioDesde.Size = new Size(115, 19);
            lblSocioDesde.TabIndex = 5;
            lblSocioDesde.Text = "Fecha de ingreso:";
            // 
            // lblSocioDesde2
            // 
            lblSocioDesde2.AutoSize = true;
            lblSocioDesde2.Font = new Font("Segoe UI", 10F);
            lblSocioDesde2.Location = new Point(148, 76);
            lblSocioDesde2.Name = "lblSocioDesde2";
            lblSocioDesde2.Size = new Size(81, 19);
            lblSocioDesde2.TabIndex = 6;
            lblSocioDesde2.Text = "Socio desde";
            // 
            // grpbDatos
            // 
            grpbDatos.Controls.Add(lblIdSocio2);
            grpbDatos.Controls.Add(lblIdSocio);
            grpbDatos.Controls.Add(lblFechaNacimiento2);
            grpbDatos.Controls.Add(lblFechaNacimiento);
            grpbDatos.Controls.Add(lblNombre);
            grpbDatos.Controls.Add(lblSocioDesde2);
            grpbDatos.Controls.Add(lblNombre2);
            grpbDatos.Controls.Add(lblSocioDesde);
            grpbDatos.Controls.Add(lblDNI);
            grpbDatos.Controls.Add(lblDNI2);
            grpbDatos.FlatStyle = FlatStyle.Flat;
            grpbDatos.Location = new Point(153, 43);
            grpbDatos.Name = "grpbDatos";
            grpbDatos.Size = new Size(262, 126);
            grpbDatos.TabIndex = 7;
            grpbDatos.TabStop = false;
            // 
            // lblIdSocio2
            // 
            lblIdSocio2.AutoSize = true;
            lblIdSocio2.Font = new Font("Segoe UI", 10F);
            lblIdSocio2.Location = new Point(148, 95);
            lblIdSocio2.Name = "lblIdSocio2";
            lblIdSocio2.Size = new Size(23, 19);
            lblIdSocio2.TabIndex = 10;
            lblIdSocio2.Text = "ID";
            // 
            // lblIdSocio
            // 
            lblIdSocio.AutoSize = true;
            lblIdSocio.Font = new Font("Segoe UI", 10F);
            lblIdSocio.Location = new Point(6, 95);
            lblIdSocio.Name = "lblIdSocio";
            lblIdSocio.Size = new Size(26, 19);
            lblIdSocio.TabIndex = 9;
            lblIdSocio.Text = "ID:";
            // 
            // lblFechaNacimiento2
            // 
            lblFechaNacimiento2.AutoSize = true;
            lblFechaNacimiento2.Font = new Font("Segoe UI", 10F);
            lblFechaNacimiento2.Location = new Point(146, 57);
            lblFechaNacimiento2.Name = "lblFechaNacimiento2";
            lblFechaNacimiento2.Size = new Size(76, 19);
            lblFechaNacimiento2.TabIndex = 8;
            lblFechaNacimiento2.Text = "nacimiento";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10F);
            lblFechaNacimiento.Location = new Point(6, 57);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(134, 19);
            lblFechaNacimiento.TabIndex = 7;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // picFoto
            // 
            picFoto.BackgroundImageLayout = ImageLayout.None;
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(12, 43);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(120, 120);
            picFoto.TabIndex = 8;
            picFoto.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(54, 116, 181);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F);
            btnImprimir.ForeColor = SystemColors.ButtonHighlight;
            btnImprimir.Location = new Point(331, 183);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(84, 31);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(427, 226);
            Controls.Add(btnImprimir);
            Controls.Add(picFoto);
            Controls.Add(grpbDatos);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Carnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VISTA PREVIA CARNET";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            grpbDatos.ResumeLayout(false);
            grpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTituloClub;
        private Label lblNombre;
        private Label lblNombre2;
        private Label lblDNI;
        private Label lblDNI2;
        private Label lblSocioDesde;
        private Label lblSocioDesde2;
        private GroupBox grpbDatos;
        private PictureBox picFoto;
        private Label lblFechaNacimiento;
        private Label lblFechaNacimiento2;
        private Label lblIdSocio2;
        private Label lblIdSocio;
        private Button btnImprimir;
    }
}