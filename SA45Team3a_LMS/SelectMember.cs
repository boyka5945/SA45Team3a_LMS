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
    public partial class SelectMember : Form
    {
        public SelectMember()
        {
            InitializeComponent();
        }

        public DataGridView GetList
        {
            get
            {
                return dataGridView_listMember;
            }
        }

        public Label label_Temp1
        {
            get
            {
                return label_temp1;
            }
        }

        public Label label_bool
        {
            get
            {
                return label_Bool;
            }
        }

        public Label label_Temp2
        {
            get
            {
                return label_temp2;
            }
        }

        public Label label_Temp3
        {
            get
            {
                return label_temp3;
            }
        }

        public Label label_Temp4
        {
            get
            {
                return label_temp4;
            }
        }

        public Label label_Temp5
        {
            get
            {
                return label_temp5;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (label_bool.Text == "CustomerID")
            {
                for (int i = 0; i < dataGridView_listMember.RowCount; i++)
                {
                    if (dataGridView_listMember.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    {

                        label_Temp1.Text = dataGridView_listMember.Rows[i].Cells["MemberID"].Value.ToString();
                    }
                }
            }
            else if(label_bool.Text == "VideoCode")
            {
                for (int i = 0; i < dataGridView_listMember.RowCount; i++)
                {
                    if (dataGridView_listMember.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    {

                        label_Temp1.Text = dataGridView_listMember.Rows[i].Cells["ISBN"].Value.ToString();
                        label_Temp2.Text = dataGridView_listMember.Rows[i].Cells["Title"].Value.ToString();
                        label_Temp3.Text = dataGridView_listMember.Rows[i].Cells["Author"].Value.ToString();
                        label_Temp4.Text = dataGridView_listMember.Rows[i].Cells["TotalQty"].Value.ToString();
                        //label_Temp2.Text = dataGridView_listMember.Rows[i].Cells["Title"].Value.ToString();

                    }
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }


}
