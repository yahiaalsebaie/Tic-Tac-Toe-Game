using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// جرب تخلي اللاعب يخار في الأول هل يلاعب حد معاه ولا الكومبيوتر 
// الكومبيوتر بيختار عشوائي من 1:9 والمستوى التاني عشوائي بررده بس من طرق الفوز ينقي ما بينهم

namespace _3.Tic_Tac_Toe_Game
{
    public partial class frmTicTacToeGame : Form
    {
        public frmTicTacToeGame()
        {
            InitializeComponent();
        }
        public enum enPlayer
        {
            Player1, Player2
        }
        enPlayer CurrentPlayer = enPlayer.Player1;
        public enum enWinner
        {
            Player1, Player2, Draw, GameInProgress
        }
        
        public struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            static public sbyte PlayCount;
        }
        public stGameStatus GameStatus;

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if ((btn1.Tag.ToString() != "?") && (btn1.Tag.ToString() == btn2.Tag.ToString()) && (btn2.Tag.ToString() == btn3.Tag.ToString()))
            {
                btn1.ForeColor = Color.Orchid;
                btn2.ForeColor = Color.Orchid;
                btn3.ForeColor = Color.Orchid;

                GameStatus.GameOver = true;
                GameStatus.Winner = (btn1.Tag.ToString() == "X") ? enWinner.Player1 : enWinner.Player2;
                lblWinner.Text = "     " + GameStatus.Winner.ToString().ToUpper();
                MessageBox.Show(lblWinner.Text + " Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                return true;
            }
                
            return false;
        }

        public void CheckWinner()
        {
            
            if (CheckValues(btn1, btn2, btn3)) return;
            if (CheckValues(btn4, btn5, btn6)) return;
            if (CheckValues(btn7, btn8, btn9)) return;
            if (CheckValues(btn1, btn4, btn7)) return;
            if (CheckValues(btn2, btn5, btn8)) return;
            if (CheckValues(btn3, btn6, btn9)) return;
            if (CheckValues(btn1, btn5, btn9)) return;
            if (CheckValues(btn3, btn5, btn7)) return;



            if (stGameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                MessageBox.Show("It's Draw!", "Game Over", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                lblWinner.Text = "       Draw";
            }

   
        }



        public void ChangeXorO(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                if (GameStatus.GameOver)
                {
                    MessageBox.Show("Wrong Choice", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CurrentPlayer == enPlayer.Player1)
                {
                    btn.Text = "X";
                    btn.Tag = "X";
                    btn.ForeColor = Color.DarkSalmon;
                    lblTurnPlayer.Text = "Player2";
                    CurrentPlayer = enPlayer.Player2;
                }
                else
                {
                    btn.Text = "O";
                    btn.Tag = "O";
                    btn.ForeColor = Color.White;
                    lblTurnPlayer.Text = "Player1";
                    CurrentPlayer = enPlayer.Player1;
                }
                

                    stGameStatus.PlayCount++;
                CheckWinner();
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            ChangeXorO((Button)sender);
        }

        /*
         private void btn1_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ChangeXorO(btn9);
        }
*/


        private void btnRestartGame_Click_1(object sender, EventArgs e)
        {
            GameStatus = new stGameStatus();
            stGameStatus.PlayCount = 0;
            CurrentPlayer = enPlayer.Player1;
            lblTurnPlayer.Text = "Player1";
            lblWinner.Text = "IN PROGRESS";

            foreach (Button btn in Controls.OfType<Button>().Where(B => B.Tag != null )  )
            {
                btn.Text = "?";
                btn.Tag = "?";
                btn.ForeColor = Color.Red;
            }

        }


    }
}