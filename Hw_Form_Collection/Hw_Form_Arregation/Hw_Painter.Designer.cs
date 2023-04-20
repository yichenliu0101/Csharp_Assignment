namespace Hw_Form_Arregation
{
    partial class Hw_Painter
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
            this.btnColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labeColor = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(520, 22);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 22);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(528, 88);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 178);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labeColor
            // 
            this.labeColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeColor.Location = new System.Drawing.Point(520, 46);
            this.labeColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeColor.Name = "labeColor";
            this.labeColor.Size = new System.Drawing.Size(50, 39);
            this.labeColor.TabIndex = 2;
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber.Location = new System.Drawing.Point(525, 261);
            this.labNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(16, 16);
            this.labNumber.TabIndex = 3;
            this.labNumber.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Hw_Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labeColor);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hw_Painter";
            this.Text = "小畫家";
            this.Load += new System.EventHandler(this.Hw_Painter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labeColor;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}