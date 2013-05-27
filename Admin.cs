using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using RomGeo.QuizObjects;

namespace RomGeo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filePickButton.Enabled = !filePickButton.Enabled;
            label6.Enabled = !label6.Enabled;
            label8.Enabled = !label8.Enabled;
            textBox6.Enabled = !textBox6.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox6.Text = openFileDialog1.FileName;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String file = openFileDialog1.FileName;
            String text = richTextBox1.Text;
            String domainname = null;
            Domain domain = 0;
            Answers answers = new Answers();
            answers[1] = textBox1.Text;
            answers[2] = textBox2.Text;
            answers[3] = textBox3.Text;
            answers[4] = textBox4.Text;

            switch (comboBox1.SelectedIndex)
            {
                case 0: answers.CorrectAnswer = textBox1.Text;
                    break;
                case 1: answers.CorrectAnswer = textBox2.Text;
                    break;
                case 2: answers.CorrectAnswer = textBox3.Text;
                    break;
                case 3: answers.CorrectAnswer = textBox4.Text;
                    break;
                default:
                    answers.CorrectAnswer = textBox1.Text;
                    break;
            }

            foreach (Control c in this.Controls)
                if (c is RadioButton) if (((RadioButton)c).Checked == true) domainname = ((RadioButton)c).Text;

            switch (domainname)
            {
                case "hidro":
                    domain = Domain.Hidrografie;
                    break;
                case "rel":
                    domain = Domain.Relief;
                    break;
                case "res":
                    domain = Domain.Resurse;
                    break;
                case "admin":
                    domain = Domain.Administrativ;
                    break;
                default:
                    domain = Domain.None;
                    break;
            }


            Question question = new Question(0, text, domain, 0, answers);



            DatabaseAbstractionLayer.DAL.UploadQuestion(question, file);
            //Do whatever you want
            //openFileDialog1.FileName .....
        }
    }
}
