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
    public partial class Memberlogin : Form
    {     
        int number = 0;
        public Memberlogin()
        {
            InitializeComponent();
        }

        private void Memberlogin_Load(object sender, EventArgs e)
        {
            
        }
        void 查詢ID() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫
            string strSQL = $"select memberid from members where number = @number";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@memberid", ); 錯誤示範
            cmd.Parameters.AddWithValue("@number", txt號碼.Text); //參數只帶值  memberid是欄位名稱 沒有值 所以不用代入
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                txt套餐編號.Text = reader["setID"].ToString();
                txt套餐名稱.Text = reader["setname"].ToString();
                txt套餐折扣.Text = reader["setDiscount"].ToString();


                image套餐檔名 = (string)reader["pictures"];

                string 完整圖檔路徑 = $"{GlobalVar.image_setmeal}\\{image套餐檔名}";
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);//FileStream 建立空間 存取圖檔路徑 
                //新增會成功 但是沒辦法點選 一定要去SQL把圖檔名稱修正才不會出現DEBUG


                // Image 存入圖片的檔案型態 取變數名 = Image.
                pbox套餐圖片.Image = Image.FromStream(fs);
                fs.Close();
            }


            reader.Close();
            con.Close();
        }
        void 新增訂單() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推
            string strSQL = "insert into Orders values( @MemberID, @OrderTime,)";
            //"insert into Orders values(1, '1985-07-10 09:30:00', '已出貨')";
            //"insert into products values(@productname , @Inventory, @Price, @Category , @Description, @pboxPictures)";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            
            cmd.Parameters.AddWithValue("@MemberID",);
            DateTime orderTime = new DateTime(1985, 7, 10, 9, 30, 0);
            cmd.Parameters.AddWithValue("@OrderTime", orderTime);          
                     
            


            //if (is修改圖檔 == true)
            //{
            //    cmd.Parameters.AddWithValue("@pboxPictures", str修改後圖檔名稱);
            //    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後圖檔名稱;
            //    pbox商品圖片.Image.Save(完整圖檔路徑);
            //    is修改圖檔 = false;
            //}
            //else
            //{
            //    cmd.Parameters.AddWithValue("@pboxPictures", image檔名);///沒修改圖片的話 就會拿上面原本呈現的圖片
            //}

            int rows = cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txt號碼.Text);
        }
    }
}
