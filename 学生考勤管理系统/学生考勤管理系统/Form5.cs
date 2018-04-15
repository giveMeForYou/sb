using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace 学生考勤管理系统
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "星期/节数";
            dataGridView1.Columns[1].Name = "星期一";
            dataGridView1.Columns[2].Name = "星期二";
            dataGridView1.Columns[3].Name = "星期三";
            dataGridView1.Columns[4].Name = "星期四";
            dataGridView1.Columns[5].Name = "星期五";
            dataGridView1.ColumnHeadersVisible = true;
            string a = "select*from teaherN";
            string b = "";
            string c = "";
            string d = "";
            string ee = "";
            string[] row1 = new string[] { a, b, c, d, ee };
           /* dataGridView1.Rows.Add("第1节","Java\n 李宏宇\n509","2","3","4","5");
            dataGridView1.Rows.Add("第2节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第3节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第4节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第5节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第6节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第7节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第8节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第9节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第10节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第11节", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("第12节", "1", "2", "3", "4", "5");*/
            //建
            ArrayList list = new ArrayList();
            //星期一第一节
            list.Add("教室,1课程,教师");
            //星期一第2节
            list.Add("教室21,课程,教师");
            //星期一第3节
            list.Add("教师1");
            ArrayList list2 = new ArrayList();
            //星期一第一节
            list2.Add("教室2,课程,教师");
            //星期一第2节
            list2.Add("教室2,2课程,教师");
            //星期一第3节
            list2.Add("教师2");
            ArrayList list3 = new ArrayList();
            //星期一第一节
            list3.Add("教室3,课程,教师");
            //星期一第2节
            list3.Add("教室23,课程,教师");
            //星期一第3节
            list3.Add("教师3");
            ArrayList list4 = new ArrayList();
            //星期一第一节
            list4.Add("教室4,课程,教师");
            //星期一第2节
            list4.Add("教室24,课程,教师");
            //星期一第3节
            list4.Add("教师4");
            ArrayList list5 = new ArrayList();
            //星期一第一节
            list5.Add("教室5,课程,教师");
            //星期一第2节
            list5.Add("教室5,课程,教师");
            //星期一第3节
            list5.Add("教师5");
            //  MessageBox.Show(list[0].ToString());
            for (int i = 0; i < 3; i++) {
                dataGridView1.Rows.Add("第"+(i+1)+"节", list[i], list2[i], list3[i], list4[i], list5[i]);
            }
            //dataGridView1.Rows.Add("第12节", list[0], "2", "3", "4", "5");

        }
    }
}
