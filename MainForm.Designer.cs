namespace RomGeo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLink = new System.Windows.Forms.LinkLabel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.forgotPassLink = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newQuizButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.Label();
            this.questionImage = new System.Windows.Forms.PictureBox();
            this.logoSmall = new System.Windows.Forms.PictureBox();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.footerImage = new System.Windows.Forms.PictureBox();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.footerImageSmall = new System.Windows.Forms.PictureBox();
            this.quizTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerImageSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(415, 370);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(170, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Autentificare";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButon_Click);
            // 
            // createAccountLink
            // 
            this.createAccountLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.createAccountLink.AutoSize = true;
            this.createAccountLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createAccountLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.createAccountLink.Location = new System.Drawing.Point(453, 440);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(93, 17);
            this.createAccountLink.TabIndex = 2;
            this.createAccountLink.TabStop = true;
            this.createAccountLink.Text = "Creare cont";
            this.createAccountLink.Visible = false;
            this.createAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLink_LinkClicked);
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(380, 230);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameBox.Size = new System.Drawing.Size(240, 26);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Visible = false;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(380, 310);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(240, 26);
            this.passBox.TabIndex = 4;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.Visible = false;
            // 
            // forgotPassLink
            // 
            this.forgotPassLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.forgotPassLink.AutoSize = true;
            this.forgotPassLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPassLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.forgotPassLink.Location = new System.Drawing.Point(442, 470);
            this.forgotPassLink.Name = "forgotPassLink";
            this.forgotPassLink.Size = new System.Drawing.Size(119, 17);
            this.forgotPassLink.TabIndex = 5;
            this.forgotPassLink.TabStop = true;
            this.forgotPassLink.Text = "Ai uitat parola?";
            this.forgotPassLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forgotPassLink.Visible = false;
            this.forgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassLink_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(463, 200);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 20);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Utilizator";
            this.usernameLabel.Visible = false;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(473, 280);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(54, 20);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "Parola";
            this.passLabel.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(420, 170);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(178, 20);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Bine ai venit, [Prenume]!";
            this.welcomeLabel.Visible = false;
            // 
            // newQuizButton
            // 
            this.newQuizButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.newQuizButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.newQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuizButton.ForeColor = System.Drawing.Color.White;
            this.newQuizButton.Location = new System.Drawing.Point(400, 230);
            this.newQuizButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newQuizButton.Name = "newQuizButton";
            this.newQuizButton.Size = new System.Drawing.Size(200, 50);
            this.newQuizButton.TabIndex = 10;
            this.newQuizButton.Text = "Chestionar Nou";
            this.newQuizButton.UseVisualStyleBackColor = false;
            this.newQuizButton.Visible = false;
            this.newQuizButton.Click += new System.EventHandler(this.QuizButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.statisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.ForeColor = System.Drawing.Color.White;
            this.statisticsButton.Location = new System.Drawing.Point(400, 300);
            this.statisticsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(200, 50);
            this.statisticsButton.TabIndex = 11;
            this.statisticsButton.Text = "Statistici";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Visible = false;
            this.statisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(400, 370);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Iesire";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.Location = new System.Drawing.Point(105, 120);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(525, 20);
            this.questionText.TabIndex = 16;
            this.questionText.Text = "In imaginea de mai jos este aer. De ce oamenii nu simt greutatea aerului?";
            this.questionText.Visible = false;
            // 
            // questionImage
            // 
            this.questionImage.Image = global::RomGeo.Properties.Resources.cer;
            this.questionImage.Location = new System.Drawing.Point(450, 150);
            this.questionImage.Name = "questionImage";
            this.questionImage.Size = new System.Drawing.Size(500, 330);
            this.questionImage.TabIndex = 18;
            this.questionImage.TabStop = false;
            this.questionImage.Visible = false;
            // 
            // logoSmall
            // 
            this.logoSmall.Image = global::RomGeo.Properties.Resources.logo6;
            this.logoSmall.Location = new System.Drawing.Point(0, 0);
            this.logoSmall.Name = "logoSmall";
            this.logoSmall.Size = new System.Drawing.Size(980, 100);
            this.logoSmall.TabIndex = 15;
            this.logoSmall.TabStop = false;
            this.logoSmall.Visible = false;
            // 
            // headerImage
            // 
            this.headerImage.Image = global::RomGeo.Properties.Resources.logo2_150;
            this.headerImage.InitialImage = null;
            this.headerImage.Location = new System.Drawing.Point(410, 0);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(189, 150);
            this.headerImage.TabIndex = 1;
            this.headerImage.TabStop = false;
            this.headerImage.Visible = false;
            // 
            // footerImage
            // 
            this.footerImage.Image = global::RomGeo.Properties.Resources.bottom;
            this.footerImage.Location = new System.Drawing.Point(0, 510);
            this.footerImage.Name = "footerImage";
            this.footerImage.Size = new System.Drawing.Size(980, 147);
            this.footerImage.TabIndex = 8;
            this.footerImage.TabStop = false;
            this.footerImage.Visible = false;
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(110, 200);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(168, 21);
            this.answer1.TabIndex = 19;
            this.answer1.TabStop = true;
            this.answer1.Text = "Pentru ca sunt ocupati";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Visible = false;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(110, 250);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(168, 21);
            this.answer2.TabIndex = 20;
            this.answer2.TabStop = true;
            this.answer2.Text = "Pentru ca sunt ocupati";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Visible = false;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(110, 300);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(168, 21);
            this.answer3.TabIndex = 21;
            this.answer3.TabStop = true;
            this.answer3.Text = "Pentru ca sunt ocupati";
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Visible = false;
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(110, 350);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(168, 21);
            this.answer4.TabIndex = 22;
            this.answer4.TabStop = true;
            this.answer4.Text = "Pentru ca sunt ocupati";
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Visible = false;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.nextQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.ForeColor = System.Drawing.Color.White;
            this.nextQuestionButton.Location = new System.Drawing.Point(750, 510);
            this.nextQuestionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(200, 50);
            this.nextQuestionButton.TabIndex = 23;
            this.nextQuestionButton.Text = "Urmatoarea Intrebare";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Visible = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // footerImageSmall
            // 
            this.footerImageSmall.Image = global::RomGeo.Properties.Resources.bottom;
            this.footerImageSmall.Location = new System.Drawing.Point(0, 550);
            this.footerImageSmall.Name = "footerImageSmall";
            this.footerImageSmall.Size = new System.Drawing.Size(980, 147);
            this.footerImageSmall.TabIndex = 24;
            this.footerImageSmall.TabStop = false;
            this.footerImageSmall.Visible = false;
            // 
            // quizTitle
            // 
            this.quizTitle.AutoSize = true;
            this.quizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizTitle.Location = new System.Drawing.Point(200, 15);
            this.quizTitle.Name = "quizTitle";
            this.quizTitle.Size = new System.Drawing.Size(219, 31);
            this.quizTitle.TabIndex = 26;
            this.quizTitle.Text = "Intrebarea  5 / 30";
            this.quizTitle.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 657);
            this.Controls.Add(this.quizTitle);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.footerImageSmall);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.logoSmall);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.newQuizButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.headerImage);
            this.Controls.Add(this.footerImage);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.forgotPassLink);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.createAccountLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.questionImage);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RomGeo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerImageSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox headerImage;
        private System.Windows.Forms.LinkLabel createAccountLink;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.LinkLabel forgotPassLink;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.PictureBox footerImage;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button newQuizButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox logoSmall;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.PictureBox questionImage;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.RadioButton answer4;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.PictureBox footerImageSmall;
        private System.Windows.Forms.Label quizTitle;

    }
}

