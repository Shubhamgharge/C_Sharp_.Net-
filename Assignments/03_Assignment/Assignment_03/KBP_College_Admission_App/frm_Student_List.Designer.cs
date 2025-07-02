
namespace KBP_College_Admission_App
{
    partial class frm_Student_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student_List));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kBP_College_Admission_App_DBDataSet = new KBP_College_Admission_App.KBP_College_Admission_App_DBDataSet();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new KBP_College_Admission_App.KBP_College_Admission_App_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBP_College_Admission_App_DBDataSet)).BeginInit();
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
            this.pnl_Header.Size = new System.Drawing.Size(1082, 134);
            this.pnl_Header.TabIndex = 10;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbl_User.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_User.Location = new System.Drawing.Point(12, 36);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(113, 27);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "Username";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BackColor = System.Drawing.Color.OldLace;
            this.btn_Logout.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(960, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(110, 51);
            this.btn_Logout.TabIndex = 4;
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
            this.lbl_Header.Location = new System.Drawing.Point(358, 32);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(339, 68);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Student List";
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_List.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Student_List.Location = new System.Drawing.Point(17, 158);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1039, 482);
            this.dgv_Student_List.TabIndex = 20;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.kBP_College_Admission_App_DBDataSet;
            // 
            // kBP_College_Admission_App_DBDataSet
            // 
            this.kBP_College_Admission_App_DBDataSet.DataSetName = "KBP_College_Admission_App_DBDataSet";
            this.kBP_College_Admission_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Mongolian Baiti", 18F);
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(401, 675);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(270, 60);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student
            // 
            this.btn_Search_Student.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Search_Student.Font = new System.Drawing.Font("Mongolian Baiti", 18F);
            this.btn_Search_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Search_Student.Location = new System.Drawing.Point(63, 675);
            this.btn_Search_Student.Name = "btn_Search_Student";
            this.btn_Search_Student.Size = new System.Drawing.Size(236, 60);
            this.btn_Search_Student.TabIndex = 2;
            this.btn_Search_Student.Text = "Search Student";
            this.btn_Search_Student.UseVisualStyleBackColor = false;
            this.btn_Search_Student.Click += new System.EventHandler(this.btn_Search_Student_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Update_Student.Font = new System.Drawing.Font("Mongolian Baiti", 18F);
            this.btn_Update_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Update_Student.Location = new System.Drawing.Point(766, 675);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(240, 60);
            this.btn_Update_Student.TabIndex = 3;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btn_Update_Student);
            this.Controls.Add(this.btn_Search_Student);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBP_College_Admission_App_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student;
        private System.Windows.Forms.Button btn_Update_Student;
        private KBP_College_Admission_App_DBDataSet kBP_College_Admission_App_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private KBP_College_Admission_App_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}