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
    public partial class frm_Add_New_Student_Details : Form
    {
        public frm_Add_New_Student_Details()
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

        void Clear_Cantroles()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = "31 - 12 - 2025";

            tb_Roll_No.Focus();
        }

        private void Only_number(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                 e.Handled = true;
            }
        }

        private void frm_Add_New_Student_Details_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
            lbl_User.Text = "Welcome " + Shared_Content.Uname;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = SCon;
                cmd.CommandText = "Insert Into Student_Details (Roll_No,Name,DOB,Mobile_No,Course) Values (@RNo, @Nam, @DOB, @Mobile, @Course)";

                cmd.Parameters.Add("@RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("@Nam", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("@Mobile", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("@Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Information Inserted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Cantroles();
            }
            else
            {
                MessageBox.Show("Fill all information", "INCOMPLET INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            SCon_Stop();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Cantroles();
        }

        private void btn_Search_student_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
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
    }
}
