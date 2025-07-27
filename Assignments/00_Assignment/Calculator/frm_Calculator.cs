using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_Calculator : Form
    {
        public frm_Calculator()
        {
            InitializeComponent();
        }

        private void frm_Calculator_Load(object sender, EventArgs e)
        {
            tb_first_No.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(tb_first_No.Text != "" && tb_second_No.Text!= "")
            {
                
            }
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public void btn_Add_Click(object sender, EventArgs e)
        {
           
                lbl_Operator.Visible = true;
                lbl_Operator.Text = "+";
                int Res = Convert.ToInt32(tb_first_No.Text) + Convert.ToInt32(tb_second_No.Text);

                tb_Answer.Text = Convert.ToString(Res);
           
            
            //.Visible = false;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            lbl_Operator.Text = "-";
            int Res = Convert.ToInt32(tb_first_No.Text) - Convert.ToInt32(tb_second_No.Text);
           
            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            lbl_Operator.Text = "*";
            int Res = Convert.ToInt32(tb_first_No.Text) * Convert.ToInt32(tb_second_No.Text);

            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            lbl_Operator.Text = "/";
            int Res = Convert.ToInt32(tb_first_No.Text) / Convert.ToInt32(tb_second_No.Text);

            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            lbl_Operator.Text = "%";
            int Res = Convert.ToInt32(tb_first_No.Text) % Convert.ToInt32(tb_second_No.Text);

            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            lbl_Operator.Text = "Min";
            if (Convert.ToInt32(tb_first_No.Text) == Convert.ToInt32(tb_second_No.Text))
            {
                tb_Answer.Text = tb_first_No.Text + " And " + tb_second_No.Text + " are equal.";
            }
            else if(Convert.ToInt32(tb_first_No.Text) > Convert.ToInt32(tb_second_No.Text))
            {
                tb_Answer.Text = tb_second_No.Text + " is minimum  number.";
            }
            else if (Convert.ToInt32(tb_second_No.Text) > Convert.ToInt32(tb_first_No.Text))
            {
                tb_Answer.Text = tb_first_No.Text + " is minimum  number.";
            }
            else
            {
                tb_Answer.Text = tb_first_No.Text + " is minimum  number.";
            }
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            lbl_Operator.Text = "Max";
            if (Convert.ToInt32(tb_first_No.Text) == Convert.ToInt32(tb_second_No.Text))
            {
                tb_Answer.Text = tb_first_No.Text + " And " + tb_second_No.Text + " are equal.";
            }
            else if (Convert.ToInt32(tb_first_No.Text) > Convert.ToInt32(tb_second_No.Text))
            {
                tb_Answer.Text = tb_first_No.Text + " is maximum  number.";
            }
            else if(Convert.ToInt32(tb_second_No.Text) < Convert.ToInt32(tb_first_No.Text))
            {
                tb_Answer.Text = tb_second_No.Text + " is maximun  number.";
            }
            else
            {
                tb_Answer.Text = tb_second_No.Text + " is maximum  number.";
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
           
            lbl_Operator.Text = "x²";

            int Res = Convert.ToInt32(tb_first_No.Text) * Convert.ToInt32(tb_first_No.Text);

            tb_Answer.Text = Convert.ToString(Res);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_first_No.Clear();
            tb_second_No.Clear();
            tb_Answer.Clear();
            lbl_Operator.Visible = true;
           
        }

        private void tb_first_No_TextChanged(object sender, EventArgs e)
        {
            tb_second_No.Enabled = true;
        }

        private void tb_second_No_TextChanged(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_sub.Enabled = true;
            btn_multi.Enabled = true;
            btn_div.Enabled = true;
            btn_mod.Enabled = true;
            btn_Min.Enabled = true;
            btn_Max.Enabled = true;
           // btn_X.Enabled = true;
        }
    }
}
