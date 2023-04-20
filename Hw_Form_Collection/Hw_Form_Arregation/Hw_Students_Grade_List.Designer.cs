namespace Hw_Form_Arregation
{
    partial class Hw_Students_Grade_List
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
            this.listViewAvg = new System.Windows.Forms.ListView();
            this.listViewAll = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsertSave = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchMin = new System.Windows.Forms.TextBox();
            this.txtSearchMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStat = new System.Windows.Forms.Button();
            this.SearchOutput = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewAvg
            // 
            this.listViewAvg.BackColor = System.Drawing.SystemColors.Control;
            this.listViewAvg.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewAvg.HideSelection = false;
            this.listViewAvg.Location = new System.Drawing.Point(217, 305);
            this.listViewAvg.Name = "listViewAvg";
            this.listViewAvg.Size = new System.Drawing.Size(441, 88);
            this.listViewAvg.TabIndex = 37;
            this.listViewAvg.UseCompatibleStateImageBehavior = false;
            this.listViewAvg.View = System.Windows.Forms.View.Details;
            // 
            // listViewAll
            // 
            this.listViewAll.BackColor = System.Drawing.SystemColors.Control;
            this.listViewAll.FullRowSelect = true;
            this.listViewAll.GridLines = true;
            this.listViewAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAll.HideSelection = false;
            this.listViewAll.LabelWrap = false;
            this.listViewAll.Location = new System.Drawing.Point(217, 22);
            this.listViewAll.MultiSelect = false;
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(441, 278);
            this.listViewAll.TabIndex = 36;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(32, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 29);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(31, 305);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(131, 29);
            this.btnResetAll.TabIndex = 34;
            this.btnResetAll.Text = "移除所有資料";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(32, 270);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 29);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "移除資料";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsertSave
            // 
            this.btnInsertSave.Location = new System.Drawing.Point(32, 234);
            this.btnInsertSave.Name = "btnInsertSave";
            this.btnInsertSave.Size = new System.Drawing.Size(131, 29);
            this.btnInsertSave.TabIndex = 32;
            this.btnInsertSave.Text = "插入儲存資料";
            this.btnInsertSave.UseVisualStyleBackColor = true;
            this.btnInsertSave.Click += new System.EventHandler(this.btnInsertSave_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(32, 199);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(131, 29);
            this.btnAddStudent.TabIndex = 31;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(92, 168);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(71, 27);
            this.txtMath.TabIndex = 30;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "數學:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(92, 120);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(71, 27);
            this.txtEnglish.TabIndex = 28;
            this.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "英文:";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(92, 69);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(71, 27);
            this.txtChinese.TabIndex = 26;
            this.txtChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(92, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 27);
            this.txtName.TabIndex = 24;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "姓名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(37, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 14);
            this.label5.TabIndex = 38;
            this.label5.Text = "搜尋國文成績範圍:";
            // 
            // txtSearchMin
            // 
            this.txtSearchMin.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchMin.Location = new System.Drawing.Point(32, 359);
            this.txtSearchMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchMin.Name = "txtSearchMin";
            this.txtSearchMin.Size = new System.Drawing.Size(54, 24);
            this.txtSearchMin.TabIndex = 39;
            // 
            // txtSearchMax
            // 
            this.txtSearchMax.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchMax.Location = new System.Drawing.Point(104, 359);
            this.txtSearchMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchMax.Name = "txtSearchMax";
            this.txtSearchMax.Size = new System.Drawing.Size(55, 24);
            this.txtSearchMax.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(90, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 14);
            this.label6.TabIndex = 41;
            this.label6.Text = "-";
            // 
            // btnStat
            // 
            this.btnStat.Enabled = false;
            this.btnStat.Location = new System.Drawing.Point(526, 394);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(131, 29);
            this.btnStat.TabIndex = 42;
            this.btnStat.Text = "各科統計";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // SearchOutput
            // 
            this.SearchOutput.BackColor = System.Drawing.SystemColors.Control;
            this.SearchOutput.FullRowSelect = true;
            this.SearchOutput.GridLines = true;
            this.SearchOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SearchOutput.HideSelection = false;
            this.SearchOutput.LabelWrap = false;
            this.SearchOutput.Location = new System.Drawing.Point(217, 21);
            this.SearchOutput.MultiSelect = false;
            this.SearchOutput.Name = "SearchOutput";
            this.SearchOutput.Size = new System.Drawing.Size(441, 278);
            this.SearchOutput.TabIndex = 43;
            this.SearchOutput.UseCompatibleStateImageBehavior = false;
            this.SearchOutput.View = System.Windows.Forms.View.Details;
            this.SearchOutput.Visible = false;
            // 
            // Hw_Students_Grade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 455);
            this.Controls.Add(this.SearchOutput);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchMax);
            this.Controls.Add(this.txtSearchMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewAvg);
            this.Controls.Add(this.listViewAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsertSave);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hw_Students_Grade_List";
            this.Text = "StudentGradeSearch";
            this.Load += new System.EventHandler(this.Hw_Students_Grade_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAvg;
        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsertSave;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchMin;
        private System.Windows.Forms.TextBox txtSearchMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.ListView SearchOutput;
    }
}