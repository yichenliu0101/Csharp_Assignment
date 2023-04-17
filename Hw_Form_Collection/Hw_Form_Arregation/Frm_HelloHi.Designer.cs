namespace Frm_M02_HelloForm
{
    partial class Frm_HelloHi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloHi));
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.labSex = new System.Windows.Forms.Label();
            this.txtAstro = new System.Windows.Forms.TextBox();
            this.labAstro = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.SystemColors.Window;
            this.labName.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labName.Location = new System.Drawing.Point(300, 123);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 15);
            this.labName.TabIndex = 0;
            this.labName.Text = "中文名字";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(398, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHello.Location = new System.Drawing.Point(420, 309);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(100, 31);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEnglish.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(398, 159);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 27);
            this.txtEnglish.TabIndex = 4;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.BackColor = System.Drawing.SystemColors.Window;
            this.labEnglish.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labEnglish.Location = new System.Drawing.Point(300, 163);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(75, 15);
            this.labEnglish.TabIndex = 3;
            this.labEnglish.Text = "英文名字";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSex.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(398, 202);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 27);
            this.txtSex.TabIndex = 6;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.SystemColors.Window;
            this.labSex.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labSex.Location = new System.Drawing.Point(300, 206);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(41, 15);
            this.labSex.TabIndex = 5;
            this.labSex.Text = "性別";
            // 
            // txtAstro
            // 
            this.txtAstro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAstro.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAstro.Location = new System.Drawing.Point(398, 250);
            this.txtAstro.Name = "txtAstro";
            this.txtAstro.Size = new System.Drawing.Size(100, 27);
            this.txtAstro.TabIndex = 8;
            // 
            // labAstro
            // 
            this.labAstro.AutoSize = true;
            this.labAstro.BackColor = System.Drawing.SystemColors.Window;
            this.labAstro.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAstro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labAstro.Location = new System.Drawing.Point(300, 254);
            this.labAstro.Name = "labAstro";
            this.labAstro.Size = new System.Drawing.Size(41, 15);
            this.labAstro.TabIndex = 7;
            this.labAstro.Text = "星座";
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHi.Location = new System.Drawing.Point(303, 309);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(100, 31);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi";
            this.btnHi.UseVisualStyleBackColor = false;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Frm_HelloHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 497);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.txtAstro);
            this.Controls.Add(this.labAstro);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HelloHi";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.TextBox txtAstro;
        private System.Windows.Forms.Label labAstro;
        private System.Windows.Forms.Button btnHi;
    }
}

