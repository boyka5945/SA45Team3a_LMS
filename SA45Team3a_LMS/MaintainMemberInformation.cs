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
    public partial class MaintainMemberInformation : Form
    {
        public MaintainMemberInformation()
        {
            InitializeComponent();
        }

        private void cboMemberID_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            var q = from x in ctx.Members select x.MemberID;
            cboMemberID.DataSource = q.ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var showMemberInfo = new ShowMemberInfo();
            showMemberInfo.Show(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();
            if (cboMemberID.Text == "--Select ID--")
            {
                MessageBox.Show("Select Member ID.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
            }
            else if (cboMemberID.Text == "")
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
                    txtTitle.Text = m.Title;
                    txtAge.Text = m.Age.ToString();
                    txtAddress.Text = m.Addresses;
                    txtCity.Text = m.City;
                    txtContactNo.Text = m.Contact.ToString();
                    txtEmail.Text = m.Email;
                    lblBorrowedBook.Text = m.BooksBorrowed.ToString();
                    txtRemark.Text = m.Remarks;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            int mID = Convert.ToInt32(cboMemberID.Text);
            var q = from x in ctx.Members where x.MemberID == mID select x;
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
                Member m = q.First();
                m.MemberName = txtMemberName.Text;
                m.Title = txtTitle.Text;
                m.Age = Convert.ToInt32(txtAge.Text);
                m.Addresses = txtAddress.Text;
                m.City = txtCity.Text;
                m.Contact = Convert.ToInt32(txtContactNo.Text);
                m.Email = txtEmail.Text;
                m.BooksBorrowed = Convert.ToInt32(lblBorrowedBook.Text);
                m.Remarks = txtRemark.Text;

                ctx.SaveChanges();
                MessageBox.Show("Updated Successfully.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            int mID = Convert.ToInt32(cboMemberID.Text);
            var q = from x in ctx.Members where x.MemberID == mID select x;
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
                Member m = q.First();
                ctx.Members.Remove(m);

                ctx.SaveChanges();
                MessageBox.Show("Deleted Successfully.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMemberID.Text = "--Select ID--";
            txtMemberName.Text ="";
            txtTitle.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            lblBorrowedBook.Text = "";
            txtRemark.Text = "";
        }
    }
}
