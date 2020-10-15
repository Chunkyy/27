using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Bobs_27 : Form
    {
        int d = 1;
        int sv = 27;
        int calc;
        int dartValue;

        public Bobs_27()
        {
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            dartValue = 1;
            calculate();
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            dartValue = 2;
            calculate();
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            dartValue = 3;
            calculate();
        }

        private void missBtn_Click(object sender, EventArgs e)
        {
            calc = sv - (d * 2);
            sv = calc;
            scoreValue.Text = sv.ToString();

            updateScore();
        }

        public void incrementDouble()
        {
            d++;

            if (d == 21)
            {
                d = 25;
                dblValue.Text = "Bull";
                boardNumber.Visible = false;
            }
            else if (d == 26)
            {
                MessageBox.Show("You've won! Your score is " + sv.ToString() + "!");
                newGame();
            }
            else
            {
                dblValue.Text = d.ToString();
            }
        }

        public void newGame()
        {
            scoreValue.ForeColor = Color.Black;
            d = 1;
            sv = 27;
            dblValue.Text = d.ToString();
            scoreValue.Text = sv.ToString();
            boardNumber.Visible = true;
        }

        public void updateScore()
        {
            if (sv <= 0)
            {
                scoreValue.ForeColor = Color.Red;
                MessageBox.Show("Bust, you finished on " + d.ToString());
                newGame();
            }
            else if (sv - (d * 2) <= 0)
            {
                scoreValue.ForeColor = Color.Orange;
                incrementDouble();
            }
            else if (sv - (d * 2) > 0)
            {
                scoreValue.ForeColor = Color.Black;
                incrementDouble();
            }
        }

        public void calculate()
        {            
            calc = (d * 2) * dartValue + sv;
            sv = calc;
            scoreValue.Text = sv.ToString();
            
            updateScore();
        }

        private void NgBtn_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}
