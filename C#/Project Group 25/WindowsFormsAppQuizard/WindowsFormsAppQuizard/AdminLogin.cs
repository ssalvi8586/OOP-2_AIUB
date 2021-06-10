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
    internal partial class AdminLogin : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        public FormLogIn F1 { get; set; }
        public AdminLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public AdminLogin(FormLogIn A1)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.F1 = A1;
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string sql = @"select * from UserLog where Email = '" + this.txtUserEmailAdmin.Text + "' and Password = '" + this.txtPasswordAdmin.Text + "' and UserType = 'Admin';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                AdminDashboard AdminDash = new AdminDashboard(this.F1);
                AdminDash.Show();
            }
            else
            {
                MessageBox.Show("InValid");
            }
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            F1.Show();
        }
    }
}
