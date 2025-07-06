
namespace Gharge_Enterprise
{
    partial class frm_Emp_Details
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift = new System.Windows.Forms.Label();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb_Night = new System.Windows.Forms.RadioButton();
            this.rdb_Evening = new System.Windows.Forms.RadioButton();
            this.rdb_Morning = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Header.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(341, 39);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(305, 43);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Employee Details";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Emp_Name.Location = new System.Drawing.Point(54, 209);
            this.lbl_Emp_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(197, 27);
            this.lbl_Emp_Name.TabIndex = 1;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // lbl_Emp_Department
            // 
            this.lbl_Emp_Department.AutoSize = true;
            this.lbl_Emp_Department.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Department.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Emp_Department.Location = new System.Drawing.Point(54, 287);
            this.lbl_Emp_Department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Emp_Department.Name = "lbl_Emp_Department";
            this.lbl_Emp_Department.Size = new System.Drawing.Size(265, 27);
            this.lbl_Emp_Department.TabIndex = 2;
            this.lbl_Emp_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Gender.Location = new System.Drawing.Point(54, 370);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(98, 27);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.AutoSize = true;
            this.lbl_Shift.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Shift.Location = new System.Drawing.Point(54, 468);
            this.lbl_Shift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(122, 27);
            this.lbl_Shift.TabIndex = 4;
            this.lbl_Shift.Text = "Shift Time";
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Output.ForeColor = System.Drawing.Color.Magenta;
            this.Lbl_Output.Location = new System.Drawing.Point(56, 697);
            this.Lbl_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(81, 27);
            this.Lbl_Output.TabIndex = 5;
            this.Lbl_Output.Text = "Output";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(472, 209);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(312, 31);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_letters);
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "CA",
            "R&D",
            "Finance",
            "Networking"});
            this.cmb_Course.Location = new System.Drawing.Point(472, 287);
            this.cmb_Course.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(312, 30);
            this.cmb_Course.TabIndex = 2;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Male.Location = new System.Drawing.Point(26, 19);
            this.rdb_Male.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(77, 26);
            this.rdb_Male.TabIndex = 8;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdb_Female);
            this.panel1.Controls.Add(this.rdb_Male);
            this.panel1.Location = new System.Drawing.Point(472, 352);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 72);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(8, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 83);
            this.panel2.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(202, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 26);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(26, 19);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 26);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Female.Location = new System.Drawing.Point(202, 19);
            this.rdb_Female.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(98, 26);
            this.rdb_Female.TabIndex = 9;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Reset.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.btn_Reset.Location = new System.Drawing.Point(235, 601);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(132, 54);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Submit.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Submit.Location = new System.Drawing.Point(554, 601);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 54);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_Output
            // 
            this.tb_Output.Enabled = false;
            this.tb_Output.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(196, 701);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(728, 31);
            this.tb_Output.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdb_Night);
            this.panel3.Controls.Add(this.rdb_Evening);
            this.panel3.Controls.Add(this.rdb_Morning);
            this.panel3.Location = new System.Drawing.Point(472, 453);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 77);
            this.panel3.TabIndex = 4;
            // 
            // rdb_Night
            // 
            this.rdb_Night.AutoSize = true;
            this.rdb_Night.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Night.Location = new System.Drawing.Point(354, 19);
            this.rdb_Night.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_Night.Name = "rdb_Night";
            this.rdb_Night.Size = new System.Drawing.Size(81, 26);
            this.rdb_Night.TabIndex = 10;
            this.rdb_Night.TabStop = true;
            this.rdb_Night.Text = "Night";
            this.rdb_Night.UseVisualStyleBackColor = true;
            // 
            // rdb_Evening
            // 
            this.rdb_Evening.AutoSize = true;
            this.rdb_Evening.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Evening.Location = new System.Drawing.Point(202, 19);
            this.rdb_Evening.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_Evening.Name = "rdb_Evening";
            this.rdb_Evening.Size = new System.Drawing.Size(107, 26);
            this.rdb_Evening.TabIndex = 9;
            this.rdb_Evening.TabStop = true;
            this.rdb_Evening.Text = "Evening";
            this.rdb_Evening.UseVisualStyleBackColor = true;
            // 
            // rdb_Morning
            // 
            this.rdb_Morning.AutoSize = true;
            this.rdb_Morning.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Morning.Location = new System.Drawing.Point(26, 19);
            this.rdb_Morning.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_Morning.Name = "rdb_Morning";
            this.rdb_Morning.Size = new System.Drawing.Size(109, 26);
            this.rdb_Morning.TabIndex = 8;
            this.rdb_Morning.TabStop = true;
            this.rdb_Morning.Text = "Morning";
            this.rdb_Morning.UseVisualStyleBackColor = true;
            // 
            // frm_Emp_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Emp_Department);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Header);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Emp_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Emp_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift;
        private System.Windows.Forms.Label Lbl_Output;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdb_Evening;
        private System.Windows.Forms.RadioButton rdb_Morning;
        private System.Windows.Forms.RadioButton rdb_Night;
    }
}

