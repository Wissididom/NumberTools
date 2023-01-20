public class English
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "Zero";
        }
        else if (number == 1UL)
        {
            return "One";
        }
        else if (number == 2UL)
        {
            return "Two";
        }
        else if (number == 3UL)
        {
            return "Three";
        }
        else if (number == 4UL)
        {
            return "Four";
        }
        else if (number == 5UL)
        {
            return "Five";
        }
        else if (number == 6UL)
        {
            return "Six";
        }
        else if (number == 7UL)
        {
            return "Seven";
        }
        else if (number == 8UL)
        {
            return "Eight";
        }
        else if (number == 9UL)
        {
            return "Nine";
        }
        else if (number == 10UL)
        {
            return "Ten";
        }
        else if (number == 11UL)
        {
            return "Eleven";
        }
        else if (number == 12UL)
        {
            return "Twelve";
        }
        else if (number == 13UL)
        {
            return "Thirteen";
        }
        else if (number == 14UL)
        {
            return "Fourteen";
        }
        else if (number == 15UL)
        {
            return "Fifteen";
        }
        else if (number < 20UL)
        {
            return (English.GetNumber(number % 10UL) + "teen").Replace("tt", "t");
        }
        else if (number == 20UL)
        {
            return "Twenty";
        }
        else if (number < 30UL)
        {
            return "Twenty-" + English.GetNumber(number % 10UL);
        }
        else if (number == 30UL)
        {
            return "Thirty";
        }
        else if (number < 40UL)
        {
            return "Thirty-" + English.GetNumber(number % 10UL);
        }
        else if (number == 40UL)
        {
            return "Fourty";
        }
        else if (number < 50UL)
        {
            return "Fourty-" + English.GetNumber(number % 10UL);
        }
        else if (number == 50UL)
        {
            return "Fifty";
        }
        else if (number < 60UL)
        {
            return "Fifty-" + English.GetNumber(number % 10UL);
        }
        else if (number == 60UL)
        {
            return "Sixty";
        }
        else if (number < 70UL)
        {
            return "Sixty-" + English.GetNumber(number % 10UL);
        }
        else if (number == 70UL)
        {
            return "Seventy";
        }
        else if (number < 80UL)
        {
            return "Seventy-" + English.GetNumber(number % 10UL);
        }
        else if (number == 80UL)
        {
            return "Eighty";
        }
        else if (number < 90UL)
        {
            return "Eighty-" + English.GetNumber(number % 10UL);
        }
        else if (number == 90UL)
        {
            return "Ninety";
        }
        else if (number < 100UL)
        {
            return "Ninety-" + English.GetNumber(number % 10UL);
        }
        else if (number < 1000UL && number % 100UL == 0UL)
        {
            return English.GetNumber(number / 100UL) + "-Hundred";
        }
        else if (number < 1000UL)
        {
            return English.GetNumber(number / 100UL) + "-Hundred-" + English.GetNumber(number % 100UL);
        }
        else if (number < 10000UL && number % 1000UL == 0UL)
        {
            return English.GetNumber(number / 1000UL) + "-Thousand";
        }
        else if (number < 10000UL)
        {
            return English.GetNumber(number / 1000UL) + "-Thousand-" + English.GetNumber(number % 1000UL);
        }
        else if (number < 100000UL && number % 10000UL == 0UL)
        {
            return English.GetNumber(number / 1000UL) + "-Thousand";
        }
        else if (number < 100000UL)
        {
            return English.GetNumber(number / 1000UL) + "-Thousand-" + English.GetNumber(number % 1000UL);
        }
        else if (number < 1000000UL && number % 100000UL == 0UL)
        {
            return English.GetNumber(number / 1000UL) + "-Thousand";
        }
        else if (number < 1000000UL)
        {
            return English.GetNumber(number / 1000UL) + "-Thousand-" + English.GetNumber(number % 1000UL);
        }
        else if (number < 10000000UL && number % 1000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000UL) + "-Million";
        }
        else if (number < 10000000UL)
        {
            return English.GetNumber(number / 1000000UL) + "-Million-" + English.GetNumber(number % 1000000UL);
        }
        else if (number < 100000000UL && number % 10000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000UL) + "-Million";
        }
        else if (number < 100000000UL)
        {
            return English.GetNumber(number / 1000000UL) + "-Million-" + English.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL && number % 100000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000UL) + "-Million";
        }
        else if (number < 1000000000UL)
        {
            return English.GetNumber(number / 1000000UL) + "-Million-" + English.GetNumber(number % 1000000UL);
        }
        else if (number < 10000000000UL && number % 1000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000UL) + "-Billion";
        }
        else if (number < 10000000000UL)
        {
            return English.GetNumber(number / 1000000000UL) + "-Billion-" + English.GetNumber(number % 1000000000UL);
        }
        else if (number < 100000000000UL && number % 10000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000UL) + "-Billion";
        }
        else if (number < 100000000000UL)
        {
            return English.GetNumber(number / 1000000000UL) + "-Billion-" + English.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000UL && number % 100000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000UL) + "-Billion";
        }
        else if (number < 1000000000000UL)
        {
            return English.GetNumber(number / 1000000000UL) + "-Billion-" + English.GetNumber(number % 1000000000UL);
        }
        else if (number < 10000000000000UL && number % 1000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000UL) + "-Trillion";
        }
        else if (number < 10000000000000UL)
        {
            return English.GetNumber(number / 1000000000000UL) + "-Trillion-" + English.GetNumber(number % 1000000000000UL);
        }
        else if (number < 100000000000000UL && number % 10000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000UL) + "-Trillion";
        }
        else if (number < 100000000000000UL)
        {
            return English.GetNumber(number / 1000000000000UL) + "-Trillion-" + English.GetNumber(number % 1000000000000UL);
        }
        else if (number < 1000000000000000UL && number % 100000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000UL) + "-Trillion";
        }
        else if (number < 1000000000000000UL)
        {
            return English.GetNumber(number / 1000000000000UL) + "-Trillion-" + English.GetNumber(number % 1000000000000UL);
        }
        else if (number < 10000000000000000UL && number % 1000000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000000UL) + "-Quadrillion";
        }
        else if (number < 10000000000000000UL)
        {
            return English.GetNumber(number / 1000000000000000UL) + "-Quadrillion-" + English.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 100000000000000000UL && number % 10000000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000000UL) + "-Quadrillion";
        }
        else if (number < 100000000000000000UL)
        {
            return English.GetNumber(number / 1000000000000000UL) + "-Quadrillion-" + English.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 1000000000000000000UL && number % 100000000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000000UL) + "-Quadrillion";
        }
        else if (number < 1000000000000000000UL)
        {
            return English.GetNumber(number / 1000000000000000UL) + "-Quadrillion-" + English.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 10000000000000000000UL && number % 1000000000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000000000UL) + "-Quintillion";
        }
        else if (number < 10000000000000000000UL)
        {
            return English.GetNumber(number / 1000000000000000000UL) + "-Quintillion-" + English.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20U)) && number % 10000000000000000000UL == 0UL)
        {
            return English.GetNumber(number / 1000000000000000000UL) + "-Quintillion";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20U)))
        {
            return English.GetNumber(number / 1000000000000000000UL) + "-Quintillion-" + English.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 20U)) == 0UL)
        {
            return English.GetNumber(number / 1000000000000000000UL) + "-Quintillion";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21U)))
        {
            return English.GetNumber(number / 1000000000000000000UL) + "-Quintillion-" + English.GetNumber(number % 1000000000000000000UL);
        }
        return "";
    }
}
