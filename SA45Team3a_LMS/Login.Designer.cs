namespace SA45Team3a_LMS
{
    partial class Login
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
            this.button_Login = new System.Windows.Forms.Button();
            this.label_UserID = new System.Windows.Forms.Label();
            this.textbox_UserID = new System.Windows.Forms.TextBox();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textbox_PassWord = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(229, 289);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(161, 112);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(41, 12);
            this.label_UserID.TabIndex = 1;
            this.label_UserID.Text = "UserID";
            // 
            // textbox_UserID
            // 
            this.textbox_UserID.Location = new System.Drawing.Point(218, 112);
            this.textbox_UserID.Name = "textbox_UserID";
            this.textbox_UserID.Size = new System.Drawing.Size(100, 21);
            this.textbox_UserID.TabIndex = 2;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(149, 179);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(53, 12);
            this.label_PassWord.TabIndex = 3;
            this.label_PassWord.Text = "PassWord";
            // 
            // textbox_PassWord
            // 
            this.textbox_PassWord.Location = new System.Drawing.Point(218, 176);
            this.textbox_PassWord.Name = "textbox_PassWord";
            this.textbox_PassWord.Size = new System.Drawing.Size(100, 21);
            this.textbox_PassWord.TabIndex = 4;
            this.textbox_PassWord.UseSystemPasswordChar = true;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(375, 66);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(117, 23);
            this.button_Create.TabIndex = 5;
            this.button_Create.Text = "Create an account";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(47, 66);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(161, 240);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(29, 12);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "type";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Member",
            "Staff"});
            this.comboBox_type.Location = new System.Drawing.Point(218, 237);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 20);
            this.comboBox_type.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 374);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textbox_PassWord);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.textbox_UserID);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.button_Login);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.TextBox textbox_UserID;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.TextBox textbox_PassWord;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.ComboBox comboBox_type;
    }
}

