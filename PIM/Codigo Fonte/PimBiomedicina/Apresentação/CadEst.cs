using PimBiomedicina.Conexões.TestePimDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PimBiomedicina.Modelo
{
    public partial class CadEst : Form
    {
        public CadEst()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void CadEst_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.estagiario'. Você pode movê-la ou removê-la conforme necessário.
            this.estagiarioTableAdapter.Fill(this.testePimDataSet.estagiario);

        }
        void Limpar()
        {
            txtnome.Clear();
            txtra.Clear();
            txtsenha.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            estagiarioTableAdapter estagiario = new estagiarioTableAdapter();
            estagiario.Insert(txtnome.Text, txtra.Text, txtsenha.Text);
            MessageBox.Show("Estagiário cadastrado com sucesso");
            Limpar();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            estagiarioTableAdapter estagiario = new estagiarioTableAdapter();
            estagiario.Update(txtnome.Text, txtra.Text, txtsenha.Text);
            MessageBox.Show("Cadastro alterado com sucesso");
            Limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            estagiarioTableAdapter estagiario = new estagiarioTableAdapter();
            estagiario.Delete(txtra.Text);
            MessageBox.Show("Estagiário " + txtra.Text + " excluído com sucesso");
            Limpar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
