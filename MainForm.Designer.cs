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
            this.chestionarNouButton = new System.Windows.Forms.Button();
            this.statisticiButton = new System.Windows.Forms.Button();
            this.iesireButton = new System.Windows.Forms.Button();
            this.intrebareText = new System.Windows.Forms.Label();
            this.quizTitle = new System.Windows.Forms.Label();
            this.intrebareImagine = new System.Windows.Forms.PictureBox();
            this.logoSmall = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bottomPic = new System.Windows.Forms.PictureBox();
            this.raspuns1 = new System.Windows.Forms.RadioButton();
            this.raspuns2 = new System.Windows.Forms.RadioButton();
            this.raspuns3 = new System.Windows.Forms.RadioButton();
            this.raspuns4 = new System.Windows.Forms.RadioButton();
            this.urmatoareaIntrebare = new System.Windows.Forms.Button();
            this.bottomPicSmall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.intrebareImagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.loginButton.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(415, 370);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(170, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Autentificare";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.login_Click);
            // 
            // createAccountLink
            // 
            this.createAccountLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.createAccountLink.AutoSize = true;
            this.createAccountLink.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createAccountLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.createAccountLink.Location = new System.Drawing.Point(453, 440);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(94, 19);
            this.createAccountLink.TabIndex = 2;
            this.createAccountLink.TabStop = true;
            this.createAccountLink.Text = "Creare cont";
            this.createAccountLink.Visible = false;
            this.createAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLink_LinkClicked);
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(380, 230);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameBox.Size = new System.Drawing.Size(240, 29);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Visible = false;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(380, 310);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(240, 29);
            this.passBox.TabIndex = 4;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.Visible = false;
            // 
            // forgotPassLink
            // 
            this.forgotPassLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.forgotPassLink.AutoSize = true;
            this.forgotPassLink.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPassLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.forgotPassLink.Location = new System.Drawing.Point(442, 470);
            this.forgotPassLink.Name = "forgotPassLink";
            this.forgotPassLink.Size = new System.Drawing.Size(116, 19);
            this.forgotPassLink.TabIndex = 5;
            this.forgotPassLink.TabStop = true;
            this.forgotPassLink.Text = "Ai uitat parola?";
            this.forgotPassLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forgotPassLink.Visible = false;
            this.forgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassLink_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(463, 200);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 22);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Utilizator";
            this.usernameLabel.Visible = false;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(473, 280);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(54, 22);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "Parola";
            this.passLabel.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(423, 170);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(182, 22);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Bine ai venit, [Prenume]!";
            this.welcomeLabel.Visible = false;
            // 
            // chestionarNouButton
            // 
            this.chestionarNouButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.chestionarNouButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.chestionarNouButton.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestionarNouButton.ForeColor = System.Drawing.Color.White;
            this.chestionarNouButton.Location = new System.Drawing.Point(400, 230);
            this.chestionarNouButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chestionarNouButton.Name = "chestionarNouButton";
            this.chestionarNouButton.Size = new System.Drawing.Size(200, 50);
            this.chestionarNouButton.TabIndex = 10;
            this.chestionarNouButton.Text = "Chestionar Nou";
            this.chestionarNouButton.UseVisualStyleBackColor = false;
            this.chestionarNouButton.Visible = false;
            this.chestionarNouButton.Click += new System.EventHandler(this.chestionarNouButton_Click);
            // 
            // statisticiButton
            // 
            this.statisticiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.statisticiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.statisticiButton.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticiButton.ForeColor = System.Drawing.Color.White;
            this.statisticiButton.Location = new System.Drawing.Point(400, 300);
            this.statisticiButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticiButton.Name = "statisticiButton";
            this.statisticiButton.Size = new System.Drawing.Size(200, 50);
            this.statisticiButton.TabIndex = 11;
            this.statisticiButton.Text = "Statistici";
            this.statisticiButton.UseVisualStyleBackColor = false;
            this.statisticiButton.Visible = false;
            this.statisticiButton.Click += new System.EventHandler(this.statisticiButton_Click);
            // 
            // iesireButton
            // 
            this.iesireButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.iesireButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.iesireButton.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireButton.ForeColor = System.Drawing.Color.White;
            this.iesireButton.Location = new System.Drawing.Point(400, 370);
            this.iesireButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iesireButton.Name = "iesireButton";
            this.iesireButton.Size = new System.Drawing.Size(200, 50);
            this.iesireButton.TabIndex = 12;
            this.iesireButton.Text = "Iesire";
            this.iesireButton.UseVisualStyleBackColor = false;
            this.iesireButton.Visible = false;
            this.iesireButton.Click += new System.EventHandler(this.iesireButton_Click);
            // 
            // intrebareText
            // 
            this.intrebareText.AutoSize = true;
            this.intrebareText.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrebareText.Location = new System.Drawing.Point(105, 120);
            this.intrebareText.Name = "intrebareText";
            this.intrebareText.Size = new System.Drawing.Size(526, 22);
            this.intrebareText.TabIndex = 16;
            this.intrebareText.Text = "In imaginea de mai jos este aer. De ce oamenii nu simt greutatea aerului?";
            this.intrebareText.Visible = false;
            // 
            // quizTitle
            // 
            this.quizTitle.AutoSize = true;
            this.quizTitle.Font = new System.Drawing.Font("Open Sans Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizTitle.Location = new System.Drawing.Point(200, 15);
            this.quizTitle.Name = "quizTitle";
            this.quizTitle.Size = new System.Drawing.Size(225, 36);
            this.quizTitle.TabIndex = 17;
            this.quizTitle.Text = "Intrebarea  5 / 25";
            this.quizTitle.Visible = false;
            // 
            // intrebareImagine
            // 
            this.intrebareImagine.Image = global::RomGeo.Properties.Resources.cer;
            this.intrebareImagine.Location = new System.Drawing.Point(450, 150);
            this.intrebareImagine.Name = "intrebareImagine";
            this.intrebareImagine.Size = new System.Drawing.Size(500, 330);
            this.intrebareImagine.TabIndex = 18;
            this.intrebareImagine.TabStop = false;
            this.intrebareImagine.Visible = false;
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
            // logo
            // 
            this.logo.Image = global::RomGeo.Properties.Resources.logo2_150;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(410, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(189, 150);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // bottomPic
            // 
            this.bottomPic.Image = global::RomGeo.Properties.Resources.bottom;
            this.bottomPic.Location = new System.Drawing.Point(0, 510);
            this.bottomPic.Name = "bottomPic";
            this.bottomPic.Size = new System.Drawing.Size(980, 147);
            this.bottomPic.TabIndex = 8;
            this.bottomPic.TabStop = false;
            this.bottomPic.Visible = false;
            // 
            // raspuns1
            // 
            this.raspuns1.AutoSize = true;
            this.raspuns1.Location = new System.Drawing.Point(110, 200);
            this.raspuns1.Name = "raspuns1";
            this.raspuns1.Size = new System.Drawing.Size(169, 23);
            this.raspuns1.TabIndex = 19;
            this.raspuns1.TabStop = true;
            this.raspuns1.Text = "Pentru ca sunt ocupati";
            this.raspuns1.UseVisualStyleBackColor = true;
            this.raspuns1.Visible = false;
            // 
            // raspuns2
            // 
            this.raspuns2.AutoSize = true;
            this.raspuns2.Location = new System.Drawing.Point(110, 250);
            this.raspuns2.Name = "raspuns2";
            this.raspuns2.Size = new System.Drawing.Size(169, 23);
            this.raspuns2.TabIndex = 20;
            this.raspuns2.TabStop = true;
            this.raspuns2.Text = "Pentru ca sunt ocupati";
            this.raspuns2.UseVisualStyleBackColor = true;
            this.raspuns2.Visible = false;
            // 
            // raspuns3
            // 
            this.raspuns3.AutoSize = true;
            this.raspuns3.Location = new System.Drawing.Point(110, 300);
            this.raspuns3.Name = "raspuns3";
            this.raspuns3.Size = new System.Drawing.Size(169, 23);
            this.raspuns3.TabIndex = 21;
            this.raspuns3.TabStop = true;
            this.raspuns3.Text = "Pentru ca sunt ocupati";
            this.raspuns3.UseVisualStyleBackColor = true;
            this.raspuns3.Visible = false;
            // 
            // raspuns4
            // 
            this.raspuns4.AutoSize = true;
            this.raspuns4.Location = new System.Drawing.Point(110, 350);
            this.raspuns4.Name = "raspuns4";
            this.raspuns4.Size = new System.Drawing.Size(169, 23);
            this.raspuns4.TabIndex = 22;
            this.raspuns4.TabStop = true;
            this.raspuns4.Text = "Pentru ca sunt ocupati";
            this.raspuns4.UseVisualStyleBackColor = true;
            this.raspuns4.Visible = false;
            // 
            // urmatoareaIntrebare
            // 
            this.urmatoareaIntrebare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.urmatoareaIntrebare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.urmatoareaIntrebare.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urmatoareaIntrebare.ForeColor = System.Drawing.Color.White;
            this.urmatoareaIntrebare.Location = new System.Drawing.Point(750, 510);
            this.urmatoareaIntrebare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urmatoareaIntrebare.Name = "urmatoareaIntrebare";
            this.urmatoareaIntrebare.Size = new System.Drawing.Size(200, 50);
            this.urmatoareaIntrebare.TabIndex = 23;
            this.urmatoareaIntrebare.Text = "Urmatoarea Intrebare";
            this.urmatoareaIntrebare.UseVisualStyleBackColor = false;
            this.urmatoareaIntrebare.Visible = false;
            this.urmatoareaIntrebare.Click += new System.EventHandler(this.urmatoareaIntrebare_Click);
            // 
            // bottomPicSmall
            // 
            this.bottomPicSmall.Image = global::RomGeo.Properties.Resources.bottom;
            this.bottomPicSmall.Location = new System.Drawing.Point(0, 550);
            this.bottomPicSmall.Name = "bottomPicSmall";
            this.bottomPicSmall.Size = new System.Drawing.Size(980, 147);
            this.bottomPicSmall.TabIndex = 24;
            this.bottomPicSmall.TabStop = false;
            this.bottomPicSmall.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 657);
            this.Controls.Add(this.urmatoareaIntrebare);
            this.Controls.Add(this.bottomPicSmall);
            this.Controls.Add(this.raspuns4);
            this.Controls.Add(this.raspuns3);
            this.Controls.Add(this.raspuns2);
            this.Controls.Add(this.raspuns1);
            this.Controls.Add(this.intrebareImagine);
            this.Controls.Add(this.quizTitle);
            this.Controls.Add(this.intrebareText);
            this.Controls.Add(this.logoSmall);
            this.Controls.Add(this.iesireButton);
            this.Controls.Add(this.statisticiButton);
            this.Controls.Add(this.chestionarNouButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bottomPic);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.forgotPassLink);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.createAccountLink);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "RomGeo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intrebareImagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.LinkLabel createAccountLink;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.LinkLabel forgotPassLink;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.PictureBox bottomPic;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button chestionarNouButton;
        private System.Windows.Forms.Button statisticiButton;
        private System.Windows.Forms.Button iesireButton;
        private System.Windows.Forms.PictureBox logoSmall;
        private System.Windows.Forms.Label intrebareText;
        private System.Windows.Forms.Label quizTitle;
        private System.Windows.Forms.PictureBox intrebareImagine;
        private System.Windows.Forms.RadioButton raspuns1;
        private System.Windows.Forms.RadioButton raspuns2;
        private System.Windows.Forms.RadioButton raspuns3;
        private System.Windows.Forms.RadioButton raspuns4;
        private System.Windows.Forms.Button urmatoareaIntrebare;
        private System.Windows.Forms.PictureBox bottomPicSmall;

    }
}

