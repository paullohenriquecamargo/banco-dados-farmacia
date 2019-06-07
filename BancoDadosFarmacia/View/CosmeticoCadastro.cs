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
    public partial class CosmeticoCadastro : Form
    {
        public CosmeticoCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cosmetico cosmetico = new Cosmetico();
            cosmetico.Nome = txtNome.Text;
            cosmetico.DataVencimento = Convert.ToDateTime(txtDataVencimento.Text);
            cosmetico.Valor = Convert.ToDecimal(txtValor.Text);
            cosmetico.Marca = txtMarca.Text;
            cosmetico.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            CosmeticoRepositorio repositorio = new CosmeticoRepositorio();
            repositorio.Inserir(cosmetico);
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDataVencimento.Clear();
            txtValor.Clear();
            txtMarca.Clear();
            txtQuantidade.Clear();
        }
    }
}
