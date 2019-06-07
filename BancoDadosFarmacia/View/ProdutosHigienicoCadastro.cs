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
    public partial class ProdutosHigienicoCadastro : Form
    {
        public ProdutosHigienicoCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutosHigienico produtosHigienico = new ProdutosHigienico();
            produtosHigienico.Nome = txtNome.Text;
            produtosHigienico.Categoria = txtCategoria.Text;
            ProdutosHigienicoRepositorio repositorio = new ProdutosHigienicoRepositorio();
            repositorio.Inserir(produtosHigienico);
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCategoria.Clear();
        }
    }
}
