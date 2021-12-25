namespace Tufan.Common.Configuration
{
    public class UrlConfig : BaseConfig
    {
        public string AuthorityUrl { get; set; }
        public string TicketUrl { get; set; }
        public string ObiletUrl { get; set; }
        public override string ConfigSection => "Url";
    }
}