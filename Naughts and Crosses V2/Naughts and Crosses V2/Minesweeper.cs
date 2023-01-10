using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naughts_and_Crosses_V2
{
    public partial class Minesweeper : Form
    {
        Menu HomeFrm;
        bool CheckChange = true;
        int MineNum = 0;
        int BoardWidth; int BoxWidth;
        int BoardHeight; int BoxHeight;
        int BoxScale = 24;
        bool NewGame = true;
        Object[,,] Board;
        Random Rand = new Random();
        int MineTotal;

        public Minesweeper(Menu Menu)
        {
            InitializeComponent();
            HomeFrm = Menu;
            CountText.Hide();
            DifficultyDrop.Hide();
            pictureBox1.Hide();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Size = new Size(816, 489);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeFrm.Show();
        }

        private void DifficultyBox_CheckedChanged(object sender, EventArgs e){ if (CountBox.Checked && CheckChange) { CheckChange = false; CountBox.Checked = false; } else { CheckChange = true; } DifficultyDrop.Show(); CountText.Hide(); }
        private void CountBox_CheckedChanged(object sender, EventArgs e){ if(DifficultyBox.Checked && CheckChange){ CheckChange = false; DifficultyBox.Checked = false; } else { CheckChange = true; } DifficultyDrop.Hide(); CountText.Show(); }

        private void StartBut_Click(object sender, EventArgs e)
        {
            try { MineNum = int.Parse(CountText.Text); } catch { ErrorBox.Text = "That is not a number, try again."; }
            if((CountBox.Checked && MineNum > 0) || (DifficultyBox.Checked && DifficultyDrop.SelectedIndex != -1))
            {
                CountBox.Hide(); CountText.Hide(); Home.Hide(); ErrorBox.Hide(); DifficultyBox.Hide(); DifficultyDrop.Hide(); label1.Hide(); label2.Hide(); StartBut.Hide();
                pictureBox1.Show();
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (NewGame == true)
            {
                if (CountBox.Checked) { BoardWidth = 31; BoardHeight = 31; }
                else if (DifficultyDrop.SelectedIndex == 0) { BoardWidth = 9; BoardHeight = 9; MineNum = 10; } // Easy has mine density of 16%
                else if (DifficultyDrop.SelectedIndex == 1) { BoardWidth = 15; BoardHeight = 15; MineNum = 40; } // Intermediate has mine density of 18%
                else if (DifficultyDrop.SelectedIndex == 2) { BoardWidth = 22; BoardHeight = 22; MineNum = 105; } // Expert has mine density of 22%
                else if (DifficultyDrop.SelectedIndex == 3) { BoardWidth = 30; BoardHeight = 30; MineNum = 220; } // Master has mine density of 25%

                NewGame = false;
                BoxWidth = pictureBox1.Width / BoardWidth; BoxHeight = pictureBox1.Height / BoardHeight;

                GenerateBoard();
            }

            int Border = 48; //border for the canvas
            this.Size = new Size((BoxScale*BoardWidth)+Border, (BoxScale*BoardHeight)+Border+16);
            for (int x = 0; x <= BoardWidth; x++){
                for (int y = 0; y <= BoardHeight; y++){
                    e.Graphics.DrawRectangle(new Pen(Color.Black), BoxScale, BoxScale, x * BoxScale, y * BoxScale);
                }
            }
        }

        void GenerateBoard()
        {
            Board = new object[BoardWidth,BoardHeight,2];
            for (int b = 0; b < MineNum; b++)
            {
                int RandIntX = Rand.Next(0, BoardWidth); int RandIntY = Rand.Next(0, BoardHeight);
                if (Board[RandIntX, RandIntY, 0] == null) { Board[RandIntX, RandIntY, 0] = 'X'; }
                else { b--; }
            }

            for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    MineTotal = 0;
                    try { if ((char)Board[x - 1, y - 1, 0] == 'X') { MineTotal++; } } catch { } //Cheking all cells around for any mines
                    try { if ((char)Board[x - 1, y, 0] == 'X') { MineTotal++; } } catch { }     //Are trys as it can error on corners and it can just ignore those
                    try { if ((char)Board[x - 1, y + 1, 0] == 'X') { MineTotal++; } } catch { }
                    try { if ((char)Board[x, y - 1, 0] == 'X') { MineTotal++; } } catch { }
                    try { if ((char)Board[x, y + 1, 0] == 'X') { MineTotal++; } } catch { }
                    try { if ((char)Board[x + 1, y - 1, 0] == 'X') { MineTotal++; } } catch { }
                    try { if ((char)Board[x + 1, y, 0] == 'X') { MineTotal++; } } catch { }
                    try { if ((char)Board[x + 1, y + 1, 0] == 'X') { MineTotal++; } } catch { }

                    Board[x, y, 0] = MineTotal; Board[x, y, 1] = false;
                }
            }
            Console.Write(Board);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
