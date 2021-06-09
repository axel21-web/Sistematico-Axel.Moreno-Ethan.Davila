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
    public partial class Agregar_Producto : Form
    {
        private string Busqueda = "";
        private TelefonoModel TModel { get; set; }
        public Agregar_Producto()
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
            CmbMarca.Items.AddRange(Enum.GetValues(typeof(Marcas)).Cast<Object>().ToArray());
            CmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMarca.SelectedIndex = 0;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                int Id = r.Next(0, 100);
                string Nombre = TxtNombre.Text;
                int NoExistencias = Int32.Parse(TxtNoExistencias.Text);
                int index = CmbMarca.SelectedIndex;
                Marcas Marca = (Marcas)Enum.GetValues(typeof(Marcas)).GetValue(index);
                string Modelo = TxtModelo.Text;
                decimal.TryParse(TxtPrecio.Text, out decimal Precio);
                string Descripcion = TxtDescripcion.Text;
                string Imagen = TxtImagen.Text;
                ValidateTelefono(Nombre, NoExistencias, out Precio, Modelo);

                Telefono T = new Telefono()
                {
                    ID = Id,
                    Nombre = Nombre,
                    NoExistencias = NoExistencias,
                    Marca = Marca,
                    Modelo = Modelo,
                    Precio = Precio,
                    Descripción = Descripcion,
                    Imagen = Imagen,
                };

                TModel.Add(T);
                dgvTelefonos.DataSource = TModel.getAll();
                MessageBox.Show("El Teléfono ha sido agregado exitosamente!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateTelefono(string Nombre, int NoExistencias, out decimal Precio, string Modelo)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new ArgumentException("El nombres es requerido!!");
            }
            if (!int.TryParse(TxtNoExistencias.Text, out int No))
            {
                throw new ArgumentException("El No. de productos es inválido!!");
            }
            NoExistencias = No;
            if (!decimal.TryParse(TxtPrecio.Text, out decimal PrecioT))
            {
                throw new ArgumentException($"El salario '{TxtPrecio.Text}' es inválido");
            }
            Precio = PrecioT;
            if (string.IsNullOrWhiteSpace(Modelo))
            {
                throw new ArgumentException("El modelo es requerido!!");
            }
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
    }
}
