
namespace examsprepcreator
{
    partial class frmSetImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetImages));
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxexam = new System.Windows.Forms.CheckBox();
            this.checkBoxpractice = new System.Windows.Forms.CheckBox();
            this.checkBoxassignment = new System.Windows.Forms.CheckBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonreset = new System.Windows.Forms.Button();
            this.textBoxSubjectname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttoncreateJS = new System.Windows.Forms.Button();
            this.lbla_num = new System.Windows.Forms.Label();
            this.lblq_num = new System.Windows.Forms.Label();
            this.btnQuestionCorrect = new System.Windows.Forms.Button();
            this.btnAnsCorrect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(274, 32);
            this.pictureBoxAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(242, 325);
            this.pictureBoxAnswer.TabIndex = 0;
            this.pictureBoxAnswer.TabStop = false;
            this.pictureBoxAnswer.Click += new System.EventHandler(this.pictureBoxAnswer_Click);
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(9, 32);
            this.pictureBoxQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(242, 325);
            this.pictureBoxQuestion.TabIndex = 1;
            this.pictureBoxQuestion.TabStop = false;
            this.pictureBoxQuestion.Click += new System.EventHandler(this.pictureBoxQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            // 
            // textBoxnumber
            // 
            this.textBoxnumber.Location = new System.Drawing.Point(173, 462);
            this.textBoxnumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxnumber.Name = "textBoxnumber";
            this.textBoxnumber.Size = new System.Drawing.Size(37, 20);
            this.textBoxnumber.TabIndex = 4;
            this.textBoxnumber.TextChanged += new System.EventHandler(this.textBoxnumber_TextChanged);
            this.textBoxnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exam\\Practice\\assignment NO.:";
            // 
            // checkBoxexam
            // 
            this.checkBoxexam.AutoSize = true;
            this.checkBoxexam.Location = new System.Drawing.Point(11, 362);
            this.checkBoxexam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxexam.Name = "checkBoxexam";
            this.checkBoxexam.Size = new System.Drawing.Size(52, 17);
            this.checkBoxexam.TabIndex = 7;
            this.checkBoxexam.Text = "Exam";
            this.checkBoxexam.UseVisualStyleBackColor = true;
            // 
            // checkBoxpractice
            // 
            this.checkBoxpractice.AutoSize = true;
            this.checkBoxpractice.Location = new System.Drawing.Point(11, 384);
            this.checkBoxpractice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxpractice.Name = "checkBoxpractice";
            this.checkBoxpractice.Size = new System.Drawing.Size(65, 17);
            this.checkBoxpractice.TabIndex = 8;
            this.checkBoxpractice.Text = "Practice";
            this.checkBoxpractice.UseVisualStyleBackColor = true;
            // 
            // checkBoxassignment
            // 
            this.checkBoxassignment.AutoSize = true;
            this.checkBoxassignment.Location = new System.Drawing.Point(11, 405);
            this.checkBoxassignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxassignment.Name = "checkBoxassignment";
            this.checkBoxassignment.Size = new System.Drawing.Size(79, 17);
            this.checkBoxassignment.TabIndex = 9;
            this.checkBoxassignment.Text = "assignment";
            this.checkBoxassignment.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(255, 382);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(261, 20);
            this.textBoxPath.TabIndex = 11;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "MAIN FOLDER PATH: ";
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonreset.Location = new System.Drawing.Point(478, 455);
            this.buttonreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(38, 23);
            this.buttonreset.TabIndex = 14;
            this.buttonreset.Text = "reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // textBoxSubjectname
            // 
            this.textBoxSubjectname.Location = new System.Drawing.Point(173, 438);
            this.textBoxSubjectname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubjectname.Name = "textBoxSubjectname";
            this.textBoxSubjectname.Size = new System.Drawing.Size(274, 20);
            this.textBoxSubjectname.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "subject name:";
            // 
            // buttoncreateJS
            // 
            this.buttoncreateJS.BackColor = System.Drawing.Color.Goldenrod;
            this.buttoncreateJS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttoncreateJS.Location = new System.Drawing.Point(451, 406);
            this.buttoncreateJS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoncreateJS.Name = "buttoncreateJS";
            this.buttoncreateJS.Size = new System.Drawing.Size(65, 45);
            this.buttoncreateJS.TabIndex = 18;
            this.buttoncreateJS.Text = "Create JS array";
            this.buttoncreateJS.UseVisualStyleBackColor = false;
            this.buttoncreateJS.Click += new System.EventHandler(this.buttoncreateJS_Click);
            // 
            // lbla_num
            // 
            this.lbla_num.AutoSize = true;
            this.lbla_num.Location = new System.Drawing.Point(382, 11);
            this.lbla_num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbla_num.Name = "lbla_num";
            this.lbla_num.Size = new System.Drawing.Size(14, 13);
            this.lbla_num.TabIndex = 19;
            this.lbla_num.Text = "#";
            // 
            // lblq_num
            // 
            this.lblq_num.AutoSize = true;
            this.lblq_num.Location = new System.Drawing.Point(109, 7);
            this.lblq_num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblq_num.Name = "lblq_num";
            this.lblq_num.Size = new System.Drawing.Size(14, 13);
            this.lblq_num.TabIndex = 20;
            this.lblq_num.Text = "#";
            // 
            // btnQuestionCorrect
            // 
            this.btnQuestionCorrect.Location = new System.Drawing.Point(185, 7);
            this.btnQuestionCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuestionCorrect.Name = "btnQuestionCorrect";
            this.btnQuestionCorrect.Size = new System.Drawing.Size(65, 21);
            this.btnQuestionCorrect.TabIndex = 21;
            this.btnQuestionCorrect.Text = "Step Back";
            this.btnQuestionCorrect.UseVisualStyleBackColor = true;
            this.btnQuestionCorrect.Click += new System.EventHandler(this.btnQuestionCorrect_Click);
            // 
            // btnAnsCorrect
            // 
            this.btnAnsCorrect.Location = new System.Drawing.Point(451, 7);
            this.btnAnsCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnsCorrect.Name = "btnAnsCorrect";
            this.btnAnsCorrect.Size = new System.Drawing.Size(65, 21);
            this.btnAnsCorrect.TabIndex = 22;
            this.btnAnsCorrect.Text = "Step Back";
            this.btnAnsCorrect.UseVisualStyleBackColor = true;
            this.btnAnsCorrect.Click += new System.EventHandler(this.btnAnsCorrect_Click);
            // 
            // frmSetImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(520, 487);
            this.Controls.Add(this.btnAnsCorrect);
            this.Controls.Add(this.btnQuestionCorrect);
            this.Controls.Add(this.lblq_num);
            this.Controls.Add(this.lbla_num);
            this.Controls.Add(this.buttoncreateJS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSubjectname);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.checkBoxassignment);
            this.Controls.Add(this.checkBoxpractice);
            this.Controls.Add(this.checkBoxexam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxQuestion);
            this.Controls.Add(this.pictureBoxAnswer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSetImages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxexam;
        private System.Windows.Forms.CheckBox checkBoxpractice;
        private System.Windows.Forms.CheckBox checkBoxassignment;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.TextBox textBoxSubjectname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttoncreateJS;
        private System.Windows.Forms.Label lbla_num;
        private System.Windows.Forms.Label lblq_num;
        private System.Windows.Forms.Button btnQuestionCorrect;
        private System.Windows.Forms.Button btnAnsCorrect;
    }
}

