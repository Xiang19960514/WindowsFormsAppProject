namespace WindowsFormsAppProject
{
    partial class setmealdetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn購物車列表 = new System.Windows.Forms.Button();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt商品數量 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt商品描述
            // 
            this.txt商品描述.BackColor = System.Drawing.Color.White;
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(19, 223);
            this.txt商品描述.Margin = new System.Windows.Forms.Padding(4);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(367, 168);
            this.txt商品描述.TabIndex = 15;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(145, 90);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(4);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(155, 34);
            this.txt商品價格.TabIndex = 14;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(145, 35);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(4);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(219, 34);
            this.txt商品名稱.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "商品描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "商品名稱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(378, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 30);
            this.label7.TabIndex = 18;
            // 
            // btn購物車列表
            // 
            this.btn購物車列表.BackColor = System.Drawing.Color.DarkOrange;
            this.btn購物車列表.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn購物車列表.Location = new System.Drawing.Point(428, 315);
            this.btn購物車列表.Margin = new System.Windows.Forms.Padding(4);
            this.btn購物車列表.Name = "btn購物車列表";
            this.btn購物車列表.Size = new System.Drawing.Size(168, 70);
            this.btn購物車列表.TabIndex = 21;
            this.btn購物車列表.Text = "購物車列表";
            this.btn購物車列表.UseVisualStyleBackColor = false;
            this.btn購物車列表.Click += new System.EventHandler(this.btn購物車列表_Click);
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.LightCoral;
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(428, 222);
            this.btn加入購物車.Margin = new System.Windows.Forms.Padding(4);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(168, 70);
            this.btn加入購物車.TabIndex = 22;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "商品數量";
            // 
            // txt商品數量
            // 
            this.txt商品數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品數量.Location = new System.Drawing.Point(145, 141);
            this.txt商品數量.Margin = new System.Windows.Forms.Padding(4);
            this.txt商品數量.Name = "txt商品數量";
            this.txt商品數量.Size = new System.Drawing.Size(69, 34);
            this.txt商品數量.TabIndex = 24;
            // 
            // setmealdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(607, 429);
            this.Controls.Add(this.txt商品數量);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.btn購物車列表);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "setmealdetail";
            this.Text = "setmeadetail";
            this.Load += new System.EventHandler(this.setmealdetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn購物車列表;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt商品數量;
    }
}