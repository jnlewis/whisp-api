using System;
using System.Collections.Generic;
using System.Text;

namespace Whisp.Application.Interfaces
{
    public interface IConfig
    {
        string ConnectionString { get; }
        string GetFileSettings(string file, string keyName);
    }
}
