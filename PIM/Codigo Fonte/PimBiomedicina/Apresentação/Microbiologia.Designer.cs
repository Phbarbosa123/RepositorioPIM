namespace PimBiomedicina.Apresentação
{
    partial class frmMicrobiologia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMicrobiologia));
            this.mskresp = new System.Windows.Forms.MaskedTextBox();
            this.microbiologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.Label29 = new System.Windows.Forms.Label();
            this.mskdata = new System.Windows.Forms.MaskedTextBox();
            this.txtresp = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtbaar = new System.Windows.Forms.TextBox();
            this.txtccol2 = new System.Windows.Forms.TextBox();
            this.txtmicr2 = new System.Windows.Forms.TextBox();
            this.txtccol = new System.Windows.Forms.TextBox();
            this.txtmicr1 = new System.Windows.Forms.TextBox();
            this.txtgram2 = new System.Windows.Forms.TextBox();
            this.txtgram = new System.Windows.Forms.TextBox();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.microbiologiaTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.microbiologiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.microbiologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mskresp
            // 
            this.mskresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "cpf", true));
            this.mskresp.Location = new System.Drawing.Point(165, 114);
            this.mskresp.Mask = "000.000.000-00";
            this.mskresp.Name = "mskresp";
            this.mskresp.Size = new System.Drawing.Size(88, 20);
            this.mskresp.TabIndex = 262;
            // 
            // microbiologiaBindingSource
            // 
            this.microbiologiaBindingSource.DataMember = "microbiologia";
            this.microbiologiaBindingSource.DataSource = this.testePimDataSet;
            // 
            // testePimDataSet
            // 
            this.testePimDataSet.DataSetName = "TestePimDataSet";
            this.testePimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Location = new System.Drawing.Point(129, 117);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(30, 13);
            this.Label29.TabIndex = 261;
            this.Label29.Text = "CPF:";
            // 
            // mskdata
            // 
            this.mskdata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "data", true));
            this.mskdata.Location = new System.Drawing.Point(57, 114);
            this.mskdata.Mask = "00/00/0000";
            this.mskdata.Name = "mskdata";
            this.mskdata.Size = new System.Drawing.Size(66, 20);
            this.mskdata.TabIndex = 260;
            this.mskdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtresp
            // 
            this.txtresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "responsavel", true));
            this.txtresp.Location = new System.Drawing.Point(302, 114);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(79, 20);
            this.txtresp.TabIndex = 259;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(259, 117);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 13);
            this.Label4.TabIndex = 258;
            this.Label4.Text = "Resp.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(13, 117);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 257;
            this.Label2.Text = "Data:";
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(57, 75);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(325, 20);
            this.txtnome.TabIndex = 256;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(126, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(173, 31);
            this.Label3.TabIndex = 255;
            this.Label3.Text = "Microbiologia";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(13, 78);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 254;
            this.Label1.Text = "Nome:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(291, 236);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 13);
            this.Label11.TabIndex = 278;
            this.Label11.Text = "BAAR";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(225, 236);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(38, 13);
            this.Label12.TabIndex = 277;
            this.Label12.Text = "C.COL";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(159, 236);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(43, 13);
            this.Label9.TabIndex = 276;
            this.Label9.Text = "MICR 2";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(92, 236);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(38, 13);
            this.Label10.TabIndex = 275;
            this.Label10.Text = "C.COL";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Location = new System.Drawing.Point(291, 173);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 274;
            this.Label7.Text = "MICR 1";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(225, 173);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 273;
            this.Label8.Text = "GRAM";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(158, 173);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 272;
            this.Label5.Text = "GRAM";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Location = new System.Drawing.Point(92, 173);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(30, 13);
            this.Label6.TabIndex = 271;
            this.Label6.Text = "MAT";
            // 
            // txtbaar
            // 
            this.txtbaar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "baar", true));
            this.txtbaar.Location = new System.Drawing.Point(294, 252);
            this.txtbaar.Multiline = true;
            this.txtbaar.Name = "txtbaar";
            this.txtbaar.Size = new System.Drawing.Size(44, 20);
            this.txtbaar.TabIndex = 270;
            // 
            // txtccol2
            // 
            this.txtccol2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "ccol2", true));
            this.txtccol2.Location = new System.Drawing.Point(228, 252);
            this.txtccol2.Multiline = true;
            this.txtccol2.Name = "txtccol2";
            this.txtccol2.Size = new System.Drawing.Size(44, 20);
            this.txtccol2.TabIndex = 269;
            // 
            // txtmicr2
            // 
            this.txtmicr2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "micr2", true));
            this.txtmicr2.Location = new System.Drawing.Point(161, 252);
            this.txtmicr2.Multiline = true;
            this.txtmicr2.Name = "txtmicr2";
            this.txtmicr2.Size = new System.Drawing.Size(44, 20);
            this.txtmicr2.TabIndex = 268;
            // 
            // txtccol
            // 
            this.txtccol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "ccol", true));
            this.txtccol.Location = new System.Drawing.Point(95, 252);
            this.txtccol.Multiline = true;
            this.txtccol.Name = "txtccol";
            this.txtccol.Size = new System.Drawing.Size(44, 20);
            this.txtccol.TabIndex = 267;
            // 
            // txtmicr1
            // 
            this.txtmicr1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "micr1", true));
            this.txtmicr1.Location = new System.Drawing.Point(294, 189);
            this.txtmicr1.Multiline = true;
            this.txtmicr1.Name = "txtmicr1";
            this.txtmicr1.Size = new System.Drawing.Size(44, 20);
            this.txtmicr1.TabIndex = 266;
            // 
            // txtgram2
            // 
            this.txtgram2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "gram1", true));
            this.txtgram2.Location = new System.Drawing.Point(228, 189);
            this.txtgram2.Multiline = true;
            this.txtgram2.Name = "txtgram2";
            this.txtgram2.Size = new System.Drawing.Size(44, 20);
            this.txtgram2.TabIndex = 265;
            // 
            // txtgram
            // 
            this.txtgram.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "gram", true));
            this.txtgram.Location = new System.Drawing.Point(161, 189);
            this.txtgram.Multiline = true;
            this.txtgram.Name = "txtgram";
            this.txtgram.Size = new System.Drawing.Size(44, 20);
            this.txtgram.TabIndex = 264;
            // 
            // txtmat
            // 
            this.txtmat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.microbiologiaBindingSource, "mat", true));
            this.txtmat.Location = new System.Drawing.Point(95, 189);
            this.txtmat.Multiline = true;
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(44, 20);
            this.txtmat.TabIndex = 263;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(168, 309);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(85, 36);
            this.btnsalvar.TabIndex = 279;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // microbiologiaTableAdapter
            // 
            this.microbiologiaTableAdapter.ClearBeforeFill = true;
            // 
            // frmMicrobiologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(419, 371);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtbaar);
            this.Controls.Add(this.txtccol2);
            this.Controls.Add(this.txtmicr2);
            this.Controls.Add(this.txtccol);
            this.Controls.Add(this.txtmicr1);
            this.Controls.Add(this.txtgram2);
            this.Controls.Add(this.txtgram);
            this.Controls.Add(this.txtmat);
            this.Controls.Add(this.mskresp);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.mskdata);
            this.Controls.Add(this.txtresp);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "frmMicrobiologia";
            this.Text = "Microbiologia";
            this.Load += new System.EventHandler(this.frmMicrobiologia_Load);
            this.Click += new System.EventHandler(this.Label1_Click);
            this.DoubleClick += new System.EventHandler(this.Label3_Click);
            ((System.ComponentModel.ISupportInitialize)(this.microbiologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskresp;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.MaskedTextBox mskdata;
        internal System.Windows.Forms.TextBox txtresp;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtnome;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtbaar;
        internal System.Windows.Forms.TextBox txtccol2;
        internal System.Windows.Forms.TextBox txtmicr2;
        internal System.Windows.Forms.TextBox txtccol;
        internal System.Windows.Forms.TextBox txtmicr1;
        internal System.Windows.Forms.TextBox txtgram2;
        internal System.Windows.Forms.TextBox txtgram;
        internal System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.Button btnsalvar;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource microbiologiaBindingSource;
        private Conexões.TestePimDataSetTableAdapters.microbiologiaTableAdapter microbiologiaTableAdapter;
    }
}