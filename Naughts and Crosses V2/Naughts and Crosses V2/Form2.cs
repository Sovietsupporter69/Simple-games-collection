﻿using System;
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
            for (int i = 0; i < 6; i++) {
                if ("R"+i+"C"+Column.Text == "") {

                }
            }
        }
    }
}
