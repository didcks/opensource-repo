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
            this.ceuniversity = new System.Windows.Forms.ComboBox();
            this.firstGrade = new System.Windows.Forms.ComboBox();
            this.fourthGrade = new System.Windows.Forms.ComboBox();
            this.secondGrade = new System.Windows.Forms.ComboBox();
            this.thirdGrade = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cultureGrade = new System.Windows.Forms.ComboBox();
            this.list = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.ColumnHeadersHeight = 46;
            this.TimeTable.Location = new System.Drawing.Point(14, -1);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(674, 665);
            this.TimeTable.TabIndex = 1;
            this.TimeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeTable_CellClick_1);
            this.TimeTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeTable_CellValueChanged);
            // 
            // ceuniversity
            // 
            this.ceuniversity.FormattingEnabled = true;
            this.ceuniversity.Items.AddRange(new object[] {
            "1학년",
            "2학년",
            "3학년",
            "4학년",
            "교양"});
            this.ceuniversity.Location = new System.Drawing.Point(145, 670);
            this.ceuniversity.Name = "ceuniversity";
            this.ceuniversity.Size = new System.Drawing.Size(90, 20);
            this.ceuniversity.TabIndex = 5;
            this.ceuniversity.SelectedIndexChanged += new System.EventHandler(this.ceuniversity_SelectedIndexChanged);
            // 
            // firstGrade
            // 
            this.firstGrade.FormattingEnabled = true;
            this.firstGrade.Items.AddRange(new object[] {
            "종교와 원불교",
            "대학생활과 자기혁신",
            "컴퓨팅적 사고력",
            "C언어 및 실습",
            "컴퓨터 개론",
            "문학과 문화 콘텐츠",
            "실무 원어민 영어1",
            "실무 원어민 영어2",
            "IT융합기술 및 이해",
            "파이썬 프로그래밍",
            "고급 프로그래밍 언어 및 실습"});
            this.firstGrade.Location = new System.Drawing.Point(252, 672);
            this.firstGrade.Name = "firstGrade";
            this.firstGrade.Size = new System.Drawing.Size(202, 20);
            this.firstGrade.TabIndex = 6;
            this.firstGrade.Visible = false;
            this.firstGrade.SelectedIndexChanged += new System.EventHandler(this.firstGrade_SelectedIndexChanged);
            // 
            // fourthGrade
            // 
            this.fourthGrade.FormattingEnabled = true;
            this.fourthGrade.Items.AddRange(new object[] {
            "사물 인터넷 응용",
            "졸업 논문",
            "분산 시스템",
            "산학 옴니버스 강좌",
            "지능 정보 시스템",
            "빅데이터 시스템"});
            this.fourthGrade.Location = new System.Drawing.Point(252, 672);
            this.fourthGrade.Name = "fourthGrade";
            this.fourthGrade.Size = new System.Drawing.Size(202, 20);
            this.fourthGrade.TabIndex = 7;
            this.fourthGrade.Visible = false;
            this.fourthGrade.SelectedIndexChanged += new System.EventHandler(this.fourthGrade_SelectedIndexChanged);
            // 
            // secondGrade
            // 
            this.secondGrade.FormattingEnabled = true;
            this.secondGrade.Items.AddRange(new object[] {
            "데이터 구조",
            "웹 프로그래밍",
            "이산수학",
            "JAVA와 객체지향 프로그래밍",
            "대학생을 위한 기본수학",
            "컴퓨터활용1",
            "컴퓨터 조직",
            "프로그래밍 언어론",
            "알고리즘",
            "오픈소스 SW응용",
            "통계분석의 이해",
            "윈도우 프로그래밍"});
            this.secondGrade.Location = new System.Drawing.Point(252, 672);
            this.secondGrade.Name = "secondGrade";
            this.secondGrade.Size = new System.Drawing.Size(202, 20);
            this.secondGrade.TabIndex = 8;
            this.secondGrade.Visible = false;
            this.secondGrade.SelectedIndexChanged += new System.EventHandler(this.secondGrade_SelectedIndexChanged);
            // 
            // thirdGrade
            // 
            this.thirdGrade.FormattingEnabled = true;
            this.thirdGrade.Items.AddRange(new object[] {
            "안전 및 조직관례사례연구",
            "데이터베이스",
            "정보보안",
            "기업연계 프로젝트",
            "빅데이터",
            "스마트 디바이스",
            "컴퓨터 네트워크",
            "데이터베이스",
            "영상처리",
            "정보보안",
            "스마트 디바이스"});
            this.thirdGrade.Location = new System.Drawing.Point(252, 672);
            this.thirdGrade.Name = "thirdGrade";
            this.thirdGrade.Size = new System.Drawing.Size(202, 20);
            this.thirdGrade.TabIndex = 9;
            this.thirdGrade.Visible = false;
            this.thirdGrade.SelectedIndexChanged += new System.EventHandler(this.thirdGrade_SelectedIndexChanged);
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "lightBlue",
            "green",
            "yellow",
            "blue",
            "white",
            "gray",
            "red"});
            this.color.Location = new System.Drawing.Point(588, 748);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 20);
            this.color.TabIndex = 11;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(582, 670);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(106, 21);
            this.PlusButton.TabIndex = 12;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(460, 671);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(116, 21);
            this.TextBox.TabIndex = 13;
            this.TextBox.Text = "입력";
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(582, 697);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 21);
            this.bt_delete.TabIndex = 14;
            this.bt_delete.Text = "삭제";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cultureGrade
            // 
            this.cultureGrade.FormattingEnabled = true;
            this.cultureGrade.Items.AddRange(new object[] {
            "콘텐츠로보는한국문화",
            "모바일프로그래밍1",
            "실무원어민영어",
            "앱인벤터모바일프로그래밍",
            "3D프린터이해 및 활용",
            "글쓰기 이론과 실제",
            "수학과통계의세계"});
            this.cultureGrade.Location = new System.Drawing.Point(252, 672);
            this.cultureGrade.Name = "cultureGrade";
            this.cultureGrade.Size = new System.Drawing.Size(202, 20);
            this.cultureGrade.TabIndex = 15;
            this.cultureGrade.SelectedIndexChanged += new System.EventHandler(this.cultureGrade_SelectedIndexChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "창의공과대학",
            "인문대학",
            "보건과학대학",
            "의과대학",
            "치과대학",
            "사범대학",
            "조형예술디자인대학",
            "사회과학대학",
            "교학대학",
            "경영대학",
            "약학대학",
            "한의과대학",
            "독립대학"});
            this.list.Location = new System.Drawing.Point(12, 670);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 20);
            this.list.TabIndex = 16;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 780);
            this.Controls.Add(this.list);
            this.Controls.Add(this.cultureGrade);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.color);
            this.Controls.Add(this.thirdGrade);
            this.Controls.Add(this.secondGrade);
            this.Controls.Add(this.fourthGrade);
            this.Controls.Add(this.firstGrade);
            this.Controls.Add(this.ceuniversity);
            this.Controls.Add(this.TimeTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TimeTable;
        private System.Windows.Forms.ComboBox ceuniversity;
        private System.Windows.Forms.ComboBox firstGrade;
        private System.Windows.Forms.ComboBox fourthGrade;
        private System.Windows.Forms.ComboBox secondGrade;
        private System.Windows.Forms.ComboBox thirdGrade;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cultureGrade;
        private System.Windows.Forms.ComboBox list;
    }
}