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
    public partial class RemedioEditar : Form
    {
        public RemedioEditar()
        {
            InitializeComponent();
        }
        public RemedioEditar(Remedio remedio)
        {
            InitializeComponent();
            txtNome.Text = remedio.Nome;
            txtId.Text = remedio.Id.ToString();
            txtCategoria.Text = remedio.Categoria;
            rbGenerico.Checked = remedio.Generico;
            rbSolido.Checked = remedio.Solido;
            txtFaixa.Text = remedio.Faixa;
            txtBula.Text = remedio.Bula;
            txtContraIndicacoes.Text = remedio.ContraIndicacoes;

            if (remedio.PrecisaReceita)
            {
                rbSim.Checked = true;
            }else
            {
                rbNao.Checked = true;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Id = Convert.ToInt32(txtId.Text);
            remedio.Nome = txtNome.Text;
            remedio.Generico = rbGenerico.Checked;
            remedio.Categoria = txtCategoria.Text;
            remedio.PrecisaReceita = rbSim.Checked;
            remedio.Solido = rbSolido.Checked;
            remedio.Faixa = txtFaixa.Text;
            remedio.Bula = txtBula.Text;
            remedio.ContraIndicacoes = txtContraIndicacoes.Text;
            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Atualizar(remedio);

            MessageBox.Show("Editado com sucesso");
            Close();
        }
    }
}
