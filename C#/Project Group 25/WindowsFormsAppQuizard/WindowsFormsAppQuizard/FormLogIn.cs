using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuizard
{
    internal partial class FormLogIn : Form
    {
        int score;
        public int Score
        {
            get { return score; }

            set { this.score = 0; }
        }
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public FormLogIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string sql = @"select * from UserLog where Email = '" + this.txtUserEmail.Text + "' and Password = '" + this.txtPassword.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Valid");
                this.Hide();
                MainGame QSN1 = new MainGame(this);
                QSN1.Show();
            }
            else
            {
                MessageBox.Show("InValid");
            }
        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration Reg = new Registration(this);
            Reg.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin Admin = new AdminLogin(this);
            Admin.Show();
        }
    }
}
