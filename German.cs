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
        else if (number < 20UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Sieben", "Sieb") + "zehn";
        }
        else if (number == 20UL)
        {
            return "Zwanzig";
        }
        else if (number < 30UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undzwanzig";
        }
        else if (number == 30UL)
        {
            return "Dreißig";
        }
        else if (number < 40UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undreißig";
        }
        else if (number == 40UL)
        {
            return "Vierzig";
        }
        else if (number < 50UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undvierzig";
        }
        else if (number == 50UL)
        {
            return "Fünfzig";
        }
        else if (number < 60UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undfünfzig";
        }
        else if (number == 60UL)
        {
            return "Sechzig";
        }
        else if (number < 70UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undsechzig";
        }
        else if (number == 70UL)
        {
            return "Siebzig";
        }
        else if (number < 80UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undsiebzig";
        }
        else if (number == 80UL)
        {
            return "Achtzig";
        }
        else if (number < 90UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undachtzig";
        }
        else if (number == 90UL)
        {
            return "Neunzig";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 2U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undneunzig";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "hundert";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "hundert" + German.GetNumber(ulong.Parse(number.ToString().Substring(1))).ToLower();
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 3U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend" + German.GetNumber(ulong.Parse(number.ToString().Substring(1))).ToLower();
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 4U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend" + German.GetNumber(ulong.Parse(number.ToString().Substring(2))).ToLower();
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 5U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend" + German.GetNumber(ulong.Parse(number.ToString().Substring(3))).ToLower();
        }
        else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 6U)))
        {
            return "Eine Million";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 6U)))
        {
            return "Eine Million " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 6U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Millionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Millionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 7U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Millionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Millionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Millionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Millionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 9U)))
        {
            return "Eine Milliarde";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 9U)))
        {
            return "Eine Milliarde " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 9U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Milliarden";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Milliarden " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 10U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Milliarden";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Milliarden " + German.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 11U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Milliarden";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Milliarden " + German.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 12U)))
        {
            return "Eine Billion";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 12U)))
        {
            return "Eine Billion " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 12U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 13U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 14U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 15U)))
        {
            return "Eine Billiarde";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 15U)))
        {
            return "Eine Billiarde " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 15U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billiarden";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billiarden " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 16U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billiarden";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billiarden " + German.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 17U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billiarden";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billiarden " + German.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 18U)))
        {
            return "Eine Trillion";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 18U)))
        {
            return "Eine Trillion " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 18U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Trillionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Trillionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 19U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Trillionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Trillionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 20U)) == 0UL)
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Trillionen";
        }
        else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21U)))
        {
            return German.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Trillionen " + German.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
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
