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
            int i = 套餐價格.Sum() - discount;
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
            名稱 = txt商品名稱.Text;
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            if (是否重新購買())
            {  
                string strSQL = "insert into ShoppingCart ";
                if (GlobalVar.內容各別顯示 == 1)
                {
                    strSQL += " (setID,Quantity,Price) values (@ID ,@Quantity ,@Price)";
                }
                else
                {
                    strSQL += " (Productid,Quantity,Price) values (@ID ,@Quantity ,@Price) ";
                }
            }
            Console.WriteLine(0);
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", GlobalVar.商品ID);
            cmd.Parameters.AddWithValue("@Quantity", txt商品數量.Text);
            cmd.Parameters.AddWithValue("@Price", txt商品價格.Text);
            cmd.ExecuteNonQuery();

         

            con.Close();
                
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
            if (餐點內容 == "套餐")
            {
                strSQL = "select * from shoppingcart where setid = @id";
                          
            }
            else 
            {
                strSQL = "select * from shoppingcart where productid = @id";
            }
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Parameters.AddWithValue("@id", 餐點內容);
            
            while (reader.Read() == true)
            {
                if (餐點內容 == "套餐")
                {
                    if (名稱 == (string)reader["setID"])
                    {
                        return "有重複";
                    }
                    else 
                    {
                        return "沒有重複";
                    }
                }

                else  //單點有沒有重複
                {
                    if (名稱 == (string)reader["productID"])
                    {
                        return "有重複";
                    }
                    else
                    {
                        return "沒有重複";
                    }
                }

            }

            reader.Close();
            con.Close();
            
        }
    }
}///////////////////////////////////////////////////////////////////////
