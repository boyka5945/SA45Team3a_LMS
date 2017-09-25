namespace SA45Team3a_LMS
{
    partial class Return
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
            this.button_Return = new System.Windows.Forms.Button();
            this.label_LoanNumber = new System.Windows.Forms.Label();
            this.textBox_LoanNumber = new System.Windows.Forms.TextBox();
            this.label_Qty = new System.Windows.Forms.Label();
            this.textBox_Qty = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(233, 286);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(75, 23);
            this.button_Return.TabIndex = 0;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label_LoanNumber
            // 
            this.label_LoanNumber.AutoSize = true;
            this.label_LoanNumber.Location = new System.Drawing.Point(137, 82);
            this.label_LoanNumber.Name = "label_LoanNumber";
            this.label_LoanNumber.Size = new System.Drawing.Size(65, 12);
            this.label_LoanNumber.TabIndex = 3;
            this.label_LoanNumber.Text = "LoanNumber";
            // 
            // textBox_LoanNumber
            // 
            this.textBox_LoanNumber.Location = new System.Drawing.Point(208, 79);
            this.textBox_LoanNumber.Name = "textBox_LoanNumber";
            this.textBox_LoanNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_LoanNumber.TabIndex = 4;
            // 
            // label_Qty
            // 
            this.label_Qty.AutoSize = true;
            this.label_Qty.Location = new System.Drawing.Point(145, 129);
            this.label_Qty.Name = "label_Qty";
            this.label_Qty.Size = new System.Drawing.Size(23, 12);
            this.label_Qty.TabIndex = 5;
            this.label_Qty.Text = "Qty";
            // 
            // textBox_Qty
            // 
            this.textBox_Qty.Location = new System.Drawing.Point(208, 126);
            this.textBox_Qty.Name = "textBox_Qty";
            this.textBox_Qty.Size = new System.Drawing.Size(100, 21);
            this.textBox_Qty.TabIndex = 6;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(208, 180);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Date.TabIndex = 7;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(145, 180);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(29, 12);
            this.label_Date.TabIndex = 8;
            this.label_Date.Text = "Date";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 405);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.textBox_Qty);
            this.Controls.Add(this.label_Qty);
            this.Controls.Add(this.textBox_LoanNumber);
            this.Controls.Add(this.label_LoanNumber);
            this.Controls.Add(this.button_Return);
            this.Name = "Return";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Label label_LoanNumber;
        private System.Windows.Forms.TextBox textBox_LoanNumber;
        private System.Windows.Forms.Label label_Qty;
        private System.Windows.Forms.TextBox textBox_Qty;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_Date;
    }
}