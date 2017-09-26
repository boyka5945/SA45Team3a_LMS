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
    public partial class ShowBooks : Form
    {
        public ShowBooks()
        {
            InitializeComponent();
            Entities ctx = new Entities();
            var q = from x in ctx.Books
                    select new { x.ISBN, x.Title, x.Category, x.TotalQty, x.TotalOnLoan };
            dataGridViewShowBooks.DataSource = q.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            LendBook lb = (LendBook)this.Owner;
            lb.cboISBN.Text = dataGridViewShowBooks.CurrentRow.Cells[0].Value.ToString();
            lb.txtTitle.Text = dataGridViewShowBooks.CurrentRow.Cells[1].Value.ToString();
            string totalQty = dataGridViewShowBooks.CurrentRow.Cells[3].Value.ToString();
            string totalOnLoan = dataGridViewShowBooks.CurrentRow.Cells[4].Value.ToString();
            int remained = Convert.ToInt32(totalQty) - Convert.ToInt32(totalOnLoan);
            lb.lblBookRemained.Text = remained.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
