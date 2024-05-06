namespace WindowsFormsAppProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView圖片 = new System.Windows.Forms.ListView();
            this.btn套餐 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.image_picture = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView圖片
            // 
            this.listView圖片.HideSelection = false;
            this.listView圖片.Location = new System.Drawing.Point(183, 95);
            this.listView圖片.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView圖片.Name = "listView圖片";
            this.listView圖片.Size = new System.Drawing.Size(600, 415);
            this.listView圖片.TabIndex = 0;
            this.listView圖片.UseCompatibleStateImageBehavior = false;
            this.listView圖片.ItemActivate += new System.EventHandler(this.listView圖片_ItemActivate);
            // 
            // btn套餐
            // 
            this.btn套餐.BackColor = System.Drawing.Color.Salmon;
            this.btn套餐.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn套餐.Location = new System.Drawing.Point(27, 95);
            this.btn套餐.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn套餐.Name = "btn套餐";
            this.btn套餐.Size = new System.Drawing.Size(151, 51);
            this.btn套餐.TabIndex = 1;
            this.btn套餐.Text = "套餐";
            this.btn套餐.UseVisualStyleBackColor = false;
            this.btn套餐.Click += new System.EventHandler(this.btn套餐_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(27, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "主餐";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.NavajoWhite;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(27, 274);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "配餐";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Plum;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(27, 365);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "飲料";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(27, 460);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "點心";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // image_picture
            // 
            this.image_picture.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_picture.ImageSize = new System.Drawing.Size(16, 16);
            this.image_picture.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 539);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn套餐);
            this.Controls.Add(this.listView圖片);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "自助點餐系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView圖片;
        private System.Windows.Forms.Button btn套餐;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList image_picture;
    }
}

