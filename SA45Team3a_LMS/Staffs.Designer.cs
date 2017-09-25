namespace SA45Team3a_LMS
{
    partial class Staffs
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
            this.button_Borrow = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Books = new System.Windows.Forms.Button();
            this.button_Members = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Borrow
            // 
            this.button_Borrow.Location = new System.Drawing.Point(112, 70);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(75, 23);
            this.button_Borrow.TabIndex = 0;
            this.button_Borrow.Text = "Borrow";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(271, 70);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(85, 23);
            this.button_Return.TabIndex = 1;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Books
            // 
            this.button_Books.Location = new System.Drawing.Point(112, 125);
            this.button_Books.Name = "button_Books";
            this.button_Books.Size = new System.Drawing.Size(75, 23);
            this.button_Books.TabIndex = 2;
            this.button_Books.Text = "ShowBooks";
            this.button_Books.UseVisualStyleBackColor = true;
            this.button_Books.Click += new System.EventHandler(this.button_Books_Click);
            // 
            // button_Members
            // 
            this.button_Members.Location = new System.Drawing.Point(271, 125);
            this.button_Members.Name = "button_Members";
            this.button_Members.Size = new System.Drawing.Size(85, 23);
            this.button_Members.TabIndex = 3;
            this.button_Members.Text = "ShowMembers";
            this.button_Members.UseVisualStyleBackColor = true;
            this.button_Members.Click += new System.EventHandler(this.button_Members_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(185, 200);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // Staffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 454);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Members);
            this.Controls.Add(this.button_Books);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_Borrow);
            this.Name = "Staffs";
            this.Text = "Staffs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Books;
        private System.Windows.Forms.Button button_Members;
        private System.Windows.Forms.Button button_Search;
    }
}