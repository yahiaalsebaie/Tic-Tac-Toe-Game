using System;
using System.IO;
using System.Windows.Forms;
using _3.Tic_Tac_Toe_Game.Properties;

namespace _3.Tic_Tac_Toe_Game
{
    public partial class frmMain : Form
    {
        private string _player2PrevName;

        private Cursor _pointerCursor;
        private Cursor _handCursor;
        private Cursor _textCursor;
        public frmMain()
        {
            InitializeComponent();
            _player2PrevName = txtPlayer2Name.Text;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = -1;
            }
            else
            {
                numericUpDown1.Enabled = true;
                numericUpDown1.Value = 1;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Choose how many rounds to play first!", "Cannot play 0 rounds!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown1.Value = 1;
                return;
            }
            frmTicTacToeGame frmTicTacToeGame = new frmTicTacToeGame(txtPlayer1Name.Text.Trim(), txtPlayer2Name.Text.Trim(), (sbyte)numericUpDown1.Value, this);
            this.Hide();
            frmTicTacToeGame.ShowDialog();
        }

        private void rbComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComputer.Checked)
            {
                _player2PrevName = txtPlayer2Name.Text;
                lblPlayer2Title.Visible = false;
                txtPlayer2Name.Visible = false;
                txtPlayer2Name.Text = "Computer";
            }
            else
            {
                lblPlayer2Title.Visible = true;
                txtPlayer2Name.Visible = true;
                txtPlayer2Name.Text = _player2PrevName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string cursorFolder = Path.Combine(Application.StartupPath, "Cursors");

            _pointerCursor = new Cursor(Path.Combine(cursorFolder, "Cursor (32).cur"));
            _handCursor = new Cursor(Path.Combine(cursorFolder, "Hand-Cursor (32).cur"));
            _textCursor = new Cursor(Path.Combine(cursorFolder, "Text-Cursor.cur"));

            this.Cursor = _pointerCursor;
        }

        private void btnStartGame_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Cursor = _handCursor;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.XOGame96;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.XOGame;
        }

        private void txtPlayer2Name_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Cursor = _textCursor;
        }
    }
}
