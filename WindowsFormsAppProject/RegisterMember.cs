using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class RegisterMember : Form
    {
        int DGV筆數 = 0;
       


        public RegisterMember()
        {
            InitializeComponent();
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {
            cbx性別.Items.Add("男");
            cbx性別.Items.Add("女");
            cbx性別.SelectedIndex = 0;
            產生所有會員資料();
        }

        private void btn修改會員_Click(object sender, EventArgs e)
        {  
            if (txt會員名稱.Text != "" && cbx性別.SelectedItem.ToString() != "" && txt電話.Text != null & dtp生日.Value != null) //空字串不等於null 所以要改成null
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

                //修改為 不換圖片也不會出BUG 多了一個IF去判斷
                string strSQL = "update Members set  name = @name , sex= @sex , number = @number, birthday = birthday where memberid = @memberid";
                //update Members set name = '陳大貓', sex = '男', number = '0977555333',
                //birthday = '1996-05-05' where memberid = 15

                // 等號前面是SQL的欄位名稱 後面是底下的變數名稱 逗點後面是你要存放的位置
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@name", txt會員名稱.Text);
                cmd.Parameters.AddWithValue("@sex", cbx性別.SelectedItem);
                cmd.Parameters.AddWithValue("@number", txt電話.Text);//可能是這個
                cmd.Parameters.AddWithValue("@birthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@memberid", txt會員編號.Text);



                int rows = cmd.ExecuteNonQuery();//完成         
                con.Close();
                MessageBox.Show($"會員資料修改成功,影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("會員資料修改失敗");
            }
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();//打開連接資料庫                                
                string strSQL = "select * from members where memberid > 0";
            
            if (txt會員名稱.Text != "") 
            {
                strSQL += " and name like @name";
            }
            if (cbx性別.SelectedItem.ToString() != "") 
            {
                strSQL += " and sex = @sex";
            }
            if (txt電話.Text != "") 
            {
                strSQL += " and number = @number";
            }
          
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Name", $"%{txt會員名稱.Text}%"); //有模糊字串所以有% 所以要用雙引號把兩個都帶進去 這樣就要用
                cmd.Parameters.AddWithValue("@sex", cbx性別.SelectedItem);
                cmd.Parameters.AddWithValue("@number", txt電話.Text);
                

                SqlDataReader reader = cmd.ExecuteReader(); 

                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();//創建資料表
                    dt.Load(reader);// 將資料放進資料表
                    DGV筆數 = dt.Rows.Count;
                    dgv會員資料呈現.DataSource = dt; //資料表呈現 所以是放最後
                }

                reader.Close();
                con.Close();
           
        }


        private void btn新增會員_Click(object sender, EventArgs e)
        {
            if (txt會員名稱.Text != "" && cbx性別.SelectedItem.ToString() != "" && txt電話.Text != "" && dtp生日.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
                con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
                string strSQL = "insert into Members (Name,sex,number,birthday)values(@name,@sex,@number,@birthday)";
                SqlCommand cmd = new SqlCommand(strSQL, con);


                cmd.Parameters.AddWithValue("@name", txt會員名稱.Text);
                cmd.Parameters.AddWithValue("@sex", cbx性別.SelectedItem);
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

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            txt會員編號.Clear();
            txt會員名稱.Clear();
            txt電話.Clear();
            dtp生日.Value = DateTime.Now;
            產生所有會員資料();
        }

        private void dgv會員資料呈現_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strId = dgv會員資料呈現.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strId, out selectID);

                顯示所選資料欄位(selectID);
            }
        }
        void 顯示所選資料欄位(int myId)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from members where memberid = @id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", myId);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                txt會員編號.Text = reader["memberid"].ToString();
                txt會員名稱.Text = (string)reader["name"];
                txt電話.Text = (string)reader["number"];
                //string 性別 = reader["sex"].ToString();
                //switch (性別) 這個也可以
                switch((string)reader["sex"])
                {
                    case "男":
                        cbx性別.SelectedIndex = 0;
                        break;
                    case "女":
                        cbx性別.SelectedIndex = 1;
                        break;                      

                }
                //cbx性別.SelectedItem = ((string)reader["sex"]);錯的
                dtp生日.Value = (DateTime)reader["birthday"];
            }
            else
            {
                MessageBox.Show("查無此人");
            }
            reader.Close();
            con.Close();
        }
        void 產生所有會員資料()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
            string strSQL = "select * from members"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
                                                                             

            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
                                                        //cmd = 所有資料的欄位表格 然後轉給reader

            if (reader.HasRows == true) //去讀整張select表 有讀到東西就是true 讀不到東西就是false
            {
                DataTable dt = new DataTable();//創建資料表
                dt.Load(reader);// 將資料放進資料表
                DGV筆數 = dt.Rows.Count;
                dgv會員資料呈現.DataSource = dt; //資料表呈現 所以是放最後
            }

            reader.Close();
            con.Close();
  
        }
    }
}
///
