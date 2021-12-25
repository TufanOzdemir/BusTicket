namespace Tufan.Common.Logging
{
    public interface ILogService
    {
        void Debug(string message, params string[] listeners);
        void Info(string message, params string[] listeners);
        void Warn(string message, params string[] listeners);
        void Error(string message, params string[] listeners);
        void Fatal(string message, params string[] listeners);

        void Debug(string message, System.Exception ex, params string[] listeners);
        void Info(string message, System.Exception ex, params string[] listeners);
        void Warn(string message, System.Exception ex, params string[] listeners);
        void Error(string message, System.Exception ex, params string[] listeners);
        void Fatal(string message, System.Exception ex, params string[] listeners);

        void Debug(string message);
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Fatal(string message);

        void Debug(string message, System.Exception ex);
        void Info(string message, System.Exception ex);
        void Warn(string message, System.Exception ex);
        void Error(string message, System.Exception ex);
        void Fatal(string message, System.Exception ex);
    }
}