namespace KS_Token_Nuker
{
    class AccountInfo
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
        public string discriminator { get; set; }
        public string locale { get; set; }
        public bool mfa_enabled { get; set; }
        public string email { get; set; }
        public bool verified { get; set; }
        public string phone { get; set; }

        public int premium_type { get; set; }
    }
}