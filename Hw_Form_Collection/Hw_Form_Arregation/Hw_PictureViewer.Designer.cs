namespace Hw_Form_Arregation
{
    partial class Hw_PictureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hw_PictureViewer));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iu_10.jpg");
            this.imageList1.Images.SetKeyName(1, "iu_11.jpg");
            this.imageList1.Images.SetKeyName(2, "iu_13.jpg");
            this.imageList1.Images.SetKeyName(3, "iu_14.jpg");
            this.imageList1.Images.SetKeyName(4, "iu_15.jpg");
            this.imageList1.Images.SetKeyName(5, "iu_19.jpg");
            this.imageList1.Images.SetKeyName(6, "iu_20.jpg");
            this.imageList1.Images.SetKeyName(7, "iu_21.jpg");
            this.imageList1.Images.SetKeyName(8, "iu_28.jpg");
            this.imageList1.Images.SetKeyName(9, "iu_29.jpg");
            this.imageList1.Images.SetKeyName(10, "iu_31.jpg");
            this.imageList1.Images.SetKeyName(11, "iu_32.jpg");
            this.imageList1.Images.SetKeyName(12, "iu_33.jpg");
            this.imageList1.Images.SetKeyName(13, "iu_34.jpg");
            this.imageList1.Images.SetKeyName(14, "iu_37.jpg");
            this.imageList1.Images.SetKeyName(15, "iu_40.jpg");
            this.imageList1.Images.SetKeyName(16, "iu_51.jpg");
            this.imageList1.Images.SetKeyName(17, "DanceCat.gif");
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 539);
            this.panel1.TabIndex = 0;
            // 
            // Hw_PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 539);
            this.Controls.Add(this.panel1);
            this.Name = "Hw_PictureViewer";
            this.Text = "PictureViewer";
            this.Load += new System.EventHandler(this.Hw_PictureViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}