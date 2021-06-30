
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(445, 39);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(322, 399);
            this.pictureBoxAnswer.TabIndex = 0;
            this.pictureBoxAnswer.TabStop = false;
            this.pictureBoxAnswer.Click += new System.EventHandler(this.pictureBoxAnswer_Click);
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(12, 39);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(322, 399);
            this.pictureBoxQuestion.TabIndex = 1;
            this.pictureBoxQuestion.TabStop = false;
            this.pictureBoxQuestion.Click += new System.EventHandler(this.pictureBoxQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            // 
            // textBoxnumber
            // 
            this.textBoxnumber.Location = new System.Drawing.Point(234, 522);
            this.textBoxnumber.Name = "textBoxnumber";
            this.textBoxnumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxnumber.TabIndex = 4;
            this.textBoxnumber.TextChanged += new System.EventHandler(this.textBoxnumber_TextChanged);
            this.textBoxnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exam\\Practice\\assignment NO.:";
            // 
            // checkBoxexam
            // 
            this.checkBoxexam.AutoSize = true;
            this.checkBoxexam.Location = new System.Drawing.Point(15, 445);
            this.checkBoxexam.Name = "checkBoxexam";
            this.checkBoxexam.Size = new System.Drawing.Size(64, 21);
            this.checkBoxexam.TabIndex = 7;
            this.checkBoxexam.Text = "Exam";
            this.checkBoxexam.UseVisualStyleBackColor = true;
            // 
            // checkBoxpractice
            // 
            this.checkBoxpractice.AutoSize = true;
            this.checkBoxpractice.Location = new System.Drawing.Point(15, 472);
            this.checkBoxpractice.Name = "checkBoxpractice";
            this.checkBoxpractice.Size = new System.Drawing.Size(81, 21);
            this.checkBoxpractice.TabIndex = 8;
            this.checkBoxpractice.Text = "Practice";
            this.checkBoxpractice.UseVisualStyleBackColor = true;
            // 
            // checkBoxassignment
            // 
            this.checkBoxassignment.AutoSize = true;
            this.checkBoxassignment.Location = new System.Drawing.Point(15, 499);
            this.checkBoxassignment.Name = "checkBoxassignment";
            this.checkBoxassignment.Size = new System.Drawing.Size(102, 21);
            this.checkBoxassignment.TabIndex = 9;
            this.checkBoxassignment.Text = "assignment";
            this.checkBoxassignment.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(340, 470);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(433, 22);
            this.textBoxPath.TabIndex = 11;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "MAIN FOLDER PATH: ";
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(698, 523);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(75, 23);
            this.buttonreset.TabIndex = 14;
            this.buttonreset.Text = "reset";
            this.buttonreset.UseVisualStyleBackColor = true;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // textBoxSubjectname
            // 
            this.textBoxSubjectname.Location = new System.Drawing.Point(587, 523);
            this.textBoxSubjectname.Name = "textBoxSubjectname";
            this.textBoxSubjectname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSubjectname.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "subject name:";
            // 
            // buttoncreateJS
            // 
            this.buttoncreateJS.Location = new System.Drawing.Point(376, 523);
            this.buttoncreateJS.Name = "buttoncreateJS";
            this.buttoncreateJS.Size = new System.Drawing.Size(75, 23);
            this.buttoncreateJS.TabIndex = 18;
            this.buttoncreateJS.Text = "CreateJS";
            this.buttoncreateJS.UseVisualStyleBackColor = true;
            this.buttoncreateJS.Click += new System.EventHandler(this.buttoncreateJS_Click);
            // 
            // lbla_num
            // 
            this.lbla_num.AutoSize = true;
            this.lbla_num.Location = new System.Drawing.Point(584, 13);
            this.lbla_num.Name = "lbla_num";
            this.lbla_num.Size = new System.Drawing.Size(16, 17);
            this.lbla_num.TabIndex = 19;
            this.lbla_num.Text = "#";
            // 
            // lblq_num
            // 
            this.lblq_num.AutoSize = true;
            this.lblq_num.Location = new System.Drawing.Point(145, 9);
            this.lblq_num.Name = "lblq_num";
            this.lblq_num.Size = new System.Drawing.Size(16, 17);
            this.lblq_num.TabIndex = 20;
            this.lblq_num.Text = "#";
            // 
            // frmSetImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 551);
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
            this.Name = "frmSetImages";
            this.Text = "imaginizer";
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
    }
}

