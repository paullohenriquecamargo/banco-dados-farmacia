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
            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Atualizar(remedio);

            MessageBox.Show("Editado com sucesso");
            Close();
        }
    }
}
