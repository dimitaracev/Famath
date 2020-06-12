using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Famath
{
    public partial class Menu : Form
    {
        FamathWindow window;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;
            btnBack.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnEasy.Visible = true;
            btnMedium.Visible = true;
            btnHard.Visible = true;
            btnPlay.Visible = false;
            btnQuit.Visible = false;
            btnBack.Visible = true;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            window = new FamathWindow(this);
            window.TIME_INTERVAL = 20;
            window.SCORE_MULTIPLIER = 0.5f;
            window.NUMBER_RANGE = 3;
            window.Visible = true;
            this.Visible = false;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            window = new FamathWindow(this);
            window.TIME_INTERVAL = 15;
            window.SCORE_MULTIPLIER = 0.7f;
            window.NUMBER_RANGE = 5;
            window.Visible = true;
            this.Visible = false;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            window = new FamathWindow(this);
            window.TIME_INTERVAL = 10;
            window.SCORE_MULTIPLIER = 2;
            window.NUMBER_RANGE = 7;
            window.Visible = true;
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;
            btnBack.Visible = false;
            btnPlay.Visible = true;
            btnQuit.Visible = true;
        }
    }
}
