namespace SA45Team3a_LMS
{
    partial class CheckLoanStatus
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
            this.dataGridView_status = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_status)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_status
            // 
            this.dataGridView_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_status.Location = new System.Drawing.Point(13, 65);
            this.dataGridView_status.Name = "dataGridView_status";
            this.dataGridView_status.RowTemplate.Height = 23;
            this.dataGridView_status.Size = new System.Drawing.Size(560, 337);
            this.dataGridView_status.TabIndex = 0;
            // 
            // CheckLoanStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 414);
            this.Controls.Add(this.dataGridView_status);
            this.Name = "CheckLoanStatus";
            this.Text = "CheckLoanStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_status;
    }
}