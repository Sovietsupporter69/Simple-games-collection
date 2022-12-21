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
    public partial class Form2 : Form
    {
        string TurnC;
        int Turn = 0;
        bool Win;
        string WinChar;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fourinarow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void D0_Click(object sender, EventArgs e) { Place(0); }
        private void D1_Click(object sender, EventArgs e) { Place(1); }
        private void D2_Click(object sender, EventArgs e) { Place(2); }
        private void D3_Click(object sender, EventArgs e) { Place(3); }
        private void D4_Click(object sender, EventArgs e) { Place(4); }
        private void D5_Click(object sender, EventArgs e) { Place(5); }
        private void D6_Click(object sender, EventArgs e) { Place(6); }

        void Place(int Column) {
            bool Placed = false;
            noughtsandcrosses.Visible = false;

            if (!Win)
            {
                Turn++;
                if (Turn % 2 == 1) { TurnC = "X"; }
                else if (Turn % 1 == 0) { TurnC = "O"; }

                for (int i = 0; i < 6; i++)
                {
                    string s = "R" + i + "C" + Column;
                    var Controls = this.Controls.Find(s, true);
                    if ((Controls[0] as TextBox).Text == "")
                    {
                        Placed = true;
                        int Coni = i + 1;
                        string Cons = "R" + Coni + "C" + Column;
                        var ConControls = this.Controls.Find(Cons, true);
                        (Controls[0] as TextBox).Text = TurnC;
                        break;
                    }
                }
            }
            if (!Placed) { Turn--; }

            WinCheck();
        }

        void WinCheck()
        {
            Win = false;
            for (int y = 0; y <= 2; y++){
                for (int x = 0; x <= 6; x++) {
                    if ((this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 1) + "C" + x, true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 1) + "C" + x, true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 2) + "C" + x, true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 2) + "C" + x, true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 3) + "C" + x, true)[0] as TextBox).Text && (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text != "")
                    {
                        WinChar = (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text;
                        Win = true; //Vertical win checks
                    }
                }
            }
            for (int y = 0; y <= 5; y++){
                for (int x = 0; x <= 3; x++){
                    if ((this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text == (this.Controls.Find("R" + y + "C" + (x + 1), true)[0] as TextBox).Text && (this.Controls.Find("R" + y + "C" + (x + 1), true)[0] as TextBox).Text == (this.Controls.Find("R" + y + "C" + (x + 2), true)[0] as TextBox).Text && (this.Controls.Find("R" + y + "C" + (x + 2), true)[0] as TextBox).Text == (this.Controls.Find("R" + y + "C" + (x + 3), true)[0] as TextBox).Text && (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text != "")
                    {
                        WinChar = (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text;
                        Win = true; //horisontal win checks
                    }
                }
            }
            for (int y = 0; y <= 2; y++){
                for (int x = 0; x <= 3; x++){
                    if ((this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 1) + "C" + (x + 1), true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 1) + "C" + (x + 1), true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 2) + "C" + (x + 2), true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 2) + "C" + (x + 2), true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 3) + "C" + (x + 3), true)[0] as TextBox).Text && (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text != "")
                    {
                        WinChar = (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text;
                        Win = true; // Top-Right diagonal win checks
                    }
                }
            }
            for (int y = 0; y <= 2; y++){
                for (int x = 0; x <= 3; x++){
                    if ((this.Controls.Find("R" + (y + 3) + "C" + x, true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 2) + "C" + (x + 1), true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 2) + "C" + (x + 1), true)[0] as TextBox).Text == (this.Controls.Find("R" + (y + 1) + "C" + (x + 2), true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 1) + "C" + (x + 2), true)[0] as TextBox).Text == (this.Controls.Find("R" + y + "C" + (x + 3), true)[0] as TextBox).Text && (this.Controls.Find("R" + (y + 3) + "C" + x, true)[0] as TextBox).Text != "")
                    {
                        WinChar = (this.Controls.Find("R" + (y + 3) + "C" + x, true)[0] as TextBox).Text;
                        Win = true; // Top-Left diagonal win checks
                    }
                }
            }

            if (Win) { Output.Text = WinChar + " wins!"; Reset.Visible = true; }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 5; y++){
                for (int x = 0; x <= 6; x++){
                    (this.Controls.Find("R" + y + "C" + x, true)[0] as TextBox).Text = "";
                }
            }
            Win = false;
            WinChar = "";
            Turn = 0;
            Reset.Visible = false;
            noughtsandcrosses.Visible = true;
            Output.Text = "";
        }
    }
}
