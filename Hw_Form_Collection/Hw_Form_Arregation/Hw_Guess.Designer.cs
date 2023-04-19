namespace Hw_Form_Arregation
{
    partial class Hw_Guess
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
            this.labGuess = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labGuess
            // 
            this.labGuess.AutoSize = true;
            this.labGuess.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGuess.Location = new System.Drawing.Point(60, 88);
            this.labGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGuess.Name = "labGuess";
            this.labGuess.Size = new System.Drawing.Size(735, 34);
            this.labGuess.TabIndex = 0;
            this.labGuess.Text = "Please Select A Number Between 1 to 100!";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(239, 209);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(148, 61);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAns
            // 
            this.btnShowAns.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAns.Location = new System.Drawing.Point(508, 209);
            this.btnShowAns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(148, 61);
            this.btnShowAns.TabIndex = 2;
            this.btnShowAns.Text = "Show Answer";
            this.btnShowAns.UseVisualStyleBackColor = true;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // Hw_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 353);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labGuess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hw_Guess";
            this.Text = "Hw_Guess";
            this.Load += new System.EventHandler(this.Hw_Guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAns;
        public System.Windows.Forms.Label labGuess;
    }
}