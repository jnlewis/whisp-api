using System;
using System.Collections.Generic;
using System.Text;

namespace Whisp.Application.Interfaces
{
    public interface IDatabase
    {
        void Execute(string sql);
        void Execute(string sql, object param);
        IEnumerable<T> Query<T>(string sql);
        IEnumerable<T> Query<T>(string sql, object param);
    }
}
