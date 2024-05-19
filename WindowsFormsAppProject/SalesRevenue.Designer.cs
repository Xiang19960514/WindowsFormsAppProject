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
            this.cbx年營業額 = new System.Windows.Forms.ComboBox();
            this.cbox月營業額 = new System.Windows.Forms.ComboBox();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.lbl年營業額 = new System.Windows.Forms.Label();
            this.lbl月營業額 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView歷史訂單
            // 
            this.listView歷史訂單.BackColor = System.Drawing.Color.BurlyWood;
            this.listView歷史訂單.HideSelection = false;
            this.listView歷史訂單.Location = new System.Drawing.Point(-9, 90);
            this.listView歷史訂單.Name = "listView歷史訂單";
            this.listView歷史訂單.Size = new System.Drawing.Size(521, 504);
            this.listView歷史訂單.TabIndex = 0;
            this.listView歷史訂單.UseCompatibleStateImageBehavior = false;
            // 
            // cbx年營業額
            // 
            this.cbx年營業額.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx年營業額.FormattingEnabled = true;
            this.cbx年營業額.Location = new System.Drawing.Point(12, 51);
            this.cbx年營業額.Name = "cbx年營業額";
            this.cbx年營業額.Size = new System.Drawing.Size(167, 33);
            this.cbx年營業額.TabIndex = 149;
            // 
            // cbox月營業額
            // 
            this.cbox月營業額.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox月營業額.FormattingEnabled = true;
            this.cbox月營業額.Location = new System.Drawing.Point(219, 51);
            this.cbox月營業額.Name = "cbox月營業額";
            this.cbox月營業額.Size = new System.Drawing.Size(167, 33);
            this.cbox月營業額.TabIndex = 150;
            // 
            // btn查詢
            // 
            this.btn查詢.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢.Location = new System.Drawing.Point(406, 12);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(92, 72);
            this.btn查詢.TabIndex = 151;
            this.btn查詢.Text = "查詢";
            this.btn查詢.UseVisualStyleBackColor = true;
            // 
            // lbl年營業額
            // 
            this.lbl年營業額.AutoSize = true;
            this.lbl年營業額.BackColor = System.Drawing.Color.Sienna;
            this.lbl年營業額.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl年營業額.Location = new System.Drawing.Point(28, 9);
            this.lbl年營業額.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl年營業額.Name = "lbl年營業額";
            this.lbl年營業額.Size = new System.Drawing.Size(137, 38);
            this.lbl年營業額.TabIndex = 152;
            this.lbl年營業額.Text = "年營業額";
            this.lbl年營業額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl月營業額
            // 
            this.lbl月營業額.AutoSize = true;
            this.lbl月營業額.BackColor = System.Drawing.Color.Sienna;
            this.lbl月營業額.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl月營業額.Location = new System.Drawing.Point(235, 9);
            this.lbl月營業額.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl月營業額.Name = "lbl月營業額";
            this.lbl月營業額.Size = new System.Drawing.Size(137, 38);
            this.lbl月營業額.TabIndex = 153;
            this.lbl月營業額.Text = "月營業額";
            this.lbl月營業額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 591);
            this.Controls.Add(this.lbl月營業額);
            this.Controls.Add(this.lbl年營業額);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.cbox月營業額);
            this.Controls.Add(this.cbx年營業額);
            this.Controls.Add(this.listView歷史訂單);
            this.Name = "SalesRevenue";
            this.Text = "SalesRevenue";
            this.Load += new System.EventHandler(this.SalesRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView歷史訂單;
        private System.Windows.Forms.ComboBox cbx年營業額;
        private System.Windows.Forms.ComboBox cbox月營業額;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.Label lbl年營業額;
        private System.Windows.Forms.Label lbl月營業額;
    }
}