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
    public partial class View : Form
    {
        public TelefonoModel TModel { get; set; }
        public Telefono[] Telefonos = new Telefono[5];
        public View()
        {
            InitializeComponent();
            LoadComponents();
        }

        public void LoadComponents()
        {
            TModel = new TelefonoModel();
        }

        private void View_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Telefonos.Length; i++)
            {
                
            }
        }
    }
}
