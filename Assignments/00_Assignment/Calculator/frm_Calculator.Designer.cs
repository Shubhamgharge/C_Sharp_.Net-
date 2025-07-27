
namespace Calculator
{
    partial class frm_Calculator
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
            this.tb_first_No = new System.Windows.Forms.TextBox();
            this.tb_second_No = new System.Windows.Forms.TextBox();
            this.lbl_No1 = new System.Windows.Forms.Label();
            this.lbl_No2 = new System.Windows.Forms.Label();
            this.tb_Answer = new System.Windows.Forms.TextBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.gb_Operator = new System.Windows.Forms.GroupBox();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Operator = new System.Windows.Forms.Label();
            this.gb_Operator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Header.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_Header.Location = new System.Drawing.Point(422, 31);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(371, 85);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Calculator";
            // 
            // tb_first_No
            // 
            this.tb_first_No.BackColor = System.Drawing.Color.White;
            this.tb_first_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_first_No.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_first_No.Location = new System.Drawing.Point(294, 209);
            this.tb_first_No.MaxLength = 7;
            this.tb_first_No.Name = "tb_first_No";
            this.tb_first_No.Size = new System.Drawing.Size(140, 29);
            this.tb_first_No.TabIndex = 1;
            this.tb_first_No.TextChanged += new System.EventHandler(this.tb_first_No_TextChanged);
            this.tb_first_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // tb_second_No
            // 
            this.tb_second_No.BackColor = System.Drawing.Color.White;
            this.tb_second_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_second_No.Enabled = false;
            this.tb_second_No.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_second_No.Location = new System.Drawing.Point(706, 209);
            this.tb_second_No.MaxLength = 7;
            this.tb_second_No.Name = "tb_second_No";
            this.tb_second_No.Size = new System.Drawing.Size(136, 29);
            this.tb_second_No.TabIndex = 2;
            this.tb_second_No.TextChanged += new System.EventHandler(this.tb_second_No_TextChanged);
            this.tb_second_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lbl_No1
            // 
            this.lbl_No1.AutoSize = true;
            this.lbl_No1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No1.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_No1.Location = new System.Drawing.Point(212, 209);
            this.lbl_No1.Name = "lbl_No1";
            this.lbl_No1.Size = new System.Drawing.Size(50, 23);
            this.lbl_No1.TabIndex = 3;
            this.lbl_No1.Text = "No1";
            // 
            // lbl_No2
            // 
            this.lbl_No2.AutoSize = true;
            this.lbl_No2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No2.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_No2.Location = new System.Drawing.Point(638, 209);
            this.lbl_No2.Name = "lbl_No2";
            this.lbl_No2.Size = new System.Drawing.Size(50, 23);
            this.lbl_No2.TabIndex = 4;
            this.lbl_No2.Text = "No2";
            // 
            // tb_Answer
            // 
            this.tb_Answer.BackColor = System.Drawing.Color.White;
            this.tb_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Answer.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Answer.Location = new System.Drawing.Point(480, 549);
            this.tb_Answer.Name = "tb_Answer";
            this.tb_Answer.Size = new System.Drawing.Size(253, 29);
            this.tb_Answer.TabIndex = 5;
            this.tb_Answer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Answer.Location = new System.Drawing.Point(316, 549);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(118, 23);
            this.lbl_Answer.TabIndex = 6;
            this.lbl_Answer.Text = "Answer =>";
            // 
            // gb_Operator
            // 
            this.gb_Operator.BackColor = System.Drawing.Color.LightBlue;
            this.gb_Operator.Controls.Add(this.btn_X);
            this.gb_Operator.Controls.Add(this.btn_Max);
            this.gb_Operator.Controls.Add(this.btn_Min);
            this.gb_Operator.Controls.Add(this.btn_mod);
            this.gb_Operator.Controls.Add(this.btn_sub);
            this.gb_Operator.Controls.Add(this.btn_div);
            this.gb_Operator.Controls.Add(this.btn_multi);
            this.gb_Operator.Controls.Add(this.btn_Add);
            this.gb_Operator.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Operator.Location = new System.Drawing.Point(116, 329);
            this.gb_Operator.Name = "gb_Operator";
            this.gb_Operator.Size = new System.Drawing.Size(1015, 135);
            this.gb_Operator.TabIndex = 7;
            this.gb_Operator.TabStop = false;
            this.gb_Operator.Text = "Operators";
            // 
            // btn_X
            // 
            this.btn_X.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.Location = new System.Drawing.Point(866, 40);
            this.btn_X.Name = "btn_X";
            this.btn_X.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_X.Size = new System.Drawing.Size(87, 76);
            this.btn_X.TabIndex = 10;
            this.btn_X.Text = "x²";
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Enabled = false;
            this.btn_Max.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.Location = new System.Drawing.Point(759, 40);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(75, 76);
            this.btn_Max.TabIndex = 9;
            this.btn_Max.Text = "Max";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Enabled = false;
            this.btn_Min.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(641, 40);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(75, 76);
            this.btn_Min.TabIndex = 8;
            this.btn_Min.Text = "Min";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Enabled = false;
            this.btn_mod.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.Location = new System.Drawing.Point(526, 43);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 76);
            this.btn_mod.TabIndex = 7;
            this.btn_mod.Text = "%";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.AutoEllipsis = true;
            this.btn_sub.Enabled = false;
            this.btn_sub.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(157, 40);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 76);
            this.btn_sub.TabIndex = 4;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_div
            // 
            this.btn_div.Enabled = false;
            this.btn_div.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(399, 43);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 76);
            this.btn_div.TabIndex = 6;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Enabled = false;
            this.btn_multi.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(269, 43);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_multi.Size = new System.Drawing.Size(75, 76);
            this.btn_multi.TabIndex = 5;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(35, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 76);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Blue;
            this.btn_Clear.Location = new System.Drawing.Point(822, 538);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(128, 46);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Operator
            // 
            this.lbl_Operator.AutoSize = true;
            this.lbl_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operator.Location = new System.Drawing.Point(535, 199);
            this.lbl_Operator.Name = "lbl_Operator";
            this.lbl_Operator.Size = new System.Drawing.Size(23, 36);
            this.lbl_Operator.TabIndex = 8;
            this.lbl_Operator.Text = " ";
            this.lbl_Operator.Visible = false;
            // 
            // frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Operator);
            this.Controls.Add(this.gb_Operator);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.tb_Answer);
            this.Controls.Add(this.lbl_No2);
            this.Controls.Add(this.lbl_No1);
            this.Controls.Add(this.tb_second_No);
            this.Controls.Add(this.tb_first_No);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frm_Calculator_Load);
            this.gb_Operator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_first_No;
        private System.Windows.Forms.TextBox tb_second_No;
        private System.Windows.Forms.Label lbl_No1;
        private System.Windows.Forms.Label lbl_No2;
        private System.Windows.Forms.TextBox tb_Answer;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.GroupBox gb_Operator;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Operator;
    }
}

