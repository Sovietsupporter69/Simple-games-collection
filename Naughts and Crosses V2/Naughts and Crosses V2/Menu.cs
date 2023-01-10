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
    public partial class Menu : Form
    {
        NouAndCros NaC;
        FourInARow fiar;
        Minesweeper Mine;
        public Menu()
        {
            InitializeComponent();
            fiar = new FourInARow(this);
            NaC = new NouAndCros(this);
            Mine = new Minesweeper(this);
        }

        private void Noughtsandcrosses_Click(object sender, EventArgs e)
        {
            this.Hide();
            NaC.Show();
        }

        private void fourinarow_Click(object sender, EventArgs e)
        {
            this.Hide();
            fiar.Show();
        }

        private void minesweeper_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mine.Show();
        }
    }
}
