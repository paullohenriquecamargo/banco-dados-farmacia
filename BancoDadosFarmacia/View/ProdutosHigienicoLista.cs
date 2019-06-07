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
    public partial class ProdutosHigienicoLista : Form
    {
        public ProdutosHigienicoLista()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProdutosHigienicoCadastro cadastro = new ProdutosHigienicoCadastro();
            cadastro.ShowDialog();
        }
        private void ProdutosHigienicoCadastro_Load(object sender, EventArgs e)
        {
        }
        private void AtualizarTabela()
        {
            ProdutosHigienicoRepositorio repositorio = new ProdutosHigienicoRepositorio();
            List<ProdutosHigienico> produtosHigienicos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for(int i = 0;i < produtosHigienicos.Count; i ++)
            {
                ProdutosHigienico produtosHigienico = produtosHigienicos[i];
                dataGridView1.Rows.Add(new object[]
                {
                    produtosHigienico.Id, produtosHigienico.Nome, produtosHigienico.Categoria
                });
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutosHigienicoRepositorio repositorio = new ProdutosHigienicoRepositorio();
            repositorio.Apagar(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            AtualizarTabela();
        }

        private void ProdutosHigienicoLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutosHigienicoRepositorio repositorio = new ProdutosHigienicoRepositorio();
            ProdutosHigienico produtosHigienico = repositorio.ObterPeloId(id);

            ProdutosHigienicoEditar produtosHigienicoEditar = new ProdutosHigienicoEditar();
            produtosHigienicoEditar.ShowDialog();            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutosHigienicoRepositorio repositorio = new ProdutosHigienicoRepositorio();
            ProdutosHigienico produtosHigienico = repositorio.ObterPeloId(id);

            ProdutosHigienicoEditar produtosHigienicoEditar = new ProdutosHigienicoEditar(produtosHigienico);
            produtosHigienicoEditar.ShowDialog();
            AtualizarTabela();
        }
    }
}
