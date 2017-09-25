namespace SA45Team3a_LMS
{
    partial class SelectMember
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
            this.dataGridView_listMember = new System.Windows.Forms.DataGridView();
            this.button_OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label_temp1 = new System.Windows.Forms.Label();
            this.label_Bool = new System.Windows.Forms.Label();
            this.label_temp2 = new System.Windows.Forms.Label();
            this.label_temp5 = new System.Windows.Forms.Label();
            this.label_temp4 = new System.Windows.Forms.Label();
            this.label_temp3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listMember
            // 
            this.dataGridView_listMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_listMember.Location = new System.Drawing.Point(12, 60);
            this.dataGridView_listMember.Name = "dataGridView_listMember";
            this.dataGridView_listMember.RowTemplate.Height = 23;
            this.dataGridView_listMember.Size = new System.Drawing.Size(597, 243);
            this.dataGridView_listMember.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(146, 323);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(351, 322);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label_temp1
            // 
            this.label_temp1.AutoSize = true;
            this.label_temp1.Location = new System.Drawing.Point(144, 9);
            this.label_temp1.Name = "label_temp1";
            this.label_temp1.Size = new System.Drawing.Size(35, 12);
            this.label_temp1.TabIndex = 3;
            this.label_temp1.Text = "label";
            this.label_temp1.Visible = false;
            this.label_temp1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Bool
            // 
            this.label_Bool.AutoSize = true;
            this.label_Bool.Location = new System.Drawing.Point(216, 8);
            this.label_Bool.Name = "label_Bool";
            this.label_Bool.Size = new System.Drawing.Size(41, 12);
            this.label_Bool.TabIndex = 4;
            this.label_Bool.Text = "label1";
            this.label_Bool.Visible = false;
            // 
            // label_temp2
            // 
            this.label_temp2.AutoSize = true;
            this.label_temp2.Location = new System.Drawing.Point(285, 8);
            this.label_temp2.Name = "label_temp2";
            this.label_temp2.Size = new System.Drawing.Size(41, 12);
            this.label_temp2.TabIndex = 5;
            this.label_temp2.Text = "label1";
            this.label_temp2.Visible = false;
            // 
            // label_temp5
            // 
            this.label_temp5.AutoSize = true;
            this.label_temp5.Location = new System.Drawing.Point(361, 10);
            this.label_temp5.Name = "label_temp5";
            this.label_temp5.Size = new System.Drawing.Size(41, 12);
            this.label_temp5.TabIndex = 6;
            this.label_temp5.Text = "label1";
            this.label_temp5.Visible = false;
            // 
            // label_temp4
            // 
            this.label_temp4.AutoSize = true;
            this.label_temp4.Location = new System.Drawing.Point(420, 8);
            this.label_temp4.Name = "label_temp4";
            this.label_temp4.Size = new System.Drawing.Size(41, 12);
            this.label_temp4.TabIndex = 7;
            this.label_temp4.Text = "label2";
            this.label_temp4.Visible = false;
            // 
            // label_temp3
            // 
            this.label_temp3.AutoSize = true;
            this.label_temp3.Location = new System.Drawing.Point(478, 7);
            this.label_temp3.Name = "label_temp3";
            this.label_temp3.Size = new System.Drawing.Size(41, 12);
            this.label_temp3.TabIndex = 8;
            this.label_temp3.Text = "label3";
            this.label_temp3.Visible = false;
            // 
            // SelectMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 367);
            this.Controls.Add(this.label_temp3);
            this.Controls.Add(this.label_temp4);
            this.Controls.Add(this.label_temp5);
            this.Controls.Add(this.label_temp2);
            this.Controls.Add(this.label_Bool);
            this.Controls.Add(this.label_temp1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.dataGridView_listMember);
            this.Name = "SelectMember";
            this.Text = "SelectMember";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listMember;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label_temp1;
        private System.Windows.Forms.Label label_Bool;
        private System.Windows.Forms.Label label_temp2;
        private System.Windows.Forms.Label label_temp5;
        private System.Windows.Forms.Label label_temp4;
        private System.Windows.Forms.Label label_temp3;
    }
}