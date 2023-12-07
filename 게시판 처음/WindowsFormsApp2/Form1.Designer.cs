namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimeTable = new System.Windows.Forms.DataGridView();
            this.PlusButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.Location = new System.Drawing.Point(12, 12);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(650, 654);
            this.TimeTable.TabIndex = 0;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(375, 693);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(124, 47);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(125, 693);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(116, 21);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "입력";
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 846);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TimeTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TimeTable;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.TextBox TextBox;
    }
}

