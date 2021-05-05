namespace KS_Token_Nuker
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormSkin = new FlatUI.FormSkin();
            this.MinimizeButton = new FlatUI.FlatMini();
            this.CloseButton = new FlatUI.FlatClose();
            this.KersarLabel = new FlatUI.FlatLabel();
            this.MainTabControl = new FlatUI.FlatTabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.DisableV2 = new FlatUI.FlatButton();
            this.DisableToken = new FlatUI.FlatButton();
            this.FreezeButton = new FlatUI.FlatButton();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.LogInButton = new FlatUI.FlatButton();
            this.NukeButton = new FlatUI.FlatButton();
            this.MainStatusBar = new FlatUI.FlatStatusBar();
            this.OptionsTabPage = new System.Windows.Forms.TabPage();
            this.UnVerifyCheckBox = new FlatUI.FlatCheckBox();
            this.CustomStatusLabel = new FlatUI.FlatLabel();
            this.CustomStatusTextBox = new FlatUI.FlatTextBox();
            this.LanguageLabel = new FlatUI.FlatLabel();
            this.LanguageComboBox = new FlatUI.FlatComboBox();
            this.IconLabel = new FlatUI.FlatLabel();
            this.ServerCountLabel = new FlatUI.FlatLabel();
            this.ServerNameLabel = new FlatUI.FlatLabel();
            this.EmbedCheckBox = new FlatUI.FlatCheckBox();
            this.TokenLabel = new FlatUI.FlatLabel();
            this.ServerNameTextBox = new FlatUI.FlatTextBox();
            this.ServerCountNumericUpDown = new FlatUI.FlatNumeric();
            this.TokenTextBox = new FlatUI.FlatTextBox();
            this.IconButton = new FlatUI.FlatButton();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoTabPage = new System.Windows.Forms.TabPage();
            this.UserPFPLabel = new FlatUI.FlatLabel();
            this.UserPFPPictureBox = new System.Windows.Forms.PictureBox();
            this.UserNitroLabel = new FlatUI.FlatLabel();
            this.UserPhoneNumberLabel = new FlatUI.FlatLabel();
            this.User2FAColorLabel = new System.Windows.Forms.Label();
            this.User2FALabel = new FlatUI.FlatLabel();
            this.UserLocaleLabel = new FlatUI.FlatLabel();
            this.EMailVerificationLabel = new FlatUI.FlatLabel();
            this.EMailVerificationColorLabel = new System.Windows.Forms.Label();
            this.EMailLabel = new FlatUI.FlatLabel();
            this.UserTagLabel = new FlatUI.FlatLabel();
            this.UserIDLabel = new FlatUI.FlatLabel();
            this.TokenStatusLabel = new FlatUI.FlatLabel();
            this.DetectedTokenLabel = new FlatUI.FlatLabel();
            this.MainFormSkin.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.OptionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.InfoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPFPPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormSkin
            // 
            this.MainFormSkin.BackColor = System.Drawing.Color.White;
            this.MainFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.MainFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.MainFormSkin.Controls.Add(this.MinimizeButton);
            this.MainFormSkin.Controls.Add(this.CloseButton);
            this.MainFormSkin.Controls.Add(this.KersarLabel);
            this.MainFormSkin.Controls.Add(this.MainTabControl);
            this.MainFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MainFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MainFormSkin.HeaderMaximize = false;
            this.MainFormSkin.Location = new System.Drawing.Point(0, 0);
            this.MainFormSkin.Name = "MainFormSkin";
            this.MainFormSkin.Size = new System.Drawing.Size(500, 350);
            this.MainFormSkin.TabIndex = 0;
            this.MainFormSkin.Text = "KS Token Nuker v2";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.White;
            this.MinimizeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 12F);
            this.MinimizeButton.Location = new System.Drawing.Point(454, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(18, 18);
            this.MinimizeButton.TabIndex = 49;
            this.MinimizeButton.Text = "flatMini1";
            this.MinimizeButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseButton.Font = new System.Drawing.Font("Marlett", 10F);
            this.CloseButton.Location = new System.Drawing.Point(477, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 48;
            this.CloseButton.Text = "flatClose1";
            this.CloseButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // KersarLabel
            // 
            this.KersarLabel.AutoSize = true;
            this.KersarLabel.BackColor = System.Drawing.Color.Transparent;
            this.KersarLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.KersarLabel.ForeColor = System.Drawing.Color.White;
            this.KersarLabel.Location = new System.Drawing.Point(300, 5);
            this.KersarLabel.Name = "KersarLabel";
            this.KersarLabel.Size = new System.Drawing.Size(147, 37);
            this.KersarLabel.TabIndex = 85;
            this.KersarLabel.Text = "카서#6974";
            // 
            // MainTabControl
            // 
            this.MainTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MainTabControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MainTabControl.Controls.Add(this.MainTabPage);
            this.MainTabControl.Controls.Add(this.OptionsTabPage);
            this.MainTabControl.Controls.Add(this.InfoTabPage);
            this.MainTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainTabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.MainTabControl.Location = new System.Drawing.Point(0, 50);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(500, 300);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 47;
            // 
            // MainTabPage
            // 
            this.MainTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.MainTabPage.Controls.Add(this.DisableV2);
            this.MainTabPage.Controls.Add(this.DisableToken);
            this.MainTabPage.Controls.Add(this.FreezeButton);
            this.MainTabPage.Controls.Add(this.LogTextBox);
            this.MainTabPage.Controls.Add(this.LogInButton);
            this.MainTabPage.Controls.Add(this.NukeButton);
            this.MainTabPage.Controls.Add(this.MainStatusBar);
            this.MainTabPage.Location = new System.Drawing.Point(4, 44);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(492, 252);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Main";
            // 
            // DisableV2
            // 
            this.DisableV2.BackColor = System.Drawing.Color.Transparent;
            this.DisableV2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DisableV2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisableV2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DisableV2.Location = new System.Drawing.Point(372, 48);
            this.DisableV2.Name = "DisableV2";
            this.DisableV2.Rounded = false;
            this.DisableV2.Size = new System.Drawing.Size(108, 42);
            this.DisableV2.TabIndex = 70;
            this.DisableV2.Text = "Disable V2";
            this.DisableV2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DisableV2.UseCustomColor = false;
            this.DisableV2.Click += new System.EventHandler(this.DisableV2_Click);
            // 
            // DisableToken
            // 
            this.DisableToken.BackColor = System.Drawing.Color.Transparent;
            this.DisableToken.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DisableToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisableToken.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DisableToken.Location = new System.Drawing.Point(372, 10);
            this.DisableToken.Name = "DisableToken";
            this.DisableToken.Rounded = false;
            this.DisableToken.Size = new System.Drawing.Size(108, 32);
            this.DisableToken.TabIndex = 69;
            this.DisableToken.Text = "Disable Token";
            this.DisableToken.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DisableToken.UseCustomColor = false;
            this.DisableToken.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // FreezeButton
            // 
            this.FreezeButton.BackColor = System.Drawing.Color.Transparent;
            this.FreezeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.FreezeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FreezeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FreezeButton.Location = new System.Drawing.Point(256, 10);
            this.FreezeButton.Name = "FreezeButton";
            this.FreezeButton.Rounded = false;
            this.FreezeButton.Size = new System.Drawing.Size(110, 80);
            this.FreezeButton.TabIndex = 68;
            this.FreezeButton.Text = "Freeze Client클라이언트 프리즈";
            this.FreezeButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FreezeButton.UseCustomColor = false;
            this.FreezeButton.Click += new System.EventHandler(this.FreezeButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.HideSelection = false;
            this.LogTextBox.Location = new System.Drawing.Point(10, 100);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(470, 120);
            this.LogTextBox.TabIndex = 67;
            this.LogTextBox.Text = "Log - 로그";
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LogInButton.Location = new System.Drawing.Point(135, 10);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Rounded = false;
            this.LogInButton.Size = new System.Drawing.Size(115, 80);
            this.LogInButton.TabIndex = 66;
            this.LogInButton.Text = "Chrome Log In\n크롬 로그인";
            this.LogInButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LogInButton.UseCustomColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // NukeButton
            // 
            this.NukeButton.BackColor = System.Drawing.Color.Transparent;
            this.NukeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.NukeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NukeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NukeButton.Location = new System.Drawing.Point(10, 10);
            this.NukeButton.Name = "NukeButton";
            this.NukeButton.Rounded = false;
            this.NukeButton.Size = new System.Drawing.Size(119, 80);
            this.NukeButton.TabIndex = 65;
            this.NukeButton.Text = "Nuke Token\n토큰 폭파";
            this.NukeButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.NukeButton.UseCustomColor = false;
            this.NukeButton.Click += new System.EventHandler(this.NukeButton_Click);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MainStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainStatusBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MainStatusBar.ForeColor = System.Drawing.Color.White;
            this.MainStatusBar.Location = new System.Drawing.Point(3, 226);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MainStatusBar.ShowTimeDate = false;
            this.MainStatusBar.Size = new System.Drawing.Size(486, 23);
            this.MainStatusBar.TabIndex = 64;
            this.MainStatusBar.TextColor = System.Drawing.Color.White;
            // 
            // OptionsTabPage
            // 
            this.OptionsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.OptionsTabPage.Controls.Add(this.UnVerifyCheckBox);
            this.OptionsTabPage.Controls.Add(this.CustomStatusLabel);
            this.OptionsTabPage.Controls.Add(this.CustomStatusTextBox);
            this.OptionsTabPage.Controls.Add(this.LanguageLabel);
            this.OptionsTabPage.Controls.Add(this.LanguageComboBox);
            this.OptionsTabPage.Controls.Add(this.IconLabel);
            this.OptionsTabPage.Controls.Add(this.ServerCountLabel);
            this.OptionsTabPage.Controls.Add(this.ServerNameLabel);
            this.OptionsTabPage.Controls.Add(this.EmbedCheckBox);
            this.OptionsTabPage.Controls.Add(this.TokenLabel);
            this.OptionsTabPage.Controls.Add(this.ServerNameTextBox);
            this.OptionsTabPage.Controls.Add(this.ServerCountNumericUpDown);
            this.OptionsTabPage.Controls.Add(this.TokenTextBox);
            this.OptionsTabPage.Controls.Add(this.IconButton);
            this.OptionsTabPage.Controls.Add(this.IconPictureBox);
            this.OptionsTabPage.Location = new System.Drawing.Point(4, 44);
            this.OptionsTabPage.Name = "OptionsTabPage";
            this.OptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTabPage.Size = new System.Drawing.Size(492, 252);
            this.OptionsTabPage.TabIndex = 1;
            this.OptionsTabPage.Text = "Options";
            // 
            // UnVerifyCheckBox
            // 
            this.UnVerifyCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.UnVerifyCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.UnVerifyCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.UnVerifyCheckBox.Checked = false;
            this.UnVerifyCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnVerifyCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UnVerifyCheckBox.Location = new System.Drawing.Point(290, 150);
            this.UnVerifyCheckBox.Name = "UnVerifyCheckBox";
            this.UnVerifyCheckBox.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.UnVerifyCheckBox.Size = new System.Drawing.Size(150, 22);
            this.UnVerifyCheckBox.TabIndex = 90;
            this.UnVerifyCheckBox.Text = "메일 인증 해제";
            // 
            // CustomStatusLabel
            // 
            this.CustomStatusLabel.AutoSize = true;
            this.CustomStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomStatusLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustomStatusLabel.ForeColor = System.Drawing.Color.White;
            this.CustomStatusLabel.Location = new System.Drawing.Point(290, 90);
            this.CustomStatusLabel.Name = "CustomStatusLabel";
            this.CustomStatusLabel.Size = new System.Drawing.Size(40, 19);
            this.CustomStatusLabel.TabIndex = 89;
            this.CustomStatusLabel.Text = "상메:";
            // 
            // CustomStatusTextBox
            // 
            this.CustomStatusTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomStatusTextBox.FocusOnHover = false;
            this.CustomStatusTextBox.Hint = "";
            this.CustomStatusTextBox.Location = new System.Drawing.Point(340, 85);
            this.CustomStatusTextBox.MaxLength = 128;
            this.CustomStatusTextBox.Multiline = false;
            this.CustomStatusTextBox.Name = "CustomStatusTextBox";
            this.CustomStatusTextBox.ReadOnly = false;
            this.CustomStatusTextBox.Size = new System.Drawing.Size(140, 29);
            this.CustomStatusTextBox.TabIndex = 88;
            this.CustomStatusTextBox.Text = "Custom Status";
            this.CustomStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomStatusTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CustomStatusTextBox.UseSystemPasswordChar = false;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanguageLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LanguageLabel.ForeColor = System.Drawing.Color.White;
            this.LanguageLabel.Location = new System.Drawing.Point(290, 120);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(40, 19);
            this.LanguageLabel.TabIndex = 87;
            this.LanguageLabel.Text = "언어:";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LanguageComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LanguageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.White;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.LanguageComboBox.ItemHeight = 18;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "덴마크어",
            "독일어",
            "영어 (영국)",
            "영어 (미국)",
            "스페인어",
            "프랑스어",
            "크로아티아어",
            "이탈리아어",
            "리투아니아어",
            "헝가리어",
            "네덜란드어",
            "노르웨이어",
            "폴란드어",
            "포르투갈어",
            "루마니아어",
            "핀란드어",
            "스웨덴어",
            "베트남어",
            "터키어",
            "체코어",
            "그리스어",
            "불가리아어",
            "러시아어",
            "우크라이나어",
            "태국어",
            "중국어",
            "일본어",
            "중국어 (대만)",
            "한국어"});
            this.LanguageComboBox.Location = new System.Drawing.Point(340, 120);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(140, 24);
            this.LanguageComboBox.TabIndex = 86;
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.BackColor = System.Drawing.Color.Transparent;
            this.IconLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IconLabel.ForeColor = System.Drawing.Color.White;
            this.IconLabel.Location = new System.Drawing.Point(10, 90);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(83, 19);
            this.IconLabel.TabIndex = 84;
            this.IconLabel.Text = "서버 아이콘";
            // 
            // ServerCountLabel
            // 
            this.ServerCountLabel.AutoSize = true;
            this.ServerCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServerCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServerCountLabel.ForeColor = System.Drawing.Color.White;
            this.ServerCountLabel.Location = new System.Drawing.Point(290, 215);
            this.ServerCountLabel.Name = "ServerCountLabel";
            this.ServerCountLabel.Size = new System.Drawing.Size(72, 19);
            this.ServerCountLabel.TabIndex = 83;
            this.ServerCountLabel.Text = "서버 개수:";
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServerNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServerNameLabel.ForeColor = System.Drawing.Color.White;
            this.ServerNameLabel.Location = new System.Drawing.Point(10, 55);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(72, 19);
            this.ServerNameLabel.TabIndex = 82;
            this.ServerNameLabel.Text = "서버 이름:";
            // 
            // EmbedCheckBox
            // 
            this.EmbedCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.EmbedCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.EmbedCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.EmbedCheckBox.Checked = false;
            this.EmbedCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmbedCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmbedCheckBox.Location = new System.Drawing.Point(290, 180);
            this.EmbedCheckBox.Name = "EmbedCheckBox";
            this.EmbedCheckBox.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.EmbedCheckBox.Size = new System.Drawing.Size(150, 22);
            this.EmbedCheckBox.TabIndex = 81;
            this.EmbedCheckBox.Text = "DM 임베드 전송";
            // 
            // TokenLabel
            // 
            this.TokenLabel.AutoSize = true;
            this.TokenLabel.BackColor = System.Drawing.Color.Transparent;
            this.TokenLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TokenLabel.ForeColor = System.Drawing.Color.White;
            this.TokenLabel.Location = new System.Drawing.Point(10, 15);
            this.TokenLabel.Name = "TokenLabel";
            this.TokenLabel.Size = new System.Drawing.Size(40, 19);
            this.TokenLabel.TabIndex = 80;
            this.TokenLabel.Text = "토큰:";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ServerNameTextBox.FocusOnHover = false;
            this.ServerNameTextBox.Hint = "";
            this.ServerNameTextBox.Location = new System.Drawing.Point(90, 50);
            this.ServerNameTextBox.MaxLength = 32767;
            this.ServerNameTextBox.Multiline = false;
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.ReadOnly = false;
            this.ServerNameTextBox.Size = new System.Drawing.Size(390, 29);
            this.ServerNameTextBox.TabIndex = 79;
            this.ServerNameTextBox.Text = "Server Name";
            this.ServerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServerNameTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ServerNameTextBox.UseSystemPasswordChar = false;
            // 
            // ServerCountNumericUpDown
            // 
            this.ServerCountNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ServerCountNumericUpDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ServerCountNumericUpDown.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ServerCountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServerCountNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.ServerCountNumericUpDown.Location = new System.Drawing.Point(370, 210);
            this.ServerCountNumericUpDown.Maximum = ((long)(100));
            this.ServerCountNumericUpDown.Minimum = ((long)(0));
            this.ServerCountNumericUpDown.Name = "ServerCountNumericUpDown";
            this.ServerCountNumericUpDown.Size = new System.Drawing.Size(110, 30);
            this.ServerCountNumericUpDown.TabIndex = 78;
            this.ServerCountNumericUpDown.Value = ((long)(100));
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TokenTextBox.FocusOnHover = false;
            this.TokenTextBox.Hint = "";
            this.TokenTextBox.Location = new System.Drawing.Point(60, 10);
            this.TokenTextBox.MaxLength = 32767;
            this.TokenTextBox.Multiline = false;
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.ReadOnly = false;
            this.TokenTextBox.Size = new System.Drawing.Size(420, 29);
            this.TokenTextBox.TabIndex = 77;
            this.TokenTextBox.Text = "Token";
            this.TokenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TokenTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TokenTextBox.UseSystemPasswordChar = false;
            this.TokenTextBox.TextChanged += new System.EventHandler(this.TokenTextBox_TextChanged);
            // 
            // IconButton
            // 
            this.IconButton.BackColor = System.Drawing.Color.Transparent;
            this.IconButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.IconButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IconButton.Location = new System.Drawing.Point(148, 115);
            this.IconButton.Name = "IconButton";
            this.IconButton.Rounded = false;
            this.IconButton.Size = new System.Drawing.Size(128, 128);
            this.IconButton.TabIndex = 76;
            this.IconButton.Text = "Open Icon File\n아이콘 파일 열기";
            this.IconButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.IconButton.UseCustomColor = false;
            this.IconButton.Click += new System.EventHandler(this.IconButton_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.BackgroundImage")));
            this.IconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPictureBox.Location = new System.Drawing.Point(10, 115);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(128, 128);
            this.IconPictureBox.TabIndex = 74;
            this.IconPictureBox.TabStop = false;
            // 
            // InfoTabPage
            // 
            this.InfoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.InfoTabPage.Controls.Add(this.UserPFPLabel);
            this.InfoTabPage.Controls.Add(this.UserPFPPictureBox);
            this.InfoTabPage.Controls.Add(this.UserNitroLabel);
            this.InfoTabPage.Controls.Add(this.UserPhoneNumberLabel);
            this.InfoTabPage.Controls.Add(this.User2FAColorLabel);
            this.InfoTabPage.Controls.Add(this.User2FALabel);
            this.InfoTabPage.Controls.Add(this.UserLocaleLabel);
            this.InfoTabPage.Controls.Add(this.EMailVerificationLabel);
            this.InfoTabPage.Controls.Add(this.EMailVerificationColorLabel);
            this.InfoTabPage.Controls.Add(this.EMailLabel);
            this.InfoTabPage.Controls.Add(this.UserTagLabel);
            this.InfoTabPage.Controls.Add(this.UserIDLabel);
            this.InfoTabPage.Controls.Add(this.TokenStatusLabel);
            this.InfoTabPage.Controls.Add(this.DetectedTokenLabel);
            this.InfoTabPage.Location = new System.Drawing.Point(4, 44);
            this.InfoTabPage.Name = "InfoTabPage";
            this.InfoTabPage.Size = new System.Drawing.Size(492, 252);
            this.InfoTabPage.TabIndex = 2;
            this.InfoTabPage.Text = "Info";
            // 
            // UserPFPLabel
            // 
            this.UserPFPLabel.AutoSize = true;
            this.UserPFPLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPFPLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserPFPLabel.ForeColor = System.Drawing.Color.White;
            this.UserPFPLabel.Location = new System.Drawing.Point(346, 88);
            this.UserPFPLabel.Name = "UserPFPLabel";
            this.UserPFPLabel.Size = new System.Drawing.Size(118, 19);
            this.UserPFPLabel.TabIndex = 13;
            this.UserPFPLabel.Text = "유저 프로필 사진:";
            // 
            // UserPFPPictureBox
            // 
            this.UserPFPPictureBox.Location = new System.Drawing.Point(350, 110);
            this.UserPFPPictureBox.Name = "UserPFPPictureBox";
            this.UserPFPPictureBox.Size = new System.Drawing.Size(128, 128);
            this.UserPFPPictureBox.TabIndex = 12;
            this.UserPFPPictureBox.TabStop = false;
            // 
            // UserNitroLabel
            // 
            this.UserNitroLabel.AutoSize = true;
            this.UserNitroLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNitroLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserNitroLabel.ForeColor = System.Drawing.Color.White;
            this.UserNitroLabel.Location = new System.Drawing.Point(10, 217);
            this.UserNitroLabel.Name = "UserNitroLabel";
            this.UserNitroLabel.Size = new System.Drawing.Size(118, 19);
            this.UserNitroLabel.TabIndex = 11;
            this.UserNitroLabel.Text = "유저 니트로: 없음";
            // 
            // UserPhoneNumberLabel
            // 
            this.UserPhoneNumberLabel.AutoSize = true;
            this.UserPhoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserPhoneNumberLabel.ForeColor = System.Drawing.Color.White;
            this.UserPhoneNumberLabel.Location = new System.Drawing.Point(10, 194);
            this.UserPhoneNumberLabel.Name = "UserPhoneNumberLabel";
            this.UserPhoneNumberLabel.Size = new System.Drawing.Size(132, 19);
            this.UserPhoneNumberLabel.TabIndex = 10;
            this.UserPhoneNumberLabel.Text = "유저 전화번호: 없음";
            // 
            // User2FAColorLabel
            // 
            this.User2FAColorLabel.BackColor = System.Drawing.Color.Red;
            this.User2FAColorLabel.Location = new System.Drawing.Point(125, 171);
            this.User2FAColorLabel.Name = "User2FAColorLabel";
            this.User2FAColorLabel.Size = new System.Drawing.Size(20, 20);
            this.User2FAColorLabel.TabIndex = 9;
            // 
            // User2FALabel
            // 
            this.User2FALabel.AutoSize = true;
            this.User2FALabel.BackColor = System.Drawing.Color.Transparent;
            this.User2FALabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.User2FALabel.ForeColor = System.Drawing.Color.White;
            this.User2FALabel.Location = new System.Drawing.Point(10, 171);
            this.User2FALabel.Name = "User2FALabel";
            this.User2FALabel.Size = new System.Drawing.Size(112, 19);
            this.User2FALabel.TabIndex = 8;
            this.User2FALabel.Text = "유저 2단계 인증:";
            // 
            // UserLocaleLabel
            // 
            this.UserLocaleLabel.AutoSize = true;
            this.UserLocaleLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLocaleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserLocaleLabel.ForeColor = System.Drawing.Color.White;
            this.UserLocaleLabel.Location = new System.Drawing.Point(10, 148);
            this.UserLocaleLabel.Name = "UserLocaleLabel";
            this.UserLocaleLabel.Size = new System.Drawing.Size(104, 19);
            this.UserLocaleLabel.TabIndex = 7;
            this.UserLocaleLabel.Text = "유저 언어: 없음";
            // 
            // EMailVerificationLabel
            // 
            this.EMailVerificationLabel.AutoSize = true;
            this.EMailVerificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.EMailVerificationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EMailVerificationLabel.ForeColor = System.Drawing.Color.White;
            this.EMailVerificationLabel.Location = new System.Drawing.Point(10, 125);
            this.EMailVerificationLabel.Name = "EMailVerificationLabel";
            this.EMailVerificationLabel.Size = new System.Drawing.Size(118, 19);
            this.EMailVerificationLabel.TabIndex = 6;
            this.EMailVerificationLabel.Text = "유저 이메일 인증:";
            // 
            // EMailVerificationColorLabel
            // 
            this.EMailVerificationColorLabel.BackColor = System.Drawing.Color.Red;
            this.EMailVerificationColorLabel.Location = new System.Drawing.Point(130, 125);
            this.EMailVerificationColorLabel.Name = "EMailVerificationColorLabel";
            this.EMailVerificationColorLabel.Size = new System.Drawing.Size(20, 20);
            this.EMailVerificationColorLabel.TabIndex = 5;
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EMailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EMailLabel.ForeColor = System.Drawing.Color.White;
            this.EMailLabel.Location = new System.Drawing.Point(10, 102);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(118, 19);
            this.EMailLabel.TabIndex = 4;
            this.EMailLabel.Text = "유저 이메일: 없음";
            // 
            // UserTagLabel
            // 
            this.UserTagLabel.AutoSize = true;
            this.UserTagLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserTagLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserTagLabel.ForeColor = System.Drawing.Color.White;
            this.UserTagLabel.Location = new System.Drawing.Point(10, 79);
            this.UserTagLabel.Name = "UserTagLabel";
            this.UserTagLabel.Size = new System.Drawing.Size(104, 19);
            this.UserTagLabel.TabIndex = 3;
            this.UserTagLabel.Text = "유저 태그: 없음";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserIDLabel.ForeColor = System.Drawing.Color.White;
            this.UserIDLabel.Location = new System.Drawing.Point(10, 56);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(118, 19);
            this.UserIDLabel.TabIndex = 2;
            this.UserIDLabel.Text = "유저 아이디: 없음";
            // 
            // TokenStatusLabel
            // 
            this.TokenStatusLabel.AutoSize = true;
            this.TokenStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.TokenStatusLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TokenStatusLabel.ForeColor = System.Drawing.Color.White;
            this.TokenStatusLabel.Location = new System.Drawing.Point(10, 33);
            this.TokenStatusLabel.Name = "TokenStatusLabel";
            this.TokenStatusLabel.Size = new System.Drawing.Size(204, 19);
            this.TokenStatusLabel.TabIndex = 1;
            this.TokenStatusLabel.Text = "토큰 상태: 만료됨 (사용 불가능)";
            // 
            // DetectedTokenLabel
            // 
            this.DetectedTokenLabel.AutoSize = true;
            this.DetectedTokenLabel.BackColor = System.Drawing.Color.Transparent;
            this.DetectedTokenLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DetectedTokenLabel.ForeColor = System.Drawing.Color.White;
            this.DetectedTokenLabel.Location = new System.Drawing.Point(10, 10);
            this.DetectedTokenLabel.Name = "DetectedTokenLabel";
            this.DetectedTokenLabel.Size = new System.Drawing.Size(118, 19);
            this.DetectedTokenLabel.TabIndex = 0;
            this.DetectedTokenLabel.Text = "감지된 토큰: 없음";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.ControlBox = false;
            this.Controls.Add(this.MainFormSkin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KS Token Nuker v2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormSkin.ResumeLayout(false);
            this.MainFormSkin.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.OptionsTabPage.ResumeLayout(false);
            this.OptionsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.InfoTabPage.ResumeLayout(false);
            this.InfoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPFPPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

        private FlatUI.FormSkin MainFormSkin;
        private FlatUI.FlatTabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabPage;
        private FlatUI.FlatStatusBar MainStatusBar;
        private System.Windows.Forms.TabPage OptionsTabPage;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private FlatUI.FlatMini MinimizeButton;
        private FlatUI.FlatClose CloseButton;
        private FlatUI.FlatButton LogInButton;
        private FlatUI.FlatButton NukeButton;
        private FlatUI.FlatButton IconButton;
        private FlatUI.FlatTextBox ServerNameTextBox;
        private FlatUI.FlatNumeric ServerCountNumericUpDown;
        private FlatUI.FlatTextBox TokenTextBox;
        private FlatUI.FlatLabel TokenLabel;
        private FlatUI.FlatCheckBox EmbedCheckBox;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private FlatUI.FlatLabel ServerCountLabel;
        private FlatUI.FlatLabel ServerNameLabel;
        private FlatUI.FlatLabel IconLabel;
        private FlatUI.FlatLabel KersarLabel;
        private FlatUI.FlatComboBox LanguageComboBox;
        private FlatUI.FlatLabel LanguageLabel;
        private FlatUI.FlatLabel CustomStatusLabel;
        private FlatUI.FlatTextBox CustomStatusTextBox;
        private FlatUI.FlatCheckBox UnVerifyCheckBox;
        private FlatUI.FlatButton FreezeButton;
        private System.Windows.Forms.TabPage InfoTabPage;
        private FlatUI.FlatLabel DetectedTokenLabel;
        private FlatUI.FlatLabel TokenStatusLabel;
        private FlatUI.FlatLabel UserIDLabel;
        private FlatUI.FlatLabel UserTagLabel;
        private FlatUI.FlatLabel EMailLabel;
        private FlatUI.FlatLabel EMailVerificationLabel;
        private System.Windows.Forms.Label EMailVerificationColorLabel;
        private FlatUI.FlatLabel UserLocaleLabel;
        private System.Windows.Forms.Label User2FAColorLabel;
        private FlatUI.FlatLabel User2FALabel;
        private FlatUI.FlatLabel UserPhoneNumberLabel;
        private FlatUI.FlatLabel UserNitroLabel;
        private FlatUI.FlatLabel UserPFPLabel;
        private System.Windows.Forms.PictureBox UserPFPPictureBox;
        private FlatUI.FlatButton DisableToken;
        private FlatUI.FlatButton DisableV2;
    }
}