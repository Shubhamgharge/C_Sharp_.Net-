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
    public partial class frm_Update : Form
    {
        public frm_Update()
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

            dtp_DOB.Text = "25 - 09 - 2005";

            Enabled_False();
            tb_Roll_No.Focus();
        }

        void Enabled_True()
        {
            tb_Name.Enabled = true;
            tb_Mobile_No.Enabled = true;
            cmb_Course.Enabled = true;
            dtp_DOB.Enabled = true;

            tb_Roll_No.Enabled = false;
        }

        void Enabled_False()
        {
            tb_Name.Enabled = false;
            tb_Mobile_No.Enabled = false;
            cmb_Course.Enabled = false;
            dtp_DOB.Enabled = false;

            tb_Roll_No.Enabled = true;
        }

        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_User.Text = "Welcome " + Shared_Content.Uname;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = SCon;
                cmd.CommandText = " select * from Student_Details where Roll_No = @RNo";

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enabled_True();
                }
                else
                {
                    MessageBox.Show("No Such Record Found", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tb_Roll_No.Focus();
                    tb_Roll_No.Clear();

                    Enabled_False();
                }
            }
           
            SCon_Stop();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if(tb_Roll_No.Text != "" && tb_Name.Text!= "" && dtp_DOB.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
               
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = SCon;
                cmd.CommandText = "Update Student_details set Name = @Nm, DOB = @Db, Mobile_No =@Mobile, Course = @Course  where Roll_No = @RNo";

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("mobile", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successful..", "Succress", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Cantroles();
            }
            else
            {
                MessageBox.Show("No Such student", "No record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_Roll_No.Clear();
                tb_Roll_No.Focus();

                Enabled_False();
            }


            SCon_Stop();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Cantroles();
            tb_Roll_No.Focus();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
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
