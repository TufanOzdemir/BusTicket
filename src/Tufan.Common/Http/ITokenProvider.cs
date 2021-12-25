namespace Tufan.Common.Http
{
    public interface ITokenProvider
    {
        string GetToken();
        string GetScheme();
    }
}