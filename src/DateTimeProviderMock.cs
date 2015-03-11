using System;
using System.Collections.Generic;

namespace Nepente.DateTimeProvider
{
    public class DateTimeProviderMock : IDateTimeProvider
    {
        readonly IDictionary<TypeOfDateTime, DateTime> _values = new Dictionary<TypeOfDateTime, DateTime>
        {
            { TypeOfDateTime.Now, DateTime.Now },
            { TypeOfDateTime.UtcNow, DateTime.UtcNow },
            { TypeOfDateTime.Today, DateTime.Today }
        };

        public void Set(TypeOfDateTime typeOfDateTime, DateTime dateTime)
        {
            _values[typeOfDateTime] = dateTime;
        }

        public DateTime Get(TypeOfDateTime typeOfDateTime)
        {
            return _values[typeOfDateTime];
        }
    }
}