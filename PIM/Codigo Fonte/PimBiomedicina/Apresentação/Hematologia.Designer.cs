namespace PimBiomedicina.Apresentação
{
    partial class frmHematologia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHematologia));
            this.txtfalci = new System.Windows.Forms.TextBox();
            this.hematologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.txtvhs = new System.Windows.Forms.TextBox();
            this.txtrh = new System.Windows.Forms.TextBox();
            this.txtabo = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.txtoutras = new System.Windows.Forms.TextBox();
            this.txtmono = new System.Windows.Forms.TextBox();
            this.txtlinat = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.txtlintip = new System.Windows.Forms.TextBox();
            this.txtbaf = new System.Windows.Forms.TextBox();
            this.txteos = new System.Windows.Forms.TextBox();
            this.txtseg = new System.Windows.Forms.TextBox();
            this.txtbas = new System.Windows.Forms.TextBox();
            this.txtmet = new System.Windows.Forms.TextBox();
            this.txtmie = new System.Windows.Forms.TextBox();
            this.txtleuc = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtret = new System.Windows.Forms.TextBox();
            this.txtplaq = new System.Windows.Forms.TextBox();
            this.txtchcm = new System.Windows.Forms.TextBox();
            this.txthcm = new System.Windows.Forms.TextBox();
            this.txtvmc = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txthb = new System.Windows.Forms.TextBox();
            this.txterit = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.mskdata = new System.Windows.Forms.MaskedTextBox();
            this.txtresp = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.hematologiaTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.hematologiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hematologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfalci
            // 
            this.txtfalci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "falci", true));
            this.txtfalci.Location = new System.Drawing.Point(481, 298);
            this.txtfalci.Multiline = true;
            this.txtfalci.Name = "txtfalci";
            this.txtfalci.Size = new System.Drawing.Size(44, 20);
            this.txtfalci.TabIndex = 128;
            // 
            // hematologiaBindingSource
            // 
            this.hematologiaBindingSource.DataMember = "hematologia";
            this.hematologiaBindingSource.DataSource = this.testePimDataSet;
            // 
            // testePimDataSet
            // 
            this.testePimDataSet.DataSetName = "TestePimDataSet";
            this.testePimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtvhs
            // 
            this.txtvhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "vhs", true));
            this.txtvhs.Location = new System.Drawing.Point(415, 298);
            this.txtvhs.Multiline = true;
            this.txtvhs.Name = "txtvhs";
            this.txtvhs.Size = new System.Drawing.Size(44, 20);
            this.txtvhs.TabIndex = 127;
            // 
            // txtrh
            // 
            this.txtrh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "rh", true));
            this.txtrh.Location = new System.Drawing.Point(348, 298);
            this.txtrh.Multiline = true;
            this.txtrh.Name = "txtrh";
            this.txtrh.Size = new System.Drawing.Size(44, 20);
            this.txtrh.TabIndex = 126;
            // 
            // txtabo
            // 
            this.txtabo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "abo", true));
            this.txtabo.Location = new System.Drawing.Point(282, 298);
            this.txtabo.Multiline = true;
            this.txtabo.Name = "txtabo";
            this.txtabo.Size = new System.Drawing.Size(44, 20);
            this.txtabo.TabIndex = 125;
            // 
            // txtobs
            // 
            this.txtobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "obs", true));
            this.txtobs.Location = new System.Drawing.Point(217, 298);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(44, 20);
            this.txtobs.TabIndex = 124;
            // 
            // txtoutras
            // 
            this.txtoutras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "outras", true));
            this.txtoutras.Location = new System.Drawing.Point(151, 298);
            this.txtoutras.Multiline = true;
            this.txtoutras.Name = "txtoutras";
            this.txtoutras.Size = new System.Drawing.Size(44, 20);
            this.txtoutras.TabIndex = 123;
            // 
            // txtmono
            // 
            this.txtmono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "mono", true));
            this.txtmono.Location = new System.Drawing.Point(84, 298);
            this.txtmono.Multiline = true;
            this.txtmono.Name = "txtmono";
            this.txtmono.Size = new System.Drawing.Size(44, 20);
            this.txtmono.TabIndex = 122;
            // 
            // txtlinat
            // 
            this.txtlinat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "lint_at", true));
            this.txtlinat.Location = new System.Drawing.Point(18, 298);
            this.txtlinat.Multiline = true;
            this.txtlinat.Name = "txtlinat";
            this.txtlinat.Size = new System.Drawing.Size(44, 20);
            this.txtlinat.TabIndex = 121;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Location = new System.Drawing.Point(478, 282);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(36, 13);
            this.Label21.TabIndex = 120;
            this.Label21.Text = "FALCI";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.BackColor = System.Drawing.Color.Transparent;
            this.Label22.Location = new System.Drawing.Point(412, 282);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(29, 13);
            this.Label22.TabIndex = 119;
            this.Label22.Text = "VHS";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Location = new System.Drawing.Point(345, 282);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(23, 13);
            this.Label23.TabIndex = 118;
            this.Label23.Text = "RH";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Location = new System.Drawing.Point(281, 282);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(29, 13);
            this.Label24.TabIndex = 117;
            this.Label24.Text = "ABO";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.Color.Transparent;
            this.Label25.Location = new System.Drawing.Point(215, 282);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(29, 13);
            this.Label25.TabIndex = 116;
            this.Label25.Text = "OBS";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.BackColor = System.Drawing.Color.Transparent;
            this.Label26.Location = new System.Drawing.Point(150, 282);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(52, 13);
            this.Label26.TabIndex = 115;
            this.Label26.Text = "OUTRAS";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.BackColor = System.Drawing.Color.Transparent;
            this.Label27.Location = new System.Drawing.Point(83, 282);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(40, 13);
            this.Label27.TabIndex = 114;
            this.Label27.Text = "MONO";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.BackColor = System.Drawing.Color.Transparent;
            this.Label28.Location = new System.Drawing.Point(15, 282);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(48, 13);
            this.Label28.TabIndex = 113;
            this.Label28.Text = "LINT AT";
            // 
            // txtlintip
            // 
            this.txtlintip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "lin_tip", true));
            this.txtlintip.Location = new System.Drawing.Point(481, 233);
            this.txtlintip.Multiline = true;
            this.txtlintip.Name = "txtlintip";
            this.txtlintip.Size = new System.Drawing.Size(44, 20);
            this.txtlintip.TabIndex = 112;
            // 
            // txtbaf
            // 
            this.txtbaf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "baf", true));
            this.txtbaf.Location = new System.Drawing.Point(415, 233);
            this.txtbaf.Multiline = true;
            this.txtbaf.Name = "txtbaf";
            this.txtbaf.Size = new System.Drawing.Size(44, 20);
            this.txtbaf.TabIndex = 111;
            // 
            // txteos
            // 
            this.txteos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "eos", true));
            this.txteos.Location = new System.Drawing.Point(348, 233);
            this.txteos.Multiline = true;
            this.txteos.Name = "txteos";
            this.txteos.Size = new System.Drawing.Size(44, 20);
            this.txteos.TabIndex = 110;
            // 
            // txtseg
            // 
            this.txtseg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "seg", true));
            this.txtseg.Location = new System.Drawing.Point(282, 233);
            this.txtseg.Multiline = true;
            this.txtseg.Name = "txtseg";
            this.txtseg.Size = new System.Drawing.Size(44, 20);
            this.txtseg.TabIndex = 109;
            // 
            // txtbas
            // 
            this.txtbas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "bas", true));
            this.txtbas.Location = new System.Drawing.Point(217, 233);
            this.txtbas.Multiline = true;
            this.txtbas.Name = "txtbas";
            this.txtbas.Size = new System.Drawing.Size(44, 20);
            this.txtbas.TabIndex = 108;
            // 
            // txtmet
            // 
            this.txtmet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "met", true));
            this.txtmet.Location = new System.Drawing.Point(151, 233);
            this.txtmet.Multiline = true;
            this.txtmet.Name = "txtmet";
            this.txtmet.Size = new System.Drawing.Size(44, 20);
            this.txtmet.TabIndex = 107;
            // 
            // txtmie
            // 
            this.txtmie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "mie", true));
            this.txtmie.Location = new System.Drawing.Point(84, 233);
            this.txtmie.Multiline = true;
            this.txtmie.Name = "txtmie";
            this.txtmie.Size = new System.Drawing.Size(44, 20);
            this.txtmie.TabIndex = 106;
            // 
            // txtleuc
            // 
            this.txtleuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "leuc", true));
            this.txtleuc.Location = new System.Drawing.Point(18, 233);
            this.txtleuc.Multiline = true;
            this.txtleuc.Name = "txtleuc";
            this.txtleuc.Size = new System.Drawing.Size(44, 20);
            this.txtleuc.TabIndex = 105;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Location = new System.Drawing.Point(479, 217);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(44, 13);
            this.Label13.TabIndex = 104;
            this.Label13.Text = "LIN TIP";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Location = new System.Drawing.Point(418, 217);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(27, 13);
            this.Label14.TabIndex = 103;
            this.Label14.Text = "BAF";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Location = new System.Drawing.Point(345, 217);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(29, 13);
            this.Label15.TabIndex = 102;
            this.Label15.Text = "EOS";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(279, 217);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(29, 13);
            this.Label16.TabIndex = 101;
            this.Label16.Text = "SEG";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Location = new System.Drawing.Point(214, 217);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(28, 13);
            this.Label17.TabIndex = 100;
            this.Label17.Text = "BAS";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Location = new System.Drawing.Point(150, 217);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(30, 13);
            this.Label18.TabIndex = 99;
            this.Label18.Text = "MET";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Location = new System.Drawing.Point(83, 217);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(26, 13);
            this.Label19.TabIndex = 98;
            this.Label19.Text = "MIE";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Location = new System.Drawing.Point(15, 217);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(35, 13);
            this.Label20.TabIndex = 97;
            this.Label20.Text = "LEUC";
            // 
            // txtret
            // 
            this.txtret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "ret", true));
            this.txtret.Location = new System.Drawing.Point(481, 169);
            this.txtret.Multiline = true;
            this.txtret.Name = "txtret";
            this.txtret.Size = new System.Drawing.Size(44, 20);
            this.txtret.TabIndex = 96;
            // 
            // txtplaq
            // 
            this.txtplaq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "plaq", true));
            this.txtplaq.Location = new System.Drawing.Point(415, 169);
            this.txtplaq.Multiline = true;
            this.txtplaq.Name = "txtplaq";
            this.txtplaq.Size = new System.Drawing.Size(44, 20);
            this.txtplaq.TabIndex = 95;
            // 
            // txtchcm
            // 
            this.txtchcm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "chcm", true));
            this.txtchcm.Location = new System.Drawing.Point(348, 169);
            this.txtchcm.Multiline = true;
            this.txtchcm.Name = "txtchcm";
            this.txtchcm.Size = new System.Drawing.Size(44, 20);
            this.txtchcm.TabIndex = 94;
            // 
            // txthcm
            // 
            this.txthcm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "vmc", true));
            this.txthcm.Location = new System.Drawing.Point(282, 169);
            this.txthcm.Multiline = true;
            this.txthcm.Name = "txthcm";
            this.txthcm.Size = new System.Drawing.Size(44, 20);
            this.txthcm.TabIndex = 93;
            // 
            // txtvmc
            // 
            this.txtvmc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "vmc", true));
            this.txtvmc.Location = new System.Drawing.Point(217, 169);
            this.txtvmc.Multiline = true;
            this.txtvmc.Name = "txtvmc";
            this.txtvmc.Size = new System.Drawing.Size(44, 20);
            this.txtvmc.TabIndex = 92;
            // 
            // txtht
            // 
            this.txtht.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "ht", true));
            this.txtht.Location = new System.Drawing.Point(151, 169);
            this.txtht.Multiline = true;
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(44, 20);
            this.txtht.TabIndex = 91;
            // 
            // txthb
            // 
            this.txthb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "hb", true));
            this.txthb.Location = new System.Drawing.Point(84, 169);
            this.txthb.Multiline = true;
            this.txthb.Name = "txthb";
            this.txthb.Size = new System.Drawing.Size(44, 20);
            this.txthb.TabIndex = 90;
            // 
            // txterit
            // 
            this.txterit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "erit", true));
            this.txterit.Location = new System.Drawing.Point(18, 169);
            this.txterit.Multiline = true;
            this.txterit.Name = "txterit";
            this.txterit.Size = new System.Drawing.Size(44, 20);
            this.txterit.TabIndex = 89;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(478, 153);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(29, 13);
            this.Label11.TabIndex = 88;
            this.Label11.Text = "RET";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(412, 153);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(35, 13);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "PLAQ";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(345, 153);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(38, 13);
            this.Label9.TabIndex = 86;
            this.Label9.Text = "CHCM";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(279, 153);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(31, 13);
            this.Label10.TabIndex = 85;
            this.Label10.Text = "HCM";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Location = new System.Drawing.Point(214, 153);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 13);
            this.Label7.TabIndex = 84;
            this.Label7.Text = "VMC";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(150, 153);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(22, 13);
            this.Label8.TabIndex = 83;
            this.Label8.Text = "HT";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(83, 153);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(22, 13);
            this.Label5.TabIndex = 82;
            this.Label5.Text = "HB";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Location = new System.Drawing.Point(14, 153);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 81;
            this.Label6.Text = "ERIT";
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(117, 72);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(325, 20);
            this.txtnome.TabIndex = 78;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(186, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(166, 31);
            this.Label3.TabIndex = 77;
            this.Label3.Text = "Hematologia";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(73, 75);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 74;
            this.Label1.Text = "Nome:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(233, 371);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(85, 36);
            this.btnsalvar.TabIndex = 247;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // mskcpf
            // 
            this.mskcpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "cpf", true));
            this.mskcpf.Location = new System.Drawing.Point(225, 111);
            this.mskcpf.Mask = "000.000.000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(88, 20);
            this.mskcpf.TabIndex = 253;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Location = new System.Drawing.Point(189, 114);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(30, 13);
            this.Label29.TabIndex = 252;
            this.Label29.Text = "CPF:";
            // 
            // mskdata
            // 
            this.mskdata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "data", true));
            this.mskdata.Location = new System.Drawing.Point(117, 111);
            this.mskdata.Mask = "00/00/0000";
            this.mskdata.Name = "mskdata";
            this.mskdata.Size = new System.Drawing.Size(66, 20);
            this.mskdata.TabIndex = 251;
            this.mskdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtresp
            // 
            this.txtresp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hematologiaBindingSource, "responsavel", true));
            this.txtresp.Location = new System.Drawing.Point(362, 111);
            this.txtresp.Name = "txtresp";
            this.txtresp.Size = new System.Drawing.Size(79, 20);
            this.txtresp.TabIndex = 250;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(319, 114);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 13);
            this.Label4.TabIndex = 249;
            this.Label4.Text = "Resp.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(73, 114);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 248;
            this.Label2.Text = "Data:";
            // 
            // hematologiaTableAdapter
            // 
            this.hematologiaTableAdapter.ClearBeforeFill = true;
            // 
            // frmHematologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.mskdata);
            this.Controls.Add(this.txtresp);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtfalci);
            this.Controls.Add(this.txtvhs);
            this.Controls.Add(this.txtrh);
            this.Controls.Add(this.txtabo);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtoutras);
            this.Controls.Add(this.txtmono);
            this.Controls.Add(this.txtlinat);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label28);
            this.Controls.Add(this.txtlintip);
            this.Controls.Add(this.txtbaf);
            this.Controls.Add(this.txteos);
            this.Controls.Add(this.txtseg);
            this.Controls.Add(this.txtbas);
            this.Controls.Add(this.txtmet);
            this.Controls.Add(this.txtmie);
            this.Controls.Add(this.txtleuc);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.txtret);
            this.Controls.Add(this.txtplaq);
            this.Controls.Add(this.txtchcm);
            this.Controls.Add(this.txthcm);
            this.Controls.Add(this.txtvmc);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.txthb);
            this.Controls.Add(this.txterit);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "frmHematologia";
            this.Text = "Hematologia";
            this.Load += new System.EventHandler(this.frmHematologia_Load);
            this.Click += new System.EventHandler(this.Label1_Click);
            this.DoubleClick += new System.EventHandler(this.Label3_Click);
            ((System.ComponentModel.ISupportInitialize)(this.hematologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtfalci;
        internal System.Windows.Forms.TextBox txtvhs;
        internal System.Windows.Forms.TextBox txtrh;
        internal System.Windows.Forms.TextBox txtabo;
        internal System.Windows.Forms.TextBox txtobs;
        internal System.Windows.Forms.TextBox txtoutras;
        internal System.Windows.Forms.TextBox txtmono;
        internal System.Windows.Forms.TextBox txtlinat;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.TextBox txtlintip;
        internal System.Windows.Forms.TextBox txtbaf;
        internal System.Windows.Forms.TextBox txteos;
        internal System.Windows.Forms.TextBox txtseg;
        internal System.Windows.Forms.TextBox txtbas;
        internal System.Windows.Forms.TextBox txtmet;
        internal System.Windows.Forms.TextBox txtmie;
        internal System.Windows.Forms.TextBox txtleuc;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox txtret;
        internal System.Windows.Forms.TextBox txtplaq;
        internal System.Windows.Forms.TextBox txtchcm;
        internal System.Windows.Forms.TextBox txthcm;
        internal System.Windows.Forms.TextBox txtvmc;
        internal System.Windows.Forms.TextBox txtht;
        internal System.Windows.Forms.TextBox txthb;
        internal System.Windows.Forms.TextBox txterit;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtnome;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.MaskedTextBox mskdata;
        internal System.Windows.Forms.TextBox txtresp;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource hematologiaBindingSource;
        private Conexões.TestePimDataSetTableAdapters.hematologiaTableAdapter hematologiaTableAdapter;
    }
}