namespace WindowsFormsApp1
{
    partial class Form4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this._2_DataSet = new WindowsFormsApp1._2_DataSet();
            this.запрос1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос1TableAdapter = new WindowsFormsApp1._2_DataSetTableAdapters.Запрос1TableAdapter();
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос2TableAdapter = new WindowsFormsApp1._2_DataSetTableAdapters.Запрос2TableAdapter();
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос3TableAdapter = new WindowsFormsApp1._2_DataSetTableAdapters.Запрос3TableAdapter();
            this.улицаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос4TableAdapter = new WindowsFormsApp1._2_DataSetTableAdapters.Запрос4TableAdapter();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разницаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 289);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запрос 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запрос 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(334, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЗАПРОСЫ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запрос 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(744, 263);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Запрос 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.квартираDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.запрос1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.датаОплатыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.запрос2BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(738, 257);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.улицаDataGridViewTextBoxColumn1,
            this.countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.запрос3BindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(738, 257);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.разницаDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.запрос4BindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(738, 257);
            this.dataGridView4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(701, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(19, 382);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 34);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // _2_DataSet
            // 
            this._2_DataSet.DataSetName = "_2_DataSet";
            this._2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запрос1BindingSource
            // 
            this.запрос1BindingSource.DataMember = "Запрос1";
            this.запрос1BindingSource.DataSource = this._2_DataSet;
            // 
            // запрос1TableAdapter
            // 
            this.запрос1TableAdapter.ClearBeforeFill = true;
            // 
            // регистрационныйНомерАбонентаDataGridViewTextBoxColumn
            // 
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный номер абонента";
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn.HeaderText = "Регистрационный номер абонента";
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn.Name = "регистрационныйНомерАбонентаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            // 
            // квартираDataGridViewTextBoxColumn
            // 
            this.квартираDataGridViewTextBoxColumn.DataPropertyName = "Квартира";
            this.квартираDataGridViewTextBoxColumn.HeaderText = "Квартира";
            this.квартираDataGridViewTextBoxColumn.Name = "квартираDataGridViewTextBoxColumn";
            // 
            // запрос2BindingSource
            // 
            this.запрос2BindingSource.DataMember = "Запрос2";
            this.запрос2BindingSource.DataSource = this._2_DataSet;
            // 
            // запрос2TableAdapter
            // 
            this.запрос2TableAdapter.ClearBeforeFill = true;
            // 
            // регистрационныйНомерАбонентаDataGridViewTextBoxColumn1
            // 
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn1.DataPropertyName = "Регистрационный номер абонента";
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn1.HeaderText = "Регистрационный номер абонента";
            this.регистрационныйНомерАбонентаDataGridViewTextBoxColumn1.Name = "регистрационныйНомерАбонентаDataGridViewTextBoxColumn1";
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            // 
            // датаОплатыDataGridViewTextBoxColumn
            // 
            this.датаОплатыDataGridViewTextBoxColumn.DataPropertyName = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.Name = "датаОплатыDataGridViewTextBoxColumn";
            // 
            // запрос3BindingSource
            // 
            this.запрос3BindingSource.DataMember = "Запрос3";
            this.запрос3BindingSource.DataSource = this._2_DataSet;
            // 
            // запрос3TableAdapter
            // 
            this.запрос3TableAdapter.ClearBeforeFill = true;
            // 
            // улицаDataGridViewTextBoxColumn1
            // 
            this.улицаDataGridViewTextBoxColumn1.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn1.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn1.Name = "улицаDataGridViewTextBoxColumn1";
            // 
            // countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn
            // 
            this.countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn.DataPropertyName = "Count-Регистрационный номер абонента";
            this.countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn.HeaderText = "Count-Регистрационный номер абонента";
            this.countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn.Name = "countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn";
            // 
            // запрос4BindingSource
            // 
            this.запрос4BindingSource.DataMember = "Запрос4";
            this.запрос4BindingSource.DataSource = this._2_DataSet;
            // 
            // запрос4TableAdapter
            // 
            this.запрос4TableAdapter.ClearBeforeFill = true;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // разницаDataGridViewTextBoxColumn
            // 
            this.разницаDataGridViewTextBoxColumn.DataPropertyName = "Разница";
            this.разницаDataGridViewTextBoxColumn.HeaderText = "Разница";
            this.разницаDataGridViewTextBoxColumn.Name = "разницаDataGridViewTextBoxColumn";
            this.разницаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back;
        private _2_DataSet _2_DataSet;
        private System.Windows.Forms.BindingSource запрос1BindingSource;
        private _2_DataSetTableAdapters.Запрос1TableAdapter запрос1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйНомерАбонентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource запрос2BindingSource;
        private _2_DataSetTableAdapters.Запрос2TableAdapter запрос2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйНомерАбонентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource запрос3BindingSource;
        private _2_DataSetTableAdapters.Запрос3TableAdapter запрос3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countРегистрационныйНомерАбонентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource запрос4BindingSource;
        private _2_DataSetTableAdapters.Запрос4TableAdapter запрос4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разницаDataGridViewTextBoxColumn;
    }
}