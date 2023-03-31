namespace Hw_Form_Pos
{
    partial class Hw_Form_Pos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequlia = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listShopping = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWine);
            this.groupBox1.Controls.Add(this.btnWhisky);
            this.groupBox1.Controls.Add(this.btnTequlia);
            this.groupBox1.Controls.Add(this.btnBeer);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(34, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單Menu";
            // 
            // btnWine
            // 
            this.btnWine.BackgroundImage = global::Hw_Form_Pos.Properties.Resources.Wine;
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWine.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(104, 38);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(75, 91);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "紅酒 Wine $NT220";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackgroundImage = global::Hw_Form_Pos.Properties.Resources.Whisky;
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(23, 38);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(75, 91);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌 Whisky $NT450";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequlia
            // 
            this.btnTequlia.BackgroundImage = global::Hw_Form_Pos.Properties.Resources.Tequila;
            this.btnTequlia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTequlia.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequlia.Location = new System.Drawing.Point(104, 135);
            this.btnTequlia.Name = "btnTequlia";
            this.btnTequlia.Size = new System.Drawing.Size(75, 91);
            this.btnTequlia.TabIndex = 1;
            this.btnTequlia.Text = "龍舌蘭 Tequlia $NT590";
            this.btnTequlia.UseVisualStyleBackColor = true;
            this.btnTequlia.Click += new System.EventHandler(this.btnTequlia_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = global::Hw_Form_Pos.Properties.Resources.Beer;
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(23, 135);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(75, 91);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒 Beer $NT120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTotal);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(285, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額 Total Price";
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotal.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotal.Location = new System.Drawing.Point(28, 28);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(154, 42);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "$NT0";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCredit);
            this.groupBox3.Controls.Add(this.btnCash);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(285, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "信用卡享九折";
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(112, 27);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(68, 28);
            this.btnCredit.TabIndex = 3;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(31, 26);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(68, 28);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listShopping);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(503, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 297);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 Shopping List";
            // 
            // listShopping
            // 
            this.listShopping.DisplayMember = "尚未點餐";
            this.listShopping.FormattingEnabled = true;
            this.listShopping.ItemHeight = 16;
            this.listShopping.Location = new System.Drawing.Point(6, 28);
            this.listShopping.Name = "listShopping";
            this.listShopping.Size = new System.Drawing.Size(261, 180);
            this.listShopping.Sorted = true;
            this.listShopping.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(140, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除清單";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Hw_Form_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hw_Form_Pos";
            this.Text = "POS系統";
            this.Load += new System.EventHandler(this.Hw_Form_Pos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequlia;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listShopping;
    }
}

