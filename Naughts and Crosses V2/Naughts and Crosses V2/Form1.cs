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
    public partial class Form1 : Form
    {
        int turn = 1;
        string text = "X"; char arr = 'X';
        bool WinBool = false;
        char Win = '-';
        Random rnd = new Random();
        char[,] A = new char[3,3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

        public Form1()
        {
            InitializeComponent();
        }

        private void TL_Click(object sender, EventArgs e){ ButtonChange(TL, 0, 0); }
        private void TM_Click(object sender, EventArgs e){ ButtonChange(TM, 0, 1); }
        private void TR_Click(object sender, EventArgs e){ ButtonChange(TR, 0, 2); }
        private void ML_Click(object sender, EventArgs e){ ButtonChange(ML, 1, 0); }
        private void MM_Click(object sender, EventArgs e){ ButtonChange(MM, 1, 1); }
        private void MR_Click(object sender, EventArgs e){ ButtonChange(MR, 1, 2); }
        private void BL_Click(object sender, EventArgs e){ ButtonChange(BL, 2, 0); }
        private void BM_Click(object sender, EventArgs e){ ButtonChange(BM, 2, 1); }
        private void BR_Click(object sender, EventArgs e){ ButtonChange(BR, 2, 2); }

        void ButtonChange(Button button, int X, int Y)
        {
            fourinarow.Visible = false;
            if (WinBool == false && button.Text == "")
            {
                if (turn % 2 == 1) { text = "X"; arr = 'X'; }
                else if (turn % 2 == 0) { text = "O"; arr = 'O'; }
                turn++;
                button.Text = text;
                A[X, Y] = arr;
                WinCheck();
            }
            //for (int y = 0; y <= 2; y++) { Console.WriteLine(A[0, y] + " " + A[0, y] + " " + A[0, y]); }
        }

        void WinCheck()
        {
            WinBool = false;
            for (int i = 0; i <= 2; i++){
                if (A[i, 0] == A[i, 1] && A[i, 1] == A[i, 2] && A[i, 1] != '-') { WinBool = true; Win = A[i, 1]; }
            }
            for (int i = 0; i <= 2; i++){
                if (A[0, i] == A[1, i] && A[1, i] == A[2, i] && A[1, i] != '-') { WinBool = true; Win = A[1, i]; }
            }
            if (A[0, 0] == A[1, 1] && A[1, 1] == A[2, 2] && A[1, 1] != '-') { WinBool = true; Win = A[1, 1]; }
            if (A[0, 2] == A[1, 1] && A[1, 1] == A[2, 0] && A[1, 1] != '-') { WinBool = true; Win = A[1, 1]; }

            if (WinBool) { Output.Text = Win + " Wins!"; Reset.Visible = true; }
            if (turn == 10 && WinBool == false) { Output.Text = "Draw"; Reset.Visible = true; }
        }

        private void Reset_Click(object sender, EventArgs e) {
            WinBool = false;
            Win = '-';
            turn = 1;
            for (int i = 0; i <= 2; i++) { for (int j = 0; j <= 2; j++) { A[i, j] = '-'; } }
            TL.Text = ""; TM.Text = ""; TR.Text = "";
            ML.Text = ""; MM.Text = ""; MR.Text = "";
            BL.Text = ""; BM.Text = ""; BR.Text = "";
            Output.Text = "";
            Reset.Visible = false;
            fourinarow.Visible = true;
        }

        private void fourinarow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
