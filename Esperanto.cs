public class Esperanto
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "nulo";
        }
        else if (number == 1UL)
        {
            return "unu";
        }
        else if (number == 2UL)
        {
            return "du";
        }
        else if (number == 3UL)
        {
            return "tri";
        }
        else if (number == 4UL)
        {
            return "kvar";
        }
        else if (number == 5UL)
        {
            return "kvin";
        }
        else if (number == 6UL)
        {
            return "ses";
        }
        else if (number == 7UL)
        {
            return "sep";
        }
        else if (number == 8UL)
        {
            return "ok";
        }
        else if (number == 9UL)
        {
            return "naŭ";
        }
        else if (number == 10UL)
        {
            return "dek";
        }
        else if (number < 20UL)
        {
            return "dek " + Esperanto.GetNumber(number % 10UL);
        }
        else if (number < 100UL && number % 10UL == 0UL)
        {
            return Esperanto.GetNumber(number / 10UL) + "dek";
        }
        else if (number < 100UL)
        {
            return Esperanto.GetNumber(number / 10UL) + "dek " + Esperanto.GetNumber(number % 10UL);
        }
        else if (number == 100UL)
        {
            return "cent";
        }
        else if (number < 200UL)
        {
            return "cent " + Esperanto.GetNumber(number % 100UL);
        }
        else if (number < 1000UL && number % 100UL == 0UL)
        {
            return Esperanto.GetNumber(number / 100UL) + "cent";
        }
        else if (number < 1000UL)
        {
            return Esperanto.GetNumber(number / 100UL) + "cent " + Esperanto.GetNumber(number % 100UL);
        }
        else if (number == 1000UL)
        {
            return "mil";
        }
        else if (number < 2000UL)
        {
            return "mil " + Esperanto.GetNumber(number % 1000UL);
        }
        else if (number < 10000UL && number % 1000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000UL) + " mil";
        }
        else if (number < 10000UL)
        {
            return Esperanto.GetNumber(number / 1000UL) + " mil " + Esperanto.GetNumber(number % 1000UL);
        }
        else if (number < 100000UL && number % 10000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000UL) + " mil";
        }
        else if (number < 100000UL)
        {
            return Esperanto.GetNumber(number / 1000UL) + " mil " + Esperanto.GetNumber(number % 1000UL);
        }
        else if (number < 1000000UL && number % 100000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000UL) + " mil";
        }
        else if (number < 1000000UL)
        {
            return Esperanto.GetNumber(number / 1000UL) + " mil " + Esperanto.GetNumber(number % 1000UL);
        }
        else if (number < 10000000UL && number % 1000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000UL) + " miliono";
        }
        else if (number < 10000000UL)
        {
            return Esperanto.GetNumber(number / 1000000UL) + " miliono " + Esperanto.GetNumber(number % 1000000UL);
        }
        else if (number < 100000000UL && number % 10000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000UL) + " miliono";
        }
        else if (number < 100000000UL)
        {
            return Esperanto.GetNumber(number / 1000000UL) + " miliono " + Esperanto.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL && number % 100000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000UL) + " miliono";
        }
        else if (number < 1000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000UL) + " miliono " + Esperanto.GetNumber(number % 1000000UL);
        }
        else if (number < 10000000000UL && number % 1000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000UL) + " miliardo";
        }
        else if (number < 10000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000UL) + " miliardo " + Esperanto.GetNumber(number % 1000000000UL);
        }
        else if (number < 100000000000UL && number % 10000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000UL) + " miliardo";
        }
        else if (number < 100000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000UL) + " miliardo " + Esperanto.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000UL && number % 100000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000UL) + " miliardo";
        }
        else if (number < 1000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000UL) + " miliardo " + Esperanto.GetNumber(number % 1000000000UL);
        }
        else if (number < 10000000000000UL && number % 1000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000UL) + " biliono";
        }
        else if (number < 10000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000UL) + " biliono " + Esperanto.GetNumber(number % 1000000000000UL);
        }
        else if (number < 100000000000000UL && number % 10000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000UL) + " biliono";
        }
        else if (number < 100000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000UL) + " biliono " + Esperanto.GetNumber(number % 1000000000000UL);
        }
        else if (number < 1000000000000000UL && number % 100000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000UL) + " biliono";
        }
        else if (number < 1000000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000UL) + " biliono " + Esperanto.GetNumber(number % 1000000000000UL);
        }
        else if (number < 10000000000000000UL && number % 1000000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000UL) + " biliardo";
        }
        else if (number < 10000000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000UL) + " biliardo " + Esperanto.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 100000000000000000UL && number % 10000000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000UL) + " biliardo";
        }
        else if (number < 100000000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000UL) + " biliardo " + Esperanto.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 1000000000000000000UL && number % 100000000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000UL) + " biliardo";
        }
        else if (number < 1000000000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000UL) + " biliardo " + Esperanto.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 10000000000000000000UL && number % 1000000000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000000UL) + " triliono";
        }
        else if (number < 10000000000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000000UL) + " triliono " + Esperanto.GetNumber(number % 1000000000000000000UL);
        }
        /*else if (number < 100000000000000000000UL && number % 10000000000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000000UL) + " triliono";
        }
        else if (number < 100000000000000000000UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000000UL) + " triliono " + Esperanto.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < 1000000000000000000000UL && number % 100000000000000000000UL == 0UL)
        {
            return Esperanto.GetNumber(number / 1000000000000000000UL) + " triliono";
        }
        else if (number < 1000000000000000000000UL)
            return Esperanto.GetNumber(number / 1000000000000000000UL) + " triliono " + Esperanto.GetNumber(number % 1000000000000000000UL);
        } //ulong.MaxValue = 18446744073709551615 -> "CS1021: Die integrale Konstante ist zu groß."*/
        return "";
    }
}
