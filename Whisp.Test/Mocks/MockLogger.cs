using System;
using System.Runtime.CompilerServices;
using Whisp.Application.Interfaces;

namespace Whisp.Tests.Mocks
{
    public class MockLogger : IAppLogger
    {
        public void Trace(string message, [CallerMemberName] string method = null){}

        public void Debug(string message, [CallerMemberName] string method = null) { }

        public void Info(string message, [CallerMemberName] string method = null) { }
        public void Info(string message, [CallerMemberName] string method = null, params object[] args) { }

        public void Warn(string message, [CallerMemberName] string method = null) { }

        public void Error(string message, [CallerMemberName] string method = null) { }

        public void Fatal(string message, [CallerMemberName] string method = null) { }

        public void Exception(Exception ex, [CallerMemberName] string method = null) {}
    }
}
