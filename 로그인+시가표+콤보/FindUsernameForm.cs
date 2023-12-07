using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 윈도우프로그래밍_프로젝트
{
    public partial class FindUsernameForm : Form
    {
        public FindUsernameForm()
        {
            InitializeComponent();
        }

        private void FindUsernameForm_Load(object sender, EventArgs e)
        {

        }
        private void btnFindUsername_Click(object sender, EventArgs e)
        {
            // 사용자가 입력한 이메일 주소를 가져옵니다.
            string userEmail = txtEmail.Text;

            // 이메일 주소를 사용하여 아이디를 찾는 로직을 수행합니다.
            string foundUsername = FindUsername(userEmail);

            // 결과를 사용자에게 보여줍니다.
            MessageBox.Show($"찾은 아이디: {foundUsername}", "아이디 찾기 결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string FindUsername(string userEmail)
        {
            // 실제로 아이디를 찾는 로직을 구현합니다.
            // 이 예시에서는 이메일이 "breitling50@naver.com"일 때 "soneojin"을 반환합니다.
            if (userEmail == "breitling50@naver.com")
            {
                return "soneojin";
            }
            else
            {
                // 다른 이메일에 대한 처리를 추가할 수 있습니다.
                return "아이디를 찾을 수 없습니다.";
            }
        }
    }
}
