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
    public partial class CadPacAdm : Form
    {
        public CadPacAdm()
        {
            InitializeComponent();
        }
        String sexo;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadPacAdm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.testePimDataSet.paciente);

        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void btnalterar_Click(object sender, EventArgs e)
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
            paciente.Update(txtnome.Text, mskrg.Text, mskcpf.Text, mskdatanasc.Text,
                Convert.ToInt32(txtidade.Text), msktel.Text, mskcel.Text, sexo, txtrua.Text, txtnum.Text, txtcomplemento.Text,
                txtbairro.Text, txtcidade.Text, txtestado.Text, txtobs.Text, txtresp.Text);
            MessageBox.Show("Cadastro alterado com sucesso");
            Limpar();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
