namespace 学生考勤管理系统
{
    partial class Form3
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.termIDtxt = new System.Windows.Forms.TextBox();
            this.weekdaytxt = new System.Windows.Forms.TextBox();
            this.sectiontxt = new System.Windows.Forms.TextBox();
            this.roomNOtxt = new System.Windows.Forms.ComboBox();
            this.courseNOtxt = new System.Windows.Forms.ComboBox();
            this.classIDtxt = new System.Windows.Forms.ComboBox();
            this.teacherNOtxt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(55, 31);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(53, 12);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "学期编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "教室编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "班级编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "教师编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "星期几";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "第几节";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // termIDtxt
            // 
            this.termIDtxt.Location = new System.Drawing.Point(151, 31);
            this.termIDtxt.Name = "termIDtxt";
            this.termIDtxt.Size = new System.Drawing.Size(100, 21);
            this.termIDtxt.TabIndex = 8;
            // 
            // weekdaytxt
            // 
            this.weekdaytxt.Location = new System.Drawing.Point(131, 269);
            this.weekdaytxt.Name = "weekdaytxt";
            this.weekdaytxt.Size = new System.Drawing.Size(100, 21);
            this.weekdaytxt.TabIndex = 9;
            // 
            // sectiontxt
            // 
            this.sectiontxt.Location = new System.Drawing.Point(131, 304);
            this.sectiontxt.Name = "sectiontxt";
            this.sectiontxt.Size = new System.Drawing.Size(100, 21);
            this.sectiontxt.TabIndex = 9;
            // 
            // roomNOtxt
            // 
            this.roomNOtxt.FormattingEnabled = true;
            this.roomNOtxt.Location = new System.Drawing.Point(151, 77);
            this.roomNOtxt.Name = "roomNOtxt";
            this.roomNOtxt.Size = new System.Drawing.Size(121, 20);
            this.roomNOtxt.TabIndex = 10;
            this.roomNOtxt.SelectedIndexChanged += new System.EventHandler(this.roomNOtxt_SelectedIndexChanged);
            // 
            // courseNOtxt
            // 
            this.courseNOtxt.FormattingEnabled = true;
            this.courseNOtxt.Location = new System.Drawing.Point(151, 140);
            this.courseNOtxt.Name = "courseNOtxt";
            this.courseNOtxt.Size = new System.Drawing.Size(121, 20);
            this.courseNOtxt.TabIndex = 11;
            // 
            // classIDtxt
            // 
            this.classIDtxt.FormattingEnabled = true;
            this.classIDtxt.Location = new System.Drawing.Point(140, 191);
            this.classIDtxt.Name = "classIDtxt";
            this.classIDtxt.Size = new System.Drawing.Size(121, 20);
            this.classIDtxt.TabIndex = 12;
            // 
            // teacherNOtxt
            // 
            this.teacherNOtxt.FormattingEnabled = true;
            this.teacherNOtxt.Location = new System.Drawing.Point(140, 231);
            this.teacherNOtxt.Name = "teacherNOtxt";
            this.teacherNOtxt.Size = new System.Drawing.Size(121, 20);
            this.teacherNOtxt.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::学生考勤管理系统.Properties.Resources.login3;
            this.ClientSize = new System.Drawing.Size(477, 376);
            this.Controls.Add(this.teacherNOtxt);
            this.Controls.Add(this.classIDtxt);
            this.Controls.Add(this.courseNOtxt);
            this.Controls.Add(this.roomNOtxt);
            this.Controls.Add(this.sectiontxt);
            this.Controls.Add(this.weekdaytxt);
            this.Controls.Add(this.termIDtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox termIDtxt;
        private System.Windows.Forms.TextBox weekdaytxt;
        private System.Windows.Forms.TextBox sectiontxt;
        private System.Windows.Forms.ComboBox roomNOtxt;
        private System.Windows.Forms.ComboBox courseNOtxt;
        private System.Windows.Forms.ComboBox classIDtxt;
        private System.Windows.Forms.ComboBox teacherNOtxt;
    }
}