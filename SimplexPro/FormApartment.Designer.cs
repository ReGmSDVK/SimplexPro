namespace SimplexPro
{
    partial class FormApartment
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
            this.квартирыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.недвижимостьDataSet = new SimplexPro.НедвижимостьDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.retrBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.домаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.домаTableAdapter = new SimplexPro.НедвижимостьDataSetTableAdapters.ДомаTableAdapter();
            this.квартирыTableAdapter = new SimplexPro.НедвижимостьDataSetTableAdapters.КвартирыTableAdapter();
            this.квартирыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.квартирыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.кодКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комнатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.владелецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.домаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // квартирыBindingSource
            // 
            this.квартирыBindingSource.DataMember = "Квартиры";
            this.квартирыBindingSource.DataSource = this.недвижимостьDataSet;
            // 
            // недвижимостьDataSet
            // 
            this.недвижимостьDataSet.DataSetName = "НедвижимостьDataSet";
            this.недвижимостьDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(469, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(469, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 38);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(469, 178);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(273, 51);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Удалить запись";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            this.deleteBtn.MouseEnter += new System.EventHandler(this.deleteBtn_MouseEnter);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.deleteBtn_MouseLeave);
            // 
            // retrBtn
            // 
            this.retrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.retrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.retrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrBtn.ForeColor = System.Drawing.Color.White;
            this.retrBtn.Location = new System.Drawing.Point(469, 121);
            this.retrBtn.Name = "retrBtn";
            this.retrBtn.Size = new System.Drawing.Size(273, 51);
            this.retrBtn.TabIndex = 19;
            this.retrBtn.Text = "Обновить таблицу";
            this.retrBtn.UseVisualStyleBackColor = false;
            this.retrBtn.Click += new System.EventHandler(this.retrBtn_Click);
            this.retrBtn.MouseEnter += new System.EventHandler(this.retrBtn_MouseEnter);
            this.retrBtn.MouseLeave += new System.EventHandler(this.retrBtn_MouseLeave);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(469, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(273, 51);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseEnter += new System.EventHandler(this.addButton_MouseEnter);
            this.addButton.MouseLeave += new System.EventHandler(this.addButton_MouseLeave);
            // 
            // домаBindingSource
            // 
            this.домаBindingSource.DataMember = "Дома";
            this.домаBindingSource.DataSource = this.недвижимостьDataSet;
            // 
            // домаTableAdapter
            // 
            this.домаTableAdapter.ClearBeforeFill = true;
            // 
            // квартирыTableAdapter
            // 
            this.квартирыTableAdapter.ClearBeforeFill = true;
            // 
            // квартирыBindingSource1
            // 
            this.квартирыBindingSource1.DataMember = "Квартиры";
            this.квартирыBindingSource1.DataSource = this.недвижимостьDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКвартирыDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.комнатDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.серияDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.владелецDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.квартирыBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 479);
            this.dataGridView1.TabIndex = 23;
            // 
            // квартирыBindingSource2
            // 
            this.квартирыBindingSource2.DataMember = "Квартиры";
            this.квартирыBindingSource2.DataSource = this.недвижимостьDataSet;
            // 
            // кодКвартирыDataGridViewTextBoxColumn
            // 
            this.кодКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Код квартиры";
            this.кодКвартирыDataGridViewTextBoxColumn.HeaderText = "Код квартиры";
            this.кодКвартирыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКвартирыDataGridViewTextBoxColumn.Name = "кодКвартирыDataGridViewTextBoxColumn";
            this.кодКвартирыDataGridViewTextBoxColumn.Width = 125;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 125;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.Width = 125;
            // 
            // комнатDataGridViewTextBoxColumn
            // 
            this.комнатDataGridViewTextBoxColumn.DataPropertyName = "Комнат";
            this.комнатDataGridViewTextBoxColumn.HeaderText = "Комнат";
            this.комнатDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.комнатDataGridViewTextBoxColumn.Name = "комнатDataGridViewTextBoxColumn";
            this.комнатDataGridViewTextBoxColumn.Width = 125;
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            this.этажDataGridViewTextBoxColumn.Width = 125;
            // 
            // серияDataGridViewTextBoxColumn
            // 
            this.серияDataGridViewTextBoxColumn.DataPropertyName = "Серия";
            this.серияDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.серияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияDataGridViewTextBoxColumn.Name = "серияDataGridViewTextBoxColumn";
            this.серияDataGridViewTextBoxColumn.Width = 125;
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            this.площадьDataGridViewTextBoxColumn.Width = 125;
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            this.районDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.Width = 125;
            // 
            // владелецDataGridViewTextBoxColumn
            // 
            this.владелецDataGridViewTextBoxColumn.DataPropertyName = "Владелец";
            this.владелецDataGridViewTextBoxColumn.HeaderText = "Владелец";
            this.владелецDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.владелецDataGridViewTextBoxColumn.Name = "владелецDataGridViewTextBoxColumn";
            this.владелецDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(754, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.retrBtn);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApartment";
            this.Text = "FormApartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormApartment_FormClosing);
            this.Load += new System.EventHandler(this.FormApartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.домаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button retrBtn;
        private System.Windows.Forms.Button addButton;
        private НедвижимостьDataSet недвижимостьDataSet;
        private System.Windows.Forms.BindingSource домаBindingSource;
        private НедвижимостьDataSetTableAdapters.ДомаTableAdapter домаTableAdapter;
        private System.Windows.Forms.BindingSource квартирыBindingSource;
        private НедвижимостьDataSetTableAdapters.КвартирыTableAdapter квартирыTableAdapter;
        private System.Windows.Forms.BindingSource квартирыBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комнатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn владелецDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource квартирыBindingSource2;
    }
}