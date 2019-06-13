using PimBiomedicina.Conexões.TestePimDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PimBiomedicina.Apresentação
{
    public partial class frmMicrobiologia : Form
    {
        public frmMicrobiologia()
        {
            InitializeComponent();
        }

        private void frmMicrobiologia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.microbiologia'. Você pode movê-la ou removê-la conforme necessário.
            this.microbiologiaTableAdapter.Fill(this.testePimDataSet.microbiologia);

        }

        void Limpar()
        {
            txtnome.Clear();
            mskdata.Clear();
            txtresp.Clear();
            mskresp.Clear();
            txtmat.Clear();
            txtgram.Clear();
            txtgram2.Clear();
            txtmicr1.Clear();
            txtccol.Clear();
            txtmicr2.Clear();
            txtccol2.Clear();
            txtbaar.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            microbiologiaTableAdapter microbiologia = new microbiologiaTableAdapter();
            microbiologia.Insert(txtnome.Text, Convert.ToDateTime(mskdata.Text), txtresp.Text,
                mskresp.Text, txtmat.Text, txtgram.Text, txtgram2.Text, txtmicr1.Text,
                txtccol.Text, txtmicr2.Text, txtccol2.Text, txtbaar.Text);
            MessageBox.Show("Exame salvo com sucesso");
            Limpar();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
