using System;

namespace Nepente.DateTimeProvider
{
    public interface IDateTimeProvider
    {
        DateTime Get(TypeOfDateTime typeOfDateTime);
    }
}

