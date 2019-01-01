using System;
using System.Collections.Generic;
using System.Text;
using Whisp.Application.Interfaces;
using System.Configuration;

namespace Whisp.Application.Configuration
{
    public class Config : IConfig
    {
        public string ConnectionString { get { return GetConnectionString("WhispDB"); } }
        
        public string ApplicationName { get { return GetAppSetting("ApplicationName"); } }
        public string LogRequests { get { return GetAppSetting("LogRequests"); } }

        public string GetFileSettings(string file, string keyName)
        {
            return ""; //TODO:
        }

        #region Helpers

        private string GetConnectionString(string key)
        {
            if (ConfigurationManager.ConnectionStrings[key] == null)
                throw new Exception($"ConnectionString '{key}' not found.");

            return ConfigurationManager.ConnectionStrings[key].ToString();
        }
        private string GetAppSetting(string key)
        {
            if (ConfigurationManager.AppSettings[key] == null)
                throw new Exception($"AppSetting '{key}' not found.");

            return ConfigurationManager.AppSettings[key].ToString();
        }

        #endregion

    }
}
