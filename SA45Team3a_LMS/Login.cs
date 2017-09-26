using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team3a_LMS
{

    public partial class Login : Form
    {
        Entities context;
        Member_menu cus;
        Staff_menu stf;
        public Login()
        {
            context = new Entities();
            cus = new Member_menu();
            stf = new Staff_menu();
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (comboBox_type.Text == "Member")
            {
                if (context.Members.Where(x => textbox_UserID.Text == x.UserID).Count() == 0)
                {
                    
                    MessageBox.Show("UserID is incorrect");
                }
                else
                {
                    if (textbox_PassWord.Text == context.Members.Where(x => textbox_UserID.Text == x.UserID).First().PassWord)
                    {
                        currentuser.Type = comboBox_type.Text;
                        currentuser.Userid = textbox_UserID.Text;

                        cus.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("PassWord is incorrect");
                    }
                }
            }
            else
            {
                if (context.Staffs.Where(x => textbox_UserID.Text == x.StaffID.ToString()).Count() == 0)
                {
                    MessageBox.Show("UserID is incorrect");
                }
                else
                {
                   
                    if (textbox_PassWord.Text == context.Staffs.Where(x => textbox_UserID.Text == x.StaffID.ToString()).First().PassWord)
                    {
                        currentuser.Type = comboBox_type.Text;
                        currentuser.Userid = textbox_UserID.Text;
                        
                        stf.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("PassWord is incorrect");
                    }
                }
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            CreateAccount createForm = new CreateAccount();
            createForm.ShowDialog();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Borrow.Visible = false;
            searchForm.Availibility.Visible = false;
            searchForm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

    public class currentuser
    {
        private static string Userid_string;

        public static string Userid
        {

            get
            {
                return Userid_string;
            }
            set
            {
                Userid_string = value;
            }

        }

        private static string type;

        public static string Type
        {

            get
            {
                return type;
            }
            set
            {
                type = value;
            }

        }
    }
}
