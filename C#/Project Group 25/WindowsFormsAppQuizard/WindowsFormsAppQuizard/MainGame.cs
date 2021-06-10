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
    internal partial class MainGame : Form
    {
        /*int score;
        public int Score  
        {
            get { return score; }

            set { this.score = 0; }
        }*/
        
        string Answer { set; get; }
        public FormLogIn F1 { get; set; }
        public MainGame()
        {
            InitializeComponent();

        }
        public MainGame(FormLogIn f1)
        {
            InitializeComponent();
            this.F1 = f1;
            QuestionDisplayLevel1();
        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            F1.Show();
        }

        public int IntArrayLinearSearch(int[] data, int item)
        {
            int N = data.Length;
            for (int i = 0; i < N; i++)
                if (data[i] == item)
                    return i;
            return -1;
        }

        public int[] OptionShuffle()
        {
            int[] OptionID = new int[4];
            Random OptId = new Random();
            int Count = 0;

            do
            {
                OptionID[Count] = OptId.Next(2, 5);
                if (this.IntArrayLinearSearch(OptionID, OptionID[Count]) == -1)
                {
                    OptionID[Count++] = OptionID[Count];
                }

            }
            while (Count < 4);
            return OptionID;

        }
        public void QuestionDisplayLevel1()
        {

            List<int> intList = new List<int>();
            int Count = 0;
            int QuestionId;
            Random QId = new Random();
            QuestionId = QId.Next(1, 6);
            //int[] OptionId = new int[4];

            //OptionId = this.OptionShuffle();

            //int QuestionId = 1;

            if (intList.Contains(QuestionId) == true)
            {
                QuestionDisplayLevel1();
            }
            else
            {
                string sql = "select * from QuestionTable where QuestionId =" + QuestionId + " and QuestionLevel = '1';";

                DataTable Dt = F1.Da.ExecuteQueryTable(sql);
                string Question = Dt.Rows[0][1].ToString();
                string OptionA = Dt.Rows[0][2].ToString();
                string OptionB = Dt.Rows[0][3].ToString();
                string OptionC = Dt.Rows[0][4].ToString();
                string OptionD = Dt.Rows[0][5].ToString();
                Answer = OptionA;
                this.lblQuestion.Text = Question;



                this.btnMCQOptA.Text = "A) " + OptionA;
                this.btnMCQOptB.Text = "B) " + OptionB;
                this.btnMCQOptC.Text = "C) " + OptionC;
                this.btnMCQOptD.Text = "D) " + OptionD;

                intList.Insert(Count, QuestionId);
                Count++;
                //sql = "select Answer from QuestionTable where QuestionId =" + QuestionId + " and QuestionLevel = '1';";
                //this.btnMCQOptA.Text = 

            }


            /*string sql = "select Question from QuestionTable where QuestionId =" + QuestionId + " and QuestionLevel = '1';";

            DataTable Dt = F1.Da.ExecuteQueryTable(sql);
            string Question = Dt.Rows[0][0].ToString();
            this.lblQuestion.Text = Question;*/
        }
        
        int CountQuestion = 0;
        private void btnMCQOptA_Click(object sender, EventArgs e)
        {
            if (CountQuestion < 5)
            {
                if (this.btnMCQOptA.Text == Answer)
                {
                    //Score += 10;
                    F1.Score += 10;
                    //QuestionDisplayLevel1();
                }
                QuestionDisplayLevel1();
                CountQuestion++;
            }
            else 
            {
                this.Hide();
                ScoreBoard SB = new ScoreBoard(this);
                SB.Show();
            }


        }
        
        private void btnMCQOptB_Click(object sender, EventArgs e)
        {
            if (CountQuestion < 5)
            {
                if (this.btnMCQOptB.Text == Answer)
                {
                    //Score += 10;
                    F1.Score += 10;
                    //QuestionDisplayLevel1();
                }
                QuestionDisplayLevel1();
                CountQuestion++;
            }
            else
            {
                this.Hide();
                ScoreBoard SB = new ScoreBoard(this);
                SB.Show();
            }
        }

        private void btnMCQOptC_Click(object sender, EventArgs e)
        {
            if (CountQuestion < 5)
            {
                if (this.btnMCQOptC.Text == Answer)
                {
                    //Score += 10;
                    F1.Score += 10;
                    //QuestionDisplayLevel1();
                }
                QuestionDisplayLevel1();
                CountQuestion++;
            }
            else
            {
                this.Hide();
                ScoreBoard SB = new ScoreBoard(this);
                SB.Show();
            }
        }

        private void btnMCQOptD_Click(object sender, EventArgs e)
        {
            if (CountQuestion < 5)
            {
                if (this.btnMCQOptD.Text == Answer)
                {
                    //Score += 10;
                    F1.Score += 10;
                    //QuestionDisplayLevel1();
                }
                QuestionDisplayLevel1();
                CountQuestion++;
            }
            else
            {
                this.Hide();
                ScoreBoard SB = new ScoreBoard(this);
                SB.Show();
            }
        }
    }
}
