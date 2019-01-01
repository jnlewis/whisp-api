using System;
using System.Collections.Generic;
using Whisp.Domain.Exceptions;
using Whisp.Domain.Infrastructure;

namespace Whisp.Domain.ValueObjects
{
    public class Coordinates : ValueObject
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        private Coordinates()
        {
        }

        public Coordinates(string value)
        {
            try
            {
                var index = value.IndexOf(",", StringComparison.Ordinal);
                Latitude = Convert.ToDouble(value.Substring(0, index));
                Longitude = Convert.ToDouble(value.Substring(index + 1));
            }
            catch (Exception ex)
            {
                throw new CoordinatesInvalidException(value, ex);
            }
        }

        public static implicit operator string(Coordinates adAccount)
        {
            return adAccount.ToString();
        }

        public static explicit operator Coordinates(string value)
        {
            return new Coordinates(value);
        }

        public override string ToString()
        {
            return $"{Latitude},{Longitude}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Latitude;
            yield return Longitude;
        }
    }
}
