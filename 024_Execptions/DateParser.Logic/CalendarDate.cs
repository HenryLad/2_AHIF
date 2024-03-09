namespace DateParser.Logic;

public class CalendarDate(int year, int month, int day)
{
    public int Year { get; private set; } = year;
    public int Month { get; private set; } = month;
    public int Day { get; private set; } = day;

    /// <summary>
    /// Parses the given date string into a CalendarDate object.
    /// </summary>
    /// <param name="dateString">Date string to parse</param>
    /// <returns>
    /// Calendar date object
    /// </returns>
    /// <remarks>
    /// Parses a date expression from a string in the format "dd.MM.yyyy".
    /// dd, MM, and yyyy must be numbers. The resulting date must be a valid date.
    /// Note leap years: A year is a leap year if it is divisible by 4.
    /// However, if the year is a century year (ending in 00), it must 
    /// also be divisible by 400 to be a leap year.
    /// Note that you MUST NOT use methods from DateTime or related classes.
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if the date string is empty or the date string does not have a
    /// length of 10 characters.
    /// </exception>
    /// <exception cref="InvalidDateException">
    /// Thrown if the date string is syntactically valid, but the date itself is invalid (e.g. February 30th)
    /// </exception>
    /// <exception cref="FormatException">
    /// Thrown if the date string is not in the expected format
    /// </exception>
    public static CalendarDate Parse(string dateString)
    {
        if (string.IsNullOrEmpty(dateString) || dateString.Length != 10)
        {
            throw new ArgumentOutOfRangeException("Date string has invalid length");
        }
        var parts = dateString.Split('.');
        int day, month, year;
        for (int i = 0; i < dateString.Length; i++)
        {
            if (!char.IsDigit(dateString[i]))
            {
                throw new FormatException();
            }
        }
        if (!int.TryParse(parts[0], out day) || !int.TryParse(parts[1], out month) || !int.TryParse(parts[2], out year))
        {
            throw new FormatException("Date string is not in the expected format");
        }
        if (month == 2)
        {
            var isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (day > 29 || (!isLeapYear && day > 28))
            {
                throw new InvalidDateException("Invalid date for February");
            }
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day > 30)
            {
                throw new InvalidDateException("Invalid date for month " + month);
            }
        }
        return new CalendarDate(day, month, year);
    }
}

public static class CalendarResponseBuilder
{
    /// <summary>
    /// Tries to parse the given date string and returns a response string.
    /// </summary>
    /// <param name="date">Date string to parse</param>
    /// <returns>
    /// One of the following responses:
    /// - "The date is valid. It is the dd.MM.yyyy." (replace dd, MM, yyyy with the actual date)
    /// - "Date string has invalid length" (in case of ArgumentOutOfRangeException)
    /// - "Date string has invalid format" (in case of FormatException)
    /// - "The date is invalid" (in case of InvalidDateException)
    /// </returns>

public static string BuildResponse(string dateString)
{
    try
    {
        CalendarDate date = CalendarDate.Parse(dateString);
        return $"The date is valid. It is the {date.Day:00}.{date.Month:00}.{date.Year}.";
    }
    catch (ArgumentOutOfRangeException)
    {
        return "Date string has invalid length";
    }
    catch (FormatException)
    {
        return "Date string has invalid format";
    }
    catch (InvalidDateException)
    {
        return "The date is invalid";
    }
}

}

public class InvalidDateException : Exception
{
    public InvalidDateException() { }

    public InvalidDateException(string message) : base(message) { }

    public InvalidDateException(string message, Exception innerException) : base(message, innerException) { }
}
