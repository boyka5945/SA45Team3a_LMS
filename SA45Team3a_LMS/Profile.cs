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
    public partial class Profile : Form
    {
        Entities context;
        public Profile()
        {
            context = new Entities();
            InitializeComponent();
        }

        public string text_UserID
        {
            get
            {
                return textBox_UserID.Text;
            }
            set
            {
                textBox_UserID.Text = value;
            }
        }

        public string text_PassWord
        {
            get
            {
                return textBox_PassWord.Text;
            }
            set
            {
                textBox_PassWord.Text = value;
            }
        }

        public string text_Email
        {
            get
            {
                return textBox_Email.Text;
            }
            set
            {
                textBox_Email.Text = value;
            }
        }

        public string text_Contact
        {
            get
            {
                return textBox_Contact.Text;
            }
            set
            {
                textBox_Contact.Text = value;
            }
        }

        public string text_Address
        {
            get
            {
                return textBox_Address.Text;
            }
            set
            {
                textBox_Address.Text = value;
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                Member m = context.Members.Where(x => x.UserID == UserID.Userid).First();
                m.UserID = text_UserID;
                m.Contact = Convert.ToInt32(text_Contact);
                m.Email = text_Email;
                m.Addresses = text_Address;
                context.SaveChanges();
                ts.Complete();
            }
        }
    }
}
