using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEleicoes.formularios;

namespace SistemaEleicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btApuracao_Click(object sender, EventArgs e)
        {
             FormApuracaoResultados form = new FormApuracaoResultados();
            form.ShowDialog();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroCandidatos form = new FormCadastroCandidatos();
            form.ShowDialog();
        }

        private void btVotacao_Click(object sender, EventArgs e)
        {
            FormVotacaoInterativa form = new FormVotacaoInterativa();
            form.ShowDialog();
        }
    }
}
