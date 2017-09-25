namespace SA45Team3a_LMS
{
    partial class Customer
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
            this.button_search = new System.Windows.Forms.Button();
            this.button_Status = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(241, 82);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_Status
            // 
            this.button_Status.Location = new System.Drawing.Point(241, 153);
            this.button_Status.Name = "button_Status";
            this.button_Status.Size = new System.Drawing.Size(114, 23);
            this.button_Status.TabIndex = 1;
            this.button_Status.Text = "loan status";
            this.button_Status.UseVisualStyleBackColor = true;
            this.button_Status.Click += new System.EventHandler(this.button_Status_Click);
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(241, 240);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(75, 23);
            this.button_profile.TabIndex = 2;
            this.button_profile.Text = "profile";
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 400);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_Status);
            this.Controls.Add(this.button_search);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Status;
        private System.Windows.Forms.Button button_profile;
    }
}