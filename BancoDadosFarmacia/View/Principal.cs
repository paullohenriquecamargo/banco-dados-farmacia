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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();            
        }

        private void btnCadastrodeRemedios_Click(object sender, EventArgs e)
        {
            RemedioLista lista = new RemedioLista();
            lista.ShowDialog();
        }

        private void btnCadastrodeCosmeticos_Click(object sender, EventArgs e)
        {
            CosmeticosLista lista = new CosmeticosLista();
            lista.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {                        
            var dialogResult = MessageBox.Show("Deseja encerrar esta aplicação ?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
