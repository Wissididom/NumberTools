public class Api {

    public enum Language {
        ROMAN,
        GERMAN,
        ENGLISH,
        DUTCH,
        JAPANESE,
        ESPERANTO,
        VAMPIRSCHWESTERN,
        BINARY,
        HEXADECIMAL
    }

    public static string GetNumber(Language language, ulong number) {
        switch (language) {
            case Language.ROMAN:
                return GetRomanNumber(number);
            case Language.GERMAN:
                return GetGermanNumber(number);
            case Language.ENGLISH:
                return GetEnglishNumber(number);
            case Language.DUTCH:
                return GetDutchNumber(number);
            case Language.JAPANESE:
                return GetJapaneseNumber(number);
            case Language.ESPERANTO:
                return GetEsperantoNumber(number);
            case Language.VAMPIRSCHWESTERN:
                return GetVampirschwesternNumber(number);
            case Language.BINARY:
                return GetBinaryNumber(number);
            case Language.HEXADECIMAL:
                return GetHexNumber(number);
            default:
                return number.ToString();
        }
    }

    public static string GetRomanNumber(ulong number) {
        string result = "";
        ulong m = number / 1000UL;
        for (ulong a = 0UL; a < m; a++) {
            result += "M";
        }
        number -= m * 1000UL;
        ulong d = number / 500UL;
        for (ulong a = 0UL; a < d; a++) {
            result += "D";
        }
        number -= d * 500UL;
        ulong c = number / 100UL;
        for (ulong a = 0UL; a < c; a++) {
            result += "C";
        }
        number -= c * 100UL;
        ulong l = number / 50UL;
        for (ulong a = 0UL; a < l; a++) {
            result += "L";
        }
        number -= l * 50UL;
        ulong x = number / 10UL;
        for (ulong a = 0UL; a < x; a++) {
            result += "X";
        }
        number -= x * 10UL;
        ulong v = number / 5UL;
        for (ulong a = 0UL; a < v; a++) {
            result += "V";
        }
        number -= v * 5UL;
        ulong i = number / 1UL;
        for (ulong a = 0UL; a < i; a++) {
            result += "I";
        }
        result = result.Replace("VIIII", "IX"); // 9
        result = result.Replace("IIII", "IV"); // 4
        result = result.Replace("LXXXX", "XC"); // 90
        result = result.Replace("XXXX", "XL"); // 40
        result = result.Replace("DCCCC", "CM"); // 900
        result = result.Replace("CCCC", "CD"); // 400
        return result;
    }

    public static string GetGermanNumber(ulong number) {
        if (number == 0UL) {
            return "Null";
        } else if (number == 1UL) {
            return "Eins";
        } else if (number == 2UL) {
            return "Zwei";
        } else if (number == 3UL) {
            return "Drei";
        } else if (number == 4UL) {
            return "Vier";
        } else if (number == 5UL) {
            return "Fünf";
        } else if (number == 6UL) {
            return "Sechs";
        } else if (number == 7UL) {
            return "Sieben";
        } else if (number == 8UL) {
            return "Acht";
        } else if (number == 9UL) {
            return "Neun";
        } else if (number == 10UL) {
            return "Zehn";
        } else if (number == 11UL) {
            return "Elf";
        } else if (number == 12UL) {
            return "Zwölf";
        } else if (number < 20UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Sieben", "Sieb") + "zehn";
        } else if (number == 20UL) {
            return "Zwanzig";
        } else if (number < 30UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undzwanzig";
        } else if (number == 30UL) {
            return "Dreißig";
        } else if (number < 40UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undreißig";
        } else if (number == 40UL) {
            return "Vierzig";
        } else if (number < 50UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undvierzig";
        } else if (number == 50UL) {
            return "Fünfzig";
        } else if (number < 60UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undfünfzig";
        } else if (number == 60UL) {
            return "Sechzig";
        } else if (number < 70UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undsechzig";
        } else if (number == 70UL) {
            return "Siebzig";
        } else if (number < 80UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undsiebzig";
        } else if (number == 80UL) {
            return "Achtzig";
        } else if (number < 90UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undachtzig";
        } else if (number == 90UL) {
            return "Neunzig";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 2U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).Replace("Eins", "Ein") + "undneunzig";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U)) && number % ulong.Parse(AppendMultiple("1", "0", 2U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "hundert";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "hundert" + GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).ToLower();
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U)) && number % ulong.Parse(AppendMultiple("1", "0", 3U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend" + GetGermanNumber(ulong.Parse(number.ToString().Substring(1))).ToLower();
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 5U)) && number % ulong.Parse(AppendMultiple("1", "0", 4U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 5U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend" + GetGermanNumber(ulong.Parse(number.ToString().Substring(2))).ToLower();
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U)) && number % ulong.Parse(AppendMultiple("1", "0", 5U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("Eins", "Ein") + "tausend" + GetGermanNumber(ulong.Parse(number.ToString().Substring(3))).ToLower();
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 6U))) {
            return "Eine Million";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 6U))) {
            return "Eine Million " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U)) && number % ulong.Parse(AppendMultiple("1", "0", 6U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Millionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Millionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 8U)) && number % ulong.Parse(AppendMultiple("1", "0", 7U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Millionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 8U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Millionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U)) && number % ulong.Parse(AppendMultiple("1", "0", 8U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Millionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Millionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 9U))) {
            return "Eine Milliarde";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 9U))) {
            return "Eine Milliarde " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U)) && number % ulong.Parse(AppendMultiple("1", "0", 9U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Milliarden";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Milliarden " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 11U)) && number % ulong.Parse(AppendMultiple("1", "0", 10U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Milliarden";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 11U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Milliarden " + GetGermanNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U)) && number % ulong.Parse(AppendMultiple("1", "0", 11U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Milliarden";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Milliarden " + GetGermanNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 12U))) {
            return "Eine Billion";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 12U))) {
            return "Eine Billion " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 13U)) && number % ulong.Parse(AppendMultiple("1", "0", 12U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 13U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 14U)) && number % ulong.Parse(AppendMultiple("1", "0", 13U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 14U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 15U)) && number % ulong.Parse(AppendMultiple("1", "0", 14U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 15U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 15U))) {
            return "Eine Billiarde";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 15U))) {
            return "Eine Billiarde " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 16U)) && number % ulong.Parse(AppendMultiple("1", "0", 15U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billiarden";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 16U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Billiarden " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 17U)) && number % ulong.Parse(AppendMultiple("1", "0", 16U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billiarden";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 17U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Billiarden " + GetGermanNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 18U)) && number % ulong.Parse(AppendMultiple("1", "0", 17U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billiarden";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 18U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Billiarden " + GetGermanNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 18U))) {
            return "Eine Trillion";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 18U))) {
            return "Eine Trillion " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 19U)) && number % ulong.Parse(AppendMultiple("1", "0", 18U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Trillionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 19U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " Trillionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 20U)) && number % ulong.Parse(AppendMultiple("1", "0", 19U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Trillionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 20U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " Trillionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 21U)) && number % ulong.Parse(AppendMultiple("1", "0", 20U)) == 0UL) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Trillionen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 21U))) {
            return GetGermanNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " Trillionen " + GetGermanNumber(ulong.Parse(number.ToString().Substring(3)));
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

    public static string GetEnglishNumber(ulong number) {
        if (number == 0UL) {
            return "Zero";
        } else if (number == 1UL) {
            return "One";
        } else if (number == 2UL) {
            return "Two";
        } else if (number == 3UL) {
            return "Three";
        } else if (number == 4UL) {
            return "Four";
        } else if (number == 5UL) {
            return "Five";
        } else if (number == 6UL) {
            return "Six";
        } else if (number == 7UL) {
            return "Seven";
        } else if (number == 8UL) {
            return "Eight";
        } else if (number == 9UL) {
            return "Nine";
        } else if (number == 10UL) {
            return "Ten";
        } else if (number == 11UL) {
            return "Eleven";
        } else if (number == 12UL) {
            return "Twelve";
        } else if (number == 13UL) {
            return "Thirteen";
        } else if (number == 14UL) {
            return "Fourteen";
        } else if (number == 15UL) {
            return "Fifteen";
        } else if (number < 20UL) {
            return (GetEnglishNumber(ulong.Parse(number.ToString().Substring(1))) + "teen").Replace("tt", "t");
        } else if (number == 20UL) {
            return "Twenty";
        } else if (number < 30UL) {
            return "Twenty-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 30UL) {
            return "Thirty";
        } else if (number < 40UL) {
            return "Thirty-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 40UL) {
            return "Fourty";
        } else if (number < 50UL) {
            return "Fourty-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 50UL) {
            return "Fifty";
        } else if (number < 60UL) {
            return "Fifty-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 60UL) {
            return "Sixty";
        } else if (number < 70UL) {
            return "Sixty-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 70UL) {
            return "Seventy";
        } else if (number < 80UL) {
            return "Seventy-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 80UL) {
            return "Eighty";
        } else if (number < 90UL) {
            return "Eighty-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 90UL) {
            return "Ninety";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 2U))) {
            return "Ninety-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U)) && number % ulong.Parse(AppendMultiple("1", "0", 2U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Hundred";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Hundred-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U)) && number % ulong.Parse(AppendMultiple("1", "0", 3U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Thousand";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Thousand-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 5U)) && number % ulong.Parse(AppendMultiple("1", "0", 4U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Thousand";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 5U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Thousand-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U)) && number % ulong.Parse(AppendMultiple("1", "0", 5U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Thousand";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Thousand-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U)) && number % ulong.Parse(AppendMultiple("1", "0", 6U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Million";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Million-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 8U)) && number % ulong.Parse(AppendMultiple("1", "0", 7U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Million";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 8U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Million-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U)) && number % ulong.Parse(AppendMultiple("1", "0", 8U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Million";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Million-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U)) && number % ulong.Parse(AppendMultiple("1", "0", 9U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Billion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Billion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 11U)) && number % ulong.Parse(AppendMultiple("1", "0", 10U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Billion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 11U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Billion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U)) && number % ulong.Parse(AppendMultiple("1", "0", 11U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Billion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Billion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 13U)) && number % ulong.Parse(AppendMultiple("1", "0", 12U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Trillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 13U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Trillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 14U)) && number % ulong.Parse(AppendMultiple("1", "0", 13U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Trillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 14U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Trillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 15U)) && number % ulong.Parse(AppendMultiple("1", "0", 14U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Trillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 15U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Trillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 16U)) && number % ulong.Parse(AppendMultiple("1", "0", 15U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quadrillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 16U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quadrillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 17U)) && number % ulong.Parse(AppendMultiple("1", "0", 16U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quadrillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 17U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quadrillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 18U)) && number % ulong.Parse(AppendMultiple("1", "0", 17U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quadrillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 18U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quadrillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 19U)) && number % ulong.Parse(AppendMultiple("1", "0", 18U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quintillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 19U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quintillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 20U)) && number % ulong.Parse(AppendMultiple("1", "0", 19U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quintillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 20U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quintillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 21U)) && number % ulong.Parse(AppendMultiple("1", "0", 20U)) == 0UL) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quintillion";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 21U))) {
            return GetEnglishNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quintillion-" + GetEnglishNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        return "";
    }

    public static string GetDutchNumber(ulong number) {
        if (number == 0UL) {
            return "nul";
        } else if (number == 1UL) {
            return "een";
        } else if (number == 2UL) {
            return "twee";
        } else if (number == 3UL) {
            return "drie";
        } else if (number == 4UL) {
            return "vier";
        } else if (number == 5UL) {
            return "vijf";
        } else if (number == 6UL) {
            return "zes";
        } else if (number == 7UL) {
            return "zeven";
        } else if (number == 8UL) {
            return "acht";
        } else if (number == 9UL) {
            return "negen";
        } else if (number == 10UL) {
            return "tien";
        } else if (number == 11UL) {
            return "elf";
        } else if (number == 12UL) {
            return "twaalf";
        } else if (number < 20UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(1))).Replace("vier", "veer").Replace("drie", "der") + "tien";
        } else if (number == 20UL) {
            return "twintig";
        } else if (number == 30UL) {
            return "dertig";
        } else if (number == 40UL) {
            return "veertig";
        } else if (number == 50UL) {
            return "vijftig";
        } else if (number == 60UL) {
            return "zestig";
        } else if (number == 70UL) {
            return "zeventig";
        } else if (number == 80UL) {
            return "tachtig";
        } else if (number == 90UL) {
            return "negentig";
        } else if (number < 100UL) {
            string numberStr = number.ToString();
            string en = "en";
            if (numberStr.EndsWith("2") || numberStr.EndsWith("3"))
                en = "ën";
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(1))).Replace("nul", "") + en + GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1) + "0")).Replace("vier", "veer");
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U)) && number % ulong.Parse(AppendMultiple("1", "0", 2U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "honderd";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U)) && number % 10 == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "honderd " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "honderd en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U)) && number % ulong.Parse(AppendMultiple("1", "0", 3U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "duizend";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U)) && number % ulong.Parse(AppendMultiple("1", "0", 2U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "duizend " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "duizend en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 5U)) && number % ulong.Parse(AppendMultiple("1", "0", 3U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))).Replace("een", "") + "duizend";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 5U)) && number % ulong.Parse(AppendMultiple("1", "0", 2U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))).Replace("een", "") + "duizend " + GetDutchNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))).Replace("een", "") + "duizend en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U)) && number % ulong.Parse(AppendMultiple("1", "0", 2U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 3))).Replace("een", "") + "duizend " + GetDutchNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 6U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 3))).Replace("een", "") + "duizend en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U)) && number % ulong.Parse(AppendMultiple("1", "0", 6U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljoen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U)) && number % ulong.Parse(AppendMultiple("1", "0", 5U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljoen " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 7U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljoen en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 8U)) && number % ulong.Parse(AppendMultiple("1", "0", 6U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljoen";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 8U)) && number % ulong.Parse(AppendMultiple("1", "0", 5U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljoen " + GetDutchNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljoen en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U)) && number % ulong.Parse(AppendMultiple("1", "0", 5U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljoen " + GetDutchNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 9U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljoen en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U)) && number % ulong.Parse(AppendMultiple("1", "0", 9U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljard";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U)) && number % ulong.Parse(AppendMultiple("1", "0", 8U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljard " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 10U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljard en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 11U)) && number % ulong.Parse(AppendMultiple("1", "0", 9U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljard";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 11U)) && number % ulong.Parse(AppendMultiple("1", "0", 8U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljard " + GetDutchNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljard en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U)) && number % ulong.Parse(AppendMultiple("1", "0", 8U)) == 0UL) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljard " + GetDutchNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 12U))) {
            return GetDutchNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljard en " + GetDutchNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        return "";
    }

    public static string GetJapaneseNumber(ulong number) {
        if (number == 0UL) {
            return "零";
        } else if (number == 1UL) {
            return "一";
        } else if (number == 2UL) {
            return "二";
        } else if (number == 3UL) {
            return "三";
        } else if (number == 4UL) {
            return "四";
        } else if (number == 5UL) {
            return "五";
        } else if (number == 6UL) {
            return "六";
        } else if (number == 7UL) {
            return "七";
        } else if (number == 8UL) {
            return "八";
        } else if (number == 9UL) {
            return "九";
        } else if (number == 10UL) {
            return "十";
        } else if (number < 20UL) {
            return "十" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 2)) && number % 10UL == 0UL) {
            return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "十";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 2))) {
            return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "十" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 2))) {
            return "百";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 2))) {
            return "百" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3)) && number % ulong.Parse(AppendMultiple("1", "0", 2)) == 0UL) {
            return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "百";
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 3))) {
            return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "百" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == ulong.Parse(AppendMultiple("1", "0", 3))) {
            return "千";
        } else if (number < ulong.Parse(AppendMultiple("2", "0", 3))) {
            return "千" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(AppendMultiple("1", "0", 4)) && number % ulong.Parse(AppendMultiple("1", "0", 3)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "千";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 4))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "千" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 5)) && number % ulong.Parse(AppendMultiple("1", "0", 4)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "万";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 5))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "万" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 6)) && number % ulong.Parse(AppendMultiple("1", "0", 5)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "万";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 6))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "万" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 7)) && number % ulong.Parse(AppendMultiple("1", "0", 6)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "万";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 7))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "万" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 8)) && number % ulong.Parse(AppendMultiple("1", "0", 7)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "万";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 8))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "万" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 9)) && number % ulong.Parse(AppendMultiple("1", "0", 8)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "億";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 9))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "億" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 10)) && number % ulong.Parse(AppendMultiple("1", "0", 9)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "億";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 10))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "億" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 11)) && number % ulong.Parse(AppendMultiple("1", "0", 10)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "億";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 11))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "億" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 12)) && number % ulong.Parse(AppendMultiple("1", "0", 11)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "億";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 12))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "億" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 13)) && number % ulong.Parse(AppendMultiple("1", "0", 12)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "兆";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 13))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "兆" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 14)) && number % ulong.Parse(AppendMultiple("1", "0", 13)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "兆";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 14))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "兆" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 15)) && number % ulong.Parse(AppendMultiple("1", "0", 14)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "兆";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 15))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "兆" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 16)) && number % ulong.Parse(AppendMultiple("1", "0", 15)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "兆";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 16))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "兆" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 17)) && number % ulong.Parse(AppendMultiple("1", "0", 16)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "京";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 17))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "京" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 18)) && number % ulong.Parse(AppendMultiple("1", "0", 17)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "京";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 18))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "京" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 19)) && number % ulong.Parse(AppendMultiple("1", "0", 18)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "京";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 19))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "京" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 20)) && number % ulong.Parse(AppendMultiple("1", "0", 19)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "京";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 20))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "京" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 21)) && number % ulong.Parse(AppendMultiple("1", "0", 20)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "垓";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 21))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "垓" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 22)) && number % ulong.Parse(AppendMultiple("1", "0", 21)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "垓";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 22))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "垓" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 23)) && number % ulong.Parse(AppendMultiple("1", "0", 22)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "垓";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 23))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "垓" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 24)) && number % ulong.Parse(AppendMultiple("1", "0", 23)) == 0UL) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "垓";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 24))) {
			return GetJapaneseNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "垓" + GetJapaneseNumber(ulong.Parse(number.ToString().Substring(4)));
		}
        return "";
        // 秭; 穣; 溝; 澗; 正; 載; 極; 恒河沙; 阿僧祇; 那由他; 不可思議; 無量大数
        // https://de.wikipedia.org/wiki/Japanisches_Zahlensystem
        // https://en.wikipedia.org/wiki/Japanese_numerals
    }

    public static string GetEsperantoNumber(ulong number) {
        if (number == 0UL) {
			return "nulo";
		} else if (number == 1UL) {
			return "unu";
		} else if (number == 2UL) {
			return "du";
		} else if (number == 3UL) {
			return "tri";
		} else if (number == 4UL) {
			return "kvar";
		} else if (number == 5UL) {
			return "kvin";
		} else if (number == 6UL) {
			return "ses";
		} else if (number == 7UL) {
			return "sep";
		} else if (number == 8UL) {
			return "ok";
		} else if (number == 9UL) {
			return "naŭ";
		} else if (number == 10UL) {
			return "dek";
		} else if (number < ulong.Parse("20")) {
			return "dek " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 2)) && number % 10UL == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "dek";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 2))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "dek " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == ulong.Parse(AppendMultiple("1", "0", 2))) {
			return "cent";
		} else if (number < ulong.Parse(AppendMultiple("2", "0", 2))) {
			return "cent " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 3)) && number % ulong.Parse(AppendMultiple("1", "0", 2)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "cent";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 3))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "cent " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == ulong.Parse(AppendMultiple("1", "0", 3))) {
			return "mil";
		} else if (number < ulong.Parse(AppendMultiple("2", "0", 3))) {
			return "mil " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 4)) && number % ulong.Parse(AppendMultiple("1", "0", 3)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " mil";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 4))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " mil " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 5)) && number % ulong.Parse(AppendMultiple("1", "0", 4)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " mil";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 5))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " mil " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 6)) && (number % ulong.Parse(AppendMultiple("1", "0", 5))) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " mil";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 6))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " mil " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 7)) && number % ulong.Parse(AppendMultiple("1", "0", 6)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 7))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 8)) && number % ulong.Parse(AppendMultiple("1", "0", 7)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 8))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 9)) && number % ulong.Parse(AppendMultiple("1", "0", 8)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 9))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 10)) && number % ulong.Parse(AppendMultiple("1", "0", 9)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliardo";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 10))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliardo " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 11)) && number % ulong.Parse(AppendMultiple("1", "0", 10)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliardo";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 11))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliardo " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 12)) && number % ulong.Parse(AppendMultiple("1", "0", 11)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliardo";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 12))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliardo " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 13)) && number % ulong.Parse(AppendMultiple("1", "0", 12)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 13))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 14)) && number % ulong.Parse(AppendMultiple("1", "0", 13)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 14))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 15)) && number % ulong.Parse(AppendMultiple("1", "0", 14)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 15))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 16)) && number % ulong.Parse(AppendMultiple("1", "0", 15)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliardo";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 16))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliardo " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 17)) && number % ulong.Parse(AppendMultiple("1", "0", 16)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliardo";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 17))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliardo " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 18)) && number % ulong.Parse(AppendMultiple("1", "0", 17)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliardo";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 18))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliardo " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 19)) && number % ulong.Parse(AppendMultiple("1", "0", 18)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " triliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 19))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " triliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 20)) && number % ulong.Parse(AppendMultiple("1", "0", 19)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " triliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 20))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " triliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 21)) && number % ulong.Parse(AppendMultiple("1", "0", 20)) == 0UL) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " triliono";
		} else if (number < ulong.Parse(AppendMultiple("1", "0", 21))) {
			return GetEsperantoNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " triliono " + GetEsperantoNumber(ulong.Parse(number.ToString().Substring(3)));
		}
        return "";
    }

    public static string GetVampirschwesternNumber(ulong number) {
        // TODO: https://github.com/Wissididom/NumberTools/blob/0eae442067960c81ec19c54a963c3b096b0043d1/NumberTools/src/tools/number/classes/API.java#L672
        if (number == 0UL) {
            return "";
        } else if (number == 1UL) {
			return "onu";
		} else if (number == 2UL) {
			return "zoi";
		} else if (number == 3UL) {
			return "trosch";
		} else if (number == 4UL) {
			return "ziri";
		} else if (number == 5UL) {
			return "fom";
		} else if (number == 6UL) {
			return "shoist";
		} else if (number == 7UL) {
			return "syto";
		} else if (number == 8UL) {
			return "omtje";
		} else if (number == 9UL) {
			return "nonce";
		} else if (number == 10UL) {
			return "dong";
		} else if (number < 20UL) {
			return "dong-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 20UL) {
			return "zoing";
		} else if (number < 30UL) {
			return "zoing-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 30UL) {
			return "trogda";
		} else if (number < 40UL) {
			return "trogda-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 40UL) {
			return "zirick";
		} else if (number < 50UL) {
			return "zirick-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 50UL) {
			return "fomsiat";
		} else if (number < 60UL) {
			return "fomsiat-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 60UL) {
			return "shoszik";
		} else if (number < 70UL) {
			return "shoszik-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 70UL) {
			return "sytenta";
		} else if (number < 80UL) {
			return "sytenta-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 80UL) {
			return "omsiat";
		} else if (number < 90UL) {
			return "omsiat-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 90UL) {
			return "noncenta";
		} else if (number < 100UL) {
			return "noncenta-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == 100UL) {
			return "bong";
		} else if (number < 200UL) {
			return "bong-" + GetVampirschwesternNumber(ulong.Parse(number.ToString().Substring(1)));
		}
        return "";
    }

    public static string GetBinaryNumber(ulong number) {
        if (number == 0UL)
            return "0";
        string x = "";
        while (number > 0UL) {
            ulong a = number % 2UL;
            x = a.ToString() + x;
            number /= 2UL;
        }
        return x;
    }

    public static string GetHexNumber(ulong number) {
        return number.ToString("X");
    }

    public static string AppendMultiple(string str, string toAppend, uint count) {
        string result = str;
        for (int i = 0; i < count; i++) {
            result += toAppend;
        }
        return result;
    }
}
// https://github.com/Wissididom/NumberTools
