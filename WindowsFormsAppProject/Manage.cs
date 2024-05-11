using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class Manage : Form
    {
        public int loadId = 0;
        string str修改後圖檔名稱 = "";
        bool is修改圖檔 = false;
        List<string> list類別 = new List<string>();
        string 類別 = "";
        int dgv筆數 = 0;
        int dgv筆數2 = 0;
        string image檔名;
        string image套餐檔名;
        public Manage()
        {
            InitializeComponent();
        }
        private void Manage_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); //設定放連線資料庫的物件
            scsb.DataSource = @".";
            scsb.InitialCatalog = "專題";
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;//連線資料庫
            cbox類別.Items.Add("套餐");
            cbox類別.Items.Add("主餐");
            cbox類別.Items.Add("配餐");
            cbox類別.Items.Add("飲料");
            cbox類別.Items.Add("點心");
            cbox類別.SelectedIndex = 0;

            cbox欄位名稱.Items.Add("ProductID");
            cbox欄位名稱.Items.Add("ProductName");
            cbox欄位名稱.Items.Add("Inventory");
            cbox欄位名稱.Items.Add("Price");
            cbox欄位名稱.Items.Add("Category");
            cbox欄位名稱.Items.Add("Description");
           
            顯示所有商品();
          
            顯示所有商品2();
           


        }

        private void btn商品上架_Click(object sender, EventArgs e)
        {                               //txt.類別
            if (txt商品名稱.Text != "" && cbox類別.Text != "" && txt商品價格.Text != "" && txt商品存貨.Text != "" && pbox商品圖片.Image != null) //空字串不等於null 所以要改成null
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推
                string strSQL = "insert into products values(@productname , @Inventory, @Price, @Category , @Description, @pboxPictures)";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@productname", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@Inventory", txt商品存貨.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@Price", intPrice);
                cmd.Parameters.AddWithValue("@Category", cbox類別.SelectedItem); //雙引號只需要前面那段變數名 後面路徑不需要            
                cmd.Parameters.AddWithValue("@Description", txt商品描述.Text);


                if (is修改圖檔 == true)
                {
                    cmd.Parameters.AddWithValue("@pboxPictures", str修改後圖檔名稱);
                    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後圖檔名稱;
                    pbox商品圖片.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                else 
                {
                    cmd.Parameters.AddWithValue("@pboxPictures", image檔名);///沒修改圖片的話 就會拿上面原本呈現的圖片
                }

                int rows = cmd.ExecuteNonQuery();
                con.Close();




                MessageBox.Show($"資料新增成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("新增失敗");
            }

        }

        private void btn商品修改_Click(object sender, EventArgs e)
        {
            if (txt商品名稱.Text != "" && cbox類別.Text != "" && txt商品價格.Text != "" && txt商品存貨.Text != "" && pbox商品圖片.Image != null) //空字串不等於null 所以要改成null
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

                //修改為 不換圖片也不會出BUG 多了一個IF去判斷
                string strSQL = "update products set productname = @productname , Inventory =@Inventory, Price = @Price , Category =@Category, Description = @Description ";
                if (is修改圖檔 == true)
                {
                    strSQL += ", pictures = @pboxPictures ";

                }
                strSQL += "where ProductID = @productID";
                // 等號前面是SQL的欄位名稱 後面是底下的變數名稱 逗點後面是你要存放的位置
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ProductID", txt商品編號.Text);
                cmd.Parameters.AddWithValue("@productname", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@Inventory", txt商品存貨.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@Price", intPrice);
                cmd.Parameters.AddWithValue("@Category", cbox類別.SelectedItem); //雙引號只需要前面那段變數名 後面路徑不需要           
                cmd.Parameters.AddWithValue("@Description", txt商品描述.Text);




                if (is修改圖檔 == true)
                {
                    cmd.Parameters.AddWithValue("@pboxPictures", str修改後圖檔名稱);
                    //image_dir = 完整路徑(class有寫入)+\(資料夾最後面都會有一個\) + 可以從SQL語法編輯查詢
                    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後圖檔名稱;
                    //str修改後圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                    pbox商品圖片.Image.Save(完整圖檔路徑);//存檔
                    is修改圖檔 = false;
                }
                int rows = cmd.ExecuteNonQuery();//完成         
                con.Close();
                MessageBox.Show($"商品修改成功,影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("商品修改失敗");
            }
        }

        private void btn選擇圖片_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }
        void 選取商品圖片()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "檔案類型(JPEG, JPG, PNG)|*.jpeg;*.jpg;*.png";

            DialogResult R = fileDialog.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(fileDialog.FileName);
                pbox商品圖片.Image = Image.FromStream(fs);
                fs.Close();
                //pbox商品圖片.Tag = fileDialog.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(fileDialog.SafeFileName).ToLower();
                Random myRnd = new Random();
                str修改後圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後圖檔名稱);
            }
        }
        void 清除欄位()
        {
            txt商品編號.Clear();
            txt商品價格.Clear();
            txt商品存貨.Clear();
            txt商品名稱.Clear();
            txt商品描述.Clear();
            txt套餐編號.Clear();
            txt套餐名稱.Clear();
            txt套餐折扣.Clear();
            pbox商品圖片.Image = null;
            pbox套餐圖片.Image = null;
            cbox類別.SelectedIndex = 0;
        }
        private void btn欄位清除_Click(object sender, EventArgs e)
        {
            清除欄位();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt搜尋關鍵字.Text != "")
            {
                string str搜尋欄位 = cbox欄位名稱.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
                con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
                string strSQL = $"select * from products where {str搜尋欄位} like @Name"; //設變數 帶入sql語法
                SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
                cmd.Parameters.AddWithValue("@Name", $"%{txt搜尋關鍵字.Text.Trim()}%"); //有模糊字串所以有% 所以要用雙引號把兩個都帶進去 這樣就要用                                                                  

                SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
                                                            //cmd = 所有資料的欄位表格 然後轉給reader

                if (reader.HasRows == true) //去讀整張select表 有讀到東西就是true 讀不到東西就是false
                {
                    DataTable dt = new DataTable();//創建資料表
                    dt.Load(reader);// 將資料放進資料表
                    dgv筆數 = dt.Rows.Count;
                    dgv資料表.DataSource = dt; //資料表呈現 所以是放最後
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("搜尋資料失敗");
            }
        }
        void 顯示所有商品()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
            string strSQL = $"select * from products"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫
            //有模糊字串所以有% 所以要用雙引號把兩個都帶進去 這樣就要用                                                                  

            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
                                                        //cmd = 所有資料的欄位表格 然後轉給reader

            if (reader.HasRows == true) //去讀整張select表 有讀到東西就是true 讀不到東西就是false
            {
                DataTable dt = new DataTable();//創建資料表
                dt.Load(reader);// 將資料放進資料表
                dgv筆數 = dt.Rows.Count;
                dgv資料表.DataSource = dt; //資料表呈現 所以是放最後
            }

            reader.Close();
            con.Close();
        }
        void 顯示所選資料(int 商品編號)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫
            //string strSQL = $"select * from student where s_id @id"; //設變數 帶入sql語法 沒寫= 所以是錯的 其他不寫=是因為在SQL語法條件判斷的時候沒有用到=

            string strSQL = $"select * from Products where Productid = @id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", 商品編號);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                txt商品編號.Text = reader["Productid"].ToString();
                txt商品名稱.Text = reader["Productname"].ToString();
                cbox類別.SelectedItem = reader["Category"].ToString();
                txt商品存貨.Text = reader["Inventory"].ToString();
                txt商品價格.Text = reader["Price"].ToString();
                txt商品描述.Text = reader["Description"].ToString();

                image檔名 = (string)reader["pictures"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image檔名}";
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);//FileStream 建立空間 存取圖檔路徑 
                //新增會成功 但是沒辦法點選 一定要去SQL把圖檔名稱修正才不會出現DEBUG


                // Image 存入圖片的檔案型態 取變數名 = Image.
                pbox商品圖片.Image = Image.FromStream(fs);
                fs.Close();
            }


            reader.Close();
            con.Close();

        }

        private void dgv資料表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數)) //搜尋後點任一欄位資料  就會把該欄位的資料 顯示到上面的表格 (點選資料是最下面的表格)
            {  //rowindex是他的語法 
                string strId = dgv資料表.Rows[e.RowIndex].Cells[0].Value.ToString();
                //e=你滑鼠點到的任何一欄 rowindex就會帶到那一個索引 然後cells[0]是判別欄位的索引順序

                int selectID = 0;
                Int32.TryParse(strId, out selectID);

                顯示所選資料(selectID);

            }
        }

        private void btn商品下架_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "Delete Products where ProductID =@ProductID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.Add("@ProductID", txt商品編號.Text);

            int num = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"刪除{num}筆資料");
            清除欄位();

        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            清除欄位();
            顯示所有商品();
        }

        private void btn套餐上架_Click(object sender, EventArgs e)
        {
            if (txt套餐名稱.Text != "" && txt套餐折扣.Text != "" && pbox套餐圖片.Image != null) //空字串不等於null 所以要改成null
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into setmeal values(@setname , @discount , @Pictures)";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@setname", txt套餐名稱.Text);
                int discount = 0;
                Int32.TryParse(txt套餐折扣.Text, out discount);
                cmd.Parameters.AddWithValue("@discount", discount);


                if (is修改圖檔 == true)
                {
                    cmd.Parameters.AddWithValue("@Pictures", str修改後圖檔名稱);
                    string 完整圖檔路徑 = GlobalVar.image_setmeal + @"\" + str修改後圖檔名稱;
                    pbox套餐圖片.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                else 
                {
                    cmd.Parameters.AddWithValue("@Pictures", image套餐檔名);
                }

                int rows = cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show($"資料新增成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("新增失敗");
            }
        }
        
        private void btn套餐修改_Click(object sender, EventArgs e)
        {
            
            if (txt套餐名稱.Text != "" && txt套餐折扣.Text != "" && pbox套餐圖片.Image != null) //空字串不等於null 所以要改成null
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();//不用寫攔位名稱 也不用寫ID 所以第一個是PNAME以此類推

                //修改為 不換圖片也不會出BUG 多了一個IF去判斷
                string strSQL = "update setmeal set setname = @setname , setdiscount = @setdiscount ";
                if (is修改圖檔 == true)
                {
                    strSQL += ", pictures = @Pictures ";

                }
                strSQL += "where setID = @setID";
                // 等號前面是SQL的欄位名稱 後面是底下的變數名稱 逗點後面是你要存放的位置
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@setID", txt套餐編號.Text);//可能是這個
                cmd.Parameters.AddWithValue("@setname", txt套餐名稱.Text);
                
                int discount = 0;
                Int32.TryParse(txt套餐折扣.Text, out discount);
                cmd.Parameters.AddWithValue("@setdiscount", discount);

                if (is修改圖檔 == true)
                {
                    cmd.Parameters.AddWithValue("@Pictures", str修改後圖檔名稱);
                    //image_dir = 完整路徑(class有寫入)+\(資料夾最後面都會有一個\) + 可以從SQL語法編輯查詢
                    string 完整圖檔路徑 = GlobalVar.image_setmeal + @"\" + str修改後圖檔名稱;
                    //str修改後圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                    pbox套餐圖片.Image.Save(完整圖檔路徑);//存檔
                    is修改圖檔 = false;
                }
                int rows = cmd.ExecuteNonQuery();//完成         
                con.Close();
                MessageBox.Show($"套餐修改成功,影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("套餐修改失敗");
            }


        }

            private void btn欄位清除2_Click(object sender, EventArgs e)
        {
            清除欄位();
        }

        private void btn套餐下架_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();
            string strSQL = "Delete setmeal where setID =@setID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.Add("@setID", txt套餐編號.Text);

            int num = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"刪除{num}筆資料");
            清除欄位();
        }

            private void btn選擇套餐圖片_Click(object sender, EventArgs e)
        {
            選取商品圖片2();
        }

        void 選取商品圖片2()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "檔案類型(JPEG, JPG, PNG)|*.jpeg;*.jpg;*.png";

            DialogResult R = fileDialog.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(fileDialog.FileName);
                pbox套餐圖片.Image = Image.FromStream(fs);
                fs.Close();
                //pbox商品圖片.Tag = fileDialog.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(fileDialog.SafeFileName).ToLower();
                Random myRnd = new Random();
                str修改後圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後圖檔名稱);
            }
        }
        void 顯示所選資料2(int 套餐編號)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫
            //string strSQL = $"select * from student where s_id @id"; //設變數 帶入sql語法 沒寫= 所以是錯的 其他不寫=是因為在SQL語法條件判斷的時候沒有用到=

            string strSQL = $"select * from setmeal where setID = @id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", 套餐編號);
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

        private void dgv套餐內容_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數2)) //搜尋後點任一欄位資料  就會把該欄位的資料 顯示到上面的表格 (點選資料是最下面的表格)
            {  //rowindex是他的語法 
                string strId = dgv套餐內容.Rows[e.RowIndex].Cells[0].Value.ToString();
                //e=你滑鼠點到的任何一欄 rowindex就會帶到那一個索引 然後cells[0]是判別欄位的索引順序

                int selectID = 0;
                Int32.TryParse(strId, out selectID);
               
                顯示所選資料2(selectID);
            }
            
        }
        void 顯示所有商品2()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
            string strSQL = $"select * from setmeal"; //設變數 帶入sql語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //設一個變數去接 strSQL=語法,con=資料庫                                                                          

            SqlDataReader reader = cmd.ExecuteReader(); // cmd.execute = 執行  丟到reader 之後要用什麼資料就去reader取 再看看要不要轉型
                                                        //cmd = 所有資料的欄位表格 然後轉給reader

            if (reader.HasRows == true) //去讀整張select表 有讀到東西就是true 讀不到東西就是false
            {
                DataTable dt = new DataTable();//創建資料表
                dt.Load(reader);// 將資料放進資料表
                dgv筆數2 = dt.Rows.Count;
                dgv套餐內容.DataSource = dt; //資料表呈現 所以是放最後
            }

            reader.Close();
            con.Close();
        }

        private void btn重新整理2_Click(object sender, EventArgs e)
        {
            顯示所有商品2();
        }
    }
}//購物車 訂單紀錄