namespace 윈도우프로그래밍_프로젝트
{
    partial class Form3
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.lstPosts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 21);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "제목";
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 57);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(300, 100);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "내용";
            this.txtContent.Enter += new System.EventHandler(this.txtContent_Enter);
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(12, 187);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(150, 21);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.Text = "작성자";
            this.txtAuthor.Enter += new System.EventHandler(this.txtAuthor_Enter);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(212, 393);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(100, 30);
            this.btnCreatePost.TabIndex = 3;
            this.btnCreatePost.Text = "저장";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // lstPosts
            // 
            this.lstPosts.FormattingEnabled = true;
            this.lstPosts.ItemHeight = 12;
            this.lstPosts.Location = new System.Drawing.Point(12, 214);
            this.lstPosts.Name = "lstPosts";
            this.lstPosts.Size = new System.Drawing.Size(300, 148);
            this.lstPosts.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.lstPosts);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.ListBox lstPosts;
    }
}