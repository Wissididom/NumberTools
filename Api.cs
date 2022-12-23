public class Api
{

    public enum Language
    {
        ROMAN,
        GERMAN,
        ENGLISH,
        FRENCH,
        SPANISH,
        DUTCH,
        NORWEGIAN,
        JAPANESE,
        ESPERANTO,
        VAMPIRSCHWESTERN,
        BINARY,
        HEXADECIMAL
    }

    public static string GetNumber(Language language, ulong number)
    {
        switch (language)
        {
            case Language.ROMAN:
                return Api.GetRomanNumber(number);
            case Language.GERMAN:
                return Api.GetGermanNumber(number);
            case Language.ENGLISH:
                return Api.GetEnglishNumber(number);
            case Language.FRENCH:
                return Api.GetFrenchNumber(number);
            case Language.SPANISH:
                return Api.GetSpanishNumber(number);
            case Language.DUTCH:
                return Api.GetDutchNumber(number);
            case Language.NORWEGIAN:
                return Api.GetNorwegianNumber(number);
            case Language.JAPANESE:
                return Api.GetJapaneseNumber(number);
            case Language.ESPERANTO:
                return Api.GetEsperantoNumber(number);
            case Language.VAMPIRSCHWESTERN:
                return Api.GetVampirschwesternNumber(number);
            case Language.BINARY:
                return Api.GetBinaryNumber(number);
            case Language.HEXADECIMAL:
                return Api.GetHexNumber(number);
            default:
                return number.ToString();
        }
    }

    public static string GetRomanNumber(ulong number)
    {
        return Roman.GetNumber(number);
    }

    public static string GetGermanNumber(ulong number)
    {
        return German.GetNumber(number);
    }

    public static string GetEnglishNumber(ulong number)
    {
        return English.GetNumber(number);
    }

    public static string GetFrenchNumber(ulong number)
    {
        return French.GetNumber(number);
    }

    public static string GetSpanishNumber(ulong number) {
        return Spanish.GetNumber(number);
    }

    public static string GetDutchNumber(ulong number)
    {
        return Dutch.GetNumber(number);
    }

    public static string GetNorwegianNumber(ulong number)
    {
        return Norwegian.GetNumber(number);
    }

    public static string GetJapaneseNumber(ulong number)
    {
        return Japanese.GetNumber(number);
    }

    public static string GetEsperantoNumber(ulong number)
    {
        return Esperanto.GetNumber(number);
    }

    public static string GetVampirschwesternNumber(ulong number)
    {
        return Vampirschwestern.GetNumber(number);
    }

    public static string GetBinaryNumber(ulong number)
    {
        return Binary.GetNumber(number);
    }

    public static string GetHexNumber(ulong number)
    {
        return Hexadecimal.GetNumber(number);
    }

    public static string AppendMultiple(string str, string toAppend, uint count)
    {
        string result = str;
        for (int i = 0; i < count; i++)
        {
            result += toAppend;
        }
        return result;
    }
}
