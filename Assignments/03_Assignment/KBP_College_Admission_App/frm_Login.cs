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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection SCon = new SqlConnection(@"Data Source=Shubham;Initial Catalog=KBP_College_Admission_App_DB;Integrated Security=True;Pooling=False");

        void SCon_start()
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

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SCon_start();

            int Cnt = 0;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select count(*) from Login_Details where Username = @Uname  And Password = @Ps ";
            cmd.Connection = SCon;

            cmd.Parameters.Add("@Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            cmd.Parameters.Add("@Ps", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());
            if(Cnt > 0)
            {
                MessageBox.Show("Login Successful.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
                obj.Show();
                this.Hide();

                Shared_Content.Uname = tb_Username.Text;
            }
            else
            {
                MessageBox.Show("Enter correct Username and Password", "INCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_Username.Clear();
                tb_Password.Clear();
                tb_Password.Enabled = false;
                btn_Submit.Enabled = false;
            }
            SCon_Stop();
        }
    }
}
