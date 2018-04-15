using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
  

    public partial class main : Form
    {
       

        public main()
        {
            InitializeComponent();
          
           
        }
        private string flag;
        /// <summary>
        /// 接受传过来的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public string Flag {
            get{
                return flag;
            }
            set{
                flag = value;
            }
        }
        SqlConnection conn;
        private void main_Load(object sender, EventArgs e)
        {
            txt.Text = this.flag;//传递获取的值
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //string sno = txt.Text;
            //MessageBox.Show(sno);
            cmd.CommandText = "select * from teacher where teacherNO ="+ txt.Text;
            cmd.CommandType = CommandType.Text;
            SqlDataReader read =cmd.ExecuteReader();
            while (read.Read()) {
                txtName.Text = read[4].ToString();
                txtSex.Text = read[2].ToString();
                txtPhone.Text = read[3].ToString();
            }
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //this.panel3.Visible = true;
            this.dataGridView1.Visible = true;
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from userView", conn);
            //创建数据集
            SqlDataAdapter sda = new SqlDataAdapter();
            //sda的属性设置为cmd
            sda.SelectCommand = cmd;
            // 创建dataset对象
            DataSet ds = new DataSet();
            //使用sda的fill方法填充dataset数据集
            sda.Fill(ds, "userView");
            dataGridView1.DataSource = ds.Tables[0];

        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
           // this.closetxt.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
         

        }
    }
}
