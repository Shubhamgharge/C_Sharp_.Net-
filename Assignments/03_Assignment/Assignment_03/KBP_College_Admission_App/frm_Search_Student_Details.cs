using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBP_College_Admission_App
{
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection SCon = new SqlConnection(@"Data Source=Shubham;Initial Catalog=KBP_College_Admission_App_DB;Integrated Security=True;Pooling=False");

        void SCon_Open()
        {
            if(SCon.State != ConnectionState.Open)
            {
                SCon.Open();
            }
        }

        void SCon_Stop()
        {
            if(SCon.State != ConnectionState.Closed)
            {
                SCon.Close();
            }
        }

        void Clear_Cantrols()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = " 20 - 08 - 2005 ";

        }

        private void Only_number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_User.Text = "Welcome " + Shared_Content.Uname;
        }

        private void tb_Roll_No_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = SCon;
            cmd.CommandText = "select * from Student_Details where Roll_No = @RNo" ;

            cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                dtp_DOB.Text = (Dr["DOB"].ToString());
            }
            else
            {
                MessageBox.Show("No such record.", "No Data found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Roll_No.Clear();
            }
            SCon_Stop();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Cantrols();
            tb_Roll_No.Focus();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            frm_Update obj = new frm_Update();
            obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
