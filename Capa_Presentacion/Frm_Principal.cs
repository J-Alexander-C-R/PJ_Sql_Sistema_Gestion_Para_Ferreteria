using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Producto frm_Producto = new Frm_Producto();
            frm_Producto.ShowDialog();

        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            Frm_Empleado frm_Empleado = new Frm_Empleado();
            frm_Empleado.ShowDialog();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            Frm_Cliente frm_Cliente = new Frm_Cliente();
            frm_Cliente.ShowDialog();
        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            Frm_Categoria frm_categoria = new Frm_Categoria();
            frm_categoria.ShowDialog();
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            Frm_Proveedor frm_proveedor = new Frm_Proveedor();
            frm_proveedor.ShowDialog();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Frm_Consulta frm_consulta = new Frm_Consulta();
            frm_consulta.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm_login = new Login();
            frm_login.Show();
        }

        private void btn_Sistema_Click(object sender, EventArgs e)
        {
            Frm_Sistema frm_sistema = new Frm_Sistema();
            frm_sistema.ShowDialog();
        }
    }
}
