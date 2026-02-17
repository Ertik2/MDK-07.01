namespace WindowsFormsApp1
{
    partial class Administrator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.учетВыдачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_БиблеотекаDataSet1 = new WindowsFormsApp1._1_БиблеотекаDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.примерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_БиблеотекаDataSet = new WindowsFormsApp1._1_БиблеотекаDataSet();
            this.библеотекаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.примерTableAdapter = new WindowsFormsApp1._1_БиблеотекаDataSet1TableAdapters.ПримерTableAdapter();
            this.учетКнигBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_книгTableAdapter = new WindowsFormsApp1._1_БиблеотекаDataSet1TableAdapters.Учет_книгTableAdapter();
            this.учет_выдачиTableAdapter = new WindowsFormsApp1._1_БиблеотекаDataSet1TableAdapters.Учет_выдачиTableAdapter();
            this.Update = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.библеотекаDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.примерBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._1_БиблеотекаDataSet2 = new WindowsFormsApp1._1_БиблеотекаDataSet2();
            this.библеотекаDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетВыдачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.примерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетКнигBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.примерBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.библеотекаDataSet2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // учетВыдачиBindingSource
            // 
            this.учетВыдачиBindingSource.DataMember = "Учет выдачи";
            this.учетВыдачиBindingSource.DataSource = this._1_БиблеотекаDataSet1;
            // 
            // _1_БиблеотекаDataSet1
            // 
            this._1_БиблеотекаDataSet1.DataSetName = "_1_БиблеотекаDataSet1";
            this._1_БиблеотекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(214, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "АДМИНИСТРАТОР";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // примерBindingSource
            // 
            this.примерBindingSource.DataMember = "Пример";
            this.примерBindingSource.DataSource = this._1_БиблеотекаDataSet1;
            // 
            // _1_БиблеотекаDataSet
            // 
            this._1_БиблеотекаDataSet.DataSetName = "_1_БиблеотекаDataSet";
            this._1_БиблеотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // библеотекаDataSetBindingSource
            // 
            this.библеотекаDataSetBindingSource.DataSource = this._1_БиблеотекаDataSet;
            this.библеотекаDataSetBindingSource.Position = 0;
            // 
            // примерTableAdapter
            // 
            this.примерTableAdapter.ClearBeforeFill = true;
            // 
            // учетКнигBindingSource
            // 
            this.учетКнигBindingSource.DataMember = "Учет книг";
            this.учетКнигBindingSource.DataSource = this._1_БиблеотекаDataSet1;
            // 
            // учет_книгTableAdapter
            // 
            this.учет_книгTableAdapter.ClearBeforeFill = true;
            // 
            // учет_выдачиTableAdapter
            // 
            this.учет_выдачиTableAdapter.ClearBeforeFill = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(619, 368);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(131, 34);
            this.Update.TabIndex = 2;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(28, 368);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 34);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // библеотекаDataSet1BindingSource
            // 
            this.библеотекаDataSet1BindingSource.DataSource = this._1_БиблеотекаDataSet1;
            this.библеотекаDataSet1BindingSource.Position = 0;
            // 
            // примерBindingSource1
            // 
            this.примерBindingSource1.DataMember = "Пример";
            this.примерBindingSource1.DataSource = this.библеотекаDataSet1BindingSource;
            // 
            // _1_БиблеотекаDataSet2
            // 
            this._1_БиблеотекаDataSet2.DataSetName = "_1_БиблеотекаDataSet2";
            this._1_БиблеотекаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // библеотекаDataSet2BindingSource
            // 
            this.библеотекаDataSet2BindingSource.DataSource = this._1_БиблеотекаDataSet2;
            this.библеотекаDataSet2BindingSource.Position = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетВыдачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.примерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетКнигBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.примерBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_БиблеотекаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библеотекаDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource библеотекаDataSetBindingSource;
        private _1_БиблеотекаDataSet _1_БиблеотекаDataSet;
        private _1_БиблеотекаDataSet1 _1_БиблеотекаDataSet1;
        private System.Windows.Forms.BindingSource примерBindingSource;
        private _1_БиблеотекаDataSet1TableAdapters.ПримерTableAdapter примерTableAdapter;
        private System.Windows.Forms.BindingSource учетКнигBindingSource;
        private _1_БиблеотекаDataSet1TableAdapters.Учет_книгTableAdapter учет_книгTableAdapter;
        private System.Windows.Forms.BindingSource учетВыдачиBindingSource;
        private _1_БиблеотекаDataSet1TableAdapters.Учет_выдачиTableAdapter учет_выдачиTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.BindingSource библеотекаDataSet1BindingSource;
        private System.Windows.Forms.BindingSource библеотекаDataSet2BindingSource;
        private _1_БиблеотекаDataSet2 _1_БиблеотекаDataSet2;
        private System.Windows.Forms.BindingSource примерBindingSource1;
    }
}

