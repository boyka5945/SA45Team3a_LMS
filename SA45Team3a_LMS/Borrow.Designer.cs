namespace SA45Team3a_LMS
{
    partial class Borrow
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_TotalQty = new System.Windows.Forms.Label();
            this.label_DateBorrowed = new System.Windows.Forms.Label();
            this.label_DueDate = new System.Windows.Forms.Label();
            this.dateTimePicker_Borrowed = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.textBox_TotalQty = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.button_SelectUser = new System.Windows.Forms.Button();
            this.button_SelectBook = new System.Windows.Forms.Button();
            this.label_BorrowQty = new System.Windows.Forms.Label();
            this.textBox_BorrowQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Location = new System.Drawing.Point(125, 60);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(29, 12);
            this.label_ISBN.TabIndex = 1;
            this.label_ISBN.Text = "ISBN";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(125, 95);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(35, 12);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Title";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(125, 130);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(41, 12);
            this.label_Author.TabIndex = 3;
            this.label_Author.Text = "Author";
            // 
            // label_TotalQty
            // 
            this.label_TotalQty.AutoSize = true;
            this.label_TotalQty.Location = new System.Drawing.Point(125, 172);
            this.label_TotalQty.Name = "label_TotalQty";
            this.label_TotalQty.Size = new System.Drawing.Size(53, 12);
            this.label_TotalQty.TabIndex = 4;
            this.label_TotalQty.Text = "TotalQty";
            // 
            // label_DateBorrowed
            // 
            this.label_DateBorrowed.AutoSize = true;
            this.label_DateBorrowed.Location = new System.Drawing.Point(125, 263);
            this.label_DateBorrowed.Name = "label_DateBorrowed";
            this.label_DateBorrowed.Size = new System.Drawing.Size(77, 12);
            this.label_DateBorrowed.TabIndex = 5;
            this.label_DateBorrowed.Text = "DateBorrowed";
            // 
            // label_DueDate
            // 
            this.label_DueDate.AutoSize = true;
            this.label_DueDate.Location = new System.Drawing.Point(125, 309);
            this.label_DueDate.Name = "label_DueDate";
            this.label_DueDate.Size = new System.Drawing.Size(47, 12);
            this.label_DueDate.TabIndex = 6;
            this.label_DueDate.Text = "DueDate";
            // 
            // dateTimePicker_Borrowed
            // 
            this.dateTimePicker_Borrowed.Location = new System.Drawing.Point(222, 263);
            this.dateTimePicker_Borrowed.Name = "dateTimePicker_Borrowed";
            this.dateTimePicker_Borrowed.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Borrowed.TabIndex = 7;
            // 
            // dateTimePicker_Return
            // 
            this.dateTimePicker_Return.Location = new System.Drawing.Point(222, 309);
            this.dateTimePicker_Return.Name = "dateTimePicker_Return";
            this.dateTimePicker_Return.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Return.TabIndex = 8;
            // 
            // textBox_TotalQty
            // 
            this.textBox_TotalQty.Location = new System.Drawing.Point(222, 172);
            this.textBox_TotalQty.Name = "textBox_TotalQty";
            this.textBox_TotalQty.Size = new System.Drawing.Size(100, 21);
            this.textBox_TotalQty.TabIndex = 9;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(222, 130);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(100, 21);
            this.textBox_Author.TabIndex = 10;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(222, 92);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(100, 21);
            this.textBox_Title.TabIndex = 11;
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(222, 60);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(100, 21);
            this.textBox_ISBN.TabIndex = 12;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(127, 23);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(41, 12);
            this.label_UserID.TabIndex = 13;
            this.label_UserID.Text = "UserID";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(222, 23);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(100, 21);
            this.textBox_UserID.TabIndex = 14;
            // 
            // button_SelectUser
            // 
            this.button_SelectUser.Location = new System.Drawing.Point(329, 23);
            this.button_SelectUser.Name = "button_SelectUser";
            this.button_SelectUser.Size = new System.Drawing.Size(35, 21);
            this.button_SelectUser.TabIndex = 15;
            this.button_SelectUser.Text = "...";
            this.button_SelectUser.UseVisualStyleBackColor = true;
            this.button_SelectUser.Click += new System.EventHandler(this.button_SelectUser_Click);
            // 
            // button_SelectBook
            // 
            this.button_SelectBook.Location = new System.Drawing.Point(329, 60);
            this.button_SelectBook.Name = "button_SelectBook";
            this.button_SelectBook.Size = new System.Drawing.Size(35, 21);
            this.button_SelectBook.TabIndex = 16;
            this.button_SelectBook.Text = "...";
            this.button_SelectBook.UseVisualStyleBackColor = true;
            this.button_SelectBook.Click += new System.EventHandler(this.button_SelectBook_Click);
            // 
            // label_BorrowQty
            // 
            this.label_BorrowQty.AutoSize = true;
            this.label_BorrowQty.Location = new System.Drawing.Point(125, 219);
            this.label_BorrowQty.Name = "label_BorrowQty";
            this.label_BorrowQty.Size = new System.Drawing.Size(59, 12);
            this.label_BorrowQty.TabIndex = 17;
            this.label_BorrowQty.Text = "BorrowQty";
            // 
            // textBox_BorrowQty
            // 
            this.textBox_BorrowQty.Location = new System.Drawing.Point(222, 219);
            this.textBox_BorrowQty.Name = "textBox_BorrowQty";
            this.textBox_BorrowQty.Size = new System.Drawing.Size(100, 21);
            this.textBox_BorrowQty.TabIndex = 18;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 490);
            this.Controls.Add(this.textBox_BorrowQty);
            this.Controls.Add(this.label_BorrowQty);
            this.Controls.Add(this.button_SelectBook);
            this.Controls.Add(this.button_SelectUser);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_TotalQty);
            this.Controls.Add(this.dateTimePicker_Return);
            this.Controls.Add(this.dateTimePicker_Borrowed);
            this.Controls.Add(this.label_DueDate);
            this.Controls.Add(this.label_DateBorrowed);
            this.Controls.Add(this.label_TotalQty);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.button1);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_TotalQty;
        private System.Windows.Forms.Label label_DateBorrowed;
        private System.Windows.Forms.Label label_DueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Borrowed;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Return;
        private System.Windows.Forms.TextBox textBox_TotalQty;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Button button_SelectUser;
        private System.Windows.Forms.Button button_SelectBook;
        private System.Windows.Forms.Label label_BorrowQty;
        private System.Windows.Forms.TextBox textBox_BorrowQty;
    }
}