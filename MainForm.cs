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
    public enum App_States
    {
        Start,
        CreateAccount,
        UserPanel,
        InQuiz,
        empty
    }

    public partial class MainForm : Form
    {
        private App_States currentState = App_States.Start;
        private App_States previousState = App_States.empty;

        public MainForm()
        {
            InitializeComponent();
            loginButton.MouseEnter += new EventHandler(loginButton_MouseEnter);
            loginButton.MouseLeave += new EventHandler(loginButton_MouseLeave);
            chestionarNouButton.MouseEnter += new EventHandler(chestionarNouButton_MouseEnter);
            chestionarNouButton.MouseLeave += new EventHandler(chestionarNouButton_MouseLeave);
            statisticiButton.MouseEnter += new EventHandler(statisticiButton_MouseEnter);
            statisticiButton.MouseLeave += new EventHandler(statisticiButton_MouseLeave);
            iesireButton.MouseEnter += new EventHandler(iesireButton_MouseEnter);
            iesireButton.MouseLeave += new EventHandler(iesireButton_MouseLeave);
            urmatoareaIntrebare.MouseEnter += new EventHandler(urmatoareaIntrebare_MouseEnter);
            urmatoareaIntrebare.MouseLeave += new EventHandler(urmatoareaIntrebare_MouseLeave);
            createAccountLink.MouseEnter += new EventHandler(createAccountLink_MouseEnter);
            createAccountLink.MouseLeave += new EventHandler(createAccountLink_MouseLeave);
            forgotPassLink.MouseEnter += new EventHandler(forgotPassLink_MouseEnter);
            forgotPassLink.MouseLeave += new EventHandler(forgotPassLink_MouseLeave);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetNextScreen();
        }

        private void GetNextScreen()
        {
            switch (previousState)
            {
                case App_States.Start:
                    logo.Visible = false;
                    usernameLabel.Visible = false;
                    usernameBox.Visible = false;
                    passLabel.Visible = false;
                    passBox.Visible = false;
                    loginButton.Visible = false;
                    createAccountLink.Visible = false;
                    forgotPassLink.Visible = false;
                    bottomPic.Visible = false;
                    break;
                case App_States.UserPanel:
                    logo.Visible = false;
                    welcomeLabel.Visible = false;
                    chestionarNouButton.Visible = false;
                    statisticiButton.Visible = false;
                    iesireButton.Visible = false;
                    bottomPic.Visible = false;
                    break;
                case App_States.InQuiz:
                    quizTitle.Visible = false;
                    logoSmall.Visible = false;
                    intrebareText.Visible = false;
                    intrebareImagine.Visible = false;
                    raspuns1.Visible = false;
                    raspuns2.Visible = false;
                    raspuns3.Visible = false;
                    raspuns4.Visible = false;
                    urmatoareaIntrebare.Visible = false;
                    bottomPicSmall.Visible = false;
                    break;
            }
            switch (currentState)
            {
                case App_States.Start:
                    logo.Visible = true;
                    usernameLabel.Visible = true;
                    usernameBox.Visible = true;
                    passLabel.Visible = true;
                    passBox.Visible = true;
                    loginButton.Visible = true;
                    createAccountLink.Visible = true;
                    forgotPassLink.Visible = true;
                    bottomPic.Visible = true;
                    break;
                case App_States.UserPanel:
                    logo.Visible = true;
                    welcomeLabel.Visible = true;
                    chestionarNouButton.Visible = true;
                    statisticiButton.Visible = true;
                    iesireButton.Visible = true;
                    bottomPic.Visible = true;
                    break;
                case App_States.InQuiz:
                    quizTitle.Visible = true;
                    logoSmall.Visible = true;
                    intrebareText.Visible = true;
                    intrebareImagine.Visible = true;
                    raspuns1.Visible = true;
                    raspuns2.Visible = true;
                    raspuns3.Visible = true;
                    raspuns4.Visible = true;
                    urmatoareaIntrebare.Visible = true;
                    bottomPicSmall.Visible = true;
                    break;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = App_States.UserPanel;
            GetNextScreen();
        }

        private void iesireButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statisticiButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Unu din 4 romani...");
        }

        private void chestionarNouButton_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = App_States.InQuiz;
            GetNextScreen();
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Ich bin der neue gott!");
        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Karl Pilkington!");
        }

        private void urmatoareaIntrebare_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("10");
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            this.loginButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            this.loginButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void chestionarNouButton_MouseEnter(object sender, EventArgs e)
        {
            this.chestionarNouButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void chestionarNouButton_MouseLeave(object sender, EventArgs e)
        {
            this.chestionarNouButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void statisticiButton_MouseEnter(object sender, EventArgs e)
        {
            this.statisticiButton.BackColor = Color.FromArgb(161,27,60);
        }
        private void statisticiButton_MouseLeave(object sender, EventArgs e)
        {
            this.statisticiButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void iesireButton_MouseEnter(object sender, EventArgs e)
        {
            this.iesireButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void iesireButton_MouseLeave(object sender, EventArgs e)
        {
            this.iesireButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void urmatoareaIntrebare_MouseEnter(object sender, EventArgs e)
        {
            this.urmatoareaIntrebare.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void urmatoareaIntrebare_MouseLeave(object sender, EventArgs e)
        {
            this.urmatoareaIntrebare.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void createAccountLink_MouseEnter(object sender, EventArgs e)
        {
            this.createAccountLink.LinkColor = Color.FromArgb(161, 27, 60);
        }
        private void createAccountLink_MouseLeave(object sender, EventArgs e)
        {
            this.createAccountLink.LinkColor = Color.FromArgb(5, 142, 158);
        }

        private void forgotPassLink_MouseEnter(object sender, EventArgs e)
        {
            this.forgotPassLink.LinkColor = Color.FromArgb(161, 27, 60);
        }
        private void forgotPassLink_MouseLeave(object sender, EventArgs e)
        {
            this.forgotPassLink.LinkColor = Color.FromArgb(5, 142, 158);
        }
    }
}
