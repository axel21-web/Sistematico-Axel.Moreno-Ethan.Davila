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
    public partial class Actualizar : Form
    {
        public Catalogo Catalogo;
        public TelefonoModel TModel;
        public Telefono[] Telefonos = new Telefono[100];
        public int index;
        public Actualizar()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            index = Catalogo.dgvTelefonos.Rows.Count;
            Catalogo = new Catalogo();
            TModel = new TelefonoModel();
            CmbMarca.Items.AddRange(Enum.GetValues(typeof(Marcas)).Cast<Object>().ToArray());
            CmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMarca.SelectedIndex = 0;
            TxtNombre.Text = Telefonos[index].Nombre;
            TxtImagen.Text = Telefonos[index].Imagen;
            TxtModelo.Text = Telefonos[index].Modelo;
            TxtDescripcion.Text = Telefonos[index].Descripción;
            TxtNoExistencias.Text = Telefonos[index].NoExistencias.ToString();
            TxtPrecio.Text = Telefonos[index].Precio.ToString();
        }
    }
}