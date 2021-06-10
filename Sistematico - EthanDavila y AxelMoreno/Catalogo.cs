using Sistematico___EthanDavila_y_AxelMoreno.Enums;
using Sistematico___EthanDavila_y_AxelMoreno.Model;
using Sistematico___EthanDavila_y_AxelMoreno.Poco;
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
    public partial class Catalogo : Form
    {
        public string Busqueda = "";
        public TelefonoModel TModel { get; set; }
        public Catalogo()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            TModel = new TelefonoModel();
            dgvTelefonos.ReadOnly = true;
            dgvTelefonos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTelefonos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTelefonos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscador(Busqueda);
        }

        public void Buscador(string Buscador)
        {
            Buscador = TxtBusqueda.Text;
            try
            {
                foreach (DataGridViewRow Row in dgvTelefonos.Rows)
                {
                    foreach (DataGridViewCell Cell in Row.Cells)
                    {
                        if (Cell.Value.ToString() == Buscador)
                        {
                            dgvTelefonos.CurrentCell = Cell;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.Rows.Count == 0)
            {
                return;
            }
            int index = dgvTelefonos.CurrentCell.RowIndex;
            TModel.Remove(index);
            dgvTelefonos.DataSource = TModel.getAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Agregar frm = new Agregar();
            frm.TModel = TModel;
            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar frm = new Actualizar();
            frm.TModel = TModel;
            frm.Show();
        }

        private void dgvTelefonos_Click(object sender, EventArgs e)
        {
            dgvTelefonos.DataSource = TModel.getAll();
        }
    }
}