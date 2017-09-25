namespace SA45Team3a_LMS
{
    partial class Books
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
            this.dataGridView_BookList = new System.Windows.Forms.DataGridView();
            this.button_Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BookList
            // 
            this.dataGridView_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookList.Location = new System.Drawing.Point(13, 72);
            this.dataGridView_BookList.Name = "dataGridView_BookList";
            this.dataGridView_BookList.RowTemplate.Height = 23;
            this.dataGridView_BookList.Size = new System.Drawing.Size(596, 285);
            this.dataGridView_BookList.TabIndex = 0;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(276, 386);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 1;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 439);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.dataGridView_BookList);
            this.Name = "Books";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BookList;
        private System.Windows.Forms.Button button_Confirm;
    }
}