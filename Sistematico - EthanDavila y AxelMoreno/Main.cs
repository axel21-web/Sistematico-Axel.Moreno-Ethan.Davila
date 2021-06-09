﻿using Sistematico___EthanDavila_y_AxelMoreno.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico___EthanDavila_y_AxelMoreno
{
    public partial class Main : Form
    {
        private TelefonoModel TModel;
        public Main()
        {
            InitializeComponent();
            TModel = new TelefonoModel();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo frm = new Catalogo();
            frm.TModel = TModel;
            frm.Show();
        }

        private void tablaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View frm = new View();
            frm.TModel = TModel;
            frm.Show();
        }
    }
}
