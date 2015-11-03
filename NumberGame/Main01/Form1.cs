using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace Main01
{
    public partial class Form1 : Form    {
        Game game = new Game();

        string userAnswerForShow="";


        public Form1()   {
            InitializeComponent();
        }

        private void buttonRestart_Click(object sender, EventArgs e)        {
            AnswerList.Items.Clear();                                       
            game.cleanAnswerAndCounts();
            game.answer = game.GenerateNumber();                            //產生4個不重複數字放到answer
            LabelAnswer.Text = game.ConvertNumbersToString(game.answer);    //重新產生4個亂數的答案
            AnswerTimeLabel.Text = "0";
        }

        private void buttonExe_Click(object sender, EventArgs e)        {

            game.aCount = 0;
            game.bCount = 0;
            game.userAnswer.Clear();

            for (int index = 0; index <= 3; index++) {
                game.userAnswer.Add(Convert.ToInt16(textBox1.Text.Substring(index, 1))); //將BOX的字串轉成List物件
            }
            game.guestTimes++;
            AnswerList.Items.Add(game.GetResult(game.userAnswer));  //猜一次答案並秀出來
            AnswerTimeLabel.Text = game.guestTimes.ToString();
            if (game.aCount == 4)
                MessageBox.Show("You Win !!");
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)  {
            textBox1.Text = "";
        }

        private void GoButton_Click(object sender, EventArgs e)  {

            //亂數猜二次
            for (int i = 0; i < 2; i++) {
                if (i==1) {
                    game.aCount = 0;
                    game.bCount = 0;
                }
                userAnswerForShow = "";     //清除
                game.userAnswer = game.GenerateNumber(game.alearlyGuestNumber);  //產生不重複4數字
                userAnswerForShow = userAnswerForShow 
                                  + game.ConvertNumbersToString(game.userAnswer)
                                  +" --->" 
                                  + game.GetResult(game.userAnswer);
                game.guestTimes++;
                game.aCountHistory.Add(game.aCount);
                game.bCountHistory.Add(game.bCount);
                AnswerTimeLabel.Text = game.guestTimes.ToString();
                AnswerList.Items.Add(userAnswerForShow);
            if (game.aCount == 4) {
                MessageBox.Show("You Win !!");
                game.end();
                }
            }

            //int te = game.aCountHistory[0] + game.bCountHistory[0];
            //MessageBox.Show(Convert.ToString(te));

            if ((game.aCountHistory[0] + game.bCountHistory[0])
                + (game.aCountHistory[1] + game.bCountHistory[1]) == 4) { //代表最後2數字是NG的
                game.impossibleNumber = game.possibleNumber.Except(game.alearlyGuestNumber).ToList(); //把最後2個數字從possibleNumber去除
            }

            foreach (int y in game.impossibleNumber) {
                MessageBox.Show(y.ToString());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            } else {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            } else {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }
    }
}
