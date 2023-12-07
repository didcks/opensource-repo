﻿using System;
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
    public partial class Form2 : Form
    {
        DataGridViewCell selectedCell; //datagridviewcell <- 이게 표임
        public Form2()
        {
            InitializeComponent();
            InitializeTimetable(); //시작할 때 같이 실행

        }

        private void InitializeTimetable()
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            TimeTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            TimeTable.RowTemplate.Height = 20;
            
            // 초기설정 datagridview <- 이게 표임
            TimeTable.ColumnCount = 6; // 교시 열(0번 열은 교시 사용)
            TimeTable.Rows.Add("교시", "월요일", "화요일", "수요일", "목요일", "금요일");
            for (int i = 0; i < 6; i++)
            {
                TimeTable.RowTemplate.Height = 70;
            }

            // 요일 설정
            TimeTable.Rows.Add("1교시");
            TimeTable.Rows.Add("2교시");
            TimeTable.Rows.Add("3교시");
            TimeTable.Rows.Add("4교시");
            TimeTable.Rows.Add("5교시");
            TimeTable.Rows.Add("6교시");
            TimeTable.Rows.Add("7교시");
            TimeTable.Rows.Add("8교시");


            // 요일과 교시 셀들 눌러서 못 바꾸게 하는 거임(2차원 배열)
            for (int i = 0; i < TimeTable.Rows.Count; i++)
            {
                for (int j = 0; j < TimeTable.Columns.Count; j++)
                {
                    DataGridViewCell cell = TimeTable.Rows[i].Cells[j];
                    cell.ReadOnly = true; // 읽을 수만 있게
                }
            }

            

            // DataGridView 셀 클릭 이벤트 추가
            TimeTable.CellClick += TimeTable_CellClick; //cellclick 이벤트에 함수 추가

            // 변경 버튼 클릭 이벤트 추가
            PlusButton.Click += PlusButton_Click;
        }

        private void TimeTable_CellClick(object sender, DataGridViewCellEventArgs e) // 셀 눌렀을 떄
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //행렬이 0보다 큰 걸 눌렀을 떄(제대로 된 거 눌렀을 떄 만 실행한다는 거임)
            {
                selectedCell = TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex]; //선택된 셀을 이걸로 바꿈
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = grade.SelectedItem.ToString();
            if (selectedItem == "1학년")
            {
                firstGrade.Visible = true;
            }
            else
            {
                firstGrade.Visible = false;
            }

            if (selectedItem == "2학년")
            {
                secondGrade.Visible = true;
            }
            else
            {
                secondGrade.Visible = false;
            }

            if (selectedItem == "3학년")
            {
                thirdGrade.Visible = true;
            }
            else
            {
                thirdGrade.Visible = false;
            }
            if (selectedItem == "4학년")
            {
                fourthGrade.Visible = true;
            }
            else
            {
                fourthGrade.Visible = false;
            }

            if (selectedItem == "교양")
            {
                fourthGrade.Visible = true;
            }
            else
            {
                fourthGrade.Visible = false;
            }
        }

        private void secondGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputItem = secondGrade.SelectedItem.ToString();
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (TimeTable.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in TimeTable.SelectedCells)
                {
                    // 1행과 1열은 변경할 수 없도록 제한
                    if (cell.RowIndex != 0 && cell.ColumnIndex != 0)
                    {

                        cell.Value = inputItem;
                        cell.Style.BackColor = randomColor;// 선택된 모든 셀에 값을 채움
                    }
                }
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); // 선택된 셀이 없는 경우 메시지 표시
            }
        }

        private void firstGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputItem = firstGrade.SelectedItem.ToString();
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (TimeTable.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in TimeTable.SelectedCells)
                {
                    // 1행과 1열은 변경할 수 없도록 제한
                    if (cell.RowIndex != 0 && cell.ColumnIndex != 0)
                    {
                        cell.Value = inputItem; // 선택된 모든 셀에 값을 채움
                        cell.Style.BackColor = randomColor;
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); // 선택된 셀이 없는 경우 메시지 표시
            }
        }

        private void thirdGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputItem = thirdGrade.SelectedItem.ToString();
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (TimeTable.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in TimeTable.SelectedCells)
                {
                    // 1행과 1열은 변경할 수 없도록 제한
                    if (cell.RowIndex != 0 && cell.ColumnIndex != 0)
                    {
                        cell.Value = inputItem;
                        cell.Style.BackColor = randomColor;// 선택된 모든 셀에 값을 채움
                    }
                }
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); // 선택된 셀이 없는 경우 메시지 표시
            }
        }

        private void fourthGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputItem = fourthGrade.SelectedItem.ToString();
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (TimeTable.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in TimeTable.SelectedCells)
                {
                    // 1행과 1열은 변경할 수 없도록 제한
                    if (cell.RowIndex != 0 && cell.ColumnIndex != 0)
                    {
                        cell.Value = inputItem;
                        cell.Style.BackColor = randomColor;// 선택된 모든 셀에 값을 채움
                    }
                }
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); // 선택된 셀이 없는 경우 메시지 표시
            }
        }
       /*
        private void TimeTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // 1행과 1열인 경우 (인덱스가 0일 때) 변경되지 않도록 경고 메시지 표시
                if (e.RowIndex == 0 || e.ColumnIndex == 0)
                {
                    MessageBox.Show("이 셀은 변경할 수 없습니다.");
                    return;
                }

                // 이하 선택된 셀에 내용을 변경하는 코드
                string inputItem = secondGrade.SelectedItem.ToString();
                if (clickedCell != null)
                {
                    string newContent = inputItem;
                    clickedCell.Value = newContent;
                }
                else
                {
                    MessageBox.Show("셀을 먼저 선택하세요.");
                }
            }
        }
        */
        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = color.SelectedItem.ToString();
            if (selectedColor == "lightBlue")
            {
                TimeTable.DefaultCellStyle.BackColor = Color.LightBlue;
            }
            if (selectedColor == "pink")
                TimeTable.DefaultCellStyle.BackColor = Color.Pink;
            if (selectedColor == "yellow")
                TimeTable.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            if (selectedColor == "blue")
                TimeTable.DefaultCellStyle.BackColor = Color.Blue;
            if (selectedColor == "white")
                TimeTable.DefaultCellStyle.BackColor = Color.White;
            if (selectedColor == "gray")
                TimeTable.DefaultCellStyle.BackColor = Color.Gray;
        }

       
        

        private object selectedValue;

        

        private void TimeTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                selectedValue = clickedCell.Value; // 클릭된 셀의 값을 selectedValue에 저장
            }
        }

        private void TimeTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == 0 || e.ColumnIndex == 0)
            {
                // 값이 변경된 셀이 아닌 경우 또는 이전과 동일한 값으로 변경된 경우에만 실행
                if (selectedValue != null && !selectedValue.Equals(TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                {
                    TimeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = selectedValue; // 이전 값으로 다시 설정
                    MessageBox.Show("1행과 1열은 변경할 수 없습니다.");
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            /*
            if (selectedCell != null) //셀 선택 됐을떄만 실행
            {
                string newContent = TextBox.Text.Trim(); // 변경할 새로운 내용(trim이 텍스트박스 가져오는거)

                // newcontent << textbox 내용
                selectedCell.Value = newContent; //이거 값 newContent로 채움
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); //안됐으면 선택하라 뜸
            }
            */
            string inputItem = TextBox.Text.Trim();
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (TimeTable.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in TimeTable.SelectedCells)
                {
                    // 1행과 1열은 변경할 수 없도록 제한
                    if (cell.RowIndex != 0 && cell.ColumnIndex != 0)
                    {
                        cell.Value = inputItem;
                        cell.Style.BackColor = randomColor;// 선택된 모든 셀에 값을 채움
                    }
                }
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); // 선택된 셀이 없는 경우 메시지 표시
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (TimeTable.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in TimeTable.SelectedCells)
                {
                    // 1행과 1열은 변경할 수 없도록 제한
                    if (cell.RowIndex != 0 && cell.ColumnIndex != 0)
                    {
                        cell.Value = string.Empty;
                        cell.Style.BackColor = Color.White;// 선택된 모든 셀에 값을 채움
                    }
                }
            }
            else
            {
                MessageBox.Show("셀을 먼저 선택하세요."); // 선택된 셀이 없는 경우 메시지 표시
            }
        }
    }
}

