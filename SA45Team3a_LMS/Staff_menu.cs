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
    public partial class Staff_menu : Form
    {
        Entities context;
        public Staff_menu()
        {
            context = new Entities();
            InitializeComponent();
        }

        private void Member_menu_Load(object sender, EventArgs e)
        {
            int staffId = Convert.ToInt32(currentuser.Userid);
            string name = context.Staffs.Where(x => x.StaffID == staffId).First().StaffName.ToString();
            label2.Text = "Welcome " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintainMemberInformation form2 = new MaintainMemberInformation();
            //form2.txtMemberName.Text = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberName;
            //form2.tx = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberID.ToString();
            //form2.tx = currentuser.Type;
            //form2.txtAddress.Text = context.Members.Where(x => x.UserID == currentuser.Userid).First().Addresses;
            //form2.txtCity.Text = context.Members.Where(x => x.UserID == currentuser.Userid).First().City;
            //form2.txtContactNo.Text = context.Members.Where(x => x.UserID == currentuser.Userid).First().Contact.ToString();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookInformation form1 = new BookInformation();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string name = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberName.ToString();
            label2.Text = "Welcome " + name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Borrow.Visible = true;
            search.Availibility.Visible = false;
            search.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Return re = new Return();
            re.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LendBook lb = new LendBook();
            lb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
