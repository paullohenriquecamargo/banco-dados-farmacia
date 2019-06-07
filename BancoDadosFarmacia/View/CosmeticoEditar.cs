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
    public partial class CosmeticoEditar : Form
    {
        public CosmeticoEditar()
        {
            InitializeComponent();
        }

        public CosmeticoEditar(Cosmetico cosmetico)
        {
            InitializeComponent();
            txtId.Text = cosmetico.Id.ToString();
            txtDataVencimento.Text = cosmetico.DataVencimento.ToString("dd/MM/yyyy");
            txtNome.Text = cosmetico.Nome;
            txtMarca.Text = cosmetico.Marca;
            txtValor.Text = cosmetico.Valor.ToString();
            txtQuantidade.Text = cosmetico.Quantidade.ToString();
                
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cosmetico cosmetico = new Cosmetico();
            cosmetico.Id = Convert.ToInt32(txtId.Text);
            cosmetico.Nome = txtNome.Text;
            cosmetico.Marca = txtMarca.Text;
            cosmetico.Valor = Convert.ToDecimal(txtValor.Text);
            cosmetico.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            cosmetico.DataVencimento = Convert.ToDateTime(txtDataVencimento.Text);
            CosmeticoRepositorio repositorio = new CosmeticoRepositorio();
            repositorio.Atualizar(cosmetico);

            MessageBox.Show("Editado com Sucesso");
            Close();
        }
    }
}
