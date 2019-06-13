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
    public partial class frmHematologia : Form
    {
        public frmHematologia()
        {
            InitializeComponent();
        }

        private void frmHematologia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.hematologia'. Você pode movê-la ou removê-la conforme necessário.
            this.hematologiaTableAdapter.Fill(this.testePimDataSet.hematologia);

        }

        void Limpar()
        {
            txtnome.Clear();
            mskdata.Clear();
            txtresp.Clear();
            mskcpf.Clear();
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
            txtlintip.Clear();
            txtret.Clear();
            txtfalci.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            hematologiaTableAdapter hematologia = new hematologiaTableAdapter();
            hematologia.Insert(txtnome.Text, Convert.ToDateTime(mskdata.Text), txtresp.Text, mskcpf.Text,
                txterit.Text, txthb.Text, txtht.Text, txtvmc.Text, txthcm.Text, txtchcm.Text,
                txtplaq.Text, txtret.Text, txtleuc.Text, txtmie.Text, txtmet.Text, txtbas.Text, txtseg.Text,
                txteos.Text, txtbaf.Text, txtlintip.Text, txtlinat.Text, txtmono.Text, txtoutras.Text,
                txtobs.Text, txtabo.Text, txtrh.Text, txtvhs.Text, txtfalci.Text);
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
