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
        public Agregar Actualizar;
        public Telefono Telefono { get; set; }
        public ucTelefono()
        {
            InitializeComponent();
            Actualizar = new Agregar();
        }

        private void ucTelefono_Load(object sender, EventArgs e)
        {
            PBImage.Image = Image.FromFile(Telefono.Imagen);
            LkLblNombre.Text = Telefono.ID + ". " + Telefono.Nombre;
            LblMarcaModelo.Text = Telefono.Marca + ", " + Telefono.Modelo;
            LblNoExistencias.Text = LblNoExistencias.Text + " " + Telefono.NoExistencias;
            TxtDescripcionTelefono.Text = Telefono.Descripción;
        }

        private void LkLblNombre_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
