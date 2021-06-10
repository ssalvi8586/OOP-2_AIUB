namespace WindowsFormsAppQuizard
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnPlayerDetails = new System.Windows.Forms.Button();
            this.btnQuestionDetails = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuestionDelete = new System.Windows.Forms.Button();
            this.btnQuestionSearch = new System.Windows.Forms.Button();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.txtQuestionSearch = new System.Windows.Forms.TextBox();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.txtOption3Add = new System.Windows.Forms.TextBox();
            this.txtOption1Add = new System.Windows.Forms.TextBox();
            this.txtOption2Add = new System.Windows.Forms.TextBox();
            this.lblOption3Add = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblOption2Add = new System.Windows.Forms.Label();
            this.lblOption1Add = new System.Windows.Forms.Label();
            this.lblAnswerAdd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuestionAdd = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestionIDAdd = new System.Windows.Forms.TextBox();
            this.lblQuistionID = new System.Windows.Forms.Label();
            this.lblAdminDashboard = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLevel);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btnPlayerDetails);
            this.panel1.Controls.Add(this.btnQuestionDetails);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnQuestionDelete);
            this.panel1.Controls.Add(this.btnQuestionSearch);
            this.panel1.Controls.Add(this.btnUserSearch);
            this.panel1.Controls.Add(this.txtQuestionSearch);
            this.panel1.Controls.Add(this.txtUserSearch);
            this.panel1.Controls.Add(this.txtOption3Add);
            this.panel1.Controls.Add(this.txtOption1Add);
            this.panel1.Controls.Add(this.txtOption2Add);
            this.panel1.Controls.Add(this.lblOption3Add);
            this.panel1.Controls.Add(this.txtAnswer);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.lblOption2Add);
            this.panel1.Controls.Add(this.lblOption1Add);
            this.panel1.Controls.Add(this.lblAnswerAdd);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtQuestionAdd);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.txtQuestionIDAdd);
            this.panel1.Controls.Add(this.lblQuistionID);
            this.panel1.Controls.Add(this.lblAdminDashboard);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(30, 251);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(719, 172);
            this.dgv.TabIndex = 25;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // btnPlayerDetails
            // 
            this.btnPlayerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(175)))), ((int)(((byte)(168)))));
            this.btnPlayerDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnPlayerDetails.FlatAppearance.BorderSize = 3;
            this.btnPlayerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerDetails.Location = new System.Drawing.Point(599, 212);
            this.btnPlayerDetails.Name = "btnPlayerDetails";
            this.btnPlayerDetails.Size = new System.Drawing.Size(150, 31);
            this.btnPlayerDetails.TabIndex = 24;
            this.btnPlayerDetails.Text = "Player Details >>";
            this.btnPlayerDetails.UseVisualStyleBackColor = false;
            this.btnPlayerDetails.Click += new System.EventHandler(this.btnPlayerDetails_Click);
            // 
            // btnQuestionDetails
            // 
            this.btnQuestionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(175)))), ((int)(((byte)(168)))));
            this.btnQuestionDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnQuestionDetails.FlatAppearance.BorderSize = 3;
            this.btnQuestionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionDetails.Location = new System.Drawing.Point(428, 212);
            this.btnQuestionDetails.Name = "btnQuestionDetails";
            this.btnQuestionDetails.Size = new System.Drawing.Size(150, 31);
            this.btnQuestionDetails.TabIndex = 23;
            this.btnQuestionDetails.Text = "Question Details >>";
            this.btnQuestionDetails.UseVisualStyleBackColor = false;
            this.btnQuestionDetails.Click += new System.EventHandler(this.btnQuestionDetails_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(599, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 31);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuestionDelete
            // 
            this.btnQuestionDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnQuestionDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnQuestionDelete.FlatAppearance.BorderSize = 3;
            this.btnQuestionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionDelete.Location = new System.Drawing.Point(599, 109);
            this.btnQuestionDelete.Name = "btnQuestionDelete";
            this.btnQuestionDelete.Size = new System.Drawing.Size(150, 31);
            this.btnQuestionDelete.TabIndex = 22;
            this.btnQuestionDelete.Text = "Question Delete";
            this.btnQuestionDelete.UseVisualStyleBackColor = false;
            this.btnQuestionDelete.Click += new System.EventHandler(this.btnQuestionDelete_Click);
            // 
            // btnQuestionSearch
            // 
            this.btnQuestionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnQuestionSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnQuestionSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionSearch.Location = new System.Drawing.Point(272, 181);
            this.btnQuestionSearch.Name = "btnQuestionSearch";
            this.btnQuestionSearch.Size = new System.Drawing.Size(111, 28);
            this.btnQuestionSearch.TabIndex = 21;
            this.btnQuestionSearch.Text = "Question Search";
            this.btnQuestionSearch.UseVisualStyleBackColor = false;
            this.btnQuestionSearch.Click += new System.EventHandler(this.btnQuestionSearch_Click);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnUserSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSearch.Location = new System.Drawing.Point(272, 214);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(111, 28);
            this.btnUserSearch.TabIndex = 21;
            this.btnUserSearch.Text = "User Search";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // txtQuestionSearch
            // 
            this.txtQuestionSearch.Location = new System.Drawing.Point(30, 181);
            this.txtQuestionSearch.Multiline = true;
            this.txtQuestionSearch.Name = "txtQuestionSearch";
            this.txtQuestionSearch.Size = new System.Drawing.Size(225, 28);
            this.txtQuestionSearch.TabIndex = 20;
            this.txtQuestionSearch.TextChanged += new System.EventHandler(this.txtQuestionSearch_TextChanged);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(30, 215);
            this.txtUserSearch.Multiline = true;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(225, 28);
            this.txtUserSearch.TabIndex = 20;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // txtOption3Add
            // 
            this.txtOption3Add.Location = new System.Drawing.Point(265, 135);
            this.txtOption3Add.Name = "txtOption3Add";
            this.txtOption3Add.Size = new System.Drawing.Size(118, 20);
            this.txtOption3Add.TabIndex = 19;
            // 
            // txtOption1Add
            // 
            this.txtOption1Add.Location = new System.Drawing.Point(265, 109);
            this.txtOption1Add.Name = "txtOption1Add";
            this.txtOption1Add.Size = new System.Drawing.Size(118, 20);
            this.txtOption1Add.TabIndex = 19;
            // 
            // txtOption2Add
            // 
            this.txtOption2Add.Location = new System.Drawing.Point(75, 135);
            this.txtOption2Add.Name = "txtOption2Add";
            this.txtOption2Add.Size = new System.Drawing.Size(112, 20);
            this.txtOption2Add.TabIndex = 19;
            // 
            // lblOption3Add
            // 
            this.lblOption3Add.AutoSize = true;
            this.lblOption3Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption3Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblOption3Add.Location = new System.Drawing.Point(217, 138);
            this.lblOption3Add.Name = "lblOption3Add";
            this.lblOption3Add.Size = new System.Drawing.Size(38, 13);
            this.lblOption3Add.TabIndex = 18;
            this.lblOption3Add.Text = "Option";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(75, 109);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(112, 20);
            this.txtAnswer.TabIndex = 19;
            // 
            // lblOption2Add
            // 
            this.lblOption2Add.AutoSize = true;
            this.lblOption2Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption2Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblOption2Add.Location = new System.Drawing.Point(27, 138);
            this.lblOption2Add.Name = "lblOption2Add";
            this.lblOption2Add.Size = new System.Drawing.Size(41, 13);
            this.lblOption2Add.TabIndex = 18;
            this.lblOption2Add.Text = "Opttion";
            // 
            // lblOption1Add
            // 
            this.lblOption1Add.AutoSize = true;
            this.lblOption1Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption1Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblOption1Add.Location = new System.Drawing.Point(217, 112);
            this.lblOption1Add.Name = "lblOption1Add";
            this.lblOption1Add.Size = new System.Drawing.Size(38, 13);
            this.lblOption1Add.TabIndex = 18;
            this.lblOption1Add.Text = "Option";
            // 
            // lblAnswerAdd
            // 
            this.lblAnswerAdd.AutoSize = true;
            this.lblAnswerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblAnswerAdd.Location = new System.Drawing.Point(27, 112);
            this.lblAnswerAdd.Name = "lblAnswerAdd";
            this.lblAnswerAdd.Size = new System.Drawing.Size(42, 13);
            this.lblAnswerAdd.TabIndex = 18;
            this.lblAnswerAdd.Text = "Answer";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(428, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuestionAdd
            // 
            this.txtQuestionAdd.Location = new System.Drawing.Point(30, 78);
            this.txtQuestionAdd.Name = "txtQuestionAdd";
            this.txtQuestionAdd.Size = new System.Drawing.Size(353, 20);
            this.txtQuestionAdd.TabIndex = 16;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblQuestion.Location = new System.Drawing.Point(27, 62);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 15;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestionIDAdd
            // 
            this.txtQuestionIDAdd.Location = new System.Drawing.Point(31, 39);
            this.txtQuestionIDAdd.Name = "txtQuestionIDAdd";
            this.txtQuestionIDAdd.ReadOnly = true;
            this.txtQuestionIDAdd.Size = new System.Drawing.Size(353, 20);
            this.txtQuestionIDAdd.TabIndex = 14;
            // 
            // lblQuistionID
            // 
            this.lblQuistionID.AutoSize = true;
            this.lblQuistionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuistionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblQuistionID.Location = new System.Drawing.Point(27, 23);
            this.lblQuistionID.Name = "lblQuistionID";
            this.lblQuistionID.Size = new System.Drawing.Size(59, 13);
            this.lblQuistionID.TabIndex = 13;
            this.lblQuistionID.Text = "Quistion ID";
            // 
            // lblAdminDashboard
            // 
            this.lblAdminDashboard.AutoSize = true;
            this.lblAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblAdminDashboard.Location = new System.Drawing.Point(308, 2);
            this.lblAdminDashboard.Name = "lblAdminDashboard";
            this.lblAdminDashboard.Size = new System.Drawing.Size(143, 20);
            this.lblAdminDashboard.TabIndex = 3;
            this.lblAdminDashboard.Text = "Admin Dashboard";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblLevel.Location = new System.Drawing.Point(389, 76);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 18;
            this.lblLevel.Text = "Level";
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbLevel.Location = new System.Drawing.Point(428, 73);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(150, 21);
            this.cmbLevel.TabIndex = 26;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminDashboard;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnPlayerDetails;
        private System.Windows.Forms.Button btnQuestionDetails;
        private System.Windows.Forms.Button btnQuestionDelete;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswerAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuestionAdd;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestionIDAdd;
        private System.Windows.Forms.Label lblQuistionID;
        private System.Windows.Forms.TextBox txtOption3Add;
        private System.Windows.Forms.TextBox txtOption1Add;
        private System.Windows.Forms.TextBox txtOption2Add;
        private System.Windows.Forms.Label lblOption3Add;
        private System.Windows.Forms.Label lblOption2Add;
        private System.Windows.Forms.Label lblOption1Add;
        private System.Windows.Forms.Button btnQuestionSearch;
        private System.Windows.Forms.TextBox txtQuestionSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}