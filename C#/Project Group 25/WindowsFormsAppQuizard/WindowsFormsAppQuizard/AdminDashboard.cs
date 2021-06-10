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
    internal partial class AdminDashboard : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public FormLogIn F1 { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public AdminDashboard(FormLogIn f1)
        {
            InitializeComponent();
            this.F1 = f1;
            this.Da = new DataAccess();
            this.AutoQSNID();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlayerDetails_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserLog";
            this.Ds = this.Da.ExecuteQuery(sql);

            //this.dgv.AutoGenerateColumns = false;
            this.dgv.DataSource = this.Ds.Tables[0];
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            F1.Show();
        }
        private void PopulateUserGridView(string sql = "select * from UserLog;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            //this.dgv.AutoGenerateColumns = false;
            this.dgv.DataSource = this.Ds.Tables[0];
        }

        private void PopulateQSNGridView(string sql = "select * from QuestionTable;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            //this.dgv.AutoGenerateColumns = false;
            this.dgv.DataSource = this.Ds.Tables[0];
        }
        private void btnQuestionDetails_Click(object sender, EventArgs e)
        {
            string sql = "select * from QuestionTable";
            this.Ds = this.Da.ExecuteQuery(sql);

            //this.dgv.AutoGenerateColumns = false;
            this.dgv.DataSource = this.Ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into QuestionTable values ('"+this.txtQuestionIDAdd.Text+"','" + this.txtQuestionAdd.Text + "','" +
                       this.txtAnswer.Text + "','" + this.txtOption1Add.Text + "','"+this.txtOption2Add.Text+"','"+this.txtOption3Add.Text+"', '"+ this.cmbLevel.Text +"' );";

                int count = F1.Da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Question Inserted successfully");

                    //sql = "select * from QuestionTable";

                    this.PopulateQSNGridView("select * from QuestionTable");
                }
                else
                    MessageBox.Show("Error while inserting data");

                sql = "select * from QuestionTable";

                this.PopulateQSNGridView(sql);
                this.ClearData();
                this.AutoQSNID();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            
        }

        private void btnQuestionSearch_Click(object sender, EventArgs e)
        {
            string sql = @"select * from QuestionTable where QuestionTable = '" + this.txtQuestionSearch.Text + "';";
            this.PopulateQSNGridView(sql);
        }

        private void txtQuestionSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from QuestionTable where Question like '%" + this.txtQuestionSearch.Text + "%';";
            this.PopulateQSNGridView(sql);
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            string sql = @"select * from UserLog where Name = '" + this.txtUserSearch.Text + "';";
            this.PopulateUserGridView(sql);
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from UserLog where Name like '%" + this.txtUserSearch.Text + "%';";
            this.PopulateUserGridView(sql);
        }

        private void btnQuestionDelete_Click(object sender, EventArgs e)
        {
            /*try
            {
                //var id = this.dgv.CurrentRow.Cells["ID"].Value.ToString();
                //var title = this.dgv.CurrentRow.Cells["title"].Value.ToString();
                //var id = this.

                string sql = "delete from QuestionTable where ID = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(sql);

                if (count == 1)
                    MessageBox.Show("Question has been deleted");
                else
                    MessageBox.Show("Error while deleting data");

                this.PopulateQSNGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }*/
        }

        public void ClearData()
        {
            //this.txtQuestionIDAdd.Text = "";
            this.txtQuestionAdd.Text = "";
            this.txtAnswer.Text = "";
            this.txtOption1Add.Text = "";
            this.txtOption2Add.Text = "";
            this.txtOption3Add.Text = "";
            this.cmbLevel.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }
        public void AutoQSNID()
        {
            string sql = "select QuestionId from QuestionTable order by QuestionId desc";

            DataTable Dt = this.Da.ExecuteQueryTable(sql);
            string PreiviousId = Dt.Rows[0][0].ToString();
            int SerialNo = Convert.ToInt32(PreiviousId);
            string newId = (++SerialNo).ToString();
            this.txtQuestionIDAdd.Text = newId;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            //this.dgv.CellContentClick = "";
        }
    }
}
