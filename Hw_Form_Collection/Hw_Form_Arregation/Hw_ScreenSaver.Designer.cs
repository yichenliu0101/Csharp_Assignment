namespace Hw_Form_Arregation
{
    partial class Hw_ScreenSaver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hw_ScreenSaver));
            this.DanceCat = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DanceCat)).BeginInit();
            this.SuspendLayout();
            // 
            // DanceCat
            // 
            this.DanceCat.Image = ((System.Drawing.Image)(resources.GetObject("DanceCat.Image")));
            this.DanceCat.Location = new System.Drawing.Point(9, -1);
            this.DanceCat.Margin = new System.Windows.Forms.Padding(2);
            this.DanceCat.Name = "DanceCat";
            this.DanceCat.Size = new System.Drawing.Size(246, 251);
            this.DanceCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DanceCat.TabIndex = 0;
            this.DanceCat.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hw_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(355, 354);
            this.Controls.Add(this.DanceCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hw_ScreenSaver";
            this.Text = "Hw_ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hw_ScreenSaver_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Hw_ScreenSaver_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hw_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DanceCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DanceCat;
        private System.Windows.Forms.Timer timer1;
    }
}