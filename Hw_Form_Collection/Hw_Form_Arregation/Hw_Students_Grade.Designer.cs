namespace Hw_Form_Arregation
{
    partial class Hw_Students_Grade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRandomSave = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnRandomAdd20 = new System.Windows.Forms.Button();
            this.listViewAll = new System.Windows.Forms.ListView();
            this.listViewAvg = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(88, 159);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(71, 27);
            this.txtMath.TabIndex = 15;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "數學:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(88, 111);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(71, 27);
            this.txtEnglish.TabIndex = 13;
            this.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "英文:";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(88, 60);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(71, 27);
            this.txtChinese.TabIndex = 11;
            this.txtChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(88, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 27);
            this.txtName.TabIndex = 9;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(28, 204);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(131, 29);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRandomSave
            // 
            this.btnRandomSave.Location = new System.Drawing.Point(28, 239);
            this.btnRandomSave.Name = "btnRandomSave";
            this.btnRandomSave.Size = new System.Drawing.Size(131, 29);
            this.btnRandomSave.TabIndex = 17;
            this.btnRandomSave.Text = "隨機儲存資料";
            this.btnRandomSave.UseVisualStyleBackColor = true;
            this.btnRandomSave.Click += new System.EventHandler(this.btnRandomSave_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(28, 274);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 29);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "各科統計";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(28, 343);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(131, 29);
            this.btnResetAll.TabIndex = 19;
            this.btnResetAll.Text = "重設所有資料";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnRandomAdd20
            // 
            this.btnRandomAdd20.Location = new System.Drawing.Point(28, 378);
            this.btnRandomAdd20.Name = "btnRandomAdd20";
            this.btnRandomAdd20.Size = new System.Drawing.Size(131, 29);
            this.btnRandomAdd20.TabIndex = 20;
            this.btnRandomAdd20.Text = "隨機加入20筆資料";
            this.btnRandomAdd20.UseVisualStyleBackColor = true;
            this.btnRandomAdd20.Click += new System.EventHandler(this.btnRandomAdd20_Click);
            // 
            // listViewAll
            // 
            this.listViewAll.BackColor = System.Drawing.SystemColors.Control;
            this.listViewAll.FullRowSelect = true;
            this.listViewAll.GridLines = true;
            this.listViewAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAll.HideSelection = false;
            this.listViewAll.LabelWrap = false;
            this.listViewAll.Location = new System.Drawing.Point(212, 13);
            this.listViewAll.MultiSelect = false;
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(441, 291);
            this.listViewAll.TabIndex = 21;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            // 
            // listViewAvg
            // 
            this.listViewAvg.BackColor = System.Drawing.SystemColors.Control;
            this.listViewAvg.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewAvg.HideSelection = false;
            this.listViewAvg.Location = new System.Drawing.Point(212, 310);
            this.listViewAvg.Name = "listViewAvg";
            this.listViewAvg.Size = new System.Drawing.Size(441, 97);
            this.listViewAvg.TabIndex = 22;
            this.listViewAvg.UseCompatibleStateImageBehavior = false;
            this.listViewAvg.View = System.Windows.Forms.View.Details;
            // 
            // Hw_Students_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.listViewAvg);
            this.Controls.Add(this.listViewAll);
            this.Controls.Add(this.btnRandomAdd20);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRandomSave);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Hw_Students_Grade";
            this.Text = "Hw_Students_Grade";
            this.Load += new System.EventHandler(this.Hw_Students_Grade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRandomSave;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnRandomAdd20;
        private System.Windows.Forms.ListView listViewAvg;
        private System.Windows.Forms.ListView listViewAll;
    }
}