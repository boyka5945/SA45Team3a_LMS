namespace SA45Team3a_LMS
{
    partial class Profile
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
            this.label_UserId = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_UserId
            // 
            this.label_UserId.AutoSize = true;
            this.label_UserId.Location = new System.Drawing.Point(88, 76);
            this.label_UserId.Name = "label_UserId";
            this.label_UserId.Size = new System.Drawing.Size(41, 12);
            this.label_UserId.TabIndex = 0;
            this.label_UserId.Text = "UserID";
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Location = new System.Drawing.Point(90, 157);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(47, 12);
            this.label_Contact.TabIndex = 1;
            this.label_Contact.Text = "Contact";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(90, 192);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 12);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(145, 66);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(100, 21);
            this.textBox_UserID.TabIndex = 3;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(145, 148);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(100, 21);
            this.textBox_Contact.TabIndex = 4;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(145, 192);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 21);
            this.textBox_Email.TabIndex = 5;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(90, 237);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(47, 12);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(145, 227);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(100, 21);
            this.textBox_Address.TabIndex = 7;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(88, 108);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(53, 12);
            this.label_PassWord.TabIndex = 8;
            this.label_PassWord.Text = "PassWord";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(145, 105);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.ReadOnly = true;
            this.textBox_PassWord.Size = new System.Drawing.Size(100, 21);
            this.textBox_PassWord.TabIndex = 9;
            this.textBox_PassWord.UseSystemPasswordChar = true;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(247, 321);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 10;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 385);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.label_UserId);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserId;
        private System.Windows.Forms.Label label_Contact;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Button button_Confirm;
    }
}