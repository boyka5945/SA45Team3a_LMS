using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace SA45Team3a_LMS
{
    public partial class Return : Form
    {
        Entities ctx;
        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            ctx = new Entities();
            dataGridView1.DataSource = ctx.LoanRecords.Where(x => x.LoanStatus == "out").Select(x => new { x.LoanNumber, x.ISBN, x.Book.Title, x.Book.Author, x.MemberID, x.Member.MemberName, x.LoanStatus }).ToList();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //search by book title
            //search by book ISBN
            //search by member name
            //search by member ID


        }

        private void check_in_Click(object sender, EventArgs e)
        {

            int loanNumber = (int)dataGridView1.CurrentRow.Cells[0].Value;
            LoanRecord checkedIn = ctx.LoanRecords.Where(x => x.LoanNumber == loanNumber).First();
            checkedIn.DateReturned = dateTimePicker1.Value;
            checkedIn.LoanStatus = "in";
            ctx.SaveChanges();


        }
       
        //public bool isDigitOnly(string aString)
        //{
        //    string x = "1234567890";
        //    foreach (char c in aString)
        //    {
        //        string a = c.ToString();
        //        x.Contains(a);
        //    }
        //    return true;
        //}

        private void search_Click(object sender, EventArgs e)
        {
            Entities ctx = new Entities();

            string searchfield = textBox2.Text;
            int searchNum;
            bool isDigit = Int32.TryParse(searchfield, out searchNum);
            

            if (isDigit)
            {
                
                
                dataGridView1.DataSource = ctx.LoanRecords.Where(x => x.MemberID == searchNum && x.LoanStatus =="out").Select(x=> new {x.LoanNumber, x.ISBN, x.Book.Title, x.Book.Author, x.MemberID, x.Member.MemberName, x.LoanStatus}).ToList();

            }

            else {

                dataGridView1.DataSource = ctx.LoanRecords.Where(
                   x => (x.ISBN == searchfield
                || x.Book.Title == searchfield
                || x.Book.Author == searchfield
                || x.Member.MemberName == searchfield)

                &&

                x.LoanStatus == "out"
                
                ).Select(x => new { x.LoanNumber, x.ISBN, x.Book.Title, x.Book.Author, x.MemberID, x.Member.MemberName, x.LoanStatus }).ToList(); 
            }
         



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
