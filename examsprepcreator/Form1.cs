﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace examsprepcreator
{
    public partial class frmSetImages : Form
    {
        int ansclicks, questionsclick;
        string apath, qpath, latest_question, latest_answer;

        public frmSetImages()//constructor
        {
            InitializeComponent();
            reset();
        }
        private string saveimg(Image img, int click, string qa_path)//save the images (generic save method)
        {
            if (
                !(string.IsNullOrEmpty(textBoxnumber.Text)) &&
                (checkBoxassignment.Checked || checkBoxexam.Checked || checkBoxpractice.Checked))
            {
                string type;
                if (checkBoxassignment.Checked)
                    type = ""; //regular assignment question
                else if (checkBoxexam.Checked)
                    type = "e"; // exam
                else
                    type = "t"; // t for tirgul (practice..)

                int num = Int32.Parse(textBoxnumber.Text); // exam/practice/assignment number
                string filename = type + num + "-" + click + ".png"; //e.g. e1-3.png
                string path = qa_path + @"\" + filename; //e.g. c:\users\public\desktop\e1-3.png

                img.Save(path, ImageFormat.Png); // saves the image in png format

                return path; // return image path to make file deletion and modification possible
            }
            else
            {
               showmessage("please fill and select all fields");
                return null;
            }
        }

        private void deletefile(string path)//delete file
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                showmessage("file does not exist! (can delete only 1 file back");
        }

        private void correctfile(int clicks, string path, Label lbl)//correct the latest file
        {
            if (path != null)
            {
                lbl.Text = "#: " + clicks.ToString();
                deletefile(path);
            }
        }

        private void appendtoJS(string path)//write JS array
        {
            string dir = textBoxPath.Text; //will get questions or answers path
            string jsfilepath = dir + @"\js_arr.js";

            string arrname = textBoxSubjectname.Text + "_arr";
            arrname = arrname.Replace(" ", "_");

            string startstr = arrname + " = [\n";
            string endstr = "\n]";

            string[] files = Directory.GetFiles(path);
            using (StreamWriter sw = new StreamWriter(jsfilepath))
            {
                string arr = startstr;
                foreach (string file in files)
                {
                    string filename = Path.GetFileName(file);
                    if (filename.Contains(".png"))
                    {
                        arr += '\u0022' + filename + '\u0022' + ",\n";
                        if (file == files[files.Length - 1])//last file in array
                        {
                            arr += '\u0022' + filename + '\u0022';
                            arr += endstr;
                        }
                    }
                }
                sw.Write(arr); // write array to file
            }
        }

        private void reset()//partial reset and initialization
        {
            ansclicks = 0;
            questionsclick = 0;
            lblq_num.Text = "#: ";
            pictureBoxAnswer.Image = null;
            pictureBoxQuestion.Image = null;
        }

        private void resetbtn()//reset entire form
        {
            reset();
            textBoxPath.Text = null;
            textBoxnumber.Text = null;
            textBoxSubjectname.Text = null;
            checkBoxassignment.Checked = false;
            checkBoxexam.Checked = false;
            checkBoxpractice.Checked = false;
        }

        private void setDir(string path) // create questions and answers directories if not exist
        {
            if (!(Directory.Exists(path)))
                Directory.CreateDirectory(path);
        }

        private void showmessage(string message)//display simple message box
        {
            MessageBox.Show(message);
        }

        /*
         * EVENTS
         */
        private void pictureBoxQuestion_Click(object sender, EventArgs e)//save question image
        {
            if (Clipboard.ContainsImage() && !(string.IsNullOrEmpty(qpath)))
            {
                Image q_img = Clipboard.GetImage();
                pictureBoxQuestion.Image = q_img;
                questionsclick++;
                lblq_num.Text = "#: " + questionsclick.ToString();
                latest_question = saveimg(q_img, questionsclick, qpath);
            }
            else
            {
                showmessage("please fill questions path");
            }
        }

        private void pictureBoxAnswer_Click(object sender, EventArgs e) // save answer image
        {
            if (Clipboard.ContainsImage() && !(string.IsNullOrEmpty(apath)))
            {
                Image answerimg = Clipboard.GetImage();
                pictureBoxAnswer.Image = answerimg;
                ansclicks++;
                lbla_num.Text = "#: " + ansclicks.ToString();
                latest_answer = saveimg(answerimg, ansclicks, apath);
            }
            else
            {
                showmessage("please fill answers path");
            }
        }

        private void buttoncreateJS_Click(object sender, EventArgs e)//create JS array event
        {
            string path = textBoxPath.Text + @"\questions";
            appendtoJS(path);
        }

        private void buttonreset_Click(object sender, EventArgs e)//reset form
        {
            resetbtn();
            //MessageBox.Show("clicks reset");
        }

        private void textBoxnumber_TextChanged(object sender, EventArgs e) // if number changed, reset the form
        {
            reset();
            //MessageBox.Show("clicks reset");
        }

        private void btnAnsCorrect_Click(object sender, EventArgs e)//correct last answer
        {
            if (ansclicks != 0)
            {
                ansclicks--;
                correctfile(ansclicks, latest_answer, lbla_num);
            }
            else
                showmessage("clicks already at 0");
        }

        private void btnQuestionCorrect_Click(object sender, EventArgs e)//correct last question
        {
            if (questionsclick != 0)
            {
                questionsclick--;
                correctfile(questionsclick, latest_question, lblq_num);
            }
            else
                showmessage("clicks already at 0");
        }

        private void textBoxnumber_KeyPress(object sender, KeyPressEventArgs e)//checkbox number to accept only numbers
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)//set paths
        {
            string path = textBoxPath.Text;
            apath = path + @"\answers";
            qpath = path + @"\questions";
            setDir(apath);
            setDir(qpath);
        }
    }
}