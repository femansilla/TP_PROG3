﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace ViewsApp
{
    public partial class ListaProductos : Form
    {
        private static ProductoController controller = new ProductoController();
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FormAgregarProducto().Show();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            var a = controller.GetProductos();
            List<frmProducto> lista = new List<frmProducto>();
            foreach (var item in a)
            {
                frmProducto frmView = new frmProducto()
                {
                    Descripcion = item.Descripcion
                };
                lista.Add(frmView);
            }
            dgvProductos.DataSource = a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
