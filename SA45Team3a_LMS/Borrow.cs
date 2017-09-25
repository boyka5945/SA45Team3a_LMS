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
    public partial class Borrow : Form
    {
        SelectMember sem;
        Entities context;

        public Borrow()
        {
            context = new Entities();
            sem = new SelectMember();
            InitializeComponent();
        }

        public TextBox ISBN
        {
            get
            {
                return textBox_ISBN;
            }
        }

        public TextBox Author
        {
            get
            {
                return textBox_Author;
            }
        }

        public TextBox Title
        {
            get
            {
                return textBox_Title;
            }
        }

        public TextBox Qty
        {
            get
            {
                return textBox_TotalQty;
            }
        }

        private void button_SelectUser_Click(object sender, EventArgs e)
        {
            sem.GetList.DataSource = context.Members.ToList();
            sem.label_bool.Text = "CustomerID";
            DialogResult r = sem.ShowDialog();
            if (r == DialogResult.OK)
                textBox_UserID.Text = sem.label_Temp1.Text;
        }

        private void button_SelectBook_Click(object sender, EventArgs e)
        {
            sem.GetList.DataSource = context.Books.ToList();
            sem.label_bool.Text = "VideoCode";
            DialogResult r = sem.ShowDialog();
            if (r == DialogResult.OK)
            {
                textBox_ISBN.Text = sem.label_Temp1.Text;
                textBox_Title.Text = sem.label_Temp2.Text;
                textBox_Author.Text = sem.label_Temp3.Text;
                textBox_TotalQty.Text = sem.label_Temp4.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_TotalQty.Text) > 0 && Convert.ToInt32(textBox_TotalQty.Text) - Convert.ToInt32(textBox_BorrowQty.Text) > 0)
            {
                using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
                {
                    LoanRecord lr = new LoanRecord();
                    lr.LoanNumber = context.LoanRecords.Count() + 1;
                    lr.MemberID = Convert.ToInt32(textBox_UserID.Text);
                    lr.ISBN = textBox_ISBN.Text;
                    lr.Quantity = Convert.ToInt32(textBox_BorrowQty.Text);
                    lr.DateBorrowed = dateTimePicker_Borrowed.Value;
                    lr.DueDate = dateTimePicker_Return.Value;

                    Book book = context.Books.Where(x => x.ISBN == lr.ISBN).First();
                    book.TotalQty -= lr.Quantity;
                    book.TotalOnLoan += lr.Quantity;

                    Member m = context.Members.Where(x => x.MemberID == lr.MemberID).First();
                    m.BooksBorrowed += lr.Quantity;
                    context.LoanRecords.Add(lr);

                    context.SaveChanges();
                    ts.Complete();
                }
            }
            else
            {
                MessageBox.Show("no more books");
            }
        }
    }
}
