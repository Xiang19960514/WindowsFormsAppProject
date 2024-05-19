namespace WindowsFormsAppProject
{
    partial class SalesRevenue
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
            this.listView歷史訂單 = new System.Windows.Forms.ListView();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.dtp起 = new System.Windows.Forms.DateTimePicker();
            this.dtp終 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl總營業額 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView歷史訂單
            // 
            this.listView歷史訂單.BackColor = System.Drawing.Color.BurlyWood;
            this.listView歷史訂單.HideSelection = false;
            this.listView歷史訂單.Location = new System.Drawing.Point(-9, 90);
            this.listView歷史訂單.Name = "listView歷史訂單";
            this.listView歷史訂單.Size = new System.Drawing.Size(840, 504);
            this.listView歷史訂單.TabIndex = 0;
            this.listView歷史訂單.UseCompatibleStateImageBehavior = false;
            // 
            // btn查詢
            // 
            this.btn查詢.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢.Location = new System.Drawing.Point(730, 8);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(92, 72);
            this.btn查詢.TabIndex = 151;
            this.btn查詢.Text = "查詢";
            this.btn查詢.UseVisualStyleBackColor = true;
            this.btn查詢.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // dtp起
            // 
            this.dtp起.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp起.Location = new System.Drawing.Point(524, 8);
            this.dtp起.Name = "dtp起";
            this.dtp起.Size = new System.Drawing.Size(200, 35);
            this.dtp起.TabIndex = 155;
            // 
            // dtp終
            // 
            this.dtp終.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp終.Location = new System.Drawing.Point(524, 49);
            this.dtp終.Name = "dtp終";
            this.dtp終.Size = new System.Drawing.Size(200, 35);
            this.dtp終.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(482, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 157;
            this.label1.Text = "起";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(482, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 158;
            this.label2.Text = "終";
            // 
            // lbl總營業額
            // 
            this.lbl總營業額.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl總營業額.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總營業額.Location = new System.Drawing.Point(13, 13);
            this.lbl總營業額.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl總營業額.Name = "lbl總營業額";
            this.lbl總營業額.Size = new System.Drawing.Size(288, 67);
            this.lbl總營業額.TabIndex = 159;
            this.lbl總營業額.Text = "總營業額 00000 元";
            this.lbl總營業額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.lbl總營業額);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp終);
            this.Controls.Add(this.dtp起);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.listView歷史訂單);
            this.Name = "SalesRevenue";
            this.Text = "SalesRevenue";
            this.Load += new System.EventHandler(this.SalesRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView歷史訂單;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.DateTimePicker dtp起;
        private System.Windows.Forms.DateTimePicker dtp終;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl總營業額;
    }
}