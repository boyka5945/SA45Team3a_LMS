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
    public partial class Search : Form
    {
        Entities context;
        LendBook bro;
        public Search()
        {
            bro = new LendBook();
            context = new Entities();
            InitializeComponent();
        }

        public Button Borrow
        {
            get
            {
                return button_Borrow;
            }
        }

        public Button Availibility
        {
            get
            {
                return button_Availability;
            }
        }

        public DataGridView Get
        {
            get
            {
                return dataGridView_Books;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Catagory.Text == "ALL")
            {
                dataGridView_Books.DataSource = context.Books.ToList();
            }
            else
            {
                dataGridView_Books.DataSource = context.Books.Where(x => x.Category == comboBox_Catagory.Text).ToList();
            }
        }


        private void ShowBooks(object sender, MouseEventArgs e)
        {
            textBox_KeyWord.Text = "";
            textBox_KeyWord.ForeColor = Color.Black;
        }

        private void Togray(object sender, MouseEventArgs e)
        {
            textBox_KeyWord.Text = "bookname/author/publishername/ISBN";
            textBox_KeyWord.ForeColor = Color.DarkGray;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Books.DataSource = context.Books.Where(x => x.Author == textBox_KeyWord.Text || x.ISBN == textBox_KeyWord.Text || x.PublisherName == textBox_KeyWord.Text || x.Title == textBox_KeyWord.Text).ToList();
        }

        private void textBox_KeyWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            var q = from x in context.Books group x by x.Category into s select new { s.Key };
            List<string> l = new List<string>();

            for (int i = 0; i < q.ToList().Count; i++)
            {
                l.Add(q.ToList().ElementAt(i).ToString().Substring(8, q.ToList().ElementAt(i).ToString().Length - 10));
            }
            l.Add("ALL");
            // TODO: This line of code loads data into the 'sA45Team3a.Books' table. You can move, or remove it, as needed.
            comboBox_Catagory.DataSource = l;
            comboBox_Catagory.Text = "";
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {


            bro.cboISBN.Text = dataGridView_Books.CurrentRow.Cells["ISBN"].Value.ToString();
            //bro.txtTitle.Text = dataGridView_Books.Rows[i].Cells["Author"].Value.ToString();
            bro.txtTitle.Text = dataGridView_Books.CurrentRow.Cells["Title"].Value.ToString();
            bro.lblBookRemained.Text = (Convert.ToInt32(dataGridView_Books.CurrentRow.Cells["TotalQty"].Value) - Convert.ToInt32(dataGridView_Books.CurrentRow.Cells["TotalOnLoan"].Value)).ToString();
            bro.ShowDialog();

        }

        private void dataGridView_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_CheckStatus_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(dataGridView_Books.CurrentRow.Cells["TotalQty"].Value) - Convert.ToInt32(dataGridView_Books.CurrentRow.Cells["TotalOnLoan"].Value) > 0)
            {
                MessageBox.Show("Availible");
            }
            else
            {
                string temp = dataGridView_Books.CurrentRow.Cells["ISBN"].Value.ToString();
                DateTime time = context.LoanRecords.Where(x => x.ISBN == temp).First().DueDate.Value;
                foreach (LoanRecord x in context.LoanRecords.Where(x => x.ISBN == temp).ToList())
                {
                    if (x.DueDate.Value.CompareTo(time) < 0)
                    {
                        time = x.DueDate.Value;
                    }
                }
                MessageBox.Show(time + " Can Availible.");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

