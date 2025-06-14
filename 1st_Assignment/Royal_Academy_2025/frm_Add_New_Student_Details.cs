using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Royal_Academy_2025
{
    public partial class frm_Add_New_Student_Details : Form
    {
        public frm_Add_New_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection SCon = new SqlConnection(@"Data Source=Shubham;Initial Catalog=Royal_Academy_2025_db;Integrated Security=True");

       void SCon_Start()
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

        
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = "1 - 1 - 2025";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Start();
            
            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile.Text != "" && cmb_Course.SelectedIndex >= 0)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = " insert into Student_Details values (@Rno, @Name, @Db,@Mob,@Course)";
                Cmd.Connection = SCon;

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile.Text;                
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill all Fields");
            }
            SCon_Stop();

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
