namespace SA45Team3a_LMS
{
    partial class CreateAccount
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
            this.label_UserID = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(156, 74);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(41, 12);
            this.label_UserID.TabIndex = 0;
            this.label_UserID.Text = "UserID";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(216, 309);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 1;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(216, 64);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(100, 21);
            this.textBox_UserID.TabIndex = 2;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(158, 111);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(53, 12);
            this.label_PassWord.TabIndex = 3;
            this.label_PassWord.Text = "PassWord";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(216, 111);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(100, 21);
            this.textBox_PassWord.TabIndex = 4;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(216, 156);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(158, 156);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 12);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Name";
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(216, 205);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(100, 21);
            this.textBox_Contact.TabIndex = 8;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(158, 205);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(47, 12);
            this.label_contact.TabIndex = 7;
            this.label_contact.Text = "Contact";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(216, 252);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(100, 21);
            this.textBox_Title.TabIndex = 10;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(158, 252);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(35, 12);
            this.label_Title.TabIndex = 9;
            this.label_Title.Text = "Title";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 375);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label_UserID);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Title;
    }
}