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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        public string textbox2
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public string textbox3
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }
        public string textbox4
        {
            get
            {
                return textBox4.Text;
            }
            set
            {
                textBox4.Text = value;
            }
        }
        public string textbox5
        {
            get
            {
                return textBox5.Text;
            }
            set
            {
                textBox5.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities context = new Entities();
            Member a = context.Members.Where(x => x.UserID == currentuser.Userid).First();
            a.Addresses = textBox2.Text;
            a.City = textBox3.Text;
            a.Contact = Convert.ToInt32(textBox4.Text);
            a.Email = textBox5.Text;
            context.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
