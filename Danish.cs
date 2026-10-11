public class Danish {

    private static readonly string[] Ones =
    {
        "nul", "en", "to", "tre", "fire", "fem",
        "seks", "syv", "otte", "ni", "ti",
        "elleve", "tolv", "tretten", "fjorten",
        "femten", "seksten", "sytten", "atten", "nitten"
    };

    private static readonly string[] Tens =
    {
        "", "", "tyve", "tredive", "fyrre",
        "halvtreds", "tres", "halvfjerds", "firs", "halvfems"
    };

    public static string GetNumber(ulong number)
    {
        string result = ConvertNumber(number);
        return char.ToUpperInvariant(result[0]) + result.Substring(1);
    }

    private static string ConvertNumber(ulong number)
    {
        if (number < 20UL)
        {
            return Ones[(int)number];
        }
        if (number < 100UL)
        {
            ulong ones = number % 10UL;
            ulong tens = number / 10UL;
            if (ones == 0UL)
                return Tens[(int)tens];
            // Danish reverses the order of units and tens
            // 21 = enogtyve, 34 = fireogtredive
            return Ones[(int)ones] + "og" + Tens[(int)tens];
        }
        if (number < 1000UL)
        {
            ulong hundreds = number / 100UL;
            ulong remainder = number % 100UL;
            string result = (hundreds == 1UL ? "et" : ConvertNumber(hundreds)) + " hundrede";
            if (remainder > 0UL)
                result += " og " + ConvertNumber(remainder);
            return result;
        }
        return ConvertScale(number, 1_000UL, "tusind", 1_000_000UL, "million");
    }

    private static string ConvertScale(ulong number, ulong thousand, string thousandName, ulong million, string millionName)
    {
        if (number < million)
        {
            ulong quotient = number / thousand;
            ulong remainder = number % thousand;
            string result = (quotient == 1UL ? "et" : ConvertNumber(quotient)) + " " + thousandName;
            if (remainder > 0UL)
            {
                result += remainder < 100UL ? " og " + ConvertNumber(remainder) : " " + ConvertNumber(remainder);
            }
            return result;
        }
        ulong millions = number / million;
        ulong rest = number % million;
        string prefix = millions == 1UL ? "en" : ConvertNumber(millions);
        string scaleName = millionName;
        // Danish uses the long scale
        // million = 10^6
        // milliard = 10^9
        // billion = 10^12
        // billiard = 10^15
        // trillion = 10^18
        if (million == 1_000_000UL)
        {
            if (number < 1_000_000_000UL)
            {
                scaleName = "million";
            }
            else if (number < 1_000_000_000_000UL)
            {
                ConvertLargeScale(number, 1_000_000_000UL, "milliard");
            }
            else if (number < 1_000_000_000_000_000UL)
            {
                ConvertLargeScale(number, 1_000_000_000_000UL, "billion");
            }
            else if (number < 1_000_000_000_000_000_000UL)
            {
                ConvertLargeScale(number, 1_000_000_000_000_000UL, "billiard");
            }
            else
            {
                ConvertLargeScale(number, 1_000_000_000_000_000_000UL, "trillion");
            }
        }
        string answer = prefix + " " + scaleName;
        if (rest > 0UL)
            answer += " " + ConvertNumber(rest);
        return answer;
    }

    private static string ConvertLargeScale(ulong number, ulong scale, string scaleName)
    {
        ulong quotient = number / scale;
        ulong remainder = number % scale;
        string result = (quotient == 1UL ? "en" : ConvertNumber(quotient)) + " " + scaleName;
        if (remainder > 0UL)
            result += " " + ConvertNumber(remainder);
        return result;
    }
}
