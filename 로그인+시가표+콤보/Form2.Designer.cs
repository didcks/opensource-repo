namespace 윈도우프로그래밍_프로젝트
{
    partial class Form2
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
            this.TimeTable = new System.Windows.Forms.DataGridView();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.ComboBox();
            this.firstGrade = new System.Windows.Forms.ComboBox();
            this.fourthGrade = new System.Windows.Forms.ComboBox();
            this.secondGrade = new System.Windows.Forms.ComboBox();
            this.thirdGrade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.ColumnHeadersHeight = 46;
            this.TimeTable.Location = new System.Drawing.Point(-2, -1);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(650, 654);
            this.TimeTable.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(383, 745);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(116, 21);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "입력";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(375, 682);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(124, 47);
            this.PlusButton.TabIndex = 4;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "first",
            "second",
            "third",
            "fourth"});
            this.grade.Location = new System.Drawing.Point(19, 670);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(90, 20);
            this.grade.TabIndex = 5;
            this.grade.SelectedIndexChanged += new System.EventHandler(this.grade_SelectedIndexChanged);
            // 
            // firstGrade
            // 
            this.firstGrade.FormattingEnabled = true;
            this.firstGrade.Items.AddRange(new object[] {
            "C언어 기초",
            "병신같은 과목",
            "원어민 외국어"});
            this.firstGrade.Location = new System.Drawing.Point(141, 670);
            this.firstGrade.Name = "firstGrade";
            this.firstGrade.Size = new System.Drawing.Size(95, 20);
            this.firstGrade.TabIndex = 6;
            this.firstGrade.Visible = false;
            this.firstGrade.SelectedIndexChanged += new System.EventHandler(this.firstGrade_SelectedIndexChanged);
            // 
            // fourthGrade
            // 
            this.fourthGrade.FormattingEnabled = true;
            this.fourthGrade.Items.AddRange(new object[] {
            "취업",
            "해야지",
            "이런"});
            this.fourthGrade.Location = new System.Drawing.Point(141, 670);
            this.fourthGrade.Name = "fourthGrade";
            this.fourthGrade.Size = new System.Drawing.Size(95, 20);
            this.fourthGrade.TabIndex = 7;
            this.fourthGrade.Visible = false;
            // 
            // secondGrade
            // 
            this.secondGrade.FormattingEnabled = true;
            this.secondGrade.Items.AddRange(new object[] {
            "2학년과목",
            "고급프로그래밍"});
            this.secondGrade.Location = new System.Drawing.Point(141, 670);
            this.secondGrade.Name = "secondGrade";
            this.secondGrade.Size = new System.Drawing.Size(95, 20);
            this.secondGrade.TabIndex = 8;
            this.secondGrade.Visible = false;
            this.secondGrade.SelectedIndexChanged += new System.EventHandler(this.secondGrade_SelectedIndexChanged);
            // 
            // thirdGrade
            // 
            this.thirdGrade.FormattingEnabled = true;
            this.thirdGrade.Items.AddRange(new object[] {
            "3학년과목1",
            "빵상",
            "데이터베이스"});
            this.thirdGrade.Location = new System.Drawing.Point(141, 670);
            this.thirdGrade.Name = "thirdGrade";
            this.thirdGrade.Size = new System.Drawing.Size(95, 20);
            this.thirdGrade.TabIndex = 9;
            this.thirdGrade.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 765);
            this.Controls.Add(this.thirdGrade);
            this.Controls.Add(this.secondGrade);
            this.Controls.Add(this.fourthGrade);
            this.Controls.Add(this.firstGrade);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TimeTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TimeTable;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.ComboBox firstGrade;
        private System.Windows.Forms.ComboBox fourthGrade;
        private System.Windows.Forms.ComboBox secondGrade;
        private System.Windows.Forms.ComboBox thirdGrade;
    }
}