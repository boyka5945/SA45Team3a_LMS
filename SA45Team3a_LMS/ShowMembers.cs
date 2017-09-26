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
    public partial class ShowMembers : Form
    {
        public ShowMembers()
        {
            InitializeComponent();
            Entities ctx = new Entities();
            var q = from x in ctx.Members
                    select new { x.MemberID, x.MemberName, x.Age, x.Email, x.BooksBorrowed};
            dataGridViewShowMembers.DataSource = q.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LendBook lb = (LendBook)this.Owner;
            lb.cboMemberID.Text = dataGridViewShowMembers.CurrentRow.Cells[0].Value.ToString();
            lb.txtMemberName.Text = dataGridViewShowMembers.CurrentRow.Cells[1].Value.ToString();
            lb.lblBookLent.Text = dataGridViewShowMembers.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
