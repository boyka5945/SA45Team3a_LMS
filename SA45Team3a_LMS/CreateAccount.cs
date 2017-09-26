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
    public partial class CreateAccount : Form
    {
        Entities context;
        public CreateAccount()
        {
            context = new Entities();
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            int count = context.Members.Count();
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                Member m = new Member();

                m.UserID = textBox_UserID.Text;
                m.PassWord = textBox_PassWord.Text;
                m.MemberID = 1000 + count;
                m.Title = textBox_Title.Text;
                m.Contact = Convert.ToInt32(textBox_Contact.Text);

                context.Members.Add(m);
                context.SaveChanges();
                ts.Complete();
            }
            
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
