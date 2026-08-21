using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private bool _isComputerPlayer = false;

        //private enum enGameLevel { Easy = 0, Medium = 1, Hard = 2 };
        enGameLevel _GameLevel = enGameLevel.Medium;
        //picEasy.Tag   = Easy = 0
        //pbMedium.Tag = Medium = 1
        //pbHard.Tag   = Hard = 2

        private Size _GameLevelPictureOriginalSize;
        private Dictionary<PictureBox, Point> _OriginalLocations;

        public frmMain()
        {
            InitializeComponent();
            _player2PrevName = txtPlayer2Name.Text;

            _GameLevelPictureOriginalSize = pbEasy.Size; // all size is the same
                                                         // _GameLevelPictureOriginalSize = pbMedium.Size;
                                                         // _GameLevelPictureOriginalSize = pbHard.Size;

            _OriginalLocations = new Dictionary<PictureBox, Point>
            {
                { pbEasy, pbEasy.Location },
                { pbMedium, pbMedium.Location },
                { pbHard, pbHard.Location }
            };
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
            frmTicTacToeGame frmTicTacToeGame = new frmTicTacToeGame(txtPlayer1Name.Text.Trim(), txtPlayer2Name.Text.Trim(), (sbyte)numericUpDown1.Value, _isComputerPlayer, _GameLevel,this);
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
                _isComputerPlayer = true;
                gbGameLevel.Visible = true;
                lblLevel.Visible = true;
                lblDifficulty.Visible = true;


                pbEasy.TabIndex = 7;
                pbMedium.TabIndex = 8;
                pbHard.TabIndex = 9;

                pbEasy.TabStop = true;
                pbMedium.TabStop = true;
                pbHard.TabStop = true;

            }
            else
            {
                lblPlayer2Title.Visible = true;
                txtPlayer2Name.Visible = true;
                _isComputerPlayer = false;
                txtPlayer2Name.Text = _player2PrevName;
                gbGameLevel.Visible = false;

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

            _GameLevel = enGameLevel.Medium; //by default

        }

        private void ctrl_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Cursor = _handCursor;
        }

        private void ctrl_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = _pointerCursor;
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

        private void ChangeSelectedLevelSize(PictureBox selectedPicture)
        {


            foreach (PictureBox pic in gbGameLevel.Controls.OfType<PictureBox>().Where(B => B.Tag != null))
            {
                pic.Size = _GameLevelPictureOriginalSize;
                pic.Location = _OriginalLocations[pic];
            }
            selectedPicture.Size = new Size((int)(selectedPicture.Width * 1.10), (int)(selectedPicture.Height * 1.25));


            selectedPicture.Location = new Point(selectedPicture.Location.X, selectedPicture.Location.Y - 10);
            _GameLevel = (enGameLevel)Convert.ToInt32(selectedPicture.Tag);

            lblLevel.Text = _GameLevel.ToString();
            switch (_GameLevel)
            {
                case enGameLevel.Easy:
                    lblLevel.ForeColor = Color.FromArgb(210, 236, 211);
                    break;
                case enGameLevel.Medium:
                    lblLevel.ForeColor = Color.FromArgb(255, 190, 47);
                    break;
                case enGameLevel.Hard:
                    lblLevel.ForeColor = Color.FromArgb(254, 76, 130);
                    break;
            }

        }
        private void GameLevel_ClickEvent(object sender, EventArgs e)
        {
            PictureBox selectedPicture = (PictureBox)sender;
            _GameLevel = (enGameLevel)Convert.ToInt32(selectedPicture.Tag);

            ChangeSelectedLevelSize(selectedPicture);
        }

        private void CenterObjOverObj(Control obj1change, Control obj2base)
        {
            obj1change.AutoSize = true;

            obj1change.Left = obj2base.Left + (obj2base.Width - obj1change.Width) / 2;
        }
        private void rbFriend_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFriend.Checked)
            {
                lblDifficulty.Visible = false;
                lblLevel.Visible = false;
            }
        }

        private void lblLevel_SizeChanged(object sender, EventArgs e)
        {
            CenterObjOverObj(lblLevel, lblPlayer2Title);

        }

    }
}
