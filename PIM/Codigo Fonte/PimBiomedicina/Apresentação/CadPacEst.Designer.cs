namespace PimBiomedicina
{
    partial class CadPacEst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPacEst));
            this.txtresp = new System.Windows.Forms.TextBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.mskdatanasc = new System.Windows.Forms.MaskedTextBox();
            this.mskcel = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.mskrg = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbmasc = new System.Windows.Forms.RadioButton();
            this.rdbfem = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.pacienteTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.pacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtresp
            // 
            this.txtresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "responsavel", true));
            this.txtresp.Location = new System.Drawing.Point(390, 350);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(176, 20);
            this.txtresp.TabIndex = 70;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.testePimDataSet;
            // 
            // testePimDataSet
            // 
            this.testePimDataSet.DataSetName = "TestePimDataSet";
            this.testePimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(313, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Responsável:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(200, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 31);
            this.label15.TabIndex = 68;
            this.label15.Text = "Cadastrar Paciente";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(263, 400);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(85, 36);
            this.btnsalvar.TabIndex = 66;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtobs
            // 
            this.txtobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "obs", true));
            this.txtobs.Location = new System.Drawing.Point(134, 287);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(430, 48);
            this.txtobs.TabIndex = 65;
            // 
            // mskdatanasc
            // 
            this.mskdatanasc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "datanasc", true));
            this.mskdatanasc.Location = new System.Drawing.Point(420, 126);
            this.mskdatanasc.Mask = "00/00/0000";
            this.mskdatanasc.Name = "mskdatanasc";
            this.mskdatanasc.Size = new System.Drawing.Size(68, 20);
            this.mskdatanasc.TabIndex = 64;
            this.mskdatanasc.ValidatingType = typeof(System.DateTime);
            // 
            // mskcel
            // 
            this.mskcel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "celular", true));
            this.mskcel.Location = new System.Drawing.Point(268, 167);
            this.mskcel.Mask = "(99)9 9999-9999";
            this.mskcel.Name = "mskcel";
            this.mskcel.Size = new System.Drawing.Size(100, 20);
            this.mskcel.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(216, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Celular:";
            // 
            // msktel
            // 
            this.msktel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "telefone", true));
            this.msktel.Location = new System.Drawing.Point(93, 167);
            this.msktel.Mask = "(99)9999-9999";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(100, 20);
            this.msktel.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(37, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Telefone:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // mskcpf
            // 
            this.mskcpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cpf", true));
            this.mskcpf.Location = new System.Drawing.Point(219, 130);
            this.mskcpf.Mask = "999.999.999-99";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(88, 20);
            this.mskcpf.TabIndex = 59;
            // 
            // mskrg
            // 
            this.mskrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "rg", true));
            this.mskrg.Location = new System.Drawing.Point(93, 130);
            this.mskrg.Mask = "99.999.999-9";
            this.mskrg.Name = "mskrg";
            this.mskrg.Size = new System.Drawing.Size(78, 20);
            this.mskrg.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(183, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "CPF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(53, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "RG:";
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "numero", true));
            this.txtnum.Location = new System.Drawing.Point(345, 202);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(39, 20);
            this.txtnum.TabIndex = 55;
            // 
            // txtrua
            // 
            this.txtrua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "rua", true));
            this.txtrua.Location = new System.Drawing.Point(93, 202);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(227, 20);
            this.txtrua.TabIndex = 54;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "complemento", true));
            this.txtcomplemento.Location = new System.Drawing.Point(465, 202);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(100, 20);
            this.txtcomplemento.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbmasc);
            this.groupBox1.Controls.Add(this.rdbfem);
            this.groupBox1.Location = new System.Drawing.Point(390, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 35);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // rdbmasc
            // 
            this.rdbmasc.AutoSize = true;
            this.rdbmasc.Location = new System.Drawing.Point(92, 12);
            this.rdbmasc.Name = "rdbmasc";
            this.rdbmasc.Size = new System.Drawing.Size(73, 17);
            this.rdbmasc.TabIndex = 1;
            this.rdbmasc.TabStop = true;
            this.rdbmasc.Text = "Masculino";
            this.rdbmasc.UseVisualStyleBackColor = true;
            // 
            // rdbfem
            // 
            this.rdbfem.AutoSize = true;
            this.rdbfem.Location = new System.Drawing.Point(7, 12);
            this.rdbfem.Name = "rdbfem";
            this.rdbfem.Size = new System.Drawing.Size(67, 17);
            this.rdbfem.TabIndex = 0;
            this.rdbfem.TabStop = true;
            this.rdbfem.Text = "Feminino";
            this.rdbfem.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(470, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Estado:";
            // 
            // txtbairro
            // 
            this.txtbairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "bairro", true));
            this.txtbairro.Location = new System.Drawing.Point(93, 242);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(176, 20);
            this.txtbairro.TabIndex = 50;
            // 
            // txtidade
            // 
            this.txtidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "idade", true));
            this.txtidade.Location = new System.Drawing.Point(538, 126);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(27, 20);
            this.txtidade.TabIndex = 49;
            // 
            // txtcidade
            // 
            this.txtcidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cidade", true));
            this.txtcidade.Location = new System.Drawing.Point(316, 242);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(148, 20);
            this.txtcidade.TabIndex = 48;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(93, 92);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(472, 20);
            this.txtnome.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(390, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(326, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "N°:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(52, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Observações:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(275, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(50, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(313, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Data de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Rua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(495, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtestado
            // 
            this.txtestado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "estado", true));
            this.txtestado.Location = new System.Drawing.Point(519, 242);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(39, 20);
            this.txtestado.TabIndex = 72;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // CadPacEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 463);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtresp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.mskdatanasc);
            this.Controls.Add(this.mskcel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.mskrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadPacEst";
            this.Text = "CadPacEst";
            this.Load += new System.EventHandler(this.CadPacEst_Load);
            this.Click += new System.EventHandler(this.label1_Click);
            this.DoubleClick += new System.EventHandler(this.label13_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtresp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.MaskedTextBox mskdatanasc;
        private System.Windows.Forms.MaskedTextBox mskcel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.MaskedTextBox mskrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbmasc;
        private System.Windows.Forms.RadioButton rdbfem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestado;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Conexões.TestePimDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
    }
}