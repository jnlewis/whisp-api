using System;
using Whisp.Application.Interfaces;

namespace Whisp.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now { get { return DateTime.Now; } }
    }
}
