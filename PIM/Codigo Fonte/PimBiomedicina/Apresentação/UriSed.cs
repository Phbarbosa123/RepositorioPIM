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
    public partial class UriSed : Form
    {
        public UriSed()
        {
            InitializeComponent();
        }

        private void UriSed_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.urised'. Você pode movê-la ou removê-la conforme necessário.
            this.urisedTableAdapter.Fill(this.testePimDataSet.urised);

        }

        String oxalatodecalcio;
        String acidounico;
        String fosfatotriplo;
        String outros1;
        String halino;
        String granuloso;
        String cereos;
        String eritrocitarios;
        String leucocitarios;
        String cilindroide;
        String outros2;
        String parasitas;
        String leveduras;
        String outros3;

        void Limpar()
        {
            oxalatodecalcio = "";
            acidounico = "";
            fosfatotriplo = "";
            outros1 = "";
            halino = "";
            granuloso = "";
            cereos = "";
            eritrocitarios = "";
            leucocitarios = "";
            cilindroide = "";
            outros2 = "";
            parasitas = "";
            leveduras = "";
            outros3 = "";
            txtnome.Clear();
            txtresp.Clear();
            mskdata.Clear();
            mskresp.Clear();
            txbBAC.Clear();
            txbCELS.Clear();
            txbHEM.Clear();
            txbLEUC.Clear();
            txbOutrosCilindros.Clear();
            txbOutrosCristais.Clear();
            txbOutrosMuco.Clear();
            txbRaca.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if(ckbOxcal.Checked)
            {
                oxalatodecalcio = "S";
            }
            else
            {
                oxalatodecalcio = "N";
            }
            if (ckbAciuri.Checked)
            {
                acidounico = "S";
            }
            else
            {
                acidounico = "N";
            }
            if (ckbFosftri.Checked)
            {
                fosfatotriplo = "S";
            }
            else
            {
                fosfatotriplo = "N";
            }
            if (ckbOutrosCristais.Checked)
            {
                outros1 = "S";
            }
            else
            {
                outros1 = "N";
            }
            if(ckbHialino.Checked)
            {
                halino = "S";
            }
            else
            {
                halino = "N";
            }
            if (ckbGranuloso.Checked)
            {
                granuloso = "S";
            }
            else
            {
                granuloso = "N";
            }
            if (ckbCereos.Checked)
            {
                cereos = "S";
            }
            else
            {
                cereos = "N";
            }
            if (ckbEritro.Checked)
            {
                eritrocitarios = "S";
            }
            else
            {
                eritrocitarios = "N";
            }
            if (ckbLeuco.Checked)
            {
                leucocitarios = "S";
            }
            else
            {
                leucocitarios = "N";
            }
            if (ckbCilin.Checked)
            {
                cilindroide = "S";
            }
            else
            {
                cilindroide = "N";
            }
            if (ckbOutrosCilindros.Checked)
            {
                outros2 = "S";
            }
            else
            {
                outros2 = "N";
            }
            if (ckbParasi.Checked)
            {
                parasitas = "S";
            }
            else
            {
                parasitas = "N";
            }
            if (ckbLeved.Checked)
            {
                leveduras = "S";
            }
            else
            {
                leveduras = "N";
            }
            if (ckbOutrosMuco.Checked)
            {
                outros3 = "S";
            }
            else
            {
                outros3 = "N";
            }
            urisedTableAdapter urised = new urisedTableAdapter();
            urised.Insert(txtnome.Text, Convert.ToDateTime(mskdata.Text),
                mskresp.Text, txbRaca.Text, txbCELS.Text, txbLEUC.Text, txbHEM.Text,
                txbBAC.Text, oxalatodecalcio, acidounico, fosfatotriplo, outros1, halino,
                granuloso, cereos, eritrocitarios, leucocitarios, cilindroide, parasitas,
                leveduras, outros2, outros3, txbOutrosCristais.Text,
                txbOutrosCilindros.Text, txbOutrosMuco.Text, txtresp.Text);
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
