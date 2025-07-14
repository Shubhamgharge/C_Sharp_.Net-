
namespace Yadav_Emp_App
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
            this.lbl_Dep = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.gb_Known_Language = new System.Windows.Forms.GroupBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.lbl_Known_Language = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Department_Error = new System.Windows.Forms.Label();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Language_Error = new System.Windows.Forms.Label();
            this.lbl_Hobbies_Error = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.pnl_Output = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Language.SuspendLayout();
            this.pnl_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Header.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Header.Location = new System.Drawing.Point(391, 73);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(459, 64);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Employee Details";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.Location = new System.Drawing.Point(44, 220);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(170, 23);
            this.lbl_Emp_Name.TabIndex = 1;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // lbl_Dep
            // 
            this.lbl_Dep.AutoSize = true;
            this.lbl_Dep.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dep.Location = new System.Drawing.Point(35, 333);
            this.lbl_Dep.Name = "lbl_Dep";
            this.lbl_Dep.Size = new System.Drawing.Size(233, 23);
            this.lbl_Dep.TabIndex = 2;
            this.lbl_Dep.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(44, 493);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(82, 23);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(380, 213);
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(315, 33);
            this.tb_Emp_Name.TabIndex = 1;
            this.tb_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "MCA",
            "MCS"});
            this.cmb_Department.Location = new System.Drawing.Point(380, 326);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(315, 37);
            this.cmb_Department.TabIndex = 2;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_Gender.Controls.Add(this.rdb_Female);
            this.gb_Gender.Controls.Add(this.rdb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(380, 457);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(315, 81);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Female.Location = new System.Drawing.Point(120, 26);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(101, 39);
            this.rdb_Female.TabIndex = 1;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Male.Location = new System.Drawing.Point(22, 26);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(80, 39);
            this.rdb_Male.TabIndex = 0;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // gb_Known_Language
            // 
            this.gb_Known_Language.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_Known_Language.Controls.Add(this.cb_Hindi);
            this.gb_Known_Language.Controls.Add(this.cb_French);
            this.gb_Known_Language.Controls.Add(this.cb_English);
            this.gb_Known_Language.Controls.Add(this.cb_Marathi);
            this.gb_Known_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Known_Language.Location = new System.Drawing.Point(945, 220);
            this.gb_Known_Language.Name = "gb_Known_Language";
            this.gb_Known_Language.Size = new System.Drawing.Size(345, 175);
            this.gb_Known_Language.TabIndex = 4;
            this.gb_Known_Language.TabStop = false;
            this.gb_Known_Language.Text = "Known Language";
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(221, 116);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(77, 27);
            this.cb_Hindi.TabIndex = 3;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(22, 113);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(89, 27);
            this.cb_French.TabIndex = 2;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(221, 34);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(93, 27);
            this.cb_English.TabIndex = 1;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(22, 34);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(98, 27);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // lbl_Known_Language
            // 
            this.lbl_Known_Language.AutoSize = true;
            this.lbl_Known_Language.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Language.Location = new System.Drawing.Point(745, 223);
            this.lbl_Known_Language.Name = "lbl_Known_Language";
            this.lbl_Known_Language.Size = new System.Drawing.Size(180, 23);
            this.lbl_Known_Language.TabIndex = 9;
            this.lbl_Known_Language.Text = "Known Language";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.Location = new System.Drawing.Point(780, 457);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(94, 23);
            this.lbl_Hobbies.TabIndex = 10;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Reading",
            "Dancing",
            "Playing",
            "Travling",
            "Studing",
            "Gaming",
            "Sweeming",
            "Driving"});
            this.checkedListBox1.Location = new System.Drawing.Point(945, 457);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(345, 179);
            this.checkedListBox1.TabIndex = 5;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Reset.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.btn_Reset.Location = new System.Drawing.Point(340, 695);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(151, 46);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Submit.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Submit.Location = new System.Drawing.Point(793, 695);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(136, 46);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name_Error.Location = new System.Drawing.Point(597, 254);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(94, 17);
            this.lbl_Name_Error.TabIndex = 13;
            this.lbl_Name_Error.Text = "Name Error";
            this.lbl_Name_Error.Visible = false;
            // 
            // lbl_Department_Error
            // 
            this.lbl_Department_Error.AutoSize = true;
            this.lbl_Department_Error.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Department_Error.Location = new System.Drawing.Point(552, 378);
            this.lbl_Department_Error.Name = "lbl_Department_Error";
            this.lbl_Department_Error.Size = new System.Drawing.Size(143, 17);
            this.lbl_Department_Error.TabIndex = 14;
            this.lbl_Department_Error.Text = "Department Error";
            this.lbl_Department_Error.Visible = false;
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(587, 550);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(104, 17);
            this.lbl_Gender_Error.TabIndex = 15;
            this.lbl_Gender_Error.Text = "Gender Error";
            this.lbl_Gender_Error.Visible = false;
            // 
            // lbl_Language_Error
            // 
            this.lbl_Language_Error.AutoSize = true;
            this.lbl_Language_Error.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Language_Error.Location = new System.Drawing.Point(1165, 409);
            this.lbl_Language_Error.Name = "lbl_Language_Error";
            this.lbl_Language_Error.Size = new System.Drawing.Size(125, 17);
            this.lbl_Language_Error.TabIndex = 16;
            this.lbl_Language_Error.Text = "Language Error";
            this.lbl_Language_Error.Visible = false;
            // 
            // lbl_Hobbies_Error
            // 
            this.lbl_Hobbies_Error.AutoSize = true;
            this.lbl_Hobbies_Error.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobbies_Error.Location = new System.Drawing.Point(1178, 648);
            this.lbl_Hobbies_Error.Name = "lbl_Hobbies_Error";
            this.lbl_Hobbies_Error.Size = new System.Drawing.Size(112, 17);
            this.lbl_Hobbies_Error.TabIndex = 17;
            this.lbl_Hobbies_Error.Text = "Hobbies Error";
            this.lbl_Hobbies_Error.Visible = false;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(44, 784);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(81, 23);
            this.lbl_Output.TabIndex = 18;
            this.lbl_Output.Text = "Output";
            // 
            // pnl_Output
            // 
            this.pnl_Output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Output.Controls.Add(this.label1);
            this.pnl_Output.Location = new System.Drawing.Point(340, 805);
            this.pnl_Output.Name = "pnl_Output";
            this.pnl_Output.Size = new System.Drawing.Size(934, 40);
            this.pnl_Output.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hobbies";
            // 
            // frm_Emp_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 877);
            this.Controls.Add(this.pnl_Output);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Hobbies_Error);
            this.Controls.Add(this.lbl_Language_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.lbl_Department_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Known_Language);
            this.Controls.Add(this.gb_Known_Language);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Emp_Name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Dep);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Emp_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Language.ResumeLayout(false);
            this.gb_Known_Language.PerformLayout();
            this.pnl_Output.ResumeLayout(false);
            this.pnl_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Dep;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.GroupBox gb_Known_Language;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.Label lbl_Known_Language;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Department_Error;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Language_Error;
        private System.Windows.Forms.Label lbl_Hobbies_Error;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Panel pnl_Output;
        private System.Windows.Forms.Label label1;
    }
}

