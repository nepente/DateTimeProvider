using System;

namespace Nepente.DateTimeProvider
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Get(TypeOfDateTime typeOfDateTime)
        {
            switch (typeOfDateTime)
            {
                case TypeOfDateTime.Now:
                    return DateTime.Now;
                case TypeOfDateTime.UtcNow:
                    return DateTime.UtcNow;
                default:
                    return DateTime.Today;
            }
        }
    }
}

