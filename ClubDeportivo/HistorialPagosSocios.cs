﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class HistorialPagosSocios : Form
    {
        public HistorialPagosSocios(DataTable pagos)
        {
            InitializeComponent();
            dgvPagos.DataSource = pagos;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarPagoSocio registrarPagoSocio = new RegistrarPagoSocio();
            registrarPagoSocio.Show();
        }

        
    }
}
