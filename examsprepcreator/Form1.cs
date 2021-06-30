using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace examsprepcreator
{
    public partial class frmSetImages : Form
    {
        int ansclicks;
        int questionsclick;

        public frmSetImages()
        {
            InitializeComponent();
        }
        private void saveimg(Image img, int click, string qa_path)
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
                string path = qa_path + @"\" + filename; //e.g. c:\users\public\desktop + \ + e1-3.png
                img.Save(path, ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("please fill and select all fields");
            }
        }

        //write JS array
        private void appendtoJS(string path)
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

        private void pictureBoxQuestion_Click(object sender, EventArgs e)//save question
        {
            string qpath = textBoxPath.Text + @"\questions";
            if (!(Directory.Exists(qpath)))
                Directory.CreateDirectory(qpath);

            if (Clipboard.ContainsImage() && !(string.IsNullOrEmpty(qpath)))
            {
                Image q_img = Clipboard.GetImage();
                pictureBoxQuestion.Image = q_img;
                questionsclick++;
                lblq_num.Text = "#: " + questionsclick.ToString();
                saveimg(q_img, questionsclick, qpath);
            }
            else
            {
                MessageBox.Show("please fill questions path");
            }
        }
        private void reset()
        {
            ansclicks = 0;
            questionsclick = 0;
        }
        private void pictureBoxAnswer_Click(object sender, EventArgs e) // save answer
        {
            string apath = textBoxPath.Text + @"\answers";

            if (!(Directory.Exists(apath)))
                Directory.CreateDirectory(apath);

            if (Clipboard.ContainsImage() && !(string.IsNullOrEmpty(apath)))
            {
                Image answerimg = Clipboard.GetImage();
                pictureBoxAnswer.Image = answerimg;
                ansclicks++;
                lbla_num.Text = "#: " + ansclicks.ToString();
                saveimg(answerimg, ansclicks, apath);
            }
            else
            {
                MessageBox.Show("please fill answers path");
            }
        }

        private void buttoncreateJS_Click(object sender, EventArgs e)
        {
            string path = textBoxPath.Text + @"\questions";
            appendtoJS(path);
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("clicks reset");
        }

        private void textBoxnumber_TextChanged(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("clicks reset");
        }

        private void textBoxnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
