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
    public partial class Form1 : Form
    {
        Game game = new Game();
        AI aiRyan = new AI();
         


        public Form1()
        {
            
            InitializeComponent();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            game.answer = game.GenerateNumber();
            LabelAnswer.Text = game.ConvertNumbersToString(game.answer);
            
            
        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            
            AnswerList.Items.Add(game.guestTheAnswer(textBox1.Text));


        }
    }
}
