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

        Timer Clock = new Timer();

        OneBasedArray<RadioButton> answerPickers;

        FontFamily ff;
        Font openSansLight;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private void LoadOpenSansLight()
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
        
        private void ApplyOpenSansLight(Font font)
        {
            FontStyle fontStyle_regular = FontStyle.Regular;
            FontStyle fontStyle_bold = FontStyle.Bold;

            this.usernameLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.usernameBox.Font = new Font(ff, 12, fontStyle_regular);
            this.passLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.passBox.Font = new Font(ff, 12, fontStyle_regular);
            this.loginButton.Font = new Font(ff, 10, fontStyle_regular);
            this.createAccountLink.Font = new Font(ff, 10, fontStyle_bold);
            this.welcomeLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.newQuizButton.Font = new Font(ff, 10, fontStyle_regular);
            this.statisticsButton.Font = new Font(ff, 10, fontStyle_regular);
            this.exitButton.Font = new Font(ff, 10, fontStyle_regular);
            this.nextQuestionButton.Font = new Font(ff, 10, fontStyle_regular);
            this.passConfLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.passConfBox.Font = new Font(ff, 12, fontStyle_regular);
            this.createAccountLabel.Font = new Font(ff, 12, fontStyle_regular);
            this.statisticsLabel.Font = new Font(ff, 14, fontStyle_regular);
            this.statisticsNumber1.Font = new Font(ff, 24, fontStyle_regular);
            this.statisticsNumber2.Font = new Font(ff, 24, fontStyle_regular);
            this.statisticsNumber3.Font = new Font(ff, 30, fontStyle_regular);
            this.statisticsBackButton.Font = new Font(ff, 10, fontStyle_regular);
            this.statisticsPercent1.Font = new Font(ff, 26, fontStyle_regular);
            this.statisticsPercent2.Font = new Font(ff, 26, fontStyle_regular);
            this.statisticsPercent3.Font = new Font(ff, 26, fontStyle_regular);
            this.statisticsPercent4.Font = new Font(ff, 26, fontStyle_regular);
            this.statisticsType1.Font = new Font(ff, 10, fontStyle_regular);
            this.statisticsType2.Font = new Font(ff, 10, fontStyle_regular);
            this.statisticsType3.Font = new Font(ff, 10, fontStyle_regular);
            this.statisticsType4.Font = new Font(ff, 10, fontStyle_regular);
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

        public bool CheckQuestionIdDuplicate(int id)
        {
            bool result = false; //intrebarea nu mai exista in chestionarul curent

            foreach (int qid in PersistentData.quizQuestions) {
                if (qid == 0)
                    return result;
                else if (qid == id)
                {
                    result = true;
                    return result;
                }
            }

            return result;
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
            createAccountButton.MouseEnter += new EventHandler(CreateAccountButton_MouseEnter);
            createAccountButton.MouseLeave += new EventHandler(CreateAccountButton_MouseLeave);
            statisticsBackButton.MouseEnter += new EventHandler(StatisticsBackButton_MouseEnter);
            statisticsBackButton.MouseLeave += new EventHandler(StatisticsBackButton_MouseLeave);
            endingBackButton.MouseEnter += new EventHandler(EndingBackButton_MouseEnter);
            endingBackButton.MouseLeave += new EventHandler(EndingBackButton_MouseLeave);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOpenSansLight();
            ApplyOpenSansLight(openSansLight);
            Clock.Interval = 2000; // time untill next question
            Clock.Tick += new EventHandler(Timer_Tick);
            GetNextScreen();
        }

        private void GetNextScreen()
        {
            foreach (Control c in this.Controls)
                if (c is RadioButton) ((RadioButton)c).Checked = false;

            if (previousState != currentState)
                foreach (Control c in this.Controls)
                {
                    c.Visible = false;
                }
            else
            {
                quizMessageLabel.Visible = false;
                okQuestion.Visible = false;
                noQuestion.Visible = false;
                warningQuestion.Visible = false;
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
                        footerImage.Visible = true;
                    }
                    break;
                case AppState.UserPanel:
                    if(previousState != currentState)
                    {
                        headerImage.Visible = true;
                        welcomeLabel.Text = "Bine ai venit, " + PersistentData.user.ToString() + "!";
                        welcomeLabel.Left = (this.Width - welcomeLabel.Width) / 2;
                        welcomeLabel.Visible = true;

                        newQuizButton.Visible = true;
                        statisticsButton.Visible = true;
                        exitButton.Visible = true;
                        footerImage.Visible = true;
                    }
                    break;
                case AppState.InQuiz:
                    foreach (var ap in answerPickers)
                        ap.Enabled = true;
                    if (previousState != currentState)
                    {
                        quizTitle.Text = "Întrebarea  " + PersistentData.currentQuestionIndex + " / 30";
                        quizTitle.Visible = true;
                        logoSmall.Visible = true;
                        questionText.Visible = true;
                        questionImage.Visible = true;
                        foreach (var ap in answerPickers) 
                            ap.Visible = true;
                        nextQuestionButton.Visible = true;
                        footerImageSmall.Visible = true;
                    }
                    if (PersistentData.currentQuestionIndex == 30)
                        nextQuestionButton.Text = "Finalizare";

                    PersistentData.currentQuestion = DAL.GetQuestion();
                    while (CheckQuestionIdDuplicate(PersistentData.currentQuestion.Id))
                    {
                        PersistentData.currentQuestion = DAL.GetQuestion();
                    }
                    PersistentData.quizQuestions[PersistentData.currentQuestionIndex-1] = PersistentData.currentQuestion.Id;
                    ShowQuestion(PersistentData.currentQuestion);
                    DAL.MarkQueried(PersistentData.user, PersistentData.currentQuestion);
                    switch (PersistentData.currentQuestion.Domain)
                    {
                        case Domain.Relief:
                            Debug.Log("relief");
                            PersistentData.ReliefQuestionCount++;
                            break;
                        case Domain.Hidrografie:
                            Debug.Log("hidro");
                            PersistentData.HidrografieQuestionCount++;
                            break;
                        case Domain.Administrativ:
                            Debug.Log("admin");
                            PersistentData.AdministrativQuestionCount++;
                            break;
                        case Domain.Resurse:
                            Debug.Log("resurse");
                            PersistentData.ResurseQuestionCount++;
                            break;

                    }
                    break;
                case AppState.CreateAccount:
                    if (previousState != currentState)
                    {
                        headerImage.Visible = true;                      
                        usernameLabel.Visible = true;
                        usernameBox.Visible = true;
                        passLabel.Visible = true;
                        passBox.Visible = true;
                        passConfLabel.Visible = true;
                        passConfBox.Visible = true;
                        createAccountButton.Visible = true;
                        footerImage.Visible = true;
                    }
                    break;
                case AppState.Statistics:
                    if (previousState != currentState)
                    {
                        headerImage.Visible = true;

                        statisticsLabel.Text = "Statistici utilizator " + PersistentData.user.ToString();
                        statisticsLabel.Left = (this.Width - statisticsLabel.Width) / 2;
                        statisticsLabel.Visible = true;                        
                        
                        statisticsText1.Visible = true;
                        statisticsText2.Visible = true;
                        statisticsText3.Visible = true;

                        statisticsNumber1.Visible = true;
                        statisticsNumber2.Visible = true;
                        statisticsNumber3.Visible = true;

                        statisticsType1.Visible = true;
                        statisticsType2.Visible = true;
                        statisticsType3.Visible = true;
                        statisticsType4.Visible = true;

                        statisticsPercent1.Visible = true;
                        statisticsPercent2.Visible = true;
                        statisticsPercent3.Visible = true;
                        statisticsPercent4.Visible = true;

                        statisticsBackButton.Visible = true;
                        footerStatistics.Visible = true;
                    }
                    break;
                case AppState.EndingScreen:
                    if (previousState != currentState)
                    {
                        quizTitle.Text = "Rezultate Chestionar";
                        quizTitle.Visible = true;
                        logoSmall.Visible = true;

                        endingTextLabel1.Visible = true;
                        endingTextLabel2.Visible = true;
                        endingTextLabel3.Visible = true;
                        endingTextLabel4.Visible = true;
                        endingTextLabel5.Visible = true;

                        endingNumber1.Text = PersistentData.correctAnswerCount + " / 30";
                        endingNumber2.Text = PersistentData.correctAnswerReliefCount + " / " + PersistentData.ReliefQuestionCount;
                        endingNumber3.Text = PersistentData.correctAnswerHidrografieCount + " / " + PersistentData.HidrografieQuestionCount;
                        endingNumber4.Text = PersistentData.correctAnswerAdministrativCount + " / " + PersistentData.AdministrativQuestionCount;
                        endingNumber5.Text = PersistentData.correctAnswerResurseCount + " / " + PersistentData.ResurseQuestionCount;

                        endingNumber1.Visible = true;
                        endingNumber2.Visible = true;
                        endingNumber3.Visible = true;
                        endingNumber4.Visible = true;
                        endingNumber5.Visible = true;

                        endingBackButton.Visible = true;
                        footerImage.Visible = true;
                    }
                    break;
            }
        }

        private void LoginButon_Click(object sender, EventArgs e)
        {
            if (DAL.ValidateUser(usernameBox.Text, passBox.Text))
            {
                User currentUser = new User(usernameBox.Text, DAL.GetID(usernameBox.Text));
                PersistentData.user = currentUser;
                previousState = currentState;
                currentState = AppState.UserPanel;
                GetNextScreen();
            }
            else
            {
                createAccountLabel.Text = "Numele de utilizator si/sau parola au fost introduse gresit.";
                createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                noPicture.Left = createAccountLabel.Left - 36;
                createAccountLabel.Visible = true;
                noPicture.Visible = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = AppState.Statistics;
            GetNextScreen();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = AppState.UserPanel;
            GetNextScreen();
        }

        private void endingBackButton_Click(object sender, EventArgs e)
        {
            PersistentData.correctAnswerCount = 0;
            PersistentData.correctAnswerReliefCount = 0;
            PersistentData.correctAnswerHidrografieCount = 0;
            PersistentData.correctAnswerAdministrativCount = 0;
            PersistentData.correctAnswerResurseCount = 0;
            PersistentData.ReliefQuestionCount = 0;
            PersistentData.HidrografieQuestionCount = 0;
            PersistentData.AdministrativQuestionCount = 0;
            PersistentData.ResurseQuestionCount = 0;

            PersistentData.quizQuestions = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            nextQuestionButton.Text = "Urmatoarea Intrebare";

            previousState = currentState;
            currentState = AppState.UserPanel;
            GetNextScreen();
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {
            previousState = currentState;
            currentState = AppState.InQuiz;
            GetNextScreen();
        }

        private void CreateAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousState = currentState;
            currentState = AppState.CreateAccount;
            GetNextScreen();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            createAccountLabel.Visible = false;
            okPicture.Visible = false;
            noPicture.Visible = false;

            if (usernameBox.Text.Length < 4)
            {
                createAccountLabel.Text = "Numele de utilizator trebuie sa aiba minim 4 caractere.";
                createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                noPicture.Left = createAccountLabel.Left - 36;
                createAccountLabel.Visible = true;
                noPicture.Visible = true;
            }
            else if (passBox.Text.Length < 4)
            {
                createAccountLabel.Text = "Parola trebuie sa aiba minim 4 caractere.";
                createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                noPicture.Left = createAccountLabel.Left - 36;
                createAccountLabel.Visible = true;
                noPicture.Visible = true;
            }
            else if (passBox.Text != passConfBox.Text)
            {
                createAccountLabel.Text = "Parola nu a fost confirmata.";
                createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                noPicture.Left = createAccountLabel.Left - 36;
                createAccountLabel.Visible = true;
                noPicture.Visible = true;
            }
            else
            {
                
                if (DAL.SearchUser(usernameBox.Text) == false)
                {
                    User newUser = new User(usernameBox.Text);
                    DAL.CreateUser(newUser, passBox.Text);
                    if (DAL.ValidateUser(usernameBox.Text, passBox.Text))
                    {
                        previousState = currentState;
                        currentState = AppState.Start;
                        GetNextScreen();
                        createAccountLabel.Text = "Utilizator creat cu succes!";
                        createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                        okPicture.Left = createAccountLabel.Left - 36;
                        createAccountLabel.Visible = true;
                        okPicture.Visible = true;
                        passBox.Text = "";
                    }
                    else
                    {
                        createAccountLabel.Text = "Am intampinat o eroare la crearea utilizatorului.";
                        createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                        noPicture.Left = createAccountLabel.Left - 36;
                        createAccountLabel.Visible = true;
                        noPicture.Visible = true;
                    }
                }
                else
                {
                    createAccountLabel.Text = "Numele de utilizator deja exista in baza de date.";
                    createAccountLabel.Left = (this.Width - createAccountLabel.Width) / 2;
                    noPicture.Left = createAccountLabel.Left - 36;
                    createAccountLabel.Visible = true;
                    noPicture.Visible = true;
                }
            }
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            // Check if answer is ready for submission
            bool ready = false;
            foreach (var ap in answerPickers) if (ap.Checked == true) { ready = true; break; }
            if (!ready)
            {
                quizMessageLabel.Text = "Trebuie sa alegi un raspuns pentru a continua.";
                quizMessageLabel.Visible = true;
                warningQuestion.Visible = true;
                return;
            }
            quizMessageLabel.Visible = false;
            warningQuestion.Visible = false;

            // Verify if answer was correct
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton.Text.Equals(PersistentData.currentQuestion.CorrectAnswer))
            {
                DAL.MarkCorrect(PersistentData.user, PersistentData.currentQuestion);
                PersistentData.correctAnswerCount++;
                switch (PersistentData.currentQuestion.Domain)
                {
                    case Domain.Relief:
                        PersistentData.correctAnswerReliefCount++;
                        break;
                    case Domain.Hidrografie:
                        PersistentData.correctAnswerHidrografieCount++;
                        break;
                    case Domain.Administrativ:
                        PersistentData.correctAnswerAdministrativCount++;
                        break;
                    case Domain.Resurse:
                        PersistentData.correctAnswerResurseCount++;
                        break;

                }
                quizMessageLabel.Text = "Corect!";
                okQuestion.Visible = true;
            }
            else
            {
                quizMessageLabel.Text = "Gresit! Raspunsul corect este: " + PersistentData.currentQuestion.CorrectAnswer;
                noQuestion.Visible = true;
            }

            quizMessageLabel.Visible = true;
            foreach (var ap in answerPickers) 
                ap.Enabled = false;

            Clock.Start();

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

        private void CreateAccountButton_MouseEnter(object sender, EventArgs e)
        {
            this.createAccountButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void CreateAccountButton_MouseLeave(object sender, EventArgs e)
        {
            this.createAccountButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void StatisticsBackButton_MouseEnter(object sender, EventArgs e)
        {
            this.statisticsBackButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void StatisticsBackButton_MouseLeave(object sender, EventArgs e)
        {
            this.statisticsBackButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        private void EndingBackButton_MouseEnter(object sender, EventArgs e)
        {
            this.endingBackButton.BackColor = Color.FromArgb(161, 27, 60);
        }
        private void EndingBackButton_MouseLeave(object sender, EventArgs e)
        {
            this.endingBackButton.BackColor = Color.FromArgb(5, 142, 158);
        }

        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            Clock.Stop();

            // Manage form states
            previousState = AppState.InQuiz;
            if (PersistentData.currentQuestionIndex < 30)
            {
                PersistentData.currentQuestionIndex++;
                quizTitle.Text = "Întrebarea  " + PersistentData.currentQuestionIndex + " / 30";
            }
            else
            {
                PersistentData.currentQuestionIndex = 1;
                currentState = AppState.EndingScreen;
            }

            GetNextScreen();
        }
    }
}
