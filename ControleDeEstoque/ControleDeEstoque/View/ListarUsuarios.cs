﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.View
{
    public partial class ListarUsuarios : Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleDeEstoqueDataSet.ListUsuario' table. You can move, or remove it, as needed.
            this.listUsuarioTableAdapter.Fill(this.controleDeEstoqueDataSet.ListUsuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
