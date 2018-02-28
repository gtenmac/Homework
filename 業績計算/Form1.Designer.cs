namespace 業績計算
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonPencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonEraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonRuler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonLiWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingPencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingEraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingRuler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThingLiWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PersonPen,
            this.PersonPencil,
            this.PersonEraser,
            this.PersonRuler,
            this.PersonLiWhite,
            this.TotalMoney});
            this.dataGridView1.Location = new System.Drawing.Point(25, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThingPen,
            this.ThingPencil,
            this.ThingEraser,
            this.ThingRuler,
            this.ThingLiWhite});
            this.dataGridView2.Location = new System.Drawing.Point(25, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(595, 152);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "最佳業務員";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "最佳產品";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "業務員";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 70;
            // 
            // PersonPen
            // 
            this.PersonPen.DataPropertyName = "Pen";
            this.PersonPen.HeaderText = "原子筆";
            this.PersonPen.Name = "PersonPen";
            this.PersonPen.ReadOnly = true;
            this.PersonPen.Width = 70;
            // 
            // PersonPencil
            // 
            this.PersonPencil.DataPropertyName = "Pencil";
            this.PersonPencil.HeaderText = "鉛筆";
            this.PersonPencil.Name = "PersonPencil";
            this.PersonPencil.ReadOnly = true;
            this.PersonPencil.Width = 70;
            // 
            // PersonEraser
            // 
            this.PersonEraser.DataPropertyName = "Eraser";
            this.PersonEraser.HeaderText = "橡皮擦";
            this.PersonEraser.Name = "PersonEraser";
            this.PersonEraser.ReadOnly = true;
            this.PersonEraser.Width = 70;
            // 
            // PersonRuler
            // 
            this.PersonRuler.DataPropertyName = "Ruler";
            this.PersonRuler.HeaderText = "直尺";
            this.PersonRuler.Name = "PersonRuler";
            this.PersonRuler.ReadOnly = true;
            this.PersonRuler.Width = 70;
            // 
            // PersonLiWhite
            // 
            this.PersonLiWhite.DataPropertyName = "LiWhite";
            this.PersonLiWhite.HeaderText = "立可白";
            this.PersonLiWhite.Name = "PersonLiWhite";
            this.PersonLiWhite.ReadOnly = true;
            this.PersonLiWhite.Width = 70;
            // 
            // TotalMoney
            // 
            this.TotalMoney.DataPropertyName = "TotalMoney";
            this.TotalMoney.HeaderText = "總金額";
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.ReadOnly = true;
            // 
            // ThingPen
            // 
            this.ThingPen.DataPropertyName = "Pen";
            this.ThingPen.HeaderText = "原子筆";
            this.ThingPen.Name = "ThingPen";
            this.ThingPen.ReadOnly = true;
            this.ThingPen.Width = 70;
            // 
            // ThingPencil
            // 
            this.ThingPencil.DataPropertyName = "Pencil";
            this.ThingPencil.HeaderText = "鉛筆";
            this.ThingPencil.Name = "ThingPencil";
            this.ThingPencil.ReadOnly = true;
            this.ThingPencil.Width = 70;
            // 
            // ThingEraser
            // 
            this.ThingEraser.DataPropertyName = "Eraser";
            this.ThingEraser.HeaderText = "橡皮擦";
            this.ThingEraser.Name = "ThingEraser";
            this.ThingEraser.ReadOnly = true;
            this.ThingEraser.Width = 70;
            // 
            // ThingRuler
            // 
            this.ThingRuler.DataPropertyName = "Ruler";
            this.ThingRuler.HeaderText = "直尺";
            this.ThingRuler.Name = "ThingRuler";
            this.ThingRuler.ReadOnly = true;
            this.ThingRuler.Width = 70;
            // 
            // ThingLiWhite
            // 
            this.ThingLiWhite.DataPropertyName = "LiWhite";
            this.ThingLiWhite.HeaderText = "立可白";
            this.ThingLiWhite.Name = "ThingLiWhite";
            this.ThingLiWhite.ReadOnly = true;
            this.ThingLiWhite.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonPencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonEraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonRuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonLiWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingPencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingEraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingRuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThingLiWhite;
    }
}

