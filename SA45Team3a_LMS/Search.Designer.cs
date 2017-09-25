namespace SA45Team3a_LMS
{
    partial class Search
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
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label_Catagory = new System.Windows.Forms.Label();
            this.comboBox_Catagory = new System.Windows.Forms.ComboBox();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sA45team3aDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._SA45_team_3a_DataSet = new SA45Team3a_LMS._SA45_team_3a_DataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_KeyWord = new System.Windows.Forms.Label();
            this.textBox_KeyWord = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.booksTableAdapter = new SA45Team3a_LMS._SA45_team_3a_DataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button_Borrow = new System.Windows.Forms.Button();
            this.button_Availability = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA45team3aDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SA45_team_3a_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_Books.Location = new System.Drawing.Point(12, 68);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.RowTemplate.Height = 23;
            this.dataGridView_Books.Size = new System.Drawing.Size(605, 282);
            this.dataGridView_Books.TabIndex = 0;
            this.dataGridView_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Books_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label_Catagory
            // 
            this.label_Catagory.AutoSize = true;
            this.label_Catagory.Location = new System.Drawing.Point(13, 28);
            this.label_Catagory.Name = "label_Catagory";
            this.label_Catagory.Size = new System.Drawing.Size(53, 12);
            this.label_Catagory.TabIndex = 1;
            this.label_Catagory.Text = "Catagory";
            // 
            // comboBox_Catagory
            // 
            this.comboBox_Catagory.DataSource = this.booksBindingSource1;
            this.comboBox_Catagory.DisplayMember = "Category";
            this.comboBox_Catagory.FormattingEnabled = true;
            this.comboBox_Catagory.Location = new System.Drawing.Point(72, 25);
            this.comboBox_Catagory.Name = "comboBox_Catagory";
            this.comboBox_Catagory.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Catagory.TabIndex = 2;
            this.comboBox_Catagory.ValueMember = "Category";
            this.comboBox_Catagory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.sA45team3aDataSetBindingSource;
            // 
            // sA45team3aDataSetBindingSource
            // 
            this.sA45team3aDataSetBindingSource.DataSource = this._SA45_team_3a_DataSet;
            this.sA45team3aDataSetBindingSource.Position = 0;
            // 
            // _SA45_team_3a_DataSet
            // 
            this._SA45_team_3a_DataSet.DataSetName = "_SA45_team_3a_DataSet";
            this._SA45_team_3a_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.sA45team3aDataSetBindingSource;
            // 
            // label_KeyWord
            // 
            this.label_KeyWord.AutoSize = true;
            this.label_KeyWord.Location = new System.Drawing.Point(251, 28);
            this.label_KeyWord.Name = "label_KeyWord";
            this.label_KeyWord.Size = new System.Drawing.Size(47, 12);
            this.label_KeyWord.TabIndex = 3;
            this.label_KeyWord.Text = "KeyWord";
            // 
            // textBox_KeyWord
            // 
            this.textBox_KeyWord.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_KeyWord.Location = new System.Drawing.Point(304, 24);
            this.textBox_KeyWord.Name = "textBox_KeyWord";
            this.textBox_KeyWord.Size = new System.Drawing.Size(237, 21);
            this.textBox_KeyWord.TabIndex = 4;
            this.textBox_KeyWord.Text = "bookname/author/publishername/ISBN";
            this.textBox_KeyWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowBooks);
            this.textBox_KeyWord.TextChanged += new System.EventHandler(this.textBox_KeyWord_TextChanged);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(563, 23);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(54, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.sA45team3aDataSetBindingSource;
            // 
            // booksBindingSource3
            // 
            this.booksBindingSource3.DataMember = "Books";
            this.booksBindingSource3.DataSource = this.sA45team3aDataSetBindingSource;
            // 
            // button_Borrow
            // 
            this.button_Borrow.Location = new System.Drawing.Point(223, 356);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(75, 23);
            this.button_Borrow.TabIndex = 6;
            this.button_Borrow.Text = "Borrow";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // button_Availability
            // 
            this.button_Availability.Location = new System.Drawing.Point(330, 356);
            this.button_Availability.Name = "button_Availability";
            this.button_Availability.Size = new System.Drawing.Size(129, 36);
            this.button_Availability.TabIndex = 7;
            this.button_Availability.Text = "Availibility";
            this.button_Availability.UseVisualStyleBackColor = true;
            this.button_Availability.Click += new System.EventHandler(this.button_CheckStatus_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 404);
            this.Controls.Add(this.button_Availability);
            this.Controls.Add(this.button_Borrow);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_KeyWord);
            this.Controls.Add(this.label_KeyWord);
            this.Controls.Add(this.comboBox_Catagory);
            this.Controls.Add(this.label_Catagory);
            this.Controls.Add(this.dataGridView_Books);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Togray);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA45team3aDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SA45_team_3a_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Books;
        private System.Windows.Forms.Label label_Catagory;
        private System.Windows.Forms.ComboBox comboBox_Catagory;
        private System.Windows.Forms.Label label_KeyWord;
        private System.Windows.Forms.TextBox textBox_KeyWord;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.BindingSource sA45team3aDataSetBindingSource;
        private _SA45_team_3a_DataSet _SA45_team_3a_DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private _SA45_team_3a_DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.BindingSource booksBindingSource3;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button button_Availability;
    }
}