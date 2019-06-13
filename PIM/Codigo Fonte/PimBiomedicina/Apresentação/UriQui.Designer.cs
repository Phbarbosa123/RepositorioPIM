namespace PimBiomedicina.Apresentação
{
    partial class UriQui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UriQui));
            this.txbUrioquiobs = new System.Windows.Forms.TextBox();
            this.uriquiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txbraca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskresp = new System.Windows.Forms.MaskedTextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.mskdata = new System.Windows.Forms.MaskedTextBox();
            this.txtresp = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txbBIL = new System.Windows.Forms.TextBox();
            this.txbURO = new System.Windows.Forms.TextBox();
            this.txbGLI = new System.Windows.Forms.TextBox();
            this.txbPT = new System.Windows.Forms.TextBox();
            this.txbPH = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNIT = new System.Windows.Forms.TextBox();
            this.txbHB = new System.Windows.Forms.TextBox();
            this.txbCET = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.uriquiTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.uriquiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uriquiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUrioquiobs
            // 
            this.txbUrioquiobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "obs", true));
            this.txbUrioquiobs.Location = new System.Drawing.Point(91, 304);
            this.txbUrioquiobs.Multiline = true;
            this.txbUrioquiobs.Name = "txbUrioquiobs";
            this.txbUrioquiobs.Size = new System.Drawing.Size(339, 35);
            this.txbUrioquiobs.TabIndex = 278;
            // 
            // uriquiBindingSource
            // 
            this.uriquiBindingSource.DataMember = "uriqui";
            this.uriquiBindingSource.DataSource = this.testePimDataSet;
            // 
            // testePimDataSet
            // 
            this.testePimDataSet.DataSetName = "TestePimDataSet";
            this.testePimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(224, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 277;
            this.label10.Text = "Observações:";
            // 
            // txbraca
            // 
            this.txbraca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "raca", true));
            this.txbraca.Location = new System.Drawing.Point(357, 98);
            this.txbraca.Name = "txbraca";
            this.txbraca.Size = new System.Drawing.Size(73, 20);
            this.txbraca.TabIndex = 270;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(314, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 269;
            this.label6.Text = "Raça:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 268;
            this.label5.Text = "Exame químico";
            // 
            // mskresp
            // 
            this.mskresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "cpf", true));
            this.mskresp.Location = new System.Drawing.Point(213, 95);
            this.mskresp.Mask = "000.000.000-00";
            this.mskresp.Name = "mskresp";
            this.mskresp.Size = new System.Drawing.Size(88, 20);
            this.mskresp.TabIndex = 266;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Location = new System.Drawing.Point(177, 98);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(30, 13);
            this.Label29.TabIndex = 265;
            this.Label29.Text = "CPF:";
            // 
            // mskdata
            // 
            this.mskdata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "data", true));
            this.mskdata.Location = new System.Drawing.Point(105, 95);
            this.mskdata.Mask = "00/00/0000";
            this.mskdata.Name = "mskdata";
            this.mskdata.Size = new System.Drawing.Size(66, 20);
            this.mskdata.TabIndex = 264;
            this.mskdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtresp
            // 
            this.txtresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "responsavel", true));
            this.txtresp.Location = new System.Drawing.Point(381, 368);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(73, 20);
            this.txtresp.TabIndex = 263;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(105, 62);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(325, 20);
            this.txtnome.TabIndex = 262;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(190, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 31);
            this.Label3.TabIndex = 261;
            this.Label3.Text = "Urinálise";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(338, 371);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 13);
            this.Label4.TabIndex = 260;
            this.Label4.Text = "Resp.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(54, 104);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 259;
            this.Label2.Text = "Data:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(54, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 258;
            this.Label1.Text = "Nome:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(212, 359);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(85, 36);
            this.btnsalvar.TabIndex = 267;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txbBIL
            // 
            this.txbBIL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "bil", true));
            this.txbBIL.Location = new System.Drawing.Point(304, 172);
            this.txbBIL.Multiline = true;
            this.txbBIL.Name = "txbBIL";
            this.txbBIL.Size = new System.Drawing.Size(44, 20);
            this.txbBIL.TabIndex = 288;
            // 
            // txbURO
            // 
            this.txbURO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "uro", true));
            this.txbURO.Location = new System.Drawing.Point(204, 250);
            this.txbURO.Multiline = true;
            this.txbURO.Name = "txbURO";
            this.txbURO.Size = new System.Drawing.Size(44, 20);
            this.txbURO.TabIndex = 287;
            // 
            // txbGLI
            // 
            this.txbGLI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "gli", true));
            this.txbGLI.Location = new System.Drawing.Point(204, 224);
            this.txbGLI.Multiline = true;
            this.txbGLI.Name = "txbGLI";
            this.txbGLI.Size = new System.Drawing.Size(44, 20);
            this.txbGLI.TabIndex = 286;
            // 
            // txbPT
            // 
            this.txbPT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "pt", true));
            this.txbPT.Location = new System.Drawing.Point(204, 198);
            this.txbPT.Multiline = true;
            this.txbPT.Name = "txbPT";
            this.txbPT.Size = new System.Drawing.Size(44, 20);
            this.txbPT.TabIndex = 285;
            // 
            // txbPH
            // 
            this.txbPH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "ph", true));
            this.txbPH.Location = new System.Drawing.Point(204, 172);
            this.txbPH.Multiline = true;
            this.txbPH.Name = "txbPH";
            this.txbPH.Size = new System.Drawing.Size(44, 20);
            this.txbPH.TabIndex = 284;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(274, 175);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(23, 13);
            this.Label11.TabIndex = 283;
            this.Label11.Text = "BIL";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(167, 253);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(31, 13);
            this.Label12.TabIndex = 282;
            this.Label12.Text = "URO";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(174, 227);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(24, 13);
            this.Label9.TabIndex = 281;
            this.Label9.Text = "GLI";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(177, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 280;
            this.label7.Text = "PT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(176, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 279;
            this.label8.Text = "PH";
            // 
            // txbNIT
            // 
            this.txbNIT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "nit", true));
            this.txbNIT.Location = new System.Drawing.Point(304, 250);
            this.txbNIT.Multiline = true;
            this.txbNIT.Name = "txbNIT";
            this.txbNIT.Size = new System.Drawing.Size(44, 20);
            this.txbNIT.TabIndex = 294;
            // 
            // txbHB
            // 
            this.txbHB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "hb", true));
            this.txbHB.Location = new System.Drawing.Point(304, 224);
            this.txbHB.Multiline = true;
            this.txbHB.Name = "txbHB";
            this.txbHB.Size = new System.Drawing.Size(44, 20);
            this.txbHB.TabIndex = 293;
            // 
            // txbCET
            // 
            this.txbCET.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uriquiBindingSource, "cet", true));
            this.txbCET.Location = new System.Drawing.Point(304, 198);
            this.txbCET.Multiline = true;
            this.txbCET.Name = "txbCET";
            this.txbCET.Size = new System.Drawing.Size(44, 20);
            this.txbCET.TabIndex = 292;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Location = new System.Drawing.Point(273, 253);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(25, 13);
            this.Label18.TabIndex = 291;
            this.Label18.Text = "NIT";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Location = new System.Drawing.Point(276, 227);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(22, 13);
            this.Label19.TabIndex = 290;
            this.Label19.Text = "HB";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Location = new System.Drawing.Point(270, 201);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(28, 13);
            this.Label20.TabIndex = 289;
            this.Label20.Text = "CET";
            // 
            // uriquiTableAdapter
            // 
            this.uriquiTableAdapter.ClearBeforeFill = true;
            // 
            // UriQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 415);
            this.Controls.Add(this.txbNIT);
            this.Controls.Add(this.txbHB);
            this.Controls.Add(this.txbCET);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.txbBIL);
            this.Controls.Add(this.txbURO);
            this.Controls.Add(this.txbGLI);
            this.Controls.Add(this.txbPT);
            this.Controls.Add(this.txbPH);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbUrioquiobs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbraca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.mskresp);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.mskdata);
            this.Controls.Add(this.txtresp);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "UriQui";
            this.Text = "UriQui";
            this.Load += new System.EventHandler(this.UriQui_Load);
            this.Click += new System.EventHandler(this.Label1_Click);
            this.DoubleClick += new System.EventHandler(this.Label3_Click);
            ((System.ComponentModel.ISupportInitialize)(this.uriquiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txbUrioquiobs;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txbraca;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.MaskedTextBox mskresp;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.MaskedTextBox mskdata;
        internal System.Windows.Forms.TextBox txtresp;
        internal System.Windows.Forms.TextBox txtnome;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txbBIL;
        internal System.Windows.Forms.TextBox txbURO;
        internal System.Windows.Forms.TextBox txbGLI;
        internal System.Windows.Forms.TextBox txbPT;
        internal System.Windows.Forms.TextBox txbPH;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txbNIT;
        internal System.Windows.Forms.TextBox txbHB;
        internal System.Windows.Forms.TextBox txbCET;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource uriquiBindingSource;
        private Conexões.TestePimDataSetTableAdapters.uriquiTableAdapter uriquiTableAdapter;
    }
}