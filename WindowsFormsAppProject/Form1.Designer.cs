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
            this.btn主餐 = new System.Windows.Forms.Button();
            this.btn配餐 = new System.Windows.Forms.Button();
            this.btn飲料 = new System.Windows.Forms.Button();
            this.btn點心 = new System.Windows.Forms.Button();
            this.image_picture = new System.Windows.Forms.ImageList(this.components);
            this.btn查看購物車 = new System.Windows.Forms.Button();
            this.btn系統管理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView圖片
            // 
            this.listView圖片.HideSelection = false;
            this.listView圖片.Location = new System.Drawing.Point(186, 23);
            this.listView圖片.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView圖片.Name = "listView圖片";
            this.listView圖片.Size = new System.Drawing.Size(605, 510);
            this.listView圖片.TabIndex = 0;
            this.listView圖片.UseCompatibleStateImageBehavior = false;
            this.listView圖片.ItemActivate += new System.EventHandler(this.listView圖片_ItemActivate);
            // 
            // btn套餐
            // 
            this.btn套餐.BackColor = System.Drawing.Color.Salmon;
            this.btn套餐.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn套餐.Location = new System.Drawing.Point(9, 23);
            this.btn套餐.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn套餐.Name = "btn套餐";
            this.btn套餐.Size = new System.Drawing.Size(172, 51);
            this.btn套餐.TabIndex = 1;
            this.btn套餐.Text = "套餐";
            this.btn套餐.UseVisualStyleBackColor = false;
            this.btn套餐.Click += new System.EventHandler(this.btn套餐_Click);
            // 
            // btn主餐
            // 
            this.btn主餐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn主餐.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn主餐.Location = new System.Drawing.Point(8, 96);
            this.btn主餐.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn主餐.Name = "btn主餐";
            this.btn主餐.Size = new System.Drawing.Size(173, 51);
            this.btn主餐.TabIndex = 2;
            this.btn主餐.Text = "主餐";
            this.btn主餐.UseVisualStyleBackColor = false;
            this.btn主餐.Click += new System.EventHandler(this.btn主餐_Click);
            // 
            // btn配餐
            // 
            this.btn配餐.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn配餐.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn配餐.Location = new System.Drawing.Point(8, 169);
            this.btn配餐.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn配餐.Name = "btn配餐";
            this.btn配餐.Size = new System.Drawing.Size(173, 51);
            this.btn配餐.TabIndex = 3;
            this.btn配餐.Text = "配餐";
            this.btn配餐.UseVisualStyleBackColor = false;
            this.btn配餐.Click += new System.EventHandler(this.btn配餐_Click);
            // 
            // btn飲料
            // 
            this.btn飲料.BackColor = System.Drawing.Color.Plum;
            this.btn飲料.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn飲料.Location = new System.Drawing.Point(8, 243);
            this.btn飲料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn飲料.Name = "btn飲料";
            this.btn飲料.Size = new System.Drawing.Size(173, 51);
            this.btn飲料.TabIndex = 4;
            this.btn飲料.Text = "飲料";
            this.btn飲料.UseVisualStyleBackColor = false;
            this.btn飲料.Click += new System.EventHandler(this.btn飲料_Click);
            // 
            // btn點心
            // 
            this.btn點心.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn點心.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn點心.Location = new System.Drawing.Point(8, 313);
            this.btn點心.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn點心.Name = "btn點心";
            this.btn點心.Size = new System.Drawing.Size(173, 51);
            this.btn點心.TabIndex = 5;
            this.btn點心.Text = "點心";
            this.btn點心.UseVisualStyleBackColor = false;
            this.btn點心.Click += new System.EventHandler(this.btn點心_Click);
            // 
            // image_picture
            // 
            this.image_picture.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_picture.ImageSize = new System.Drawing.Size(16, 16);
            this.image_picture.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn查看購物車
            // 
            this.btn查看購物車.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn查看購物車.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看購物車.Location = new System.Drawing.Point(8, 391);
            this.btn查看購物車.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn查看購物車.Name = "btn查看購物車";
            this.btn查看購物車.Size = new System.Drawing.Size(173, 51);
            this.btn查看購物車.TabIndex = 6;
            this.btn查看購物車.Text = "查看購物車";
            this.btn查看購物車.UseVisualStyleBackColor = false;
            this.btn查看購物車.Click += new System.EventHandler(this.btn查看購物車_Click);
            // 
            // btn系統管理
            // 
            this.btn系統管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn系統管理.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統管理.Location = new System.Drawing.Point(8, 464);
            this.btn系統管理.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn系統管理.Name = "btn系統管理";
            this.btn系統管理.Size = new System.Drawing.Size(173, 51);
            this.btn系統管理.TabIndex = 7;
            this.btn系統管理.Text = "系統管理";
            this.btn系統管理.UseVisualStyleBackColor = false;
            this.btn系統管理.Click += new System.EventHandler(this.btn系統管理_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 544);
            this.Controls.Add(this.btn系統管理);
            this.Controls.Add(this.btn查看購物車);
            this.Controls.Add(this.btn點心);
            this.Controls.Add(this.btn飲料);
            this.Controls.Add(this.btn配餐);
            this.Controls.Add(this.btn主餐);
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
        private System.Windows.Forms.Button btn主餐;
        private System.Windows.Forms.Button btn配餐;
        private System.Windows.Forms.Button btn飲料;
        private System.Windows.Forms.Button btn點心;
        private System.Windows.Forms.ImageList image_picture;
        private System.Windows.Forms.Button btn查看購物車;
        private System.Windows.Forms.Button btn系統管理;
    }
}

