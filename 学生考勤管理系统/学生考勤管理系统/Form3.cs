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
using System.Configuration;
namespace 学生考勤管理系统
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string coon = ConfigurationManager.ConnectionStrings["link"].ConnectionString;
            SqlConnection conn = new SqlConnection(coon);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

              
                SqlCommand cmd = new SqlCommand("up_addCrousse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                string termID = termIDtxt.Text.Trim();//教师姓名
                string roomNO = this.roomNOtxt.Text.Trim();
                string courseNO = courseNOtxt.Text.Trim();
                string classID = this.classIDtxt.Text.Trim();
                string  teacherNO= teacherNOtxt.Text.Trim();
                string weekday = weekdaytxt.Text.Trim();
                string section = sectiontxt.Text.Trim();


                cmd.Parameters.AddWithValue("@termID", termID);
                cmd.Parameters.AddWithValue("@roomNO", roomNO);
                cmd.Parameters.AddWithValue("@courseNO", courseNO);
                cmd.Parameters.AddWithValue("@classID ", classID);
                cmd.Parameters.AddWithValue("@teacherNO", teacherNO);
                cmd.Parameters.AddWithValue("@weekday ", weekday);
                cmd.Parameters.AddWithValue("@section ", section);

                SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
                count.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int result = int.Parse(cmd.Parameters["@count"].Value.ToString());
                if (result == 1)
                {
                    MessageBox.Show("添加成功！");
                }
                else if (result == -1)
                {
                    MessageBox.Show("该用户的账号已经存在！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               // this.panel1.Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select  roomNO ,courseNO ,classID,teacherNO from couseTable";
            // cmd.CommandText = "select teacherPassword from teacher";
            cmd2.CommandType = CommandType.Text;
            SqlDataReader read = cmd2.ExecuteReader();
            this.roomNOtxt.Items.Clear();
            this.courseNOtxt.Items.Clear();
            this.classIDtxt.Items.Clear();
            this.teacherNOtxt.Items.Clear();
            while (read.Read())
            {
                
                this.roomNOtxt.Items.Add(read["roomNO"].ToString());
                this.courseNOtxt.Items.Add(read["courseNO"].ToString());
                this.classIDtxt.Items.Add(read["classID"].ToString());
                this.teacherNOtxt.Items.Add(read["teacherNO"].ToString());

            }
        }

        private void roomNOtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
