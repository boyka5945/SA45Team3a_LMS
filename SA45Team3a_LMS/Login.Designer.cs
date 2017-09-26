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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button_Login = new System.Windows.Forms.Button();
            this.label_UserID = new System.Windows.Forms.Label();
            this.textbox_UserID = new System.Windows.Forms.TextBox();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textbox_PassWord = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(168, 206);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(83, 32);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Log In";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.Location = new System.Drawing.Point(46, 84);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(49, 20);
            this.label_UserID.TabIndex = 1;
            this.label_UserID.Text = "UserID";
            // 
            // textbox_UserID
            // 
            this.textbox_UserID.Location = new System.Drawing.Point(147, 84);
            this.textbox_UserID.Name = "textbox_UserID";
            this.textbox_UserID.Size = new System.Drawing.Size(100, 21);
            this.textbox_UserID.TabIndex = 2;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PassWord.Location = new System.Drawing.Point(46, 127);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(68, 20);
            this.label_PassWord.TabIndex = 3;
            this.label_PassWord.Text = "Password";
            // 
            // textbox_PassWord
            // 
            this.textbox_PassWord.Location = new System.Drawing.Point(147, 124);
            this.textbox_PassWord.Name = "textbox_PassWord";
            this.textbox_PassWord.Size = new System.Drawing.Size(100, 21);
            this.textbox_PassWord.TabIndex = 4;
            this.textbox_PassWord.UseSystemPasswordChar = true;
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.Location = new System.Drawing.Point(37, 206);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(125, 32);
            this.button_Create.TabIndex = 5;
            this.button_Create.Text = "Create Account";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(45, 36);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(206, 30);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Search Catalogue";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(46, 170);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(71, 20);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "User Type";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Member",
            "Staff"});
            this.comboBox_type.Location = new System.Drawing.Point(147, 167);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(100, 20);
            this.comboBox_type.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(722, 485);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to Team3A Library Management System";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textbox_UserID);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.button_Create);
            this.panel1.Controls.Add(this.label_PassWord);
            this.panel1.Controls.Add(this.comboBox_type);
            this.panel1.Controls.Add(this.textbox_PassWord);
            this.panel1.Controls.Add(this.label_UserID);
            this.panel1.Controls.Add(this.button_Login);
            this.panel1.Controls.Add(this.label_type);
            this.panel1.Location = new System.Drawing.Point(205, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 291);
            this.panel1.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 485);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Login";
            this.Text = "SA45Team3A ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

