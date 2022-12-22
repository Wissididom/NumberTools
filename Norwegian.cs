public class Norwegian
{

    public static string GetNumber(ulong number, bool noOg = false)
    {
        if (number == 0UL)
        {
            return "null";
        }
        else if (number == 1UL)
        {
            return "en"; // or ett
        }
        else if (number == 2UL)
        {
            return "to";
        }
        else if (number == 3UL)
        {
            return "tre";
        }
        else if (number == 4UL)
        {
            return "fire";
        }
        else if (number == 5UL)
        {
            return "fem";
        }
        else if (number == 6UL)
        {
            return "seks";
        }
        else if (number == 7UL)
        {
            return "syv";
        }
        else if (number == 8UL)
        {
            return "åtte";
        }
        else if (number == 9UL)
        {
            return "ni";
        }
        else if (number == 10UL)
        {
            return "ti";
        }
        else if (number == 11UL)
        {
            return "elleve";
        }
        else if (number == 12UL)
        {
            return "tolv";
        }
        else if (number == 13UL)
        {
            return "tretten";
        }
        else if (number == 14UL)
        {
            return "fjorten";
        }
        else if (number == 15UL)
        {
            return "femten";
        }
        else if (number == 16UL)
        {
            return "seksten";
        }
        else if (number == 17UL)
        {
            return "sytten";
        }
        else if (number == 18UL)
        {
            return "atten";
        }
        else if (number == 19UL)
        {
            return "nitten";
        }
        else if (number == 20UL)
        {
            return "tyve";
        }
        else if (number == 30UL)
        {
            return "tretti";
        }
        else if (number == 40UL)
        {
            return "førti";
        }
        else if (number == 50UL)
        {
            return "femti";
        }
        else if (number == 60UL)
        {
            return "seksti";
        }
        else if (number == 70UL)
        {
            return "sytti";
        }
        else if (number == 80UL)
        {
            return "åtti";
        }
        else if (number == 90UL)
        {
            return "nitti";
        }
        else if (number < 100UL)
        {
            return Norwegian.GetNumber((ulong)Math.Floor(((double)number / 10)) * 10) + Norwegian.GetNumber(number % 10UL);
        }
        else if (number == 100UL)
        {
            return "hundre";
        }
        else if (number < 200UL)
        {
            return "hundre og " + Norwegian.GetNumber(number % 100UL);
        }
        else if (number < 1000UL)
        {
            string rightPart = Norwegian.GetNumber(number % 100UL).Replace("null", "");
            bool isNextBig = rightPart.Contains("hundre") || rightPart.Contains("tusen") || rightPart.Contains("million") || rightPart.Contains("milliard") || rightPart.Contains("billion");
            if (isNextBig || rightPart.Trim().Length < 1)
                return Norwegian.GetNumber((ulong)Math.Floor((double)number / 100)) + "hundre " + Norwegian.GetNumber(number % 100UL).Replace("null", "");
            else
                return Norwegian.GetNumber((ulong)Math.Floor((double)number / 100)) + "hundre og " + Norwegian.GetNumber(number % 100UL).Replace("null", "");
        }
        else if (number == 1000UL)
        {
            return "tusen";
        }
        else if (number < 2000UL)
        {
            string rightPart = Norwegian.GetNumber(number % 1000UL).Replace("null", "");
            bool isNextBig = rightPart.Contains("hundre") || rightPart.Contains("tusen") || rightPart.Contains("million") || rightPart.Contains("milliard") || rightPart.Contains("billion");
            if (isNextBig || rightPart.Trim().Length < 1)
                return "tusen " + rightPart;
            else
                return "tusen og " + rightPart;
        }
        else if (number < 1000000UL)
        {
            string rightPart = Norwegian.GetNumber(number % 1000UL).Replace("null", "");
            bool isNextBig = rightPart.Contains("hundre") || rightPart.Contains("tusen") || rightPart.Contains("million") || rightPart.Contains("milliard") || rightPart.Contains("billion");
            if (isNextBig || rightPart.Trim().Length < 1)
                return Norwegian.GetNumber((ulong)Math.Floor((double)number / 1000)) + "tusen " + rightPart;
            else
                return Norwegian.GetNumber((ulong)Math.Floor((double)number / 1000)) + "tusen og " + rightPart;
        }
        else if (number == 1000000UL)
        {
            return "en million";
        }
        else if (number < 2000000UL)
        {
            return "en million " + Norwegian.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL)
        {
            return Norwegian.GetNumber((ulong)Math.Floor((double)number / 1000000)) + " millioner " + Norwegian.GetNumber(number % 100000UL).Replace("null", "");
        }
        else if (number == 1000000000UL)
        {
            return "en milliard";
        }
        else if (number < 2000000000UL)
        {
            return "en milliard " + Norwegian.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000000UL)
        {
            return Norwegian.GetNumber((ulong)Math.Floor((double)number / 1000000000)) + " milliarder " + Norwegian.GetNumber(number % 100000000UL).Replace("null", "");
        }
        else if (number == 1000000000000UL)
        {
            return "en billion";
        }
        else if (number < 2000000000000UL)
        {
            return "en billion og " + Norwegian.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000000UL)
        {
            return Norwegian.GetNumber((ulong)Math.Floor((double)number / 1000000000000)) + " billioner " + Norwegian.GetNumber(number % 100000000000UL).Replace("null", "");
        }
        return "";
    }
}
