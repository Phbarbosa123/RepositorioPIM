namespace PimBiomedicina
{
    partial class CadPacAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPacAdm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbmasc = new System.Windows.Forms.RadioButton();
            this.rdbfem = new System.Windows.Forms.RadioButton();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mskrg = new System.Windows.Forms.MaskedTextBox();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.mskcel = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskdatanasc = new System.Windows.Forms.MaskedTextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtresp = new System.Windows.Forms.TextBox();
            this.pacienteTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.pacienteTableAdapter();
            this.txtestado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(480, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(298, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(35, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bairro:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(260, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cidade:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            this.label7.DoubleClick += new System.EventHandler(this.label15_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(37, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observações:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(311, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "N°:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(375, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Complemento:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(78, 87);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(472, 20);
            this.txtnome.TabIndex = 10;
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
            // txtcidade
            // 
            this.txtcidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cidade", true));
            this.txtcidade.Location = new System.Drawing.Point(301, 237);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(148, 20);
            this.txtcidade.TabIndex = 11;
            // 
            // txtidade
            // 
            this.txtidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "idade", true));
            this.txtidade.Location = new System.Drawing.Point(523, 121);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(27, 20);
            this.txtidade.TabIndex = 12;
            // 
            // txtbairro
            // 
            this.txtbairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "bairro", true));
            this.txtbairro.Location = new System.Drawing.Point(78, 237);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(176, 20);
            this.txtbairro.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(455, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estado:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbmasc);
            this.groupBox1.Controls.Add(this.rdbfem);
            this.groupBox1.Location = new System.Drawing.Point(375, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 35);
            this.groupBox1.TabIndex = 15;
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
            // txtcomplemento
            // 
            this.txtcomplemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "complemento", true));
            this.txtcomplemento.Location = new System.Drawing.Point(450, 197);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(100, 20);
            this.txtcomplemento.TabIndex = 17;
            this.txtcomplemento.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtrua
            // 
            this.txtrua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "rua", true));
            this.txtrua.Location = new System.Drawing.Point(78, 197);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(227, 20);
            this.txtrua.TabIndex = 18;
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "numero", true));
            this.txtnum.Location = new System.Drawing.Point(330, 197);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(39, 20);
            this.txtnum.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(168, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CPF:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(38, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "RG:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // mskrg
            // 
            this.mskrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "rg", true));
            this.mskrg.Location = new System.Drawing.Point(78, 125);
            this.mskrg.Mask = "99.999.999-9";
            this.mskrg.Name = "mskrg";
            this.mskrg.Size = new System.Drawing.Size(78, 20);
            this.mskrg.TabIndex = 24;
            // 
            // mskcpf
            // 
            this.mskcpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cpf", true));
            this.mskcpf.Location = new System.Drawing.Point(204, 125);
            this.mskcpf.Mask = "999.999.999-99";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(88, 20);
            this.mskcpf.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(22, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Telefone:";
            // 
            // msktel
            // 
            this.msktel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "telefone", true));
            this.msktel.Location = new System.Drawing.Point(78, 162);
            this.msktel.Mask = "(99)9999-9999";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(100, 20);
            this.msktel.TabIndex = 27;
            // 
            // mskcel
            // 
            this.mskcel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "celular", true));
            this.mskcel.Location = new System.Drawing.Point(253, 162);
            this.mskcel.Mask = "(99)9 9999-9999";
            this.mskcel.Name = "mskcel";
            this.mskcel.Size = new System.Drawing.Size(100, 20);
            this.mskcel.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(201, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Celular:";
            // 
            // mskdatanasc
            // 
            this.mskdatanasc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "datanasc", true));
            this.mskdatanasc.Location = new System.Drawing.Point(405, 121);
            this.mskdatanasc.Mask = "00/00/0000";
            this.mskdatanasc.Name = "mskdatanasc";
            this.mskdatanasc.Size = new System.Drawing.Size(68, 20);
            this.mskdatanasc.TabIndex = 30;
            this.mskdatanasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtobs
            // 
            this.txtobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "obs", true));
            this.txtobs.Location = new System.Drawing.Point(119, 282);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(430, 48);
            this.txtobs.TabIndex = 31;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(191, 394);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(85, 36);
            this.btnsalvar.TabIndex = 32;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Image = ((System.Drawing.Image)(resources.GetObject("btnalterar.Image")));
            this.btnalterar.Location = new System.Drawing.Point(335, 394);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(85, 36);
            this.btnalterar.TabIndex = 33;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(185, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 31);
            this.label15.TabIndex = 34;
            this.label15.Text = "Cadastrar Paciente";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            this.label15.DoubleClick += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(298, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Responsável:";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            this.label16.DoubleClick += new System.EventHandler(this.label16_Click);
            // 
            // txtresp
            // 
            this.txtresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "responsavel", true));
            this.txtresp.Location = new System.Drawing.Point(375, 345);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(176, 20);
            this.txtresp.TabIndex = 36;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // txtestado
            // 
            this.txtestado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "estado", true));
            this.txtestado.Location = new System.Drawing.Point(501, 237);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(39, 20);
            this.txtestado.TabIndex = 38;
            // 
            // CadPacAdm
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
            this.Controls.Add(this.btnalterar);
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
            this.Name = "CadPacAdm";
            this.Text = "CadPacAdm";
            this.Load += new System.EventHandler(this.CadPacAdm_Load);
            this.Click += new System.EventHandler(this.label15_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbmasc;
        private System.Windows.Forms.RadioButton rdbfem;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskrg;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.MaskedTextBox mskcel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskdatanasc;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtresp;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Conexões.TestePimDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.TextBox txtestado;
    }
}