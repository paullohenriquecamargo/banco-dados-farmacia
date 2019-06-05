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
    public partial class RemedioCadastro : Form
    {
        public RemedioCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Nome = txtNome.Text;
            remedio.Categoria = txtCategoria.Text;
            remedio.Generico = rbGenerico.Checked;
            remedio.Solido = rbSolido.Checked;
            remedio.PrecisaReceita = rbSim.Checked;
            remedio.Faixa = txtFaixa.Text;

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Inserir(remedio);
            Close();
        }
    }
}
