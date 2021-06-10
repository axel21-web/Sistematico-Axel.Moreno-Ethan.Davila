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

namespace Sistematico___EthanDavila_y_AxelMoreno.User_Controls
{
    public partial class ucTelefono : UserControl
    {
        public Telefono Telefono { get; set; }
        public ucTelefono()
        {
            InitializeComponent();
        }

        private void ucTelefono_Load(object sender, EventArgs e)
        {
            PBImage.Image = Image.FromFile(Telefono.Imagen);
            LblID.Text = LblID.Text + " " + Telefono.ID;
            LkLblNombre.Text = LkLblNombre.Text + " " + Telefono.Nombre;
            LblMarca.Text = LblMarca.Text + " " + Telefono.Marca.ToString();
            LblModelo.Text = LblModelo.Text + " " + Telefono.Modelo.ToString();
            LblNoExistencias.Text = LblNoExistencias.Text + " " + Telefono.NoExistencias;
            LblDescripcion.Text = LblDescripcion.Text + " " + Telefono.Descripción;
        }
    }
}
