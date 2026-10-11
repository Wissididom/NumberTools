public class Swedish
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "noll";
        }
        else if (number == 1UL)
        {
            return "en"; // TODO: Not sure if I should use "ett" instead
        }
        else if (number == 2UL)
        {
            return "två";
        }
        else if (number == 3UL)
        {
            return "tre";
        }
        else if (number == 4UL)
        {
            return "fyra";
        }
        else if (number == 5UL)
        {
            return "fem";
        }
        else if (number == 6UL)
        {
            return "sex";
        }
        else if (number == 7UL)
        {
            return "sju";
        }
        else if (number == 8UL)
        {
            return "åtta";
        }
        else if (number == 9UL)
        {
            return "nio";
        }
        else if (number == 10UL)
        {
            return "tio";
        }
        else if (number == 11UL)
        {
            return "elva";
        }
        else if (number == 12UL)
        {
            return "tolv";
        }
        else if (number == 13UL)
        {
            return "tretton";
        }
        else if (number == 14UL)
        {
            return "fjorton";
        }
        else if (number == 15UL)
        {
            return "femton";
        }
        else if (number == 16UL)
        {
            return "sexton";
        }
        else if (number == 17UL)
        {
            return "sjutton";
        }
        else if (number == 18UL)
        {
            return "arton";
        }
        else if (number == 19UL)
        {
            return "nitton";
        }
        else if (number == 20UL)
        {
            return "tjugo";
        }
        else if (number < 30UL)
        {
            var remainder = number % 10UL;
            return "tjugo" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 30UL)
        {
            return "trettio";
        }
        else if (number < 40UL)
        {
            var remainder = number % 10UL;
            return "trettio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 40UL)
        {
            return "fyrtio";
        }
        else if (number < 50UL)
        {
            var remainder = number % 10UL;
            return "fyrtio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 50UL)
        {
            return "femtio";
        }
        else if (number < 60UL)
        {
            var remainder = number % 10UL;
            return "femtio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 60UL)
        {
            return "sextio";
        }
        else if (number < 70UL)
        {
            var remainder = number % 10UL;
            return "sextio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 70UL)
        {
            return "sjuttio";
        }
        else if (number < 80UL)
        {
            var remainder = number % 10UL;
            return "sjuttio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 80UL)
        {
            return "åttio";
        }
        else if (number < 90UL)
        {
            var remainder = number % 10UL;
            return "åttio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number == 90UL)
        {
            return "nittio";
        }
        else if (number < 100UL)
        {
            var remainder = number % 10UL;
            return "nittio" + (remainder == 1UL ? "ett" : Swedish.GetNumber(remainder));
        }
        else if (number < 1000UL && number % 100UL == 0UL)
        {
            if (number / 100UL == 1UL)
            {
                return "hundra";
            }
            else
            {
                return Swedish.GetNumber(number / 100UL) + " hundra";
            }
        }
        else if (number < 1000UL)
        {
            if (number / 100UL == 1UL)
            {
                return "hundra " + Swedish.GetNumber(number % 100UL);
            }
            else
            {
                return Swedish.GetNumber(number / 100UL) + " hundra " + Swedish.GetNumber(number % 100UL);
            }
        }
        else if (number < 10000UL && number % 1000UL == 0UL)
        {
            if (number / 1000UL == 1UL)
            {
                return "ett tusen";
            }
            else
            {
                return Swedish.GetNumber(number / 1000UL) + " tusen";
            }
        }
        else if (number < 10000UL)
        {
            if (number / 1000UL == 1UL)
            {
                return "ett tusen " + Swedish.GetNumber(number % 1000UL);
            }
            else
            {
                return Swedish.GetNumber(number / 1000UL) + " tusen " + Swedish.GetNumber(number % 1000UL);
            }
        }
        else if (number < 100000UL && number % 10000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000UL) + " tusen";
        }
        else if (number < 100000UL)
        {
            return Swedish.GetNumber(number / 1000UL) + " tusen " + Swedish.GetNumber(number % 1000UL);
        }
        else if (number < 1000000UL && number % 100000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000UL) + " tusen";
        }
        else if (number < 1000000UL)
        {
            return Swedish.GetNumber(number / 1000UL) + " tusen " + Swedish.GetNumber(number % 1000UL);
        }
        else if (number < 10000000UL && number % 1000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000UL) + " miljon";
        }
        else if (number < 10000000UL)
        {
            return Swedish.GetNumber(number / 1000000UL) + " miljon " + Swedish.GetNumber(number % 1000000UL);
        }
        else if (number < 100000000UL && number % 10000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000UL) + " miljon";
        }
        else if (number < 100000000UL)
        {
            return Swedish.GetNumber(number / 1000000UL) + " miljon" + Swedish.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL && number % 100000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000UL) + " miljon";
        }
        else if (number < 1000000000UL)
        {
            return Swedish.GetNumber(number / 1000000UL) + " miljon" + Swedish.GetNumber(number % 1000000UL);
        }
        else if (number < 10000000000UL && number % 1000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000UL) + " miljard";
        }
        else if (number < 10000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000UL) + " miljard " + Swedish.GetNumber(number % 1000000000UL);
        }
        else if (number < 100000000000UL && number % 10000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000UL) + " miljard ";
        }
        else if (number < 100000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000UL) + " miljard " + Swedish.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000UL && number % 100000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000UL) + " miljard";
        }
        else if (number < 1000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000UL) + " miljard " + Swedish.GetNumber(number % 1000000000UL);
        }
        else if (number < 10000000000000UL && number % 1000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000UL) + " biljon";
        }
        else if (number < 10000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000UL) + " biljon " + Swedish.GetNumber(number % 1000000000000UL);
        }
        else if (number < 100000000000000UL && number % 10000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000UL) + " biljon";
        }
        else if (number < 100000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000UL) + " biljon " + Swedish.GetNumber(number % 1000000000000UL);
        }
        else if (number < 1000000000000000UL && number % 100000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000UL) + " biljon";
        }
        else if (number < 1000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000UL) + " biljon " + Swedish.GetNumber(number % 1000000000000UL);
        }
        /*else if (number < 10000000000000000UL && number % 1000000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000000UL) + "-Quadrillion";
        }
        else if (number < 10000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000000UL) + "-Quadrillion-" + Swedish.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 100000000000000000UL && number % 10000000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000000UL) + "-Quadrillion";
        }
        else if (number < 100000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000000UL) + "-Quadrillion-" + Swedish.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 1000000000000000000UL && number % 100000000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000000UL) + "-Quadrillion";
        }
        else if (number < 1000000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000000UL) + "-Quadrillion-" + Swedish.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 10000000000000000000UL && number % 1000000000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000000000UL) + "-Quintillion";
        }
        else if (number < 10000000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000000000UL) + "-Quintillion-" + Swedish.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < 100000000000000000000UL && number % 10000000000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000000000UL) + "-Quintillion";
        }
        else if (number < 100000000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000000000UL) + "-Quintillion-" + Swedish.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < 1000000000000000000000UL && number % 100000000000000000000UL == 0UL)
        {
            return Swedish.GetNumber(number / 1000000000000000000UL) + "-Quintillion";
        }
        else if (number < 1000000000000000000000UL)
        {
            return Swedish.GetNumber(number / 1000000000000000000UL) + "-Quintillion-" + Swedish.GetNumber(number % 1000000000000000000UL);
        } //ulong.MaxValue = 18446744073709551615 -> "CS1021: Die integrale Konstante ist zu groß."*/
        return "";
    }
}
