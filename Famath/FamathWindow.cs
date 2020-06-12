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
    public partial class FamathWindow : Form
    {
        MathGenerator mg = new MathGenerator();
        public int TIME_INTERVAL
        {
            get;
            set;
        }
        public float SCORE_MULTIPLIER
        {
            get;
            set;
        }

        public int NUMBER_RANGE
        {
            get;
            set;
        }

        int current_time;
        int expression_count;
        int score;

        Menu main_menu;

        public FamathWindow(Menu menu)
        {
            InitializeComponent();
            main_menu = menu;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (current_time == 0)
            {
                time.Stop();
                answer.Visible = false;
                expression.Visible = false;
                tryAgain.Visible = true;
                gameOver.Visible = true;
                time_left.Visible = false;

            }
            else
            {
                current_time -= 1;
                time_left.Text = current_time.ToString();
            }
        }

        private void FamathWindow_Load(object sender, EventArgs e)
        {
            expression_count = 1;
            score = 0;
            expression.Text = mg.GenerateExpression(expression_count, NUMBER_RANGE);
            tryAgain.Visible = false;
            gameOver.Visible = false;
            current_time = TIME_INTERVAL;
            time_left.Text = current_time.ToString();
            time.Start();
        }

        private void answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != 8;
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               if(mg.GetAnswer() == Convert.ToInt32(answer.Text))
                {
                    score += current_time *(int)((expression_count + 1) * SCORE_MULTIPLIER);
                    current_score.Text = "Score: " + score.ToString();
                    expression_count++;
                    expression.Text = mg.GenerateExpression(expression_count, NUMBER_RANGE);
                    current_time = TIME_INTERVAL;
                    time_left.Text = current_time.ToString();
                }
                answer.Text = "";
            }
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            expression_count = 1;
            current_time = TIME_INTERVAL;
            time_left.Text = current_time.ToString();
            expression.Text = mg.GenerateExpression(expression_count, NUMBER_RANGE);
            score = 0;
            current_score.Text = "Score: 0";
            answer.Visible = true;
            expression.Visible = true;
            tryAgain.Visible = false;
            gameOver.Visible = false;
            time_left.Visible = true;
            time.Start();
        }

        private void FamathWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main_menu.Visible = true;
        }
    }
}
