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
        Entities context = new Entities();
        public ShowMembers()
        {
            InitializeComponent();
        }

        public DataGridView GetList
        {
            get
            {
                return dataGridView_MemberList;
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                for (int i = 0; i < context.Members.ToList().Count; i++)
                {

                    if (dataGridView_MemberList.Rows[i].Cells[2].Value != null)
                        context.Members.ToList()[i].Addresses = dataGridView_MemberList.Rows[i].Cells[2].Value.ToString();
                    if (dataGridView_MemberList.Rows[i].Cells[3].Value != null)
                        context.Members.ToList()[i].City = dataGridView_MemberList.Rows[i].Cells[3].Value.ToString();
                    if (dataGridView_MemberList.Rows[i].Cells[4].Value != null)
                        context.Members.ToList()[i].Contact = Convert.ToInt32(dataGridView_MemberList.Rows[i].Cells[4].Value);
                    if (dataGridView_MemberList.Rows[i].Cells[5].Value != null)
                        context.Members.ToList()[i].Age = Convert.ToInt32(dataGridView_MemberList.Rows[i].Cells[5].Value);
                    if (dataGridView_MemberList.Rows[i].Cells[6].Value != null)
                        context.Members.ToList()[i].Email = dataGridView_MemberList.Rows[i].Cells[6].Value.ToString();
                    if (dataGridView_MemberList.Rows[i].Cells[8].Value != null)
                        context.Members.ToList()[i].BooksBorrowed = Convert.ToInt32(dataGridView_MemberList.Rows[i].Cells[8].Value);
                    if (dataGridView_MemberList.Rows[i].Cells[11].Value != null)
                        context.Members.ToList()[i].Remarks = dataGridView_MemberList.Rows[i].Cells[11].Value.ToString();

                }

                context.SaveChanges();
                ts.Complete();
            }
        }
    }
}
