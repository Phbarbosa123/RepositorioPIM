namespace PimBiomedicina.Apresentação
{
    partial class UriSed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UriSed));
            this.txbOutrosCristais = new System.Windows.Forms.TextBox();
            this.urisedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.txbRaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.mskresp = new System.Windows.Forms.MaskedTextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.mskdata = new System.Windows.Forms.MaskedTextBox();
            this.txtresp = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txbBAC = new System.Windows.Forms.TextBox();
            this.txbHEM = new System.Windows.Forms.TextBox();
            this.txbLEUC = new System.Windows.Forms.TextBox();
            this.txbCELS = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbAciuri = new System.Windows.Forms.CheckBox();
            this.ckbFosftri = new System.Windows.Forms.CheckBox();
            this.ckbOxcal = new System.Windows.Forms.CheckBox();
            this.ckbGranuloso = new System.Windows.Forms.CheckBox();
            this.ckbHialino = new System.Windows.Forms.CheckBox();
            this.ckbCereos = new System.Windows.Forms.CheckBox();
            this.ckbEritro = new System.Windows.Forms.CheckBox();
            this.ckbLeuco = new System.Windows.Forms.CheckBox();
            this.ckbCilin = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbLeved = new System.Windows.Forms.CheckBox();
            this.ckbParasi = new System.Windows.Forms.CheckBox();
            this.ckbOutrosMuco = new System.Windows.Forms.CheckBox();
            this.ckbOutrosCristais = new System.Windows.Forms.CheckBox();
            this.ckbOutrosCilindros = new System.Windows.Forms.CheckBox();
            this.txbOutrosCilindros = new System.Windows.Forms.TextBox();
            this.txbOutrosMuco = new System.Windows.Forms.TextBox();
            this.urisedTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.urisedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.urisedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txbOutrosCristais
            // 
            this.txbOutrosCristais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "obs1", true));
            this.txbOutrosCristais.Location = new System.Drawing.Point(149, 297);
            this.txbOutrosCristais.Multiline = true;
            this.txbOutrosCristais.Name = "txbOutrosCristais";
            this.txbOutrosCristais.Size = new System.Drawing.Size(156, 35);
            this.txbOutrosCristais.TabIndex = 309;
            // 
            // urisedBindingSource
            // 
            this.urisedBindingSource.DataMember = "urised";
            this.urisedBindingSource.DataSource = this.testePimDataSet;
            // 
            // testePimDataSet
            // 
            this.testePimDataSet.DataSetName = "TestePimDataSet";
            this.testePimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbRaca
            // 
            this.txbRaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "raca", true));
            this.txbRaca.Location = new System.Drawing.Point(504, 95);
            this.txbRaca.Name = "txbRaca";
            this.txbRaca.Size = new System.Drawing.Size(73, 20);
            this.txbRaca.TabIndex = 307;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(461, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 306;
            this.label6.Text = "Raça:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 305;
            this.label5.Text = "Sedimentoscopia";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(359, 365);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(85, 36);
            this.btnsalvar.TabIndex = 304;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // mskresp
            // 
            this.mskresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "cpf", true));
            this.mskresp.Location = new System.Drawing.Point(360, 92);
            this.mskresp.Mask = "000.000.000-00";
            this.mskresp.Name = "mskresp";
            this.mskresp.Size = new System.Drawing.Size(88, 20);
            this.mskresp.TabIndex = 303;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Location = new System.Drawing.Point(324, 95);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(30, 13);
            this.Label29.TabIndex = 302;
            this.Label29.Text = "CPF:";
            // 
            // mskdata
            // 
            this.mskdata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "data", true));
            this.mskdata.Location = new System.Drawing.Point(252, 92);
            this.mskdata.Mask = "00/00/0000";
            this.mskdata.Name = "mskdata";
            this.mskdata.Size = new System.Drawing.Size(66, 20);
            this.mskdata.TabIndex = 301;
            this.mskdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtresp
            // 
            this.txtresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "responsavel", true));
            this.txtresp.Location = new System.Drawing.Point(528, 374);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(73, 20);
            this.txtresp.TabIndex = 300;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(252, 59);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(325, 20);
            this.txtnome.TabIndex = 299;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(337, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 31);
            this.Label3.TabIndex = 298;
            this.Label3.Text = "Urinálise";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(485, 377);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 13);
            this.Label4.TabIndex = 297;
            this.Label4.Text = "Resp.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(201, 101);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 296;
            this.Label2.Text = "Data:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(201, 68);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 295;
            this.Label1.Text = "Nome:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txbBAC
            // 
            this.txbBAC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "bac", true));
            this.txbBAC.Location = new System.Drawing.Point(60, 255);
            this.txbBAC.Multiline = true;
            this.txbBAC.Name = "txbBAC";
            this.txbBAC.Size = new System.Drawing.Size(44, 20);
            this.txbBAC.TabIndex = 317;
            // 
            // txbHEM
            // 
            this.txbHEM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "hem", true));
            this.txbHEM.Location = new System.Drawing.Point(60, 229);
            this.txbHEM.Multiline = true;
            this.txbHEM.Name = "txbHEM";
            this.txbHEM.Size = new System.Drawing.Size(44, 20);
            this.txbHEM.TabIndex = 316;
            // 
            // txbLEUC
            // 
            this.txbLEUC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "leuc", true));
            this.txbLEUC.Location = new System.Drawing.Point(60, 203);
            this.txbLEUC.Multiline = true;
            this.txbLEUC.Name = "txbLEUC";
            this.txbLEUC.Size = new System.Drawing.Size(44, 20);
            this.txbLEUC.TabIndex = 315;
            // 
            // txbCELS
            // 
            this.txbCELS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "cels", true));
            this.txbCELS.Location = new System.Drawing.Point(60, 177);
            this.txbCELS.Multiline = true;
            this.txbCELS.Name = "txbCELS";
            this.txbCELS.Size = new System.Drawing.Size(44, 20);
            this.txbCELS.TabIndex = 314;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Location = new System.Drawing.Point(26, 258);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(28, 13);
            this.Label14.TabIndex = 313;
            this.Label14.Text = "BAC";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Location = new System.Drawing.Point(23, 232);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(31, 13);
            this.Label15.TabIndex = 312;
            this.Label15.Text = "HEM";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(19, 206);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(35, 13);
            this.Label16.TabIndex = 311;
            this.Label16.Text = "LEUC";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Location = new System.Drawing.Point(20, 180);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(34, 13);
            this.Label17.TabIndex = 310;
            this.Label17.Text = "CELS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(194, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 318;
            this.label7.Text = "Cristais";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(357, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 319;
            this.label8.Text = "Cilindros";
            // 
            // ckbAciuri
            // 
            this.ckbAciuri.AutoSize = true;
            this.ckbAciuri.BackColor = System.Drawing.Color.Transparent;
            this.ckbAciuri.Location = new System.Drawing.Point(197, 228);
            this.ckbAciuri.Name = "ckbAciuri";
            this.ckbAciuri.Size = new System.Drawing.Size(79, 17);
            this.ckbAciuri.TabIndex = 320;
            this.ckbAciuri.Text = "Ácido úrico";
            this.ckbAciuri.UseVisualStyleBackColor = false;
            // 
            // ckbFosftri
            // 
            this.ckbFosftri.AutoSize = true;
            this.ckbFosftri.BackColor = System.Drawing.Color.Transparent;
            this.ckbFosftri.Location = new System.Drawing.Point(197, 251);
            this.ckbFosftri.Name = "ckbFosftri";
            this.ckbFosftri.Size = new System.Drawing.Size(86, 17);
            this.ckbFosftri.TabIndex = 321;
            this.ckbFosftri.Text = "Fosfato triplo";
            this.ckbFosftri.UseVisualStyleBackColor = false;
            // 
            // ckbOxcal
            // 
            this.ckbOxcal.AutoSize = true;
            this.ckbOxcal.BackColor = System.Drawing.Color.Transparent;
            this.ckbOxcal.Location = new System.Drawing.Point(197, 205);
            this.ckbOxcal.Name = "ckbOxcal";
            this.ckbOxcal.Size = new System.Drawing.Size(108, 17);
            this.ckbOxcal.TabIndex = 322;
            this.ckbOxcal.Text = "Oxalato de cálcio";
            this.ckbOxcal.UseVisualStyleBackColor = false;
            // 
            // ckbGranuloso
            // 
            this.ckbGranuloso.AutoSize = true;
            this.ckbGranuloso.BackColor = System.Drawing.Color.Transparent;
            this.ckbGranuloso.Location = new System.Drawing.Point(360, 229);
            this.ckbGranuloso.Name = "ckbGranuloso";
            this.ckbGranuloso.Size = new System.Drawing.Size(130, 17);
            this.ckbGranuloso.TabIndex = 323;
            this.ckbGranuloso.Text = "Granuloso/Granulares";
            this.ckbGranuloso.UseVisualStyleBackColor = false;
            // 
            // ckbHialino
            // 
            this.ckbHialino.AutoSize = true;
            this.ckbHialino.BackColor = System.Drawing.Color.Transparent;
            this.ckbHialino.Location = new System.Drawing.Point(360, 205);
            this.ckbHialino.Name = "ckbHialino";
            this.ckbHialino.Size = new System.Drawing.Size(118, 17);
            this.ckbHialino.TabIndex = 324;
            this.ckbHialino.Text = "Hialino/Translúcido";
            this.ckbHialino.UseVisualStyleBackColor = false;
            // 
            // ckbCereos
            // 
            this.ckbCereos.AutoSize = true;
            this.ckbCereos.BackColor = System.Drawing.Color.Transparent;
            this.ckbCereos.Location = new System.Drawing.Point(360, 251);
            this.ckbCereos.Name = "ckbCereos";
            this.ckbCereos.Size = new System.Drawing.Size(59, 17);
            this.ckbCereos.TabIndex = 325;
            this.ckbCereos.Text = "Céreos";
            this.ckbCereos.UseVisualStyleBackColor = false;
            // 
            // ckbEritro
            // 
            this.ckbEritro.AutoSize = true;
            this.ckbEritro.BackColor = System.Drawing.Color.Transparent;
            this.ckbEritro.Location = new System.Drawing.Point(488, 205);
            this.ckbEritro.Name = "ckbEritro";
            this.ckbEritro.Size = new System.Drawing.Size(138, 17);
            this.ckbEritro.TabIndex = 326;
            this.ckbEritro.Text = "Eritrocitários/Hemáticos";
            this.ckbEritro.UseVisualStyleBackColor = false;
            // 
            // ckbLeuco
            // 
            this.ckbLeuco.AutoSize = true;
            this.ckbLeuco.BackColor = System.Drawing.Color.Transparent;
            this.ckbLeuco.Location = new System.Drawing.Point(488, 228);
            this.ckbLeuco.Name = "ckbLeuco";
            this.ckbLeuco.Size = new System.Drawing.Size(89, 17);
            this.ckbLeuco.TabIndex = 327;
            this.ckbLeuco.Text = "Leucocitários";
            this.ckbLeuco.UseVisualStyleBackColor = false;
            // 
            // ckbCilin
            // 
            this.ckbCilin.AutoSize = true;
            this.ckbCilin.BackColor = System.Drawing.Color.Transparent;
            this.ckbCilin.Location = new System.Drawing.Point(488, 251);
            this.ckbCilin.Name = "ckbCilin";
            this.ckbCilin.Size = new System.Drawing.Size(74, 17);
            this.ckbCilin.TabIndex = 328;
            this.ckbCilin.Text = "Cilindróide";
            this.ckbCilin.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(673, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 329;
            this.label9.Text = "Muco";
            // 
            // ckbLeved
            // 
            this.ckbLeved.AutoSize = true;
            this.ckbLeved.BackColor = System.Drawing.Color.Transparent;
            this.ckbLeved.Location = new System.Drawing.Point(676, 231);
            this.ckbLeved.Name = "ckbLeved";
            this.ckbLeved.Size = new System.Drawing.Size(76, 17);
            this.ckbLeved.TabIndex = 331;
            this.ckbLeved.Text = "Leveduras";
            this.ckbLeved.UseVisualStyleBackColor = false;
            // 
            // ckbParasi
            // 
            this.ckbParasi.AutoSize = true;
            this.ckbParasi.BackColor = System.Drawing.Color.Transparent;
            this.ckbParasi.Location = new System.Drawing.Point(676, 208);
            this.ckbParasi.Name = "ckbParasi";
            this.ckbParasi.Size = new System.Drawing.Size(69, 17);
            this.ckbParasi.TabIndex = 330;
            this.ckbParasi.Text = "Parasitas";
            this.ckbParasi.UseVisualStyleBackColor = false;
            // 
            // ckbOutrosMuco
            // 
            this.ckbOutrosMuco.AutoSize = true;
            this.ckbOutrosMuco.BackColor = System.Drawing.Color.Transparent;
            this.ckbOutrosMuco.Location = new System.Drawing.Point(676, 274);
            this.ckbOutrosMuco.Name = "ckbOutrosMuco";
            this.ckbOutrosMuco.Size = new System.Drawing.Size(57, 17);
            this.ckbOutrosMuco.TabIndex = 332;
            this.ckbOutrosMuco.Text = "Outros";
            this.ckbOutrosMuco.UseVisualStyleBackColor = false;
            // 
            // ckbOutrosCristais
            // 
            this.ckbOutrosCristais.AutoSize = true;
            this.ckbOutrosCristais.BackColor = System.Drawing.Color.Transparent;
            this.ckbOutrosCristais.Location = new System.Drawing.Point(197, 274);
            this.ckbOutrosCristais.Name = "ckbOutrosCristais";
            this.ckbOutrosCristais.Size = new System.Drawing.Size(57, 17);
            this.ckbOutrosCristais.TabIndex = 333;
            this.ckbOutrosCristais.Text = "Outros";
            this.ckbOutrosCristais.UseVisualStyleBackColor = false;
            // 
            // ckbOutrosCilindros
            // 
            this.ckbOutrosCilindros.AutoSize = true;
            this.ckbOutrosCilindros.BackColor = System.Drawing.Color.Transparent;
            this.ckbOutrosCilindros.Location = new System.Drawing.Point(433, 274);
            this.ckbOutrosCilindros.Name = "ckbOutrosCilindros";
            this.ckbOutrosCilindros.Size = new System.Drawing.Size(57, 17);
            this.ckbOutrosCilindros.TabIndex = 335;
            this.ckbOutrosCilindros.Text = "Outros";
            this.ckbOutrosCilindros.UseVisualStyleBackColor = false;
            // 
            // txbOutrosCilindros
            // 
            this.txbOutrosCilindros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "obs2", true));
            this.txbOutrosCilindros.Location = new System.Drawing.Point(379, 297);
            this.txbOutrosCilindros.Multiline = true;
            this.txbOutrosCilindros.Name = "txbOutrosCilindros";
            this.txbOutrosCilindros.Size = new System.Drawing.Size(156, 35);
            this.txbOutrosCilindros.TabIndex = 334;
            // 
            // txbOutrosMuco
            // 
            this.txbOutrosMuco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urisedBindingSource, "obs3", true));
            this.txbOutrosMuco.Location = new System.Drawing.Point(619, 297);
            this.txbOutrosMuco.Multiline = true;
            this.txbOutrosMuco.Name = "txbOutrosMuco";
            this.txbOutrosMuco.Size = new System.Drawing.Size(156, 35);
            this.txbOutrosMuco.TabIndex = 336;
            // 
            // urisedTableAdapter
            // 
            this.urisedTableAdapter.ClearBeforeFill = true;
            // 
            // UriSed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 415);
            this.Controls.Add(this.txbOutrosMuco);
            this.Controls.Add(this.ckbOutrosCilindros);
            this.Controls.Add(this.txbOutrosCilindros);
            this.Controls.Add(this.ckbOutrosCristais);
            this.Controls.Add(this.ckbOutrosMuco);
            this.Controls.Add(this.ckbLeved);
            this.Controls.Add(this.ckbParasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ckbCilin);
            this.Controls.Add(this.ckbLeuco);
            this.Controls.Add(this.ckbEritro);
            this.Controls.Add(this.ckbCereos);
            this.Controls.Add(this.ckbHialino);
            this.Controls.Add(this.ckbGranuloso);
            this.Controls.Add(this.ckbOxcal);
            this.Controls.Add(this.ckbFosftri);
            this.Controls.Add(this.ckbAciuri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbBAC);
            this.Controls.Add(this.txbHEM);
            this.Controls.Add(this.txbLEUC);
            this.Controls.Add(this.txbCELS);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.txbOutrosCristais);
            this.Controls.Add(this.txbRaca);
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
            this.Name = "UriSed";
            this.Text = "UriSed";
            this.Load += new System.EventHandler(this.UriSed_Load);
            this.Click += new System.EventHandler(this.Label1_Click);
            this.DoubleClick += new System.EventHandler(this.Label3_Click);
            ((System.ComponentModel.ISupportInitialize)(this.urisedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txbOutrosCristais;
        internal System.Windows.Forms.TextBox txbRaca;
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
        internal System.Windows.Forms.TextBox txbBAC;
        internal System.Windows.Forms.TextBox txbHEM;
        internal System.Windows.Forms.TextBox txbLEUC;
        internal System.Windows.Forms.TextBox txbCELS;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbAciuri;
        private System.Windows.Forms.CheckBox ckbFosftri;
        private System.Windows.Forms.CheckBox ckbOxcal;
        private System.Windows.Forms.CheckBox ckbGranuloso;
        private System.Windows.Forms.CheckBox ckbHialino;
        private System.Windows.Forms.CheckBox ckbCereos;
        private System.Windows.Forms.CheckBox ckbEritro;
        private System.Windows.Forms.CheckBox ckbLeuco;
        private System.Windows.Forms.CheckBox ckbCilin;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbLeved;
        private System.Windows.Forms.CheckBox ckbParasi;
        private System.Windows.Forms.CheckBox ckbOutrosMuco;
        private System.Windows.Forms.CheckBox ckbOutrosCristais;
        private System.Windows.Forms.CheckBox ckbOutrosCilindros;
        internal System.Windows.Forms.TextBox txbOutrosCilindros;
        internal System.Windows.Forms.TextBox txbOutrosMuco;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource urisedBindingSource;
        private Conexões.TestePimDataSetTableAdapters.urisedTableAdapter urisedTableAdapter;
    }
}