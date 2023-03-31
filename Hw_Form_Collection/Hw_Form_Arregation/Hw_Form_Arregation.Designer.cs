namespace Hw_Form_Arregation
{
    partial class Hw_Form_Arregation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnHw01 = new System.Windows.Forms.Button();
            this.btnHw02 = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(796, 472);
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnHw02);
            this.splitContainer2.Panel1.Controls.Add(this.btnHw01);
            this.splitContainer2.Size = new System.Drawing.Size(796, 418);
            this.splitContainer2.SplitterDistance = 160;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnHw01
            // 
            this.btnHw01.Location = new System.Drawing.Point(23, 13);
            this.btnHw01.Name = "btnHw01";
            this.btnHw01.Size = new System.Drawing.Size(120, 22);
            this.btnHw01.TabIndex = 0;
            this.btnHw01.Text = "Hello HI";
            this.btnHw01.UseVisualStyleBackColor = true;
            // 
            // btnHw02
            // 
            this.btnHw02.Location = new System.Drawing.Point(23, 41);
            this.btnHw02.Name = "btnHw02";
            this.btnHw02.Size = new System.Drawing.Size(120, 22);
            this.btnHw02.TabIndex = 1;
            this.btnHw02.Text = "Loan";
            this.btnHw02.UseVisualStyleBackColor = true;
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(23, 69);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(120, 22);
            this.btnPos.TabIndex = 2;
            this.btnPos.Text = "POS";
            this.btnPos.UseVisualStyleBackColor = true;
            // 
            // Hw_Form_Arregation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 472);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Hw_Form_Arregation";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnHw02;
        private System.Windows.Forms.Button btnHw01;
    }
}

