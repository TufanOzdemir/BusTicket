namespace Tufan.Common.Authentication
{
    public interface IAuthorizedUserResolver
    {
        string GetAccessToken { get; }
    }
}