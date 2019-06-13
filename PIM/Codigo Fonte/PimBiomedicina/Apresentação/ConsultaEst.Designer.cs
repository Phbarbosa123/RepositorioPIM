namespace PimBiomedicina.Modelo
{
    partial class ConsultaEst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEst));
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnconcpf = new System.Windows.Forms.Button();
            this.btnconnome = new System.Windows.Forms.Button();
            this.txtconra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testePimDataSet = new PimBiomedicina.Conexões.TestePimDataSet();
            this.estagiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estagiarioTableAdapter = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.estagiarioTableAdapter();
            this.tableAdapterManager = new PimBiomedicina.Conexões.TestePimDataSetTableAdapters.TableAdapterManager();
            this.nomeestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estagiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(101, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(287, 31);
            this.label15.TabIndex = 51;
            this.label15.Text = "Consulta de Estagiário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeestDataGridViewTextBoxColumn,
            this.raDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estagiarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(420, 204);
            this.dataGridView1.TabIndex = 58;
            // 
            // btnconcpf
            // 
            this.btnconcpf.Image = global::PimBiomedicina.Properties.Resources.zoom;
            this.btnconcpf.Location = new System.Drawing.Point(391, 119);
            this.btnconcpf.Name = "btnconcpf";
            this.btnconcpf.Size = new System.Drawing.Size(33, 25);
            this.btnconcpf.TabIndex = 57;
            this.btnconcpf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconcpf.UseVisualStyleBackColor = true;
            // 
            // btnconnome
            // 
            this.btnconnome.Image = global::PimBiomedicina.Properties.Resources.zoom;
            this.btnconnome.Location = new System.Drawing.Point(391, 67);
            this.btnconnome.Name = "btnconnome";
            this.btnconnome.Size = new System.Drawing.Size(33, 25);
            this.btnconnome.TabIndex = 56;
            this.btnconnome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconnome.UseVisualStyleBackColor = true;
            // 
            // txtconra
            // 
            this.txtconra.Location = new System.Drawing.Point(183, 119);
            this.txtconra.Name = "txtconra";
            this.txtconra.Size = new System.Drawing.Size(182, 20);
            this.txtconra.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(79, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Consulta por RA:";
            // 
            // txtconnome
            // 
            this.txtconnome.Location = new System.Drawing.Point(183, 70);
            this.txtconnome.Name = "txtconnome";
            this.txtconnome.Size = new System.Drawing.Size(182, 20);
            this.txtconnome.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Consulta por nome:";
            // 
            // testePimDataSet
            // 
            this.testePimDataSet.DataSetName = "TestePimDataSet";
            this.testePimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estagiarioBindingSource
            // 
            this.estagiarioBindingSource.DataMember = "estagiario";
            this.estagiarioBindingSource.DataSource = this.testePimDataSet;
            // 
            // estagiarioTableAdapter
            // 
            this.estagiarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bioquimicaTableAdapter = null;
            this.tableAdapterManager.estagiarioTableAdapter = this.estagiarioTableAdapter;
            this.tableAdapterManager.hematologiaTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.microbiologiaTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PimBiomedicina.Conexões.TestePimDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urifisTableAdapter = null;
            this.tableAdapterManager.uriquiTableAdapter = null;
            this.tableAdapterManager.urisedTableAdapter = null;
            // 
            // nomeestDataGridViewTextBoxColumn
            // 
            this.nomeestDataGridViewTextBoxColumn.DataPropertyName = "nome_est";
            this.nomeestDataGridViewTextBoxColumn.HeaderText = "nome_est";
            this.nomeestDataGridViewTextBoxColumn.Name = "nomeestDataGridViewTextBoxColumn";
            this.nomeestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raDataGridViewTextBoxColumn
            // 
            this.raDataGridViewTextBoxColumn.DataPropertyName = "ra";
            this.raDataGridViewTextBoxColumn.HeaderText = "ra";
            this.raDataGridViewTextBoxColumn.Name = "raDataGridViewTextBoxColumn";
            this.raDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultaEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnconcpf);
            this.Controls.Add(this.btnconnome);
            this.Controls.Add(this.txtconra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "ConsultaEst";
            this.Text = "ConsultaEst";
            this.Load += new System.EventHandler(this.ConsultaEst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testePimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estagiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnconcpf;
        private System.Windows.Forms.Button btnconnome;
        private System.Windows.Forms.TextBox txtconra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconnome;
        private System.Windows.Forms.Label label1;
        private Conexões.TestePimDataSet testePimDataSet;
        private System.Windows.Forms.BindingSource estagiarioBindingSource;
        private Conexões.TestePimDataSetTableAdapters.estagiarioTableAdapter estagiarioTableAdapter;
        private Conexões.TestePimDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
    }
}