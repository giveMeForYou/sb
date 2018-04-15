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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn;//链接器变量
        SqlDataAdapter adapter;//适配器变量
        private DataTable dbconn(string strSql) {
            conn.Open();
            this.adapter = new SqlDataAdapter(strSql, conn);//实例化适配器
            DataTable dtSelect = new DataTable();//实例化dataTable
            int rnt = this.adapter.Fill(dtSelect);
            conn.Close();
            return dtSelect;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=coursetable;Persist Security Info=True;User ID=sa;Password=123456");
            //实例化适配器
            SqlDataAdapter sda = new SqlDataAdapter("select*from couseTable", conn);
            //实例化dateSelect
            DataSet ds = new DataSet();
            //将数据添加到适配器中
            sda.Fill(ds);
            //设置dataGridView的数据源
            dataGridView1.DataSource = ds.Tables[0];
            //禁止显示标题
            dataGridView1.RowHeadersVisible = false;
            //使用for循环设置控件的列宽
            for (int i =0;i<dataGridView1.ColumnCount;i++) {
                dataGridView1.Columns[i].Width = 84;
            }

            //禁止按钮
            button1.Enabled = false;
            //将控件设置为只读
            dataGridView1.Columns[0].ReadOnly = true;


        }
        private Boolean dpUpdate() {
            string strSql = "select*from couseTable";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            dtUpdate.Rows.Clear();
            DataTable dtShow = new DataTable();
            dtShow=(DataTable)this.dataGridView1.DataSource;
            for (int i = 0; i < dtShow.Rows.Count; i++) {
                dtUpdate.ImportRow(dtShow.Rows[i]);
            }
            try {
                this.conn.Open();
                SqlCommandBuilder CommmanBuider;
                CommmanBuider = new SqlCommandBuilder(this.adapter);
                this.adapter.Update(dtUpdate);
                this.conn.Close();


            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return false;

            }
            dtUpdate.AcceptChanges();//提交更改
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dpUpdate()) {
                MessageBox.Show("修改成功！");
            }
        }
    }
}
