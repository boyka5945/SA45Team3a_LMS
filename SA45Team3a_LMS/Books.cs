using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SA45Team3a_LMS
{
    public partial class Books : Form
    {
        Entities context;
        public Books()
        {
            context = new Entities();
            InitializeComponent();
        }

        public DataGridView BookList
        {
            get
            {
                return dataGridView_BookList;
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                for (int i = 0; i < context.Books.ToList().Count; i++)
                {
                    if (dataGridView_BookList.Rows[i].Cells[0].Value != null)
                        context.Books.ToList()[i].ISBN = dataGridView_BookList.Rows[i].Cells[0].Value.ToString();
                    if (dataGridView_BookList.Rows[i].Cells[1].Value != null)
                        context.Books.ToList()[i].Title = dataGridView_BookList.Rows[i].Cells[1].Value.ToString();
                    if (dataGridView_BookList.Rows[i].Cells[2].Value != null)
                        context.Books.ToList()[i].Author = dataGridView_BookList.Rows[i].Cells[2].Value.ToString();
                    if (dataGridView_BookList.Rows[i].Cells[3].Value != null)
                        context.Books.ToList()[i].PublisherName = dataGridView_BookList.Rows[i].Cells[3].Value.ToString();
                    if (dataGridView_BookList.Rows[i].Cells[4].Value != null)
                        context.Books.ToList()[i].Category = dataGridView_BookList.Rows[i].Cells[4].Value.ToString();
                    if (dataGridView_BookList.Rows[i].Cells[5].Value != null)
                        context.Books.ToList()[i].DatePublish = Convert.ToDateTime(dataGridView_BookList.Rows[i].Cells[5].Value);
                    if (dataGridView_BookList.Rows[i].Cells[6].Value != null)
                        context.Books.ToList()[i].TotalQty = Convert.ToInt32(dataGridView_BookList.Rows[i].Cells[6].Value);
                    if (dataGridView_BookList.Rows[i].Cells[7].Value != null)
                        context.Books.ToList()[i].TotalOnLoan = Convert.ToInt32(dataGridView_BookList.Rows[i].Cells[7].Value);
                    if (dataGridView_BookList.Rows[i].Cells[8].Value != null)
                        context.Books.ToList()[i].Remark = dataGridView_BookList.Rows[i].Cells[8].Value.ToString();

                }

                context.SaveChanges();
                ts.Complete();
            }
            DialogResult = DialogResult.OK;


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
