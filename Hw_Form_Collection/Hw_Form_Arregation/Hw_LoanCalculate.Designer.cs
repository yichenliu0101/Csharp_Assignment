namespace Hw_Form_LoanCalculate
{
    partial class Hw_LoanCalculate
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
            this.labTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labTime = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.labRate = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.labFirst = new System.Windows.Forms.Label();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(243, 59);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(71, 16);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "貸款金額";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.Location = new System.Drawing.Point(320, 56);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 27);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "100000";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(320, 89);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 27);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "2";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(243, 92);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(65, 16);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "期限(年)";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(320, 122);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 27);
            this.txtRate.TabIndex = 5;
            this.txtRate.Text = "2";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(243, 125);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(62, 16);
            this.labRate.TabIndex = 4;
            this.labRate.Text = "利率(%)";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirst.Location = new System.Drawing.Point(320, 155);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 27);
            this.txtFirst.TabIndex = 7;
            this.txtFirst.Text = "0";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirst.Location = new System.Drawing.Point(243, 158);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(55, 16);
            this.labFirst.TabIndex = 6;
            this.labFirst.Text = "頭期款";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(239, 196);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(88, 34);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(333, 196);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(88, 34);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(435, 196);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(88, 34);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Hw_LoanCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labTotal);
            this.Name = "Hw_LoanCalculate";
            this.Text = "LoanCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label labFirst;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}

