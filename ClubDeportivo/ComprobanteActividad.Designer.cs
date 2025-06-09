namespace ClubDeportivo
{
    partial class ComprobanteActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprobanteActividad));
            btnImprimir = new Button();
            btnCerrar = new Button();
            panelDatos = new Panel();
            lblActividad2 = new Label();
            lblActividad = new Label();
            lblDni2 = new Label();
            lblDni = new Label();
            lblNombreCompleto2 = new Label();
            lblPeso = new Label();
            lblMonto2 = new Label();
            lblMonto = new Label();
            lblFormaPago2 = new Label();
            lblFormaPago = new Label();
            lblFechaVencimiento2 = new Label();
            lblFechaVencimiento = new Label();
            lblFechaPago2 = new Label();
            lblFechaPago = new Label();
            lblNombreCompleto = new Label();
            panelDerecho = new Panel();
            lblFechaActual = new Label();
            lblFecha = new Label();
            panelIzquierdo = new Panel();
            pictureBox1 = new PictureBox();
            lblClubDeportivo = new Label();
            panelSuperior = new Panel();
            lblComprobante = new Label();
            panelDatos.SuspendLayout();
            panelDerecho.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(54, 116, 181);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F);
            btnImprimir.ForeColor = SystemColors.ButtonHighlight;
            btnImprimir.Location = new Point(222, 351);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(84, 31);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(96, 351);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 31);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelDatos
            // 
            panelDatos.BorderStyle = BorderStyle.FixedSingle;
            panelDatos.Controls.Add(lblActividad2);
            panelDatos.Controls.Add(lblActividad);
            panelDatos.Controls.Add(lblDni2);
            panelDatos.Controls.Add(lblDni);
            panelDatos.Controls.Add(lblNombreCompleto2);
            panelDatos.Controls.Add(lblPeso);
            panelDatos.Controls.Add(lblMonto2);
            panelDatos.Controls.Add(lblMonto);
            panelDatos.Controls.Add(lblFormaPago2);
            panelDatos.Controls.Add(lblFormaPago);
            panelDatos.Controls.Add(lblFechaVencimiento2);
            panelDatos.Controls.Add(lblFechaVencimiento);
            panelDatos.Controls.Add(lblFechaPago2);
            panelDatos.Controls.Add(lblFechaPago);
            panelDatos.Controls.Add(lblNombreCompleto);
            panelDatos.Location = new Point(12, 127);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(380, 196);
            panelDatos.TabIndex = 9;
            // 
            // lblActividad2
            // 
            lblActividad2.AutoSize = true;
            lblActividad2.Location = new Point(267, 165);
            lblActividad2.Name = "lblActividad2";
            lblActividad2.Size = new Size(57, 15);
            lblActividad2.TabIndex = 14;
            lblActividad2.Text = "Actividad";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(44, 165);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(60, 15);
            lblActividad.TabIndex = 13;
            lblActividad.Text = "Actividad:";
            // 
            // lblDni2
            // 
            lblDni2.AutoSize = true;
            lblDni2.Location = new Point(267, 37);
            lblDni2.Name = "lblDni2";
            lblDni2.Size = new Size(27, 15);
            lblDni2.TabIndex = 12;
            lblDni2.Text = "DNI";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(44, 37);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 11;
            lblDni.Text = "DNI:";
            // 
            // lblNombreCompleto2
            // 
            lblNombreCompleto2.AutoSize = true;
            lblNombreCompleto2.Location = new Point(267, 10);
            lblNombreCompleto2.Name = "lblNombreCompleto2";
            lblNombreCompleto2.Size = new Size(104, 15);
            lblNombreCompleto2.TabIndex = 10;
            lblNombreCompleto2.Text = "NombreCompleto";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(267, 140);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(13, 15);
            lblPeso.TabIndex = 9;
            lblPeso.Text = "$";
            // 
            // lblMonto2
            // 
            lblMonto2.AutoSize = true;
            lblMonto2.Location = new Point(277, 140);
            lblMonto2.Name = "lblMonto2";
            lblMonto2.Size = new Size(43, 15);
            lblMonto2.TabIndex = 8;
            lblMonto2.Text = "Monto";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(44, 140);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 7;
            lblMonto.Text = "Monto:";
            // 
            // lblFormaPago2
            // 
            lblFormaPago2.AutoSize = true;
            lblFormaPago2.Location = new Point(267, 115);
            lblFormaPago2.Name = "lblFormaPago2";
            lblFormaPago2.Size = new Size(68, 15);
            lblFormaPago2.TabIndex = 6;
            lblFormaPago2.Text = "FormaPago";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(44, 115);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(90, 15);
            lblFormaPago.TabIndex = 5;
            lblFormaPago.Text = "Forma de pago:";
            // 
            // lblFechaVencimiento2
            // 
            lblFechaVencimiento2.AutoSize = true;
            lblFechaVencimiento2.Location = new Point(267, 91);
            lblFechaVencimiento2.Name = "lblFechaVencimiento2";
            lblFechaVencimiento2.Size = new Size(104, 15);
            lblFechaVencimiento2.TabIndex = 4;
            lblFechaVencimiento2.Text = "FechaVencimiento";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(44, 91);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(126, 15);
            lblFechaVencimiento.TabIndex = 3;
            lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblFechaPago2
            // 
            lblFechaPago2.AutoSize = true;
            lblFechaPago2.Location = new Point(267, 63);
            lblFechaPago2.Name = "lblFechaPago2";
            lblFechaPago2.Size = new Size(65, 15);
            lblFechaPago2.TabIndex = 2;
            lblFechaPago2.Text = "FechaPago";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(44, 63);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(87, 15);
            lblFechaPago.TabIndex = 1;
            lblFechaPago.Text = "Fecha de pago:";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(44, 10);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(54, 15);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre:";
            // 
            // panelDerecho
            // 
            panelDerecho.BorderStyle = BorderStyle.FixedSingle;
            panelDerecho.Controls.Add(lblFechaActual);
            panelDerecho.Controls.Add(lblFecha);
            panelDerecho.Location = new Point(205, 46);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(187, 75);
            panelDerecho.TabIndex = 8;
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Font = new Font("Segoe UI", 10F);
            lblFechaActual.Location = new Point(63, 13);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(86, 19);
            lblFechaActual.TabIndex = 1;
            lblFechaActual.Text = "Fecha Actual";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(16, 13);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 19);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BorderStyle = BorderStyle.FixedSingle;
            panelIzquierdo.Controls.Add(pictureBox1);
            panelIzquierdo.Controls.Add(lblClubDeportivo);
            panelIzquierdo.Location = new Point(12, 46);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(187, 75);
            panelIzquierdo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(120, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 69);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblClubDeportivo
            // 
            lblClubDeportivo.AutoSize = true;
            lblClubDeportivo.Font = new Font("Segoe UI", 10F);
            lblClubDeportivo.Location = new Point(3, 13);
            lblClubDeportivo.Name = "lblClubDeportivo";
            lblClubDeportivo.Size = new Size(121, 19);
            lblClubDeportivo.TabIndex = 0;
            lblClubDeportivo.Text = "CLUB DEPORTIVO";
            // 
            // panelSuperior
            // 
            panelSuperior.BorderStyle = BorderStyle.FixedSingle;
            panelSuperior.Controls.Add(lblComprobante);
            panelSuperior.Location = new Point(12, 11);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(380, 32);
            panelSuperior.TabIndex = 6;
            // 
            // lblComprobante
            // 
            lblComprobante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 10F);
            lblComprobante.Location = new Point(52, 11);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(268, 19);
            lblComprobante.TabIndex = 0;
            lblComprobante.Text = "COMPROBANTE DE PAGO DE ACTIVIDAD";
            // 
            // ComprobanteActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(404, 404);
            Controls.Add(btnImprimir);
            Controls.Add(btnCerrar);
            Controls.Add(panelDatos);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ComprobanteActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante Actividad";
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private Button btnCerrar;
        private Panel panelDatos;
        private Label lblDni2;
        private Label lblDni;
        private Label lblNombreCompleto2;
        private Label lblPeso;
        private Label lblMonto2;
        private Label lblMonto;
        private Label lblFormaPago2;
        private Label lblFormaPago;
        private Label lblFechaVencimiento2;
        private Label lblFechaVencimiento;
        private Label lblFechaPago2;
        private Label lblFechaPago;
        private Label lblNombreCompleto;
        private Panel panelDerecho;
        private Label lblFechaActual;
        private Label lblFecha;
        private Panel panelIzquierdo;
        private PictureBox pictureBox1;
        private Label lblClubDeportivo;
        private Panel panelSuperior;
        private Label lblComprobante;
        private Label lblActividad2;
        private Label lblActividad;
    }
}