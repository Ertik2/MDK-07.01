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
            this.cookDataSet = new WindowsFormsApp1.CookDataSet();
            this.запрос1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос1TableAdapter = new WindowsFormsApp1.CookDataSetTableAdapters.Запрос1TableAdapter();
            this.названиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос2TableAdapter = new WindowsFormsApp1.CookDataSetTableAdapters.Запрос2TableAdapter();
            this.названиеБлюдаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорииПорцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос3TableAdapter = new WindowsFormsApp1.CookDataSetTableAdapters.Запрос3TableAdapter();
            this.названиеБлюдаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countКодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос4TableAdapter = new WindowsFormsApp1.CookDataSetTableAdapters.Запрос4TableAdapter();
            this.названиеБлюдаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.очередностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookDataSet)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(27, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 279);
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
            this.tabPage2.Size = new System.Drawing.Size(753, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запрос 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запросы";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(753, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запрос 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(753, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Запрос 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеБлюдаDataGridViewTextBoxColumn,
            this.названиеПродуктаDataGridViewTextBoxColumn,
            this.категорияПродуктаDataGridViewTextBoxColumn,
            this.рецептDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.запрос1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеБлюдаDataGridViewTextBoxColumn1,
            this.калорииПорцииDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.запрос2BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(747, 273);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеБлюдаDataGridViewTextBoxColumn2,
            this.countКодПродуктаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.запрос3BindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(753, 279);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеБлюдаDataGridViewTextBoxColumn3,
            this.очередностьDataGridViewTextBoxColumn,
            this.названиеПродуктаDataGridViewTextBoxColumn1,
            this.категорияБлюдаDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.запрос4BindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(753, 279);
            this.dataGridView4.TabIndex = 0;
            // 
            // cookDataSet
            // 
            this.cookDataSet.DataSetName = "CookDataSet";
            this.cookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запрос1BindingSource
            // 
            this.запрос1BindingSource.DataMember = "Запрос1";
            this.запрос1BindingSource.DataSource = this.cookDataSet;
            // 
            // запрос1TableAdapter
            // 
            this.запрос1TableAdapter.ClearBeforeFill = true;
            // 
            // названиеБлюдаDataGridViewTextBoxColumn
            // 
            this.названиеБлюдаDataGridViewTextBoxColumn.DataPropertyName = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn.HeaderText = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn.Name = "названиеБлюдаDataGridViewTextBoxColumn";
            // 
            // названиеПродуктаDataGridViewTextBoxColumn
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.Name = "названиеПродуктаDataGridViewTextBoxColumn";
            // 
            // категорияПродуктаDataGridViewTextBoxColumn
            // 
            this.категорияПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Категория продукта";
            this.категорияПродуктаDataGridViewTextBoxColumn.HeaderText = "Категория продукта";
            this.категорияПродуктаDataGridViewTextBoxColumn.Name = "категорияПродуктаDataGridViewTextBoxColumn";
            // 
            // рецептDataGridViewTextBoxColumn
            // 
            this.рецептDataGridViewTextBoxColumn.DataPropertyName = "Рецепт";
            this.рецептDataGridViewTextBoxColumn.HeaderText = "Рецепт";
            this.рецептDataGridViewTextBoxColumn.Name = "рецептDataGridViewTextBoxColumn";
            // 
            // запрос2BindingSource
            // 
            this.запрос2BindingSource.DataMember = "Запрос2";
            this.запрос2BindingSource.DataSource = this.cookDataSet;
            // 
            // запрос2TableAdapter
            // 
            this.запрос2TableAdapter.ClearBeforeFill = true;
            // 
            // названиеБлюдаDataGridViewTextBoxColumn1
            // 
            this.названиеБлюдаDataGridViewTextBoxColumn1.DataPropertyName = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn1.HeaderText = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn1.Name = "названиеБлюдаDataGridViewTextBoxColumn1";
            // 
            // калорииПорцииDataGridViewTextBoxColumn
            // 
            this.калорииПорцииDataGridViewTextBoxColumn.DataPropertyName = "Калории_Порции";
            this.калорииПорцииDataGridViewTextBoxColumn.HeaderText = "Калории_Порции";
            this.калорииПорцииDataGridViewTextBoxColumn.Name = "калорииПорцииDataGridViewTextBoxColumn";
            // 
            // запрос3BindingSource
            // 
            this.запрос3BindingSource.DataMember = "Запрос3";
            this.запрос3BindingSource.DataSource = this.cookDataSet;
            // 
            // запрос3TableAdapter
            // 
            this.запрос3TableAdapter.ClearBeforeFill = true;
            // 
            // названиеБлюдаDataGridViewTextBoxColumn2
            // 
            this.названиеБлюдаDataGridViewTextBoxColumn2.DataPropertyName = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn2.HeaderText = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn2.Name = "названиеБлюдаDataGridViewTextBoxColumn2";
            // 
            // countКодПродуктаDataGridViewTextBoxColumn
            // 
            this.countКодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Count-Код_Продукта";
            this.countКодПродуктаDataGridViewTextBoxColumn.HeaderText = "Count-Код_Продукта";
            this.countКодПродуктаDataGridViewTextBoxColumn.Name = "countКодПродуктаDataGridViewTextBoxColumn";
            // 
            // запрос4BindingSource
            // 
            this.запрос4BindingSource.DataMember = "Запрос4";
            this.запрос4BindingSource.DataSource = this.cookDataSet;
            // 
            // запрос4TableAdapter
            // 
            this.запрос4TableAdapter.ClearBeforeFill = true;
            // 
            // названиеБлюдаDataGridViewTextBoxColumn3
            // 
            this.названиеБлюдаDataGridViewTextBoxColumn3.DataPropertyName = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn3.HeaderText = "Название блюда";
            this.названиеБлюдаDataGridViewTextBoxColumn3.Name = "названиеБлюдаDataGridViewTextBoxColumn3";
            // 
            // очередностьDataGridViewTextBoxColumn
            // 
            this.очередностьDataGridViewTextBoxColumn.DataPropertyName = "Очередность";
            this.очередностьDataGridViewTextBoxColumn.HeaderText = "Очередность";
            this.очередностьDataGridViewTextBoxColumn.Name = "очередностьDataGridViewTextBoxColumn";
            // 
            // названиеПродуктаDataGridViewTextBoxColumn1
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn1.DataPropertyName = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn1.HeaderText = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn1.Name = "названиеПродуктаDataGridViewTextBoxColumn1";
            // 
            // категорияБлюдаDataGridViewTextBoxColumn
            // 
            this.категорияБлюдаDataGridViewTextBoxColumn.DataPropertyName = "Категория блюда";
            this.категорияБлюдаDataGridViewTextBoxColumn.HeaderText = "Категория блюда";
            this.категорияБлюдаDataGridViewTextBoxColumn.Name = "категорияБлюдаDataGridViewTextBoxColumn";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(31, 381);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 34);
            this.Back.TabIndex = 4;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(718, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back);
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
            ((System.ComponentModel.ISupportInitialize)(this.cookDataSet)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private CookDataSet cookDataSet;
        private System.Windows.Forms.BindingSource запрос1BindingSource;
        private CookDataSetTableAdapters.Запрос1TableAdapter запрос1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рецептDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource запрос2BindingSource;
        private CookDataSetTableAdapters.Запрос2TableAdapter запрос2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБлюдаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn калорииПорцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource запрос3BindingSource;
        private CookDataSetTableAdapters.Запрос3TableAdapter запрос3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБлюдаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countКодПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource запрос4BindingSource;
        private CookDataSetTableAdapters.Запрос4TableAdapter запрос4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБлюдаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn очередностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
    }
}