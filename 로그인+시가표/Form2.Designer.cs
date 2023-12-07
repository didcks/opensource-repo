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
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.ColumnHeadersHeight = 46;
            this.TimeTable.Location = new System.Drawing.Point(-17, 4);
            this.TimeTable.Margin = new System.Windows.Forms.Padding(6);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 82;
            this.TimeTable.RowTemplate.Height = 23;
            this.TimeTable.Size = new System.Drawing.Size(1207, 1308);
            this.TimeTable.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(183, 1339);
            this.TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(212, 35);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "입력";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(675, 1307);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(6);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(230, 94);
            this.PlusButton.TabIndex = 4;
            this.PlusButton.Text = "추가";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 1406);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TimeTable);
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
    }
}