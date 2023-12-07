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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "아이디를 입력해 주세요.") txtUsername.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") txtUsername.Text = "아이디를 입력해 주세요.";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "비밀번호를 입력해 주세요.")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "비밀번호를 입력해 주세요.";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wku.ac.kr");
        }

        private void Button1_click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "123" && password == "123")
            {
                ShowTimetableForm();
            }
            else
            {
                MessageBox.Show("로그인 실패. 아이디와 비밀번호를 확인하세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowTimetableForm()
        {
            TimetableForm timetableForm = new TimetableForm();

            timetableForm.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Linklabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.co.kr");
        }

        private void Linklabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           System.Diagnostics.Process.Start("http://www.google.co.kr");
        }

        private void Linklabel2_Click(object sender, EventArgs e)
        {
            
        }


        private void Linklabel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Linklabel5_Click 호출됨");
            FindUsernameForm findUsernameForm = new FindUsernameForm();
            findUsernameForm.ShowDialog();
        }
    }
}