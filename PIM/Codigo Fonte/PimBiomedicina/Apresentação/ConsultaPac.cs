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
    public partial class ConsultaPac : Form
    {
        public ConsultaPac()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void mskdatanasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.testePimDataSet.paciente);
            // TODO: esta linha de código carrega dados na tabela 'testePimDataSet.paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.testePimDataSet.paciente);

        }
    }
}
