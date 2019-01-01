using System;
using System.Runtime.CompilerServices;

namespace Whisp.Application.Interfaces
{
    public interface IAppLogger
    {
        void Trace(string message, [CallerMemberName] string method = null);

        void Debug(string message, [CallerMemberName] string method = null);

        void Info(string message, [CallerMemberName] string method = null);
        void Info(string message, [CallerMemberName] string method = null, params object[] args);

        void Warn(string message, [CallerMemberName] string method = null);

        void Error(string message, [CallerMemberName] string method = null);

        void Fatal(string message, [CallerMemberName] string method = null);

        void Exception(Exception ex, [CallerMemberName] string method = null);
    }
}
