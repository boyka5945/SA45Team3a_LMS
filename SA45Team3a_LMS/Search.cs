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
        Borrow bro;
        public Search()
        {
            bro = new SA45Team3a_LMS.Borrow();
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
            dataGridView_Books.DataSource = context.Books.Where(x => x.Category == comboBox_Catagory.Text).ToList();
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
            // TODO: This line of code loads data into the '_SA45_team_3a_DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this._SA45_team_3a_DataSet.Books);
            comboBox_Catagory.Text = "";
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Books.RowCount; i++)
            {
                if (dataGridView_Books.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    
                    bro.ISBN.Text = dataGridView_Books.Rows[i].Cells["ISBN"].Value.ToString();
                    bro.Author.Text = dataGridView_Books.Rows[i].Cells["Author"].Value.ToString();
                    bro.Title.Text = dataGridView_Books.Rows[i].Cells["Title"].Value.ToString();
                    bro.Qty.Text = dataGridView_Books.Rows[i].Cells["TotalQty"].Value.ToString();
                    bro.ShowDialog();
                }
            }
        }

        private void dataGridView_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_CheckStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
