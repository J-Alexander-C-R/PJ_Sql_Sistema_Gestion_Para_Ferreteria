using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Frm_Producto : Form
    {
        public Frm_Producto()
        {
            InitializeComponent();
            dgv_Producto.DataSource = datagv_Producto.MostrarDatos();
        }

        private CN_Producto datagv_Producto = new CN_Producto();
        private void Frm_Producto_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
