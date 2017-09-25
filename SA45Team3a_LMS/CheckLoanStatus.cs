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
    public partial class CheckLoanStatus : Form
    {
        public CheckLoanStatus()
        {
            InitializeComponent();
        }

        public DataGridView dataview
        {
            get
            {
                return dataGridView_status;
            }
            set
            {
                dataGridView_status.DataSource = value;
            }
        }
    }

    
}
