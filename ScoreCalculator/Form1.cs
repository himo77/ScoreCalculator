using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        private int scoreTotal = 0, scoreCount = 0;
        public Form1()
        {
            InitializeComponent();
            this.txtScore.Focus();
        }

        private void txtScore_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.btnExit_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAdd_Click(this, EventArgs.Empty);
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            this.scoreTotal = 0;
            this.scoreCount = 0;

            this.txtScoreTotal.Text = this.scoreTotal.ToString();
            this.txtScoreCount.Text = this.scoreCount.ToString();
            this.txtScoreAverage.Text = "0";

            this.txtScore.Text = "";

            this.txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtScoreTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = 0;

            int.TryParse(this.txtScore.Text, out score);

            this.scoreTotal += score;
            this.scoreCount++;

            this.txtScoreTotal.Text = this.scoreTotal.ToString();
            this.txtScoreCount.Text = this.scoreCount.ToString();
            this.txtScoreAverage.Text = (this.scoreTotal / this.scoreCount).ToString();

            this.txtScore.Focus();
        }
    }
}
