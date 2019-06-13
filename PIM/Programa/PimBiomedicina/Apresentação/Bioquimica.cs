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
    public partial class frmBioquimica : Form
    {
        public frmBioquimica()
        {
            InitializeComponent();
        }

        private void frmBioquimica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.bioquimica'. Você pode movê-la ou removê-la conforme necessário.
            this.bioquimicaTableAdapter.Fill(this.testePimDataSet.bioquimica);

        }

        void Limpar()
        {
            txtnome.Clear();
            mskdata.Clear();
            txtresp.Clear();
            mskresp.Clear();
            txterit.Clear();
            txthb.Clear();
            txtht.Clear();
            txtvmc.Clear();
            txthcm.Clear();
            txtchcm.Clear();
            txtplaq.Clear();
            txtleuc.Clear();
            txtmie.Clear();
            txtmet.Clear();
            txtbas.Clear();
            txtseg.Clear();
            txteos.Clear();
            txtbaf.Clear();
            txtlinat.Clear();
            txtmono.Clear();
            txtoutras.Clear();
            txtobs.Clear();
            txtabo.Clear();
            txtrh.Clear();
            txtvhs.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            bioquimicaTableAdapter bioquimica = new bioquimicaTableAdapter();
            bioquimica.Insert(txtnome.Text, Convert.ToDateTime(mskdata.Text), txtresp.Text, mskresp.Text,
                txterit.Text, txthb.Text, txtht.Text, txtvmc.Text, txthcm.Text, txtchcm.Text,
                txtplaq.Text, txtleuc.Text, txtmie.Text, txtmet.Text, txtbas.Text, txtseg.Text,
                txteos.Text, txtbaf.Text, txtlinat.Text, txtmono.Text, txtoutras.Text,
                txtobs.Text, txtabo.Text, txtrh.Text, txtvhs.Text);
            MessageBox.Show("Exame salvo com sucesso");
            Limpar();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
