using ClosedXML.Excel;
using SistemaEleicoes.regraNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEleicoes.formularios
{
    public partial class FormCadastroCandidatos : Form
    {
        
        List<ClassCandidatos> candidatos = new List<ClassCandidatos>();

        public FormCadastroCandidatos()
        {
            InitializeComponent();
           
        }
        private void btCadastra_Click(object sender, EventArgs e)
        {
            string numero = txtNumCandidato.Text.Trim();

            bool numeroExistente = candidatos.Any(c => c.NumeroCandidato == numero);

            if (numeroExistente)
            {
                MessageBox.Show("Este Numero de Canditado já está cadastrado.");
                return;  
            }

            txtNumCandidato.Clear(); txtApelido.Clear(); txtPartido.Clear(); txtNome.Clear();
            txtNome.Select();

            ClassCandidatos objcandidato = new ClassCandidatos();
            objcandidato.NomeCompleto = txtNome.Text;
            objcandidato.Apelido = txtApelido.Text;
            objcandidato.NumeroCandidato = txtNumCandidato.Text;
            objcandidato.Partido = txtPartido.Text;
            candidatos.Add(objcandidato);
            MessageBox.Show("Salvo com sucesso!", "ADS");
            txtNumCandidato.Clear(); txtApelido.Clear(); txtPartido.Clear(); txtNome.Clear();
            txtNome.Select();
            dgvCandidatos.DataSource = candidatos.OrderBy(a => a.NomeCompleto).ToList();

            var pasta = new XLWorkbook("C:\\excel\\ListaCandidatos1.xlsx");
            var plan = pasta.Worksheet(1);

            int qtdLinha = plan.RowsUsed().Count();

            string opc = "S";
            int linhaLivre = qtdLinha + 1;
            plan.Cell(linhaLivre, 1).Value = linhaLivre - 1;
            plan.Cell(linhaLivre, 2).Value = objcandidato.NomeCompleto;
            plan.Cell(linhaLivre, 3).Value = objcandidato.Apelido;
            plan.Cell(linhaLivre, 4).Value = objcandidato.NumeroCandidato;
            plan.Cell(linhaLivre, 5).Value = objcandidato.Partido;

            pasta.Save();

        }

        private void FormCadastroCandidatos_Load(object sender, EventArgs e)
        {

        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtApelido.Clear(); txtNome.Clear(); txtNumCandidato.Clear(); txtPartido.Clear();
            txtNome.Select();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O Campo está vazio", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Select();
            }
            else
            {
                txtApelido.Select();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApelido_Leave(object sender, EventArgs e)
        {
            if (txtApelido.Text == "")
            {
                MessageBox.Show("O Campo está vazio", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApelido.Select();
            }
            else
            {
                txtNumCandidato.Select();
            }
        }

        private void txtPartido_Leave(object sender, EventArgs e)
        {
            if(txtPartido.Text == "")
            {
                MessageBox.Show("OCampo está vazio", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartido.Select();
            }
            else
            {
                txtNumCandidato.Select();
            }
        }

        private void txtNumCandidato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumCandidato_Layout(object sender, LayoutEventArgs e)
        {
            if (txtNumCandidato.Text == "")
            {
                MessageBox.Show("O Campo está vazio", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumCandidato.Select();
            }
          
        }
    }
}
