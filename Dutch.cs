public class Dutch
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "nul";
        }
        else if (number == 1UL)
        {
            return "een";
        }
        else if (number == 2UL)
        {
            return "twee";
        }
        else if (number == 3UL)
        {
            return "drie";
        }
        else if (number == 4UL)
        {
            return "vier";
        }
        else if (number == 5UL)
        {
            return "vijf";
        }
        else if (number == 6UL)
        {
            return "zes";
        }
        else if (number == 7UL)
        {
            return "zeven";
        }
        else if (number == 8UL)
        {
            return "acht";
        }
        else if (number == 9UL)
        {
            return "negen";
        }
        else if (number == 10UL)
        {
            return "tien";
        }
        else if (number == 11UL)
        {
            return "elf";
        }
        else if (number == 12UL)
        {
            return "twaalf";
        }
        else if (number < 20UL)
        {
            return Dutch.GetNumber(number % 10UL).Replace("vier", "veer").Replace("drie", "der") + "tien";
        }
        else if (number == 20UL)
        {
            return "twintig";
        }
        else if (number == 30UL)
        {
            return "dertig";
        }
        else if (number == 40UL)
        {
            return "veertig";
        }
        else if (number == 50UL)
        {
            return "vijftig";
        }
        else if (number == 60UL)
        {
            return "zestig";
        }
        else if (number == 70UL)
        {
            return "zeventig";
        }
        else if (number == 80UL)
        {
            return "tachtig";
        }
        else if (number == 90UL)
        {
            return "negentig";
        }
        else if (number < 100UL)
        {
            ulong numberEnd = number % 10UL;
            string en = "en";
            if (numberEnd == 2UL || numberEnd == 3UL)
                en = "ën";
            return Dutch.GetNumber(numberEnd).Replace("nul", "") + en + Dutch.GetNumber((number / 10UL) * 10UL).Replace("vier", "veer");
        }
        else if (number < 1000UL && number % 100UL == 0UL)
        {
            return Dutch.GetNumber(number / 100UL).Replace("een", "") + "honderd";
        }
        else if (number < 1000UL && number % 10UL == 0UL)
        {
            return Dutch.GetNumber(number / 100UL).Replace("een", "") + "honderd " + Dutch.GetNumber(number % 10UL).Replace("nul", "");
        }
        else if (number < 1000UL)
        {
            return Dutch.GetNumber(number / 100UL).Replace("een", "") + "honderd en " + Dutch.GetNumber(number % 100UL).Replace("nul", "");
        }
        else if (number < 10000UL && number % 1000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend";
        }
        else if (number < 10000UL && number % 100UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend " + Dutch.GetNumber(number % 1000UL);
        }
        else if (number < 10000UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend en " + Dutch.GetNumber(number % 1000UL);
        }
        else if (number < 100000UL && number % 1000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend";
        }
        else if (number < 100000UL && number % 100UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend " + Dutch.GetNumber(number % 1000UL);
        }
        else if (number < 100000UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend en " + Dutch.GetNumber(number % 1000UL);
        }
        else if (number < 1000000UL && number % 100UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend " + Dutch.GetNumber(number % 1000UL);
        }
        else if (number < 1000000UL)
        {
            return Dutch.GetNumber(number / 1000UL).Replace("een", "") + "duizend en " + Dutch.GetNumber(number % 1000UL);
        }
        else if (number < 10000000UL && number % 1000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen";
        }
        else if (number < 10000000UL && number % 100000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen " + Dutch.GetNumber(number % 1000000UL);
        }
        else if (number < 10000000UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen en " + Dutch.GetNumber(number % 1000000UL);
        }
        else if (number < 100000000UL && number % 1000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen";
        }
        else if (number < 100000000UL && number % 100000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen " + Dutch.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen en " + Dutch.GetNumber(number %  1000000UL);
        }
        else if (number < 1000000000UL && number % 100000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen " + Dutch.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL)
        {
            return Dutch.GetNumber(number / 1000000UL) + " miljoen en " + Dutch.GetNumber(number % 1000000UL);
        }
        else if (number < 10000000000UL && number % 1000000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard";
        }
        else if (number < 10000000000UL && number % 100000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard " + Dutch.GetNumber(number % 1000000000UL);
        }
        else if (number < 10000000000UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard en " + Dutch.GetNumber(number % 1000000000UL);
        }
        else if (number < 100000000000UL && number % 1000000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard";
        }
        else if (number < 100000000000UL && number % 100000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard " + Dutch.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard en " + Dutch.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000UL && number % 100000000UL == 0UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard " + Dutch.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000UL)
        {
            return Dutch.GetNumber(number / 1000000000UL) + " miljard en " + Dutch.GetNumber(number % 1000000000UL);
        }
        return "";
    }
}
