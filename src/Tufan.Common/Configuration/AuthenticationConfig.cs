namespace Tufan.Common.Configuration
{
    public class AuthenticationConfig : BaseConfig
    {
        public string Secret { get; set; }
        public int ExpireMinutes { get; set; }
        public override string ConfigSection => "Authentication";
    }
}