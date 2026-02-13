namespace WindowsFormsApp1
{
    partial class Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._1_БиблеотекаDataSet2 = new WindowsFormsApp1._1_БиблеотекаDataSet2();
            this.историяВыдачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_выдачиTableAdapter = new WindowsFormsApp1._1_БиблеотекаDataSet2TableAdapters.История_выдачиTableAdapter();
            this.библеотекаDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_БиблеотекаDataSet1 = new WindowsFormsApp1._1_БиблеотекаDataSet1();
            this.библеотекаDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос1TableAdapter = new WindowsFormsApp1._1_БиблеотекаDataSet1TableAdapters.Запрос1TableAdapter();
            this.учетЧитателейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_читателейTableAdapter = new WindowsFormsApp1._1_БиблеотекаDataSet2TableAdapters.Учет_читателейTableAdapter();
            this.библеотекаDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Back2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.историяВыдачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетЧитателейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.библеотекаDataSet2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // _1_БиблеотекаDataSet2
            // 
            this._1_БиблеотекаDataSet2.DataSetName = "_1_БиблеотекаDataSet2";
            this._1_БиблеотекаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // историяВыдачиBindingSource
            // 
            this.историяВыдачиBindingSource.DataMember = "История выдачи";
            this.историяВыдачиBindingSource.DataSource = this._1_БиблеотекаDataSet2;
            // 
            // история_выдачиTableAdapter
            // 
            this.история_выдачиTableAdapter.ClearBeforeFill = true;
            // 
            // библеотекаDataSet2BindingSource
            // 
            this.библеотекаDataSet2BindingSource.DataSource = this._1_БиблеотекаDataSet2;
            this.библеотекаDataSet2BindingSource.Position = 0;
            // 
            // _1_БиблеотекаDataSet1
            // 
            this._1_БиблеотекаDataSet1.DataSetName = "_1_БиблеотекаDataSet1";
            this._1_БиблеотекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // библеотекаDataSet1BindingSource
            // 
            this.библеотекаDataSet1BindingSource.DataSource = this._1_БиблеотекаDataSet1;
            this.библеотекаDataSet1BindingSource.Position = 0;
            // 
            // запрос1BindingSource
            // 
            this.запрос1BindingSource.DataMember = "Запрос1";
            this.запрос1BindingSource.DataSource = this.библеотекаDataSet1BindingSource;
            // 
            // запрос1TableAdapter
            // 
            this.запрос1TableAdapter.ClearBeforeFill = true;
            // 
            // учетЧитателейBindingSource
            // 
            this.учетЧитателейBindingSource.DataMember = "Учет читателей";
            this.учетЧитателейBindingSource.DataSource = this._1_БиблеотекаDataSet2;
            // 
            // учет_читателейTableAdapter
            // 
            this.учет_читателейTableAdapter.ClearBeforeFill = true;
            // 
            // библеотекаDataSet2BindingSource1
            // 
            this.библеотекаDataSet2BindingSource1.DataSource = this._1_БиблеотекаDataSet2;
            this.библеотекаDataSet2BindingSource1.Position = 0;
            // 
            // Back2
            // 
            this.Back2.Location = new System.Drawing.Point(26, 368);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(131, 34);
            this.Back2.TabIndex = 4;
            this.Back2.Text = "Назад";
            this.Back2.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.историяВыдачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетЧитателейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _1_БиблеотекаDataSet2 _1_БиблеотекаDataSet2;
        private System.Windows.Forms.BindingSource историяВыдачиBindingSource;
        private _1_БиблеотекаDataSet2TableAdapters.История_выдачиTableAdapter история_выдачиTableAdapter;
        private System.Windows.Forms.BindingSource библеотекаDataSet2BindingSource;
        private System.Windows.Forms.BindingSource библеотекаDataSet1BindingSource;
        private _1_БиблеотекаDataSet1 _1_БиблеотекаDataSet1;
        private System.Windows.Forms.BindingSource запрос1BindingSource;
        private _1_БиблеотекаDataSet1TableAdapters.Запрос1TableAdapter запрос1TableAdapter;
        private System.Windows.Forms.BindingSource учетЧитателейBindingSource;
        private _1_БиблеотекаDataSet2TableAdapters.Учет_читателейTableAdapter учет_читателейTableAdapter;
        private System.Windows.Forms.BindingSource библеотекаDataSet2BindingSource1;
        private System.Windows.Forms.Button Back2;
    }
}