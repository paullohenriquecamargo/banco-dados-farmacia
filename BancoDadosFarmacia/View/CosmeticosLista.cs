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
    public partial class CosmeticosLista : Form
    {
        public CosmeticosLista()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CosmeticoCadastro lista = new CosmeticoCadastro();
            lista.ShowDialog();
        }

        private void CosmeticosLista_Load(object sender, EventArgs e)
        {
        }
        private void AtualizarTabela(){
            CosmeticoRepositorio repositorio = new CosmeticoRepositorio();
            List<Cosmetico> cosmeticos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for(int i = 0; i < cosmeticos.Count; i++)
            {
                Cosmetico cosmetico = cosmeticos[i];
                dataGridView1.Rows.Add(new object[]
                {
                    cosmetico.Id, cosmetico.Nome, cosmetico.DataVencimento.ToString("dd/MM/yyyy"),cosmetico.Quantidade, cosmetico.Valor, cosmetico.Marca
                });
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            CosmeticoRepositorio repositorio = new CosmeticoRepositorio();
            repositorio.Apagar(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            AtualizarTabela();                
        }

        private void CosmeticosLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            CosmeticoRepositorio repositorio = new CosmeticoRepositorio();
            Cosmetico cosmetico = repositorio.ObterPeloId(id);

            CosmeticoEditar cosmeticoEditar = new CosmeticoEditar();
            cosmeticoEditar.ShowDialog();
        }
                                                                
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            CosmeticoRepositorio repositorio = new CosmeticoRepositorio();
            Cosmetico cosmetico = repositorio.ObterPeloId(id);

            CosmeticoEditar cosmeticoEditar = new CosmeticoEditar(cosmetico);
            cosmeticoEditar.ShowDialog();
            AtualizarTabela();
        }                                
    }
}
