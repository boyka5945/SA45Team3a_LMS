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
    public partial class Member_menu : Form
    {
        Entities context;
        public Member_menu()
        {
            context = new Entities();
            InitializeComponent();
        }

        private void Member_menu_Load(object sender, EventArgs e)
        {
            string name = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberName.ToString();
            label2.Text = "Welcome " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile form2 = new Profile();
            form2.text_Box6 = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberName;
            form2.text_Box1 = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberID.ToString();
            form2.text_Box7 = currentuser.Type;
            form2.text_Box2 = context.Members.Where(x => x.UserID == currentuser.Userid).First().Addresses;
            form2.text_Box3 = context.Members.Where(x => x.UserID == currentuser.Userid).First().City;
            form2.text_Box4 = context.Members.Where(x => x.UserID == currentuser.Userid).First().Contact.ToString();
            form2.text_Box5 = context.Members.Where(x => x.UserID == currentuser.Userid).First().Email.ToString();

            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoanStatus form1 = new LoanStatus();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Borrow.Visible = false;
            search.Availibility.Visible = true;
            search.Get.Columns[0].Visible = true;
            search.Show();
        }
    }
}
