using System;
using System.Collections.Generic;
using System.Text;

namespace Whisp.Domain.Exceptions
{
    public class CoordinatesInvalidException : Exception
    {
        public CoordinatesInvalidException(string coordinates, Exception ex)
            : base($"Coordinates \"{coordinates}\" is invalid.", ex)
        {
        }
    }
}
