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
using System.Collections;
namespace 学生考勤管理系统
{
  
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
       
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0x84://鼠标点任意位置后可以拖动窗体
                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == 0x01)
                    {
                        m.Result = new IntPtr(0x02);
                    }
                    break;
                case 0xA3://禁止双击最大化
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        SqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string us1;
        string ps;
       
        private void button1_Click(object sender, EventArgs e)
            
        {
            //创建数据库连接的对象SQLConnection
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            //判断数据库连接是否打开
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //创建数据库操作对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //sql语句
            cmd.CommandText = "select teacherNO ,teacherPassword from teacher";
          // 操作的类型
            cmd.CommandType = CommandType.Text;
            //创建读取器
            SqlDataReader read = cmd.ExecuteReader();
           // 创建数组存储数据库中获取的密码和账号
            ArrayList us = new ArrayList();
            ArrayList pass = new ArrayList();
            /*通过循环用读取器读取数据库表，说明读取是按照你在读取器中添加的顺序来读取，
            一行一行的读取，地一个为0，第二个为 与表内的顺序无关，如password为原来表的最后一个现在读取为第一个即下标0
            */
            while (read.Read()) {
                //把读取到的数据库中的值存到数组中
                pass.Add(read["teacherPassword"].ToString());
                us.Add(read["teacherNO"].ToString());
            }
           
           for (int i = 0; i < us.Count; i++) {
                //把数组定义赋值给变量
                 us1 = us[i].ToString();
                 ps = pass[i].ToString();
                //逐条的和文本输入框对比
                if (textBox2.Text == us1 && textBox1.Text == ps)
                {
                    textBox2.Focus();
                    main form2 = new main();
                    //把文本框的值赋值给main窗体中FLag
                    form2.Flag = textBox2.Text;
                    //如果窗体的登录事件起作用把输入框赋值给main窗体的FLag
                    if (form2.ShowDialog() == DialogResult.OK) {
                        textBox2.Text = form2.Flag;
                    }
                   
                }


            }
           if ((textBox1.Text == "" || textBox1.Text != us1)||( textBox2.Text == "" || textBox2.Text != ps)) {
                label7.Text = "你输入的账号错误或数据库中不存在";
                label6.Text = "密码错误";

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {  //连接的数据库对象
            string coon = ConfigurationManager.ConnectionStrings["link"].ConnectionString;
            SqlConnection conn = new SqlConnection(coon);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //操作存储过程
                SqlCommand cmd = new SqlCommand("up_addTeacher", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                string teacherName = this.textBox3.Text.Trim();//文本框中输入的值赋值给存储过程的教师姓名
                string teacherSex = this.radioButton1.Checked ? "男" : "女";
                string teacherNO = this.textBox5.Text.Trim();//教师账号
                string teacherPassword = this.textBox6.Text.Trim();//密码
                string teacherPhone = this.textBox7.Text.Trim();//电话
                //cmd的参数添加的值（@为存储过程中的参数，为文本框中要添加的参数）
                cmd.Parameters.AddWithValue("@teacherName", teacherName);
                cmd.Parameters.AddWithValue("@teacherNO", teacherNO);
                cmd.Parameters.AddWithValue("@teacherPassword", teacherPassword);
                cmd.Parameters.AddWithValue("@teacherSex", teacherSex);
                cmd.Parameters.AddWithValue("@teacherPhone", teacherPhone);
                //sqlparameter 等价于cmd.parameter即参数对象
                SqlParameter count = cmd.Parameters.Add("@count", SqlDbType.Int);
                //返回对象为存储过程对象
                count.Direction = ParameterDirection.ReturnValue;
                //cql操作对象为存读取之外的类型
                cmd.ExecuteNonQuery();
                //把sqlParameter的值转化为int型
                int result = int.Parse(cmd.Parameters["@count"].Value.ToString());
                //存储过程的结果如果是1的话为添加成功 -1 为数据库已经粗在
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
            finally {
                this.panel1.Visible = false;
            }
        }

       
    }
}
