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
    public partial class Staffs : Form
    {
        Search search;
        Entities context;
        Borrow bor;
        Books books;
        Return re;
        ShowMembers mem;
        public Staffs()
        {
            search = new Search();
            context = new Entities();
            bor = new Borrow();
            books = new Books();
            re = new Return();
            mem = new ShowMembers();
            InitializeComponent();
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            bor.ShowDialog();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (UserID.Type == "Staff")
            {
                search.Borrow.Visible = true;
                search.Availibility.Visible = false;
            }

            search.ShowDialog();
        }

        private void button_Members_Click(object sender, EventArgs e)
        {
            mem.GetList.DataSource = context.Members.ToList();
            mem.ShowDialog();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            re.ShowDialog();
        }

        private void button_Books_Click(object sender, EventArgs e)
        {
            books.BookList.DataSource = context.Books.ToList(); 
            books.ShowDialog();
        }
    }
}
