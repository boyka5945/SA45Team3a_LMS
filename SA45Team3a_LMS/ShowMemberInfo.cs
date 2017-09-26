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
    public partial class ShowMemberInfo : Form
    {
        public ShowMemberInfo()
        {
            InitializeComponent();
            Entities ctx = new Entities();
            var q = from x in ctx.Members
                    select new
                    {
                        x.MemberID,
                        x.MemberName,
                        x.Title,
                        x.Age,
                        x.Addresses,
                        x.City,
                        x.Contact,
                        x.Email,
                        x.BooksBorrowed,
                        x.Remarks
                    };
            dataGridViewShowMemberInfo.DataSource = q.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Member b = new Member();
            MaintainMemberInformation mmi = (MaintainMemberInformation)this.Owner;
            mmi.cboMemberID.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[0].Value.ToString();
            mmi.txtMemberName.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[1].Value.ToString();
            mmi.txtTitle.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[2].Value.ToString();
            mmi.txtAge.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[3].Value.ToString();
            mmi.txtAddress.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[4].Value.ToString();
            mmi.txtCity.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[5].Value.ToString();
            mmi.txtContactNo.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[6].Value.ToString();
            mmi.txtEmail.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[7].Value.ToString();
            mmi.lblBorrowedBook.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[8].Value.ToString();
            mmi.txtRemark.Text = dataGridViewShowMemberInfo.CurrentRow.Cells[9].Value.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
