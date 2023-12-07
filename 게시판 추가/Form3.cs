using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈도우프로그래밍_프로젝트
{
    public partial class Form3 : Form
    {
        private List<Post> posts = new List<Post>();

        public Form3()
        {
            InitializeComponent();

            txtTitle.Text = "";

            txtTitle.Enter += txtTitle_Enter;

            txtTitle.Leave += txtTitle_Leave;

            txtContent.Text = "";

            txtContent.Enter += txtContent_Enter;

            txtContent.Leave += txtContent_Leave;

            txtAuthor.Text = "";

            txtAuthor.Enter += txtAuthor_Enter;

            txtAuthor.Leave += txtAuthor_Leave;
        }

        private void ClearInputFields()
        {
            txtTitle.Text = string.Empty;
            txtContent.Text = string.Empty;
            txtAuthor.Text = string.Empty;
        }
    

    private void btnCreatePost_Click(object sender, EventArgs e)
        {
            // 사용자로부터 입력 받은 데이터로 게시물 객체 생성
            Post post = new Post
            {
                Title = txtTitle.Text,
                Content = txtContent.Text,
                Author = txtAuthor.Text
            };

            // 게시물을 리스트에 추가
            posts.Add(post);

            // 리스트 박스에 게시물 추가
            lstPosts.Items.Add(post.Title);

            // 입력 필드 초기화
            ClearInputFields();
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "제목을 입력해 주세요.")
            {
                txtTitle.Text = "";
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.Text = "제목을 입력해 주세요.";
            }
        }

      

        private void txtContent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                txtContent.Text = "내용을 입력해 주세요.";
            }
        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text == "내용을 입력해 주세요.")
            {
                txtContent.Text = "";
            }
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                txtAuthor.Text = "작성자를 입력해 주세요.";
            }
        }

        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "작성자를 입력해 주세요.")
            {
                txtAuthor.Text = "";
            }
        }
    }
}



