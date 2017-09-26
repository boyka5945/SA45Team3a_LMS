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
    public partial class LendBook : Form
    {
        public LendBook()
        {
            InitializeComponent();
           
        }

        private void LendBook_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today.AddDays(7);
            txtQuantityOfBook.Text = 1.ToString();
            cboMemberID.Text = "--Select ID--";            
            cboISBN.Text = "--Select ISBN--";
        }

        private void btnShowMember_Click(object sender, EventArgs e)
        {
            var showMembers = new ShowMembers();
            showMembers.Show(this);
        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
            var showBooks = new ShowBooks();
            showBooks.Show(this);
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            int mID = Convert.ToInt32(cboMemberID.Text);

            var q = from x in ctx.Members where x.MemberID == mID select x;
            if (!q.Any())
            {
                MessageBox.Show("It is invalid!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
            }
            else
            {
                Member m = q.First();
                txtMemberName.Text = m.MemberName;
                lblBookLent.Text = m.BooksBorrowed.ToString();
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            var q = from x in ctx.Books where x.ISBN == cboISBN.Text select x;
            if (!q.Any())
            {
                MessageBox.Show("It is invalid!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
            }
            else
            {
                Book b = q.First();
                txtTitle.Text = b.Title;
                int remained = Convert.ToInt32(b.TotalQty) - Convert.ToInt32(b.TotalOnLoan);
                lblBookRemained.Text = remained.ToString();
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);

            Entities ctx = new Entities();
            LoanRecord lr = new LoanRecord();
            if (dateTimePicker1.Value < System.DateTime.Today)
            {
                MessageBox.Show("Issue Date should not be past!",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
            }

            if (dateTimePicker1.Value > System.DateTime.Now)
            {
                MessageBox.Show("Issue Date should not be future!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboMemberID.Text == "--Select ID--" || cboISBN.Text == "--Select ISBN--")
            {
                MessageBox.Show("Select MemberID and ISBN!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
                return;
            }

            Entities ctx = new Entities();
            LoanRecord lr = new LoanRecord();

            string memberID = cboMemberID.Text;
            string isbn = cboISBN.Text;
            string issueDate = dateTimePicker1.Value.ToString();
            string dueDate = dateTimePicker2.Value.ToString();
            string qty = txtQuantityOfBook.Text;
            string remarks = txtRemarks.Text;

            lr.MemberID = Convert.ToInt32(memberID);
            lr.ISBN = isbn;
            lr.DateBorrowed = Convert.ToDateTime(issueDate);
            lr.DueDate = Convert.ToDateTime(dueDate);
            lr.Quantity = Convert.ToInt32(qty);
            lr.LoanStatus = "out";
            lr.Remarks = remarks;

            ctx.LoanRecords.Add(lr);

            Book b = ctx.Books.Where(x => x.ISBN == isbn).First();
            b.TotalOnLoan += Convert.ToInt32(qty);

            int mID = Convert.ToInt32(cboMemberID.Text);
            Member m = ctx.Members.Where(x => x.MemberID == mID).First();
            m.BooksBorrowed += Convert.ToInt32(qty);


            if (b.TotalQty < b.TotalOnLoan)
            {
                MessageBox.Show("There has no copy. It cannot be lent.");
                return;
            }


            if (lr.DateBorrowed > System.DateTime.Now)
            {
                MessageBox.Show("Issue Date should not be future!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
                return;
            }

            if (cboMemberID.Text == "--Select ID--" || cboISBN.Text == "--Select ISBN--")
            {
                MessageBox.Show("Select MemberID and ISBN!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
                return;
            }

            ctx.SaveChanges();
            MessageBox.Show("Record is saved.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMemberID.Text = "--Select ID--";
            txtMemberName.Text = "";
            lblBookLent.Text = "";
            cboISBN.Text = "--Select ISBN--";
            txtTitle.Text = "";
            lblBookRemained.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(7);
            txtQuantityOfBook.Text = 1.ToString();
            txtRemarks.Text = "";
        }

        private void cboMemberID_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            var q = from x in ctx.Members select x.MemberID;
            cboMemberID.DataSource = q.ToList();
        }

        private void cboISBN_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            var q = from x in ctx.Books select x.ISBN;
            cboISBN.DataSource = q.ToList();
        }
    }
}
