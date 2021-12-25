namespace Tufan.Common.Configuration
{
    public class ExceptionConfig : BaseConfig
    {
        public override string ConfigSection => "Exceptions";

        public ExceptionMessageConfig Messages { get; set; }
        public string ContentType { get; set; }
    }

    public class ExceptionMessageConfig : BaseConfig
    {
        public override string ConfigSection => "Messages";

        public string NotFoundMessage { get; set; }
        public string ForbiddenMessage { get; set; }
        public string BadRequestMessage { get; set; }
        public string GeneralMessage { get; set; }
        public string UnhandledMessage { get; set; }
        public string ExternalMessage { get; set; }
    }
}