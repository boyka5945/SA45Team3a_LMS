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
    
    public partial class Customer : Form
    {
        Search search;
        Entities context;
        CheckLoanStatus status;
        Profile profile;
        public Customer()
        {
            status = new CheckLoanStatus();
            context = new Entities();
            profile = new Profile();
            search = new Search();
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (UserID.Type == "Member")
            {
                search.Borrow.Visible = false;
                //search.Get.Columns[0].Visible = false;
            }
            search.ShowDialog();
        }

        private void button_Status_Click(object sender, EventArgs e)
        {

            if (UserID.Type == "Member") {
                status.dataview.DataSource = context.LoanRecords.Where(x => x.Member.UserID == UserID.Userid).ToList();
            }

            status.ShowDialog();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            if (UserID.Type == "Member")
            {
                profile.text_UserID = context.Members.Where(x => x.UserID == UserID.Userid).First().UserID;
                profile.text_Address = context.Members.Where(x => x.UserID == UserID.Userid).First().Addresses;
                profile.text_Contact = context.Members.Where(x => x.UserID == UserID.Userid).First().Contact.ToString();
                profile.text_Email = context.Members.Where(x => x.UserID == UserID.Userid).First().Email;
                profile.text_PassWord = context.Members.Where(x => x.UserID == UserID.Userid).First().PassWords;
            }
            profile.ShowDialog();
        }
    }
}
