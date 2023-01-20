public class German
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "Null";
        }
        else if (number == 1UL)
        {
            return "Eins";
        }
        else if (number == 2UL)
        {
            return "Zwei";
        }
        else if (number == 3UL)
        {
            return "Drei";
        }
        else if (number == 4UL)
        {
            return "Vier";
        }
        else if (number == 5UL)
        {
            return "Fünf";
        }
        else if (number == 6UL)
        {
            return "Sechs";
        }
        else if (number == 7UL)
        {
            return "Sieben";
        }
        else if (number == 8UL)
        {
            return "Acht";
        }
        else if (number == 9UL)
        {
            return "Neun";
        }
        else if (number == 10UL)
        {
            return "Zehn";
        }
        else if (number == 11UL)
        {
            return "Elf";
        }
        else if (number == 12UL)
        {
            return "Zwölf";
        }
        else if (number == 16UL)
        {
            return "Sechzehn";
        }
        else if (number < 20UL)
        {
            return German.GetNumber(number % 10UL).Replace("Sieben", "Sieb") + "zehn";
        }
        else if (number == 20UL)
        {
            return "Zwanzig";
        }
        else if (number < 30UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undzwanzig";
        }
        else if (number == 30UL)
        {
            return "Dreißig";
        }
        else if (number < 40UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undreißig";
        }
        else if (number == 40UL)
        {
            return "Vierzig";
        }
        else if (number < 50UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undvierzig";
        }
        else if (number == 50UL)
        {
            return "Fünfzig";
        }
        else if (number < 60UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undfünfzig";
        }
        else if (number == 60UL)
        {
            return "Sechzig";
        }
        else if (number < 70UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undsechzig";
        }
        else if (number == 70UL)
        {
            return "Siebzig";
        }
        else if (number < 80UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undsiebzig";
        }
        else if (number == 80UL)
        {
            return "Achtzig";
        }
        else if (number < 90UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undachtzig";
        }
        else if (number == 90UL)
        {
            return "Neunzig";
        }
        else if (number < 100UL)
        {
            return German.GetNumber(number % 10UL).Replace("Eins", "Ein") + "undneunzig";
        }
        else if (number < 1000UL && number % 100UL == 0UL)
        {
            return German.GetNumber(number / 100UL).Replace("Eins", "Ein") + "hundert";
        }
        else if (number < 1000UL)
        {
            return German.GetNumber(number / 100UL).Replace("Eins", "Ein") + "hundert" + German.GetNumber(number % 100UL).ToLower();
        }
        else if (number < 10000UL && number % 1000UL == 0UL)
        {
            return German.GetNumber(number / 1000UL).Replace("Eins", "Ein") + "tausend";
        }
        else if (number < 10000UL)
        {
            return German.GetNumber(number / 1000UL).Replace("Eins", "Ein") + "tausend" + German.GetNumber(number % 1000UL).ToLower();
        }
        else if (number < 100000UL && number % 10000UL == 0UL)
        {
            return German.GetNumber(number / 1000UL).Replace("Eins", "Ein") + "tausend";
        }
        else if (number < 100000UL)
        {
            return German.GetNumber(number / 1000UL).Replace("Eins", "Ein") + "tausend" + German.GetNumber(number % 1000UL).ToLower();
        }
        else if (number < 1000000UL && number % 100000UL == 0UL)
        {
            return German.GetNumber(number / 1000UL).Replace("Eins", "Ein") + "tausend";
        }
        else if (number < 1000000UL)
        {
            return German.GetNumber(number / 1000UL).Replace("Eins", "Ein") + "tausend" + German.GetNumber(number % 1000UL).ToLower();
        }
        else if (number == 1000000UL)
        {
            return "Eine Million";
        }
        else if (number < 2000000UL)
        {
            return "Eine Million " + German.GetNumber(number % 1000000UL);
        }
        else if (number < 10000000UL && number % 1000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000UL) + " Millionen";
        }
        else if (number < 10000000UL)
        {
            return German.GetNumber(number / 1000000UL) + " Millionen " + German.GetNumber(number % 1000000UL);
        }
        else if (number < 100000000UL && number % 10000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000UL) + " Millionen";
        }
        else if (number < 100000000UL)
        {
            return German.GetNumber(number / 1000000UL) + " Millionen " + German.GetNumber(number % 1000000UL);
        }
        else if (number < 1000000000UL && number % 100000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000UL) + " Millionen";
        }
        else if (number < 1000000000UL)
        {
            return German.GetNumber(number / 1000000UL) + " Millionen " + German.GetNumber(number % 1000000UL);
        }
        else if (number == 1000000000UL)
        {
            return "Eine Milliarde";
        }
        else if (number < 2000000000UL)
        {
            return "Eine Milliarde " + German.GetNumber(number % 1000000000UL);
        }
        else if (number < 10000000000UL && number % 1000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000UL) + " Milliarden";
        }
        else if (number < 10000000000UL)
        {
            return German.GetNumber(number / 1000000000UL) + " Milliarden " + German.GetNumber(number % 1000000000UL);
        }
        else if (number < 100000000000UL && number % 10000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000UL) + " Milliarden";
        }
        else if (number < 100000000000UL)
        {
            return German.GetNumber(number / 1000000000UL) + " Milliarden " + German.GetNumber(number % 1000000000UL);
        }
        else if (number < 1000000000000 && number % 100000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000UL) + " Milliarden";
        }
        else if (number < 1000000000000UL)
        {
            return German.GetNumber(number / 1000000000UL) + " Milliarden " + German.GetNumber(number % 1000000000UL);
        }
        else if (number == 1000000000000UL)
        {
            return "Eine Billion";
        }
        else if (number < 2000000000000UL)
        {
            return "Eine Billion " + German.GetNumber(number % 1000000000000UL);
        }
        else if (number < 10000000000000UL && number % 1000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000UL) + " Billionen";
        }
        else if (number < 10000000000000UL)
        {
            return German.GetNumber(number / 1000000000000UL) + " Billionen " + German.GetNumber(number % 1000000000000UL);
        }
        else if (number < 100000000000000UL && number % 10000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000UL) + " Billionen";
        }
        else if (number < 100000000000000UL)
        {
            return German.GetNumber(number / 1000000000000UL) + " Billionen " + German.GetNumber(number % 1000000000000UL);
        }
        else if (number < 1000000000000000UL && number % 100000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000UL) + " Billionen";
        }
        else if (number < 1000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000UL) + " Billionen " + German.GetNumber(number % 1000000000000UL);
        }
        else if (number == 1000000000000000UL)
        {
            return "Eine Billiarde";
        }
        else if (number < 1000000000000000UL)
        {
            return "Eine Billiarde " + German.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 10000000000000000UL && number % 1000000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000000UL) + " Billiarden";
        }
        else if (number < 10000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000000UL) + " Billiarden " + German.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 100000000000000000UL && number % 10000000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000000UL) + " Billiarden";
        }
        else if (number < 100000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000000UL) + " Billiarden " + German.GetNumber(number % 1000000000000000UL);
        }
        else if (number < 1000000000000000000UL && number % 100000000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000000UL) + " Billiarden";
        }
        else if (number < 1000000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000000UL) + " Billiarden " + German.GetNumber(number % 1000000000000000UL);
        }
        else if (number == 1000000000000000000UL)
        {
            return "Eine Trillion";
        }
        else if (number < 2000000000000000000)
        {
            return "Eine Trillion " + German.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < 10000000000000000000UL && number % 1000000000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000000000UL) + " Trillionen";
        }
        else if (number < 10000000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000000000UL) + " Trillionen " + German.GetNumber(number % 1000000000000000000UL);
        }
        /*else if (number < 100000000000000000000UL && number % 10000000000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000000000UL) + " Trillionen";
        }
        else if (number < 100000000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000000000UL) + " Trillionen " + German.GetNumber(number % 1000000000000000000UL);
        }
        else if (number < 1000000000000000000000UL && number % 100000000000000000000UL == 0UL)
        {
            return German.GetNumber(number / 1000000000000000000UL) + " Trillionen";
        }
        else if (number < 1000000000000000000000UL)
        {
            return German.GetNumber(number / 1000000000000000000UL) + " Trillionen " + German.GetNumber(number % 1000000000000000000UL);
        } //ulong.MaxValue = 18446744073709551615 -> "CS1021: Die integrale Konstante ist zu groß."*/
        return "";
        // Trilliarde; Quadrillion; Quadrilliarde; Quintillion; Quintilliarde; Sextillion; Sextilliarde; Septillion; Septilliarde; Oktillion; Oktilliarde; Nonillion; Nonilliarde;
        // Dezillion; Dezilliarde; Undezillion; Undezilliarde; Dodezillion; Dodezilliarde; Tredezillion; Tredezilliarde; Quattuordezillion; Quattuordezilliarde;
        // Quindezillion; Quindezilliarde; Sedezillion; Sedezilliarde; Septendezillion; Septendezilliarde; Dodevigintillion; Dodevigintilliarde;
        // Undevigintillion; Undevigintilliarde; Vigintillion; Vigintilliarde; Unvigintillion; Unvigintilliarde; Dovigintillion; Dovigintilliarde;
        // Tresvigintillion; Tresvigintilliarde; Quattuorvigintillion; Quattuorvigintilliarde; Quinvigintillion; Quinvigintilliarde; Sevigintillion; Sevigintilliarde;
        // Septenvigintillion; Septenvigintilliarde; Dodetrigintillion; Dodetrigintilliarde; Undetrigintillion; Undetrigintilliarde; Trigintillion; Trigintilliarde;
        // Untrigintillion; Untrigintilliarde; Dotrigintillion; Dotrigintilliarde; Tretrigintillion; Tretrigintilliarde; Quattuortrigintillion; Quattuortrigintilliarde;
        // Quintrigintillion; Quintrigintilliarde; Setrigintillion; Setrigintilliarde; Septentrigintillion; Septentrigintilliarde; Oktotrigintillion; Oktotrigintilliarde;
        // Novemtrigintillion; Novemtrigintilliarde; Quadragintillion; Quadragintilliarde; Unquadragintillion; Unquadragintilliarde; Doquadragintillion; Doquadragintilliarde;
        // Trequadragintillion; Trequadragintilliarde; Quattuorquadragintillion; Quattuorquadragintilliarde; Quinquadragintillion; Quinquadragintilliarde;
        // Sequadragintillion; Sequadragintilliarde; Septenquadragintillion; Septenquadragintilliarde; Oktoquadragintillion; Oktoquadragintilliarde;
        // Novemquadragintillion; Novemquadragintilliarde; Quinquagintillion; Quinquagintilliarde; Zentillion; Zentilliarde;Quinquagintizentillion; Quinquagintizentilliarde;
        // Duzentillion; Duzentilliarde
    }
}
