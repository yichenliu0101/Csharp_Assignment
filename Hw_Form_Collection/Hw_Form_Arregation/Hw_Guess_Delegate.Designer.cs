namespace Hw_Form_Arregation
{
    partial class Hw_Guess_Delegate
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
            this.btnShowAns = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.labGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowAns
            // 
            this.btnShowAns.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAns.Location = new System.Drawing.Point(481, 255);
            this.btnShowAns.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(148, 61);
            this.btnShowAns.TabIndex = 5;
            this.btnShowAns.Text = "Show Answer";
            this.btnShowAns.UseVisualStyleBackColor = true;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(212, 255);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(148, 61);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // labGuess
            // 
            this.labGuess.AutoSize = true;
            this.labGuess.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGuess.Location = new System.Drawing.Point(33, 134);
            this.labGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGuess.Name = "labGuess";
            this.labGuess.Size = new System.Drawing.Size(735, 34);
            this.labGuess.TabIndex = 3;
            this.labGuess.Text = "Please Select A Number Between 1 to 100!";
            // 
            // Hw_Guess_Delegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 342);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labGuess);
            this.Name = "Hw_Guess_Delegate";
            this.Text = "Hw_Guess_Delegate";
            this.Load += new System.EventHandler(this.Hw_Guess_Delegate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAns;
        private System.Windows.Forms.Button btnGuess;
        public System.Windows.Forms.Label labGuess;
    }
}