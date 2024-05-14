using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppProject
{
    public partial class setmealdetail : Form
    {
        int 取出後現有數量;
        string 名稱;
        
        public setmealdetail()
        {
            InitializeComponent();
        }

        private void setmealdetail_Load(object sender, EventArgs e)
        {
            
            顯示商品詳細資訊();
           
        }
        int 價格計算() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select products.productid,[set].setid,price,setdiscount from products join [set] on products.ProductID = [set].productid join setmeal on [set].setid = setmeal.setid where setmeal.setid = @SearchID";
           

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.商品ID);
            SqlDataReader reader = cmd.ExecuteReader();
            List<int> 套餐價格 = new List<int>();
            int discount = 0;
            while (reader.Read() == true) //這裡就是讀取 然後打欄位表格的資料 sid sname 等等 型態
            {
                套餐價格.Add((int)reader["price"]);
                discount = (int)reader["setdiscount"];


               
                //套餐價格.Sum(); //218 (只有取第一個套餐但他不只一個品項 所以是228-10=218)
               
            }
            int i = 套餐價格.Sum() + discount;
            //Console.WriteLine(i);測試用

            reader.Close();
            con.Close();
            return i;//只要能獨立運算 不需要外部的運算式or資料 就不用在方法裡面設參數
            //依方法裡面的功能判定是否需要外部提供資料 需要的話 方法(要設參數)型態+名稱 不用的話就是放小括號就好
        }
           
               
           
        void 顯示商品詳細資訊()
        {
            if (GlobalVar.商品ID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from";
                if (GlobalVar.內容各別顯示 == 1)
                {
                    strSQL += " setmeal where setID = @SearchId";
                }
                else if (GlobalVar.內容各別顯示 == 0)
                {
                    strSQL += " products where productID = @SearchId";
                }
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", GlobalVar.商品ID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    if (GlobalVar.內容各別顯示 == 1)
                    {
                        txt商品名稱.Text = reader["setname"].ToString();
                        txt商品描述.Text = reader["description"].ToString();

                        txt商品價格.Text = 價格計算().ToString();


                    }   
                    else
                    {   
                        txt商品名稱.Text = reader["productname"].ToString();
                        txt商品價格.Text = reader["price"].ToString();
                        txt商品描述.Text = reader["description"].ToString();
                    }
                }

                reader.Close();
                con.Close();
            }
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            
            string strSQL = "";
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            
            if (GlobalVar.內容各別顯示 == 1) //1等於套餐
            {  
                if (是否重新購買("套餐") == "有重複") //這裡就可以用底下帶入的參數判斷是不是套餐 有沒有重複
                {   
                    strSQL = "update ShoppingCart set Quantity =@Quantity  where setid = @ID ";
                    取出後現有數量 += Convert.ToInt32(txt商品數量.Text);//txt商品數量.Text不能作為方法 所以不能給小括號

                }
                else 
                {
                    strSQL = "insert into ShoppingCart (setID,Quantity,Price) values (@ID,@Quantity,@Price)";
                    取出後現有數量 = Convert.ToInt32(txt商品數量.Text);
                }
               
            }
            else
            {
                if (是否重新購買("單點") == "有重複") //這裡就可以用底下帶入的參數判斷是不是套餐 有沒有重複
                {  //update 只需輸入會更動的欄位 單價不用 因為會另外去計算總價
                    strSQL = "update ShoppingCart set Quantity =@Quantity  where productid = @ID ";
                    取出後現有數量 += Convert.ToInt32(txt商品數量.Text);//txt商品數量.Text不能作為方法 所以不能給小括號
                }
                else
                {  //insert的話全部欄位都要輸入
                    strSQL = "insert into ShoppingCart (productID,Quantity,Price) values (@ID,@Quantity,@Price)";
                    取出後現有數量 = Convert.ToInt32(txt商品數量.Text);
                }
                
            }

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", GlobalVar.商品ID);
            cmd.Parameters.AddWithValue("@Quantity", 取出後現有數量);
            cmd.Parameters.AddWithValue("@Price", txt商品價格.Text);
            cmd.ExecuteNonQuery();



            MessageBox.Show("已加入購物車");
            con.Close();
            Close(); 
            }

        private void btn購物車列表_Click(object sender, EventArgs e)
        {
            OrderList 購物車列表 = new OrderList();
            購物車列表.ShowDialog(); 
        }

        string 是否重新購買(string 餐點內容)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);//連線資料庫的檔案丟到con
            con.Open();//打開連接資料庫                                連接都會有and 所以上面性別選擇前面才會多加and
            string strSQL;
            if (餐點內容 == "套餐")//把方法的值帶進來 讓他判斷是不是套餐
            {
                strSQL = "select * from shoppingcart where setid = @id";
                          
            }
            else 
            {
                strSQL = "select * from shoppingcart where productid = @id";
            }

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", GlobalVar.商品ID);//把ID帶進來 原始設定在listview點擊事件那邊
            SqlDataReader reader = cmd.ExecuteReader();
            
            
            while (reader.Read() == true)
            {
                if (餐點內容 == "套餐")
                {
                    if (GlobalVar.商品ID == (int)reader["setid"])
                    {
                        取出後現有數量 = (int)reader["Quantity"];
                        return "有重複";
                    }
                   
                }

                else  //單點有沒有重複
                {
                    if (GlobalVar.商品ID == (int)reader["productid"])
                    {
                        取出後現有數量 = (int)reader["Quantity"];//取出數量
                        return "有重複";
                    }
                    
                }

            }

            reader.Close();
            con.Close();
            return "沒有重複";
        }
    }
}///////////////////////////////////////////////////////////////////////
