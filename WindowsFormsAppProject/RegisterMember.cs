using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class RegisterMember : Form
    {
        public RegisterMember()
        {
            InitializeComponent();
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {
            cbx性別.Items.Add("男");
            cbx性別.Items.Add("女");
        }

        private void btn修改會員_Click(object sender, EventArgs e)
        {

        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {

        }

        private void btn新增會員_Click(object sender, EventArgs e)
        {
            if (txt會員名稱.Text != "" && cbx性別.Text != "" && txt電話.Text != "" && dtp生日.Text != "") 
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
                con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
                string strSQL = "insert into Members (Name,sex,number,birthday)values(@name,@sex,@number,@birthday)"; 
                SqlCommand cmd = new SqlCommand(strSQL, con);
                
                
                cmd.Parameters.AddWithValue("@name", txt會員名稱.Text);
                cmd.Parameters.AddWithValue("@sex", cbx性別.SelectedIndex);
                cmd.Parameters.AddWithValue("@number", txt電話.Text);         
                cmd.Parameters.AddWithValue("@birthday", dtp生日.Value);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"資料新增成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("新增失敗");
            }
        }

        private void btn欄位清除_Click(object sender, EventArgs e)
        {

        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {

        }
    }
}
