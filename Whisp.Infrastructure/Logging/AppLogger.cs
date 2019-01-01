using NLog;
using System;
using System.Runtime.CompilerServices;
using Whisp.Application.Interfaces;

namespace WhispWeb.Infra.Logging
{
    public class AppLogger : IAppLogger
    {
        private NLog.Logger nLogger;

        public AppLogger()
        {
            nLogger = LogManager.GetCurrentClassLogger();
        }

        public void Trace([CallerMemberName] string method = null)
        {
            nLogger.Trace("Begin", method);
        }

        public void Trace(object[] data, [CallerMemberName] string method = null)
        {
            //TODO: serialize and log data
            nLogger.Trace("Begin");
        }

        public void Trace(string message, [CallerMemberName] string method = null)
        {
            nLogger.Trace(message);
        }

        public void Debug(string message, [CallerMemberName] string method = null)
        {
            nLogger.Debug(message);
        }

        public void Info(string message, [CallerMemberName] string method = null)
        {
            nLogger.Info(message);
        }
        public void Info(string message, [CallerMemberName] string method = null, params object[] args)
        {
            nLogger.Info(message, args);
        }

        public void Warn(string message, [CallerMemberName] string method = null)
        {
            nLogger.Warn(message);
        }

        public void Error(string message, [CallerMemberName] string method = null)
        {
            nLogger.Error(message);
        }

        public void Fatal(string message, [CallerMemberName] string method = null)
        {
            nLogger.Fatal(message);
        }

        public void Exception(Exception ex, [CallerMemberName] string method = null)
        {
            Error(ex.ToString());

            Exception innerException = ex.InnerException;
            while (innerException != null)
            {
                Error($"[InnerException] {innerException.Message}");
                innerException = innerException.InnerException;
            }
        }
    }
}
