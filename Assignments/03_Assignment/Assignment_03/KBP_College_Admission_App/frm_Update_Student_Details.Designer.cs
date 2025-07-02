
namespace KBP_College_Admission_App
{
    partial class frm_Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Update));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.LightCyan;
            this.pnl_Header.Controls.Add(this.lbl_User);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1082, 128);
            this.pnl_Header.TabIndex = 15;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbl_User.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_User.Location = new System.Drawing.Point(12, 30);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(113, 27);
            this.lbl_User.TabIndex = 9;
            this.lbl_User.Text = "Username";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BackColor = System.Drawing.Color.OldLace;
            this.btn_Logout.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(969, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(110, 51);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Header.Font = new System.Drawing.Font("Mongolian Baiti", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Header.Location = new System.Drawing.Point(237, 30);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(621, 68);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Update Student Details";
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Enabled = false;
            this.cmb_Course.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.ItemHeight = 36;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "BSC",
            "MCA",
            "MCS",
            "MSC",
            "M.Com"});
            this.cmb_Course.Location = new System.Drawing.Point(443, 525);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(363, 44);
            this.cmb_Course.TabIndex = 6;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Enabled = false;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(443, 441);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(363, 44);
            this.tb_Mobile_No.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(443, 352);
            this.dtp_DOB.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(363, 44);
            this.dtp_DOB.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(443, 270);
            this.tb_Name.MaxLength = 40;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(363, 44);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(443, 182);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(363, 44);
            this.tb_Roll_No.TabIndex = 1;
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_Course.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Course.Location = new System.Drawing.Point(127, 534);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(99, 32);
            this.lbl_Course.TabIndex = 46;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_Mobile.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Mobile.Location = new System.Drawing.Point(124, 450);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(100, 32);
            this.lbl_Mobile.TabIndex = 45;
            this.lbl_Mobile.Text = "Mobile";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_DOB.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Purple;
            this.lbl_DOB.Location = new System.Drawing.Point(124, 364);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(94, 32);
            this.lbl_DOB.TabIndex = 44;
            this.lbl_DOB.Text = "D.O.B";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_Name.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Name.Location = new System.Drawing.Point(124, 279);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 32);
            this.lbl_Name.TabIndex = 43;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Roll_No.Location = new System.Drawing.Point(124, 191);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(111, 32);
            this.lbl_Roll_No.TabIndex = 42;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Update.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Update.Location = new System.Drawing.Point(201, 661);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(274, 60);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update Student";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Refresh.Location = new System.Drawing.Point(25, 661);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(137, 60);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Mongolian Baiti", 18F);
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(536, 661);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(270, 60);
            this.btn_Add_New_Student.TabIndex = 9;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Student_List.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Student_List.Location = new System.Drawing.Point(855, 661);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(207, 60);
            this.btn_Student_List.TabIndex = 10;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Search.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btn_Search.Location = new System.Drawing.Point(884, 184);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 44);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update ";
            this.Load += new System.EventHandler(this.frm_Update_Student_Details_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Search;
    }
}