using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomGeo
{
    public enum AppState
    {
        Start,
        CreateAccount,
        UserPanel,
        InQuiz,
        Empty
    }

    public partial class MainForm : Form
    {
        private AppState currentState = AppState.Start;
        private AppState previousState = AppState.Empty;    // may be used in the future, leave here

        public MainForm()
        {
            InitializeComponent();
            loginButton.MouseEnter += new EventHandler(LoginButton_MouseEnter);
            loginButton.MouseLeave += new EventHandler(LoginButton_MouseLeave);
            newQuizButton.MouseEnter += new EventHandler(NewQuizButton_MouseEnter);
            newQuizButton.MouseLeave += new EventHandler(NewQuizButton_MouseLeave);
            statisticsButton.MouseEnter += new EventHandler(StatisticsButton_MouseEnter);
            statisticsButton.MouseLeave += new EventHandler(StatisticsButton_MouseLeave);
            exitButton.MouseEnter += new EventHandler(ExitButton_MouseEnter);
            exitButton.MouseLeave += new EventHandler(ExitButton_MouseLeave);
            nextQuestionButton.MouseEnter += new EventHandler(NextQuestionButton_MouseEnter);
            nextQuestionButton.MouseLeave += new EventHandler(NextQuestionButton_MouseLeave);
            createAccountLink.MouseEnter += new EventHandler(CreateAccountLink_MouseEnter);
            createAccountLink.MouseLeave += new EventHandler(CreateAccountLink_MouseLeave);
            forgotPassLink.MouseEnter += new EventHandler(ForgotPassLink_MouseEnter);
            forgotPassLink.MouseLeave += new EventHandler(ForgotPassLink_MouseLeave);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetNextScreen();
        }

        private void GetNextScreen()
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }

            switch (currentState)
            {
                case AppState.Start:
                    headerImage.Visible = true;
                    usernameLabel.Visible = true;
                    usernameBox.Visible = true;
                    passLabel.Visible = true;
                    passBox.Visible = true;
                    loginButton.Visible = true;
                    createAccountLink.Visible = true;
                    forgotPassLink.Visible = true;
                    footerImage.Visible = true;
                    break;
                case AppState.UserPanel:
                    headerImage.Visible = true;
                    welcomeLabel.Visible = true;
                    newQuizButton.Visible = true;
                    statisticsButton.Visible = true;
                    exitButton.Visible = true;
                    footerImage.Visible = true;
                    break;
                case AppState.InQuiz:
                    quizTitle.Visible = true;
                    logoSmall.Visible = true;
                    questionText.Visible = true;
                    questionImage.Visible = true;
                    answer1.Visible = true;
                    answer2.Visible = true;
                    answer3.Visible = true;
                    answer4.Visible = true;
                    nextQuestionButton.Visible = true;
                    footerImageSmall.Visible = true;
                    break;
            }
        }

        private void LoginButon_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = AppState.UserPanel;
            GetNextScreen();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("NYI");
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = AppState.InQuiz;
            GetNextScreen();
        }

        private void CreateAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("NYI");
        }

        private void ForgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("NYI");
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("NYI");
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            this.loginButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            this.loginButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void NewQuizButton_MouseEnter(object sender, EventArgs e)
        {
            this.newQuizButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void NewQuizButton_MouseLeave(object sender, EventArgs e)
        {
            this.newQuizButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void StatisticsButton_MouseEnter(object sender, EventArgs e)
        {
            this.statisticsButton.BackColor = Color.FromArgb(161,27,60);
        }
        private void StatisticsButton_MouseLeave(object sender, EventArgs e)
        {
            this.statisticsButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            this.exitButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            this.exitButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void NextQuestionButton_MouseEnter(object sender, EventArgs e)
        {
            this.nextQuestionButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void NextQuestionButton_MouseLeave(object sender, EventArgs e)
        {
            this.nextQuestionButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void CreateAccountLink_MouseEnter(object sender, EventArgs e)
        {
            this.createAccountLink.LinkColor = Color.FromArgb(161, 27, 60);
        }
        private void CreateAccountLink_MouseLeave(object sender, EventArgs e)
        {
            this.createAccountLink.LinkColor = Color.FromArgb(5, 142, 158);
        }

        private void ForgotPassLink_MouseEnter(object sender, EventArgs e)
        {
            this.forgotPassLink.LinkColor = Color.FromArgb(161, 27, 60);
        }
        private void ForgotPassLink_MouseLeave(object sender, EventArgs e)
        {
            this.forgotPassLink.LinkColor = Color.FromArgb(5, 142, 158);
        }
    }
}
