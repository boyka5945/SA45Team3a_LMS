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

        public string text_Box1
        {
            get
            {
                return textBox1.ToString();
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public string text_Box2
        {
            get
            {
                return textBox2.ToString();
            }
            set
            {
                textBox2.Text = value;
            }
        }

        public string text_Box3
        {
            get
            {
                return textBox3.ToString();
            }
            set
            {
                textBox3.Text = value;
            }
        }

        public string text_Box4
        {
            get
            {
                return textBox4.ToString();
            }
            set
            {
                textBox4.Text = value;
            }
        }

        public string text_Box5
        {
            get
            {
                return textBox5.ToString();
            }
            set
            {
                textBox5.Text = value;
            }
        }

        public string text_Box6
        {
            get
            {
                return textBox6.ToString();
            }
            set
            {
                textBox6.Text = value;
            }
        }

        public string text_Box7
        {
            get
            {
                return textBox7.ToString();
            }
            set
            {
                textBox7.Text = value;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string Name = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberName.ToString();
            
            label9.Text = "Welcome " + Name;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile a = new EditProfile();
            a.textbox2 = textBox2.Text;
            a.textbox3 = textBox3.Text;
            a.textbox4 = textBox4.Text;
            a.textbox5 = textBox5.Text;
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
