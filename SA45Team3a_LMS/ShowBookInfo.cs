using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team3a_LMS
{
    public partial class ShowBookInfo : Form
    {
        public ShowBookInfo()
        {
            InitializeComponent();
            Entities ctx = new Entities();
            var q = from x in ctx.Books
                    select new
                    {
                        x.ISBN,
                        x.Title,
                        x.Author,
                        x.PublisherName,
                        x.Category,
                        x.DatePublish,
                        x.TotalQty,
                        x.TotalOnLoan,
                        x.Remarks
                    };                    
            dataGridViewShowBookInfo.DataSource = q.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            BookInformation bi = (BookInformation)this.Owner;
            bi.cboISBN.Text = dataGridViewShowBookInfo.CurrentRow.Cells[0].Value.ToString();
            bi.txtTitle.Text = dataGridViewShowBookInfo.CurrentRow.Cells[1].Value.ToString();
            bi.txtAuthor.Text = dataGridViewShowBookInfo.CurrentRow.Cells[2].Value.ToString();
            bi.txtPublisherName.Text = dataGridViewShowBookInfo.CurrentRow.Cells[3].Value.ToString();
            bi.cboCategory.Text = dataGridViewShowBookInfo.CurrentRow.Cells[4].Value.ToString();
            bi.dateTimePicker1.Value = Convert.ToDateTime(dataGridViewShowBookInfo.CurrentRow.Cells[5].Value);
            bi.txtTotalQty.Text = dataGridViewShowBookInfo.CurrentRow.Cells[6].Value.ToString();
            bi.lblTotalOnLoan.Text = dataGridViewShowBookInfo.CurrentRow.Cells[7].Value.ToString();
            bi.txtRemark.Text = dataGridViewShowBookInfo.CurrentRow.Cells[8].Value.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
