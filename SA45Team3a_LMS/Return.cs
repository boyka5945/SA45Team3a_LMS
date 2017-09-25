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
    public partial class Return : Form
    {
        Entities context;
        public Return()
        {
            context = new Entities();
            InitializeComponent();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox_LoanNumber.Text);
            if (Convert.ToInt32(textBox_Qty.Text) <= context.LoanRecords.Where(x => x.LoanNumber == temp).First().Quantity)
            {
                using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
                {

                    Book book = context.LoanRecords.Where(x => x.LoanNumber == temp).First().Book;
                    book.TotalQty += Convert.ToInt32(textBox_Qty.Text);
                    book.TotalOnLoan -= Convert.ToInt32(textBox_Qty.Text);


                    Member m = context.LoanRecords.Where(x => x.LoanNumber == temp).First().Member;
                    m.BooksBorrowed -= Convert.ToInt32(textBox_Qty.Text);

                    LoanRecord lr = context.LoanRecords.Where(x => x.LoanNumber == temp).First();
                    lr.DateReturned = dateTimePicker_Date.Value;
                    lr.LoadStatus = "in";

                    context.SaveChanges();
                    ts.Complete();
                }
            }
            else
            {
                MessageBox.Show("do not borrow the number of books.");
            }
        }
    }
}
