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
    public partial class frmUrinalise : Form
    {
        public frmUrinalise()
        {
            InitializeComponent();
        }

        private void Urinalise_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.urifis'. Você pode movê-la ou removê-la conforme necessário.
            this.urifisTableAdapter.Fill(this.testePimDataSet.urifis);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void Limpar()
        {
            txbRaca.Clear();
            txbUriasp.Clear();
            txbUricor.Clear();
            txbUriden.Clear();
            txbUrifisobs.Clear();
            txtnome.Clear();
            txtresp.Clear();
            mskdata.Clear();
            mskresp.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            urifisTableAdapter urifis = new urifisTableAdapter();
            urifis.Insert(txbUricor.Text, txbUriasp.Text, txbUriden.Text,
                txbUrifisobs.Text, txtnome.Text, Convert.ToDateTime(mskdata.Text),
                txbRaca.Text, txtresp.Text, mskresp.Text);
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
