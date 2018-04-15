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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void pictureBox1_Click(object sender, EventArgs e)

        {
            dataGridView1.Visible = true;
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            /*bool courseNO =true;
            bool roomNO = true;
            string courseNO = this.filltxt.Text.ToString();
            string roomNO = this.filltxt.Text;
            SqlCommand cmd = new SqlCommand("select * from couseTable where+"+"courseNO"+this.filltxt.Text , conn);*/
            // SqlCommand cmd = new SqlCommand("select * from couseTable where courseNO ="+this.filltxt.Text, conn);
            //SqlCommand cmd = new SqlCommand("select * from couseTable where+" + "roomNO=" + this.filltxt.Text, conn);
            /*  if (courseNO == true)
              {

                  SqlCommand cmd = new SqlCommand("select * from couseTable where+" + "courseNO=" + this.filltxt.Text, conn);
                  //创建数据集
                  SqlDataAdapter sda = new SqlDataAdapter();
                  //sda的属性设置为cmd
                  sda.SelectCommand = cmd;
                  // 创建dataset对象
                  DataSet ds = new DataSet();
                  //使用sda的fill方法填充dataset数据集
                  sda.Fill(ds, "userView");
                  dataGridView1.DataSource = ds.Tables[0];
                  //courseNO = false;
              }*/
            /* if (roomNO == true) {
                SqlCommand cmd = new SqlCommand("select * from couseTable where+" + "roomNO=" + this.filltxt.Text, conn);
                //创建数据集
                SqlDataAdapter sda = new SqlDataAdapter();
                //sda的属性设置为cmd
                sda.SelectCommand = cmd;
                // 创建dataset对象
                DataSet ds = new DataSet();
                //使用sda的fill方法填充dataset数据集
                sda.Fill(ds, "userView");
                dataGridView1.DataSource = ds.Tables[0];
            }*/
            int nu1 =Convert.ToInt32 (filltxt.Text);
            if (nu1 < 999)
            {
                SqlCommand cmd = new SqlCommand("select * from couseTable where roomNO=" + this.filltxt.Text, conn);
                //创建数据集
                SqlDataAdapter sda = new SqlDataAdapter();
                //sda的属性设置为cmd
                sda.SelectCommand = cmd;
                // 创建dataset对象
                DataSet ds = new DataSet();
                //使用sda的fill方法填充dataset数据集
                sda.Fill(ds, "userView");
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Clone();
            }
            else {

                SqlCommand cmd = new SqlCommand("select * from couseTable where courseNO=" + this.filltxt.Text, conn);
                //创建数据集
                SqlDataAdapter sda = new SqlDataAdapter();
                //sda的属性设置为cmd
                sda.SelectCommand = cmd;
                // 创建dataset对象
                DataSet ds = new DataSet();
                //使用sda的fill方法填充dataset数据集
                sda.Fill(ds, "userView");
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Clone();
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Visible = true;
            string name = this.comboBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand("select*from teacher where teacherName='+" +name+"'" , conn);
            //创建数据集
            SqlDataAdapter sda = new SqlDataAdapter();
            //sda的属性设置为cmd
            sda.SelectCommand = cmd;
            // 创建dataset对象
            DataSet ds = new DataSet();
            //使用sda的fill方法填充dataset数据集
            sda.Fill(ds, "teacherNameview");
            dataGridView2.DataSource = ds.Tables[0];
            cmd.Clone();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select teacherName from teacher";

            cmd2.CommandType = CommandType.Text;
            SqlDataReader read = cmd2.ExecuteReader();
            this.comboBox1.Items.Clear();
            while (read.Read())
            {
                this.comboBox1.Items.Add(read["teacherName"].ToString());
            }
            read.Close();
        }
    }
}
