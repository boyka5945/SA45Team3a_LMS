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
    public partial class LoanStatus : Form
    {
        Entities context;
        public LoanStatus()
        {
            context = new Entities();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int memberID = Convert.ToInt32(context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberID.ToString());
            var qry = from x in context.LoanRecords where(x.MemberID == memberID)select x;
            //List<LoanRecord> cLst = qry.ToList<LoanRecord>();
            dataGridView1.DataSource = qry.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = currentuser.Userid;
            string name = context.Members.Where(x => x.UserID == currentuser.Userid).First().MemberID.ToString();
            textBox2.Text = name;

        }
    }
}
