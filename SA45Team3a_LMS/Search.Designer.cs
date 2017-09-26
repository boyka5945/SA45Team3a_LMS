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
            this.label_Catagory = new System.Windows.Forms.Label();
            this.comboBox_Catagory = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sA45Team3aBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sA45Team3a = new SA45Team3a_LMS.SA45Team3a();
            this.label_KeyWord = new System.Windows.Forms.Label();
            this.textBox_KeyWord = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Borrow = new System.Windows.Forms.Button();
            this.button_Availability = new System.Windows.Forms.Button();
            this.booksTableAdapter = new SA45Team3a_LMS.SA45Team3aTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA45Team3aBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA45Team3a)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.AllowUserToAddRows = false;
            this.dataGridView_Books.AllowUserToDeleteRows = false;
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Location = new System.Drawing.Point(12, 68);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.ReadOnly = true;
            this.dataGridView_Books.RowTemplate.Height = 23;
            this.dataGridView_Books.Size = new System.Drawing.Size(605, 282);
            this.dataGridView_Books.TabIndex = 0;
            this.dataGridView_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Books_CellContentClick);
            // 
            // label_Catagory
            // 
            this.label_Catagory.AutoSize = true;
            this.label_Catagory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Catagory.Location = new System.Drawing.Point(13, 28);
            this.label_Catagory.Name = "label_Catagory";
            this.label_Catagory.Size = new System.Drawing.Size(63, 20);
            this.label_Catagory.TabIndex = 1;
            this.label_Catagory.Text = "Category";
            // 
            // comboBox_Catagory
            // 
            this.comboBox_Catagory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Catagory.FormattingEnabled = true;
            this.comboBox_Catagory.Items.AddRange(new object[] {
            "NULL"});
            this.comboBox_Catagory.Location = new System.Drawing.Point(82, 25);
            this.comboBox_Catagory.Name = "comboBox_Catagory";
            this.comboBox_Catagory.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Catagory.TabIndex = 2;
            this.comboBox_Catagory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.sA45Team3aBindingSource;
            // 
            // sA45Team3aBindingSource
            // 
            this.sA45Team3aBindingSource.DataSource = this.sA45Team3a;
            this.sA45Team3aBindingSource.Position = 0;
            // 
            // sA45Team3a
            // 
            this.sA45Team3a.DataSetName = "SA45Team3a";
            this.sA45Team3a.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_KeyWord
            // 
            this.label_KeyWord.AutoSize = true;
            this.label_KeyWord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KeyWord.Location = new System.Drawing.Point(254, 28);
            this.label_KeyWord.Name = "label_KeyWord";
            this.label_KeyWord.Size = new System.Drawing.Size(62, 20);
            this.label_KeyWord.TabIndex = 3;
            this.label_KeyWord.Text = "Keyword";
            // 
            // textBox_KeyWord
            // 
            this.textBox_KeyWord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_KeyWord.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_KeyWord.Location = new System.Drawing.Point(322, 25);
            this.textBox_KeyWord.Name = "textBox_KeyWord";
            this.textBox_KeyWord.Size = new System.Drawing.Size(237, 26);
            this.textBox_KeyWord.TabIndex = 4;
            this.textBox_KeyWord.Text = "bookname/author/publishername/ISBN";
            this.textBox_KeyWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowBooks);
            this.textBox_KeyWord.TextChanged += new System.EventHandler(this.textBox_KeyWord_TextChanged);
            // 
            // button_Search
            // 
            this.button_Search.AutoSize = true;
            this.button_Search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(563, 23);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(61, 30);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Borrow
            // 
            this.button_Borrow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Borrow.Location = new System.Drawing.Point(258, 356);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(129, 36);
            this.button_Borrow.TabIndex = 6;
            this.button_Borrow.Text = "Borrow";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // button_Availability
            // 
            this.button_Availability.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Availability.Location = new System.Drawing.Point(258, 356);
            this.button_Availability.Name = "button_Availability";
            this.button_Availability.Size = new System.Drawing.Size(129, 36);
            this.button_Availability.TabIndex = 7;
            this.button_Availability.Text = "Availibility";
            this.button_Availability.UseVisualStyleBackColor = true;
            this.button_Availability.Click += new System.EventHandler(this.button_CheckStatus_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 412);
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
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA45Team3aBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA45Team3a)).EndInit();
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
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.Button button_Availability;
        private System.Windows.Forms.BindingSource sA45Team3aBindingSource;
        private SA45Team3a sA45Team3a;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private SA45Team3aTableAdapters.BooksTableAdapter booksTableAdapter;
    }
}