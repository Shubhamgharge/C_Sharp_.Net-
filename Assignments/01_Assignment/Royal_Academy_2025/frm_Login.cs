using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Academy_2025
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lbl_Header_Click(object sender, EventArgs e)
        {
            

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Username.Focus();
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "Admin" && tb_Password.Text == "a123") || (tb_Username.Text == "a" && tb_Password.Text == "a"))
            {
                MessageBox.Show("Login Successful", "WELCOME");
                frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
                lbl_Error.Text = " Login Failed, Enter Correct Username/Password.";
                lbl_Error.ForeColor = Color.OrangeRed;

            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;


        }

        
    }
}
