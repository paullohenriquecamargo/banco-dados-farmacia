using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ProdutosHigienicoEditar : Form
    {
        public ProdutosHigienicoEditar()
        {
            InitializeComponent();
        }

        public ProdutosHigienicoEditar(ProdutosHigienico produtosHigienico)
        {
            InitializeComponent();
            txtId.Text = produtosHigienico.Id.ToString();
            txtNome.Text = produtosHigienico.Nome;
            txtCategoria.Text = produtosHigienico.Categoria;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutosHigienico produtosHigienico = new ProdutosHigienico();
            produtosHigienico.Id = Convert.ToInt32(txtId.Text);
            produtosHigienico.Nome = txtNome.Text;
            produtosHigienico.Categoria = txtCategoria.Text;
            ProdutosHigienicoRepositorio repositorio = new ProdutosHigienicoRepositorio();
            repositorio.Atualizar(produtosHigienico);

            MessageBox.Show("Editado com Sucesso");
            Close();
        }
    }
}
