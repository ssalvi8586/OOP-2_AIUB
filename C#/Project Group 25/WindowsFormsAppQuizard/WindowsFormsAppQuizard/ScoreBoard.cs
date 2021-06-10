using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuizard
{
    internal partial class ScoreBoard : Form
    {
        MainGame MG { get; set; }
        public ScoreBoard()
        {
            InitializeComponent();
        }

        public ScoreBoard(MainGame mg)
        {
            InitializeComponent();
            this.MG = mg;
            //string CurrentScore = MG.Score.ToString();
            //this.lblYourScoreShow.Text = CurrentScore;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
