using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gharge_Enterprise
{
    public partial class frm_Emp_Details : Form
    {
        public frm_Emp_Details()
        {
            InitializeComponent();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {

            string Result = "";
            bool Flag = true;

            if(tb_Name.Text != "")
            {
                Result = tb_Name.Text + " from department ";

                if(cmb_Course.Text != "")
                {
                    Result += cmb_Course.Text + " is ";

                    if(rdb_Male.Checked == true)
                    {
                        Result += rdb_Male.Text + " candidate , he prefers shift timing ";

                    }
                    else if(rdb_Female.Checked == true)
                    {
                        Result += rdb_Female.Text + " candidate , she prefers shift timing ";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender of Employee.", "INCOMPLET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Flag = false;
                    }

                    if(rdb_Morning.Checked == true)
                    {
                        Result += rdb_Morning.Text = " .";

                    }
                    else if(rdb_Evening .Checked == true)
                    {
                        Result += rdb_Evening.Text = " . ";
                    }
                    else if(rdb_Night.Checked == true)
                    {
                        Result += rdb_Night.Text = " . ";
                    }
                    else
                    {
                        Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Select Course of Employee.", "INCOMPLET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Flag = false;
                }
            }
            else
            {
                MessageBox.Show("Enter A name of Employee.", "INCOMPLET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Flag = false;
            }

            if(Flag == true)
            {
                tb_Output.Text = Result;
            }
        }

        private void Only_letters(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Output.Clear();
            cmb_Course.SelectedIndex = -1;

            rdb_Male.Checked = false;
            rdb_Female.Checked = false;

            rdb_Morning.Checked = false;
            rdb_Evening.Checked = false;
            rdb_Night.Checked = false;
        }
    }
}
