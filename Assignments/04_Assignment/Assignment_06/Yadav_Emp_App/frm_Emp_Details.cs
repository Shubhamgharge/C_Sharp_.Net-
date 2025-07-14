using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yadav_Emp_App
{
    public partial class frm_Emp_Details : Form
    {
        public frm_Emp_Details()
        {
            InitializeComponent();
        }

       

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar ==(char)Keys.Space || (e.KeyChar == (char)Keys.Back))))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            String Output = "";

            if(tb_Emp_Name.Text != "")
            {
                
                Output += tb_Emp_Name.Text;
            }
            else
            {
                lbl_Name_Error.Visible = true;
            }
            if(cmb_Department.Text != "")
            {
                
            }
            else
            {
                lbl_Department_Error.Visible = true;
            }
            if(rdb_Male.Checked != true)
            {

            }
            else if(rdb_Female.Checked != true)
            {

            }
            else
            {
                lbl_Gender_Error.Visible = true;
            }

            //if(rdb_Male.)
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Emp_Name.Clear();
            cmb_Department.SelectedIndex = -1;
            

        }
    }
}
