using System;
using Whisp.Application.Interfaces;

namespace Whisp.Tests.Mocks
{
    public class MockConfig : IConfig
    {
        public string ConnectionString { get { return "server=localhost;port=3306;database=whisp_unittest;uid=root;password=newpwd;"; } }

        public string ApplicationName { get { return "WhispUnitTest"; } }
        public string LogRequests { get { return "true"; } }

        public string GetFileSettings(string file, string keyName)
        {
            return "";
        }
    }
}
