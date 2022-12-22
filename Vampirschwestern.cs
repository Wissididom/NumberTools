public class Vampirschwestern
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "";
        }
        else if (number == 1UL)
        {
            return "onu";
        }
        else if (number == 2UL)
        {
            return "zoi";
        }
        else if (number == 3UL)
        {
            return "trosch";
        }
        else if (number == 4UL)
        {
            return "ziri";
        }
        else if (number == 5UL)
        {
            return "fom";
        }
        else if (number == 6UL)
        {
            return "shoist";
        }
        else if (number == 7UL)
        {
            return "syto";
        }
        else if (number == 8UL)
        {
            return "omtje";
        }
        else if (number == 9UL)
        {
            return "nonce";
        }
        else if (number == 10UL)
        {
            return "dong";
        }
        else if (number < 20UL)
        {
            return "dong-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 20UL)
        {
            return "zoing";
        }
        else if (number < 30UL)
        {
            return "zoing-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 30UL)
        {
            return "trogda";
        }
        else if (number < 40UL)
        {
            return "trogda-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 40UL)
        {
            return "zirick";
        }
        else if (number < 50UL)
        {
            return "zirick-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 50UL)
        {
            return "fomsiat";
        }
        else if (number < 60UL)
        {
            return "fomsiat-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 60UL)
        {
            return "shoszik";
        }
        else if (number < 70UL)
        {
            return "shoszik-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 70UL)
        {
            return "sytenta";
        }
        else if (number < 80UL)
        {
            return "sytenta-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 80UL)
        {
            return "omsiat";
        }
        else if (number < 90UL)
        {
            return "omsiat-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 90UL)
        {
            return "noncenta";
        }
        else if (number < 100UL)
        {
            return "noncenta-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number == 100UL)
        {
            return "bong";
        }
        else if (number < 200UL)
        {
            return "bong-" + Vampirschwestern.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        return "";
    }
}
