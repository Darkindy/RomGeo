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
        private AppState previousState = AppState.Empty;

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
            switch (previousState)
            {
                case AppState.Start:
                    headerImage.Visible = false;
                    usernameLabel.Visible = false;
                    usernameBox.Visible = false;
                    passLabel.Visible = false;
                    passBox.Visible = false;
                    loginButton.Visible = false;
                    createAccountLink.Visible = false;
                    forgotPassLink.Visible = false;
                    footerImage.Visible = false;
                    break;
                case AppState.UserPanel:
                    headerImage.Visible = false;
                    welcomeLabel.Visible = false;
                    newQuizButton.Visible = false;
                    statisticsButton.Visible = false;
                    exitButton.Visible = false;
                    footerImage.Visible = false;
                    break;
                case AppState.InQuiz:
                    quizTitle.Visible = false;
                    logoSmall.Visible = false;
                    questionText.Visible = false;
                    questionImage.Visible = false;
                    raspuns1.Visible = false;
                    raspuns2.Visible = false;
                    raspuns3.Visible = false;
                    raspuns4.Visible = false;
                    nextQuestionButton.Visible = false;
                    footerImageSmall.Visible = false;
                    break;
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
                    raspuns1.Visible = true;
                    raspuns2.Visible = true;
                    raspuns3.Visible = true;
                    raspuns4.Visible = true;
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
