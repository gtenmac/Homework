namespace WindowsFormsApp2
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PencilAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EraserAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RulerAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiWhiteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.PenAmount,
            this.PencilAmount,
            this.EraserAmount,
            this.RulerAmount,
            this.LiWhiteAmount,
            this.TotalMoney});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.Location = new System.Drawing.Point(49, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThingName,
            this.Money});
            this.dataGridView2.Location = new System.Drawing.Point(49, 224);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(739, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(838, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(838, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(838, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "業務員";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // PenAmount
            // 
            this.PenAmount.DataPropertyName = "PenAmount";
            this.PenAmount.HeaderText = "原子筆";
            this.PenAmount.Name = "PenAmount";
            this.PenAmount.ReadOnly = true;
            // 
            // PencilAmount
            // 
            this.PencilAmount.DataPropertyName = "PencilAmount";
            this.PencilAmount.HeaderText = "鉛筆";
            this.PencilAmount.Name = "PencilAmount";
            this.PencilAmount.ReadOnly = true;
            // 
            // EraserAmount
            // 
            this.EraserAmount.DataPropertyName = "EraserAmount";
            this.EraserAmount.HeaderText = "橡皮擦";
            this.EraserAmount.Name = "EraserAmount";
            this.EraserAmount.ReadOnly = true;
            // 
            // RulerAmount
            // 
            this.RulerAmount.DataPropertyName = "RulerAmount";
            this.RulerAmount.HeaderText = "直尺";
            this.RulerAmount.Name = "RulerAmount";
            this.RulerAmount.ReadOnly = true;
            // 
            // LiWhiteAmount
            // 
            this.LiWhiteAmount.DataPropertyName = "LiWhiteAmount";
            this.LiWhiteAmount.HeaderText = "立可白";
            this.LiWhiteAmount.Name = "LiWhiteAmount";
            this.LiWhiteAmount.ReadOnly = true;
            // 
            // TotalMoney
            // 
            this.TotalMoney.DataPropertyName = "TotalMoney";
            this.TotalMoney.HeaderText = "銷售總金額";
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.ReadOnly = true;
            // 
            // ThingName
            // 
            this.ThingName.DataPropertyName = "ThingName";
            this.ThingName.HeaderText = "物品名稱";
            this.ThingName.Name = "ThingName";
            this.ThingName.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.HeaderText = "單價";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 420);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PencilAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EraserAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulerAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiWhiteAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
    }
}

