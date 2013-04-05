using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Drawing.Text;

using RomGeo.DatabaseAbstractionLayer;
using RomGeo.QuizObjects;
using RomGeo.Utils;

namespace RomGeo
{
    public enum AppState
    {
        None,
        Start,
        CreateAccount,
        UserPanel,
        InQuiz,
        EndingScreen,
        Statistics,
    }

    public partial class MainForm : Form
    {
        #region DEVELOPER-DEFINED-LOGIC

        private AppState currentState = AppState.Start;
        private AppState previousState;    // may be used in the future, leave here

        OneBasedArray<RadioButton> answerPickers;

        FontFamily ff;
        Font openSansLight;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private void LoadPrivateFontCollection()
        {
            // Create the byte array and get its length

            byte[] fontArray = Properties.Resources.opensans_light_webfont;
            int dataLength = Properties.Resources.opensans_light_webfont.Length;


            // ASSIGN MEMORY AND COPY  BYTE[] ON THAT MEMORY ADDRESS
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            //PASS THE FONT TO THE  PRIVATEFONTCOLLECTION OBJECT
            pfc.AddMemoryFont(ptrData, dataLength);

            //FREE THE  "UNSAFE" MEMORY
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            openSansLight = new Font(ff, 15f, FontStyle.Regular);
        }
        
        private void ApplyFont(Font font)
        {
            FontStyle fontStyle_regular = FontStyle.Regular;
            FontStyle fontStyle_bold = FontStyle.Bold;

            this.usernameLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.usernameBox.Font = new Font(ff, 12, fontStyle_regular);
            this.passLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.passBox.Font = new Font(ff, 12, fontStyle_regular);
            this.loginButton.Font = new Font(ff, 10, fontStyle_regular);
            this.createAccountLink.Font = new Font(ff, 10, fontStyle_bold);
            this.forgotPassLink.Font = new Font(ff, 10, fontStyle_bold);
            this.welcomeLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.newQuizButton.Font = new Font(ff, 10, fontStyle_regular);
            this.statisticsButton.Font = new Font(ff, 10, fontStyle_regular);
            this.exitButton.Font = new Font(ff, 10, fontStyle_regular);
            this.nextQuestionButton.Font = new Font(ff, 10, fontStyle_regular);
            this.quizTitle.Font = new Font(ff, 20, fontStyle_regular);
            this.questionText.Font = new Font(ff, 12, fontStyle_regular);

            foreach (var ap in answerPickers)
                ap.Font = new Font(ff, 10, fontStyle_regular);
        }

        public void ShowQuestion(Question question){
                questionText.Text = question.Text;
                for (int i = 1; i <= answerPickers.Count(); i++)
                    answerPickers[i].Text = question.Answers[i];

                if (question is GraphicQuestion)
                {
                    // do some image data handling. NYI
                }
                else
                {
                    questionImage.Visible = false;
                }
        }
        #endregion

        #region SINGLETON-PATTERN
        private static MainForm instance;

        public static MainForm Instance
         {
             get 
             {
                if (instance == null)
                {
                   instance = new MainForm();
                }
                return instance;
             }
        }
        #endregion

        private MainForm()
        {
            InitializeComponent();

            // Using OneBasedArray to have our answers numbered from 1
            answerPickers = new OneBasedArray<RadioButton>(PersistentData.MAX_ANSWERS);
            answerPickers[1] = answerPicker1;
            answerPickers[2] = answerPicker2;
            answerPickers[3] = answerPicker3;
            answerPickers[4] = answerPicker4;

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
            LoadPrivateFontCollection();
            ApplyFont(openSansLight);
            GetNextScreen();
        }

        private void GetNextScreen()
        {
            if (previousState != currentState)
                foreach (Control c in this.Controls)
                {
                    c.Visible = false;
                }
            else
            {
                foreach (Control c in this.Controls)
                    if (c is RadioButton) ((RadioButton)c).Checked = false;
            }

            switch (currentState)
            {
                case AppState.Start:
                    if (previousState != currentState)
                    {
                        headerImage.Visible = true;
                        usernameLabel.Visible = true;
                        usernameBox.Visible = true;
                        passLabel.Visible = true;
                        passBox.Visible = true;
                        loginButton.Visible = true;
                        createAccountLink.Visible = true;
                        forgotPassLink.Visible = true;
                        footerImage.Visible = true;
                    }
                    break;
                case AppState.UserPanel:
                    if(previousState != currentState)
                    {
                    headerImage.Visible = true;
                    welcomeLabel.Visible = true;
                    newQuizButton.Visible = true;
                    statisticsButton.Visible = true;
                    exitButton.Visible = true;
                    footerImage.Visible = true;
                    }
                    break;
                case AppState.InQuiz:
                    if (previousState != currentState)
                    {
                        quizTitle.Visible = true;
                        logoSmall.Visible = true;
                        questionText.Visible = true;
                        questionImage.Visible = true;
                        foreach (var ap in answerPickers) ap.Visible = true;
                        nextQuestionButton.Visible = true;
                        footerImageSmall.Visible = true;
                    }
                    PersistentData.currentQuestion = DAL.GetQuestion();
                    ShowQuestion(PersistentData.currentQuestion);
                    break;
            }
        }

        private void LoginButon_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = AppState.UserPanel;
            if (usernameBox.Text.Length == 0) GetNextScreen();   // default testing
            else
            {
                if (DAL.ValidateUser(usernameBox.Text, passBox.Text))
                    Debug.Log("Validated user");
                else Debug.Log("User validation failed");
            }
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
            // To be replaced with real data
            if (usernameBox.Text.Length >= 4 && passBox.Text.Length >= 4)
            {
                User newUser = new User(usernameBox.Text);
                DAL.CreateUser(newUser, passBox.Text);
            }
        }

        private void ForgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("NYI");
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            // Check if answer is ready for submission
            bool ready = false;
            foreach (var ap in answerPickers) if (ap.Checked == true) { ready = true; break; }
            if (!ready)
            {
                MessageBox.Show("Trebuie sa alegi un raspuns pentru a continua.");
                return;
            }

            // Manage form states
            previousState = AppState.InQuiz;
            if (PersistentData.currentQuestionIndex < 30)
            {
                PersistentData.currentQuestionIndex++;
                quizTitle.Text = "Intrebarea  " + PersistentData.currentQuestionIndex + " / 30";
            }
            else
            {
                // PersistentData.correctAnswerCount = 0; // Maybe go to ending screen instead
                PersistentData.currentQuestionIndex = 1;
                currentState = AppState.Start;
            }

            // Verify if answer was correct
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton.Text.Equals(PersistentData.currentQuestion.CorrectAnswer))
                PersistentData.correctAnswerCount++;

            // Proceed to next screen
            GetNextScreen();
            Debug.Log("Correct: "+PersistentData.correctAnswerCount);
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
