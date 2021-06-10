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
    internal partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public FormLogIn F1 { get; set; }

        public Registration(FormLogIn f1)
        {
            InitializeComponent();
            this.F1 = f1;
            //AutoUserID();
        }
        public string AutoUserID()
        {
            string sql = "select ID from UserLog order by ID desc";

            DataTable Dt = F1.Da.ExecuteQueryTable(sql);
            string PreiviousId = Dt.Rows[0][0].ToString();
            
            string[] Temp = PreiviousId.Split('-');
            int SerialNo = Convert.ToInt32(Temp[1]);
            string newId = "User-"+(++SerialNo).ToString("000");
            return newId;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //AutoUserID();
                //string newId = AutoUserID();
                string sql = @"insert into UserLog values ('" + this.AutoUserID() + "','" + this.txtUsernameReg.Text + "','" +
                       this.txtPasswordReg.Text + "','" + this.txtEmailReg.Text + "',0,'User');";

                int count = F1.Da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Registered successfully");
                    F1.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Error while inserting data");

                //this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            F1.Show();
            this.Hide();
        }
    }
}
