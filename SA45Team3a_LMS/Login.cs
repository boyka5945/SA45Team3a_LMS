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
        Customer cus;
        Staffs stf;
        public Login()
        {
            context = new Entities();
            cus = new Customer();
            stf = new Staffs();
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
                    if (textbox_PassWord.Text == context.Members.Where(x => textbox_UserID.Text == x.UserID).First().PassWords)
                    {
                        UserID.Type = comboBox_type.Text;
                        UserID.Userid = textbox_UserID.Text;

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
                    if (textbox_PassWord.Text == context.Staffs.Where(x => textbox_UserID.Text == x.StaffID.ToString()).First().PassWords)
                    {
                        UserID.Type = comboBox_type.Text;
                        UserID.Userid = textbox_UserID.Text;

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
            searchForm.Get.Columns[0].Visible = false;
            searchForm.ShowDialog();
        }
    }

    public class UserID
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
