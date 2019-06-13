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
    public partial class UriQui : Form
    {
        public UriQui()
        {
            InitializeComponent();
        }

        private void UriQui_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.uriqui'. Você pode movê-la ou removê-la conforme necessário.
            this.uriquiTableAdapter.Fill(this.testePimDataSet.uriqui);

        }

        void Limpar()
        {
            txbBIL.Clear();
            txbCET.Clear();
            txbGLI.Clear();
            txbHB.Clear();
            txbNIT.Clear();
            txbPH.Clear();
            txbPT.Clear();
            txbraca.Clear();
            txbUrioquiobs.Clear();
            txbURO.Clear();
            txtnome.Clear();
            txtresp.Clear();
            mskdata.Clear();
            mskresp.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            uriquiTableAdapter uriqui = new uriquiTableAdapter();
            uriqui.Insert(txtnome.Text, Convert.ToDateTime(mskdata.Text),
                mskresp.Text, txbraca.Text, txbPH.Text, txbPT.Text, txbGLI.Text,
                txbURO.Text, txbBIL.Text, txbCET.Text, txbHB.Text, txbNIT.Text,
                txbUrioquiobs.Text, txtresp.Text);
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
