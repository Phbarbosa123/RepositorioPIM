using PimBiomedicina.Conexões.TestePimDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PimBiomedicina
{
    public partial class CadPacEst : Form
    {
        public CadPacEst()
        {
            InitializeComponent();
        }

        String sexo;

        private void CadPacEst_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.testePimDataSet.paciente);

        }

        void Limpar()
        {
            txtnome.Clear();
            mskrg.Clear();
            mskcpf.Clear();
            mskdatanasc.Clear();
            txtidade.Clear();
            msktel.Clear();
            mskcel.Clear();
            sexo = "";
            txtrua.Clear();
            txtnum.Clear();
            txtcomplemento.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txtestado.Clear();
            txtobs.Clear();
            txtresp.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (rdbmasc.Checked)
            {
                sexo = "M";
            }
            else if (rdbfem.Checked)
            {
                sexo = "F";
            }
            pacienteTableAdapter paciente = new pacienteTableAdapter();
            paciente.Insert(txtnome.Text, mskrg.Text, mskcpf.Text, Convert.ToDateTime(mskdatanasc.Text),
                Convert.ToInt32(txtidade.Text), msktel.Text, mskcel.Text, sexo, txtrua.Text, txtnum.Text, txtcomplemento.Text,
                txtbairro.Text, txtcidade.Text, txtestado.Text, txtobs.Text, txtresp.Text);
            MessageBox.Show("Paciente cadastrado com sucesso");
            Limpar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
