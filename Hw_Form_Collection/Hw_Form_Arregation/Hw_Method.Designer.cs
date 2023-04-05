namespace Hw_Form_Arregation
{
    partial class Hw_Method
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
            this.labNum = new System.Windows.Forms.Label();
            this.btnOddOrEven = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnArrMaxMin = new System.Windows.Forms.Button();
            this.btnLongest = new System.Windows.Forms.Button();
            this.btnCountOddAndEven = new System.Windows.Forms.Button();
            this.btnOut1In0 = new System.Windows.Forms.Button();
            this.btnCountC = new System.Windows.Forms.Button();
            this.btnIn0Out1 = new System.Windows.Forms.Button();
            this.btn1001 = new System.Windows.Forms.Button();
            this.btnSumArray = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnMaxArray = new System.Windows.Forms.Button();
            this.btnMinArray = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum.Location = new System.Drawing.Point(21, 37);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(75, 20);
            this.labNum.TabIndex = 0;
            this.labNum.Text = "Number:";
            // 
            // btnOddOrEven
            // 
            this.btnOddOrEven.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddOrEven.Location = new System.Drawing.Point(12, 70);
            this.btnOddOrEven.Name = "btnOddOrEven";
            this.btnOddOrEven.Size = new System.Drawing.Size(211, 29);
            this.btnOddOrEven.TabIndex = 1;
            this.btnOddOrEven.Text = "輸入的數字是奇數或偶數";
            this.btnOddOrEven.UseVisualStyleBackColor = true;
            this.btnOddOrEven.Click += new System.EventHandler(this.btnOddOrEven_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(102, 33);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 31);
            this.txtNum.TabIndex = 2;
            // 
            // btnArrMaxMin
            // 
            this.btnArrMaxMin.AutoSize = true;
            this.btnArrMaxMin.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrMaxMin.Location = new System.Drawing.Point(12, 121);
            this.btnArrMaxMin.Name = "btnArrMaxMin";
            this.btnArrMaxMin.Size = new System.Drawing.Size(217, 29);
            this.btnArrMaxMin.TabIndex = 3;
            this.btnArrMaxMin.Text = "陣列arr0711[]的最大/小值";
            this.btnArrMaxMin.UseVisualStyleBackColor = true;
            this.btnArrMaxMin.Click += new System.EventHandler(this.btnArrMaxMin_Click);
            // 
            // btnLongest
            // 
            this.btnLongest.AutoSize = true;
            this.btnLongest.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongest.Location = new System.Drawing.Point(241, 88);
            this.btnLongest.Name = "btnLongest";
            this.btnLongest.Size = new System.Drawing.Size(222, 29);
            this.btnLongest.TabIndex = 5;
            this.btnLongest.Text = "陣列arr0711_Str[]最長的名字";
            this.btnLongest.UseVisualStyleBackColor = true;
            this.btnLongest.Click += new System.EventHandler(this.btnLongest_Click);
            // 
            // btnCountOddAndEven
            // 
            this.btnCountOddAndEven.AutoSize = true;
            this.btnCountOddAndEven.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountOddAndEven.Location = new System.Drawing.Point(221, 37);
            this.btnCountOddAndEven.Name = "btnCountOddAndEven";
            this.btnCountOddAndEven.Size = new System.Drawing.Size(247, 29);
            this.btnCountOddAndEven.TabIndex = 4;
            this.btnCountOddAndEven.Text = "陣列arr0711[]統計奇偶數的數量";
            this.btnCountOddAndEven.UseVisualStyleBackColor = true;
            this.btnCountOddAndEven.Click += new System.EventHandler(this.btnCountOddAndEven_Click);
            // 
            // btnOut1In0
            // 
            this.btnOut1In0.AutoSize = true;
            this.btnOut1In0.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOut1In0.Location = new System.Drawing.Point(506, 37);
            this.btnOut1In0.Name = "btnOut1In0";
            this.btnOut1In0.Size = new System.Drawing.Size(195, 29);
            this.btnOut1In0.TabIndex = 7;
            this.btnOut1In0.Text = "[10, 10]二維陣列-邊1,內0";
            this.btnOut1In0.UseVisualStyleBackColor = true;
            this.btnOut1In0.Click += new System.EventHandler(this.btnOut1In0_Click);
            // 
            // btnCountC
            // 
            this.btnCountC.AutoSize = true;
            this.btnCountC.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountC.Location = new System.Drawing.Point(12, 179);
            this.btnCountC.Name = "btnCountC";
            this.btnCountC.Size = new System.Drawing.Size(309, 29);
            this.btnCountC.TabIndex = 6;
            this.btnCountC.Text = "陣列arr0711_Str[]xue \'C\'or\'c\'的字樣有幾個";
            this.btnCountC.UseVisualStyleBackColor = true;
            this.btnCountC.Click += new System.EventHandler(this.btnCountC_Click);
            // 
            // btnIn0Out1
            // 
            this.btnIn0Out1.AutoSize = true;
            this.btnIn0Out1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIn0Out1.Location = new System.Drawing.Point(506, 72);
            this.btnIn0Out1.Name = "btnIn0Out1";
            this.btnIn0Out1.Size = new System.Drawing.Size(195, 29);
            this.btnIn0Out1.TabIndex = 8;
            this.btnIn0Out1.Text = "[10, 10]二維陣列-邊0,內1";
            this.btnIn0Out1.UseVisualStyleBackColor = true;
            this.btnIn0Out1.Click += new System.EventHandler(this.btnIn0Out1_Click);
            // 
            // btn1001
            // 
            this.btn1001.AutoSize = true;
            this.btn1001.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1001.Location = new System.Drawing.Point(506, 107);
            this.btn1001.Name = "btn1001";
            this.btn1001.Size = new System.Drawing.Size(195, 78);
            this.btn1001.TabIndex = 9;
            this.btn1001.Text = "[10, 10]二維陣列\n101010\n010101\n......";
            this.btn1001.UseVisualStyleBackColor = true;
            this.btn1001.Click += new System.EventHandler(this.btn1001_Click);
            // 
            // btnSumArray
            // 
            this.btnSumArray.AutoSize = true;
            this.btnSumArray.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSumArray.Location = new System.Drawing.Point(728, 73);
            this.btnSumArray.Name = "btnSumArray";
            this.btnSumArray.Size = new System.Drawing.Size(172, 29);
            this.btnSumArray.TabIndex = 11;
            this.btnSumArray.Text = "Sum(陣列arr0711[])";
            this.btnSumArray.UseVisualStyleBackColor = true;
            this.btnSumArray.Click += new System.EventHandler(this.btnSumArray_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.AutoSize = true;
            this.btnSwap.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(728, 38);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(172, 29);
            this.btnSwap.TabIndex = 10;
            this.btnSwap.Text = "Swap[int, int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnMaxArray
            // 
            this.btnMaxArray.AutoSize = true;
            this.btnMaxArray.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxArray.Location = new System.Drawing.Point(728, 108);
            this.btnMaxArray.Name = "btnMaxArray";
            this.btnMaxArray.Size = new System.Drawing.Size(172, 29);
            this.btnMaxArray.TabIndex = 12;
            this.btnMaxArray.Text = "Max(陣列arr0711[])";
            this.btnMaxArray.UseVisualStyleBackColor = true;
            this.btnMaxArray.Click += new System.EventHandler(this.btnMaxArray_Click);
            // 
            // btnMinArray
            // 
            this.btnMinArray.AutoSize = true;
            this.btnMinArray.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinArray.Location = new System.Drawing.Point(728, 143);
            this.btnMinArray.Name = "btnMinArray";
            this.btnMinArray.Size = new System.Drawing.Size(172, 29);
            this.btnMinArray.TabIndex = 13;
            this.btnMinArray.Text = "Min(陣列arr0711[])";
            this.btnMinArray.UseVisualStyleBackColor = true;
            this.btnMinArray.Click += new System.EventHandler(this.btnMinArray_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(12, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(137, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Result:";
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BackColor = System.Drawing.Color.OldLace;
            this.labShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(217, 239);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(49, 20);
            this.labShow.TabIndex = 16;
            this.labShow.Text = "結果";
            // 
            // Hw_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMinArray);
            this.Controls.Add(this.btnMaxArray);
            this.Controls.Add(this.btnSumArray);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn1001);
            this.Controls.Add(this.btnIn0Out1);
            this.Controls.Add(this.btnOut1In0);
            this.Controls.Add(this.btnCountC);
            this.Controls.Add(this.btnLongest);
            this.Controls.Add(this.btnCountOddAndEven);
            this.Controls.Add(this.btnArrMaxMin);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnOddOrEven);
            this.Controls.Add(this.labNum);
            this.Name = "Hw_Method";
            this.Text = "Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Button btnOddOrEven;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnArrMaxMin;
        private System.Windows.Forms.Button btnLongest;
        private System.Windows.Forms.Button btnCountOddAndEven;
        private System.Windows.Forms.Button btnOut1In0;
        private System.Windows.Forms.Button btnCountC;
        private System.Windows.Forms.Button btnIn0Out1;
        private System.Windows.Forms.Button btn1001;
        private System.Windows.Forms.Button btnSumArray;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnMaxArray;
        private System.Windows.Forms.Button btnMinArray;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labShow;
    }
}