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
    public partial class BookInformation : Form
    {
        public BookInformation()
        {
            InitializeComponent();
        }

        private void cboISBN_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            var q = from x in ctx.Books select x.ISBN;
            cboISBN.DataSource = q.ToList();
        }

        private void cboCategory_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            var q = from x in ctx.Books select x.Category;
            cboCategory.DataSource = q.Distinct().ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var show = new ShowBookInfo();
            show.Show(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                txtAuthor.Text = b.Author;
                txtPublisherName.Text = b.PublisherName;
                cboCategory.Text = b.Category;
                dateTimePicker1.Value = b.DatePublish.Value;
                txtTotalQty.Text = b.TotalQty.ToString();
                lblTotalOnLoan.Text = b.TotalOnLoan.ToString();
                txtRemark.Text = b.Remarks;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            var q = from x in ctx.Books where x.ISBN == cboISBN.Text select x;
            if (!q.Any())
            {
                Book b = new Book();
                b.ISBN = cboISBN.Text;
                b.Title = txtTitle.Text;
                b.Author = txtAuthor.Text;
                b.PublisherName = txtPublisherName.Text;
                b.Category = cboCategory.Text;
                b.DatePublish = dateTimePicker1.Value.Date;
                b.TotalQty = Convert.ToInt32(txtTotalQty.Text);
                b.TotalOnLoan = 0;
                b.Remarks = txtRemark.Text;

                ctx.Books.Add(b);

                ctx.SaveChanges();
                MessageBox.Show("Saved Successfully.");
            }
            else
            {
                MessageBox.Show("This ISBN has already existed!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            var q = from x in ctx.Books where x.ISBN == cboISBN.Text select x;
            if (!q.Any())
            {
                MessageBox.Show("The record you want to update is not existed!!",
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
                b.Title = txtTitle.Text;
                b.Author = txtAuthor.Text;
                b.PublisherName = txtPublisherName.Text;
                b.Category = cboCategory.Text;
                b.DatePublish = dateTimePicker1.Value.Date;
                b.TotalQty = Convert.ToInt32(txtTotalQty.Text);
                b.TotalOnLoan = 0;
                b.Remarks = txtRemark.Text;

                ctx.SaveChanges();
                MessageBox.Show("Updated Successfully.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            var q = from x in ctx.Books where x.ISBN == cboISBN.Text select x;
            if (!q.Any())
            {
                MessageBox.Show("The record you want to delete is not existed!!",
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
                ctx.Books.Remove(b);

                ctx.SaveChanges();
                MessageBox.Show("Deleted Successfully.");
            }              
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboISBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisherName.Text = "";
            cboCategory.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            txtTotalQty.Text = "";
            lblTotalOnLoan.Text = 0.ToString();
            txtRemark.Text = "";
        }
    }
}
