using System.Text;

public class Roman
{

    public static string GetNumber(ulong number)
    {
        StringBuilder result = new StringBuilder();
        result.Append('M', (int)(number / 1000));
        number %= 1000;
        AppendRoman(ref result, "CM", ref number, 900);
        AppendRoman(ref result, "D", ref number, 500);
        AppendRoman(ref result, "CD", ref number, 400);
        AppendRoman(ref result, "C", ref number, 100);
        AppendRoman(ref result, "XC", ref number, 90);
        AppendRoman(ref result, "L", ref number, 50);
        AppendRoman(ref result, "XL", ref number, 40);
        AppendRoman(ref result, "X", ref number, 10);
        AppendRoman(ref result, "IX", ref number, 9);
        AppendRoman(ref result, "V", ref number, 5);
        AppendRoman(ref result, "IV", ref number, 4);
        AppendRoman(ref result, "I", ref number, 1);
        return result.ToString();
    }

    private static void AppendRoman(ref StringBuilder result, string roman, ref ulong number, ulong value)
    {
        int count = (int)(number / value);
        if (count > 0)
        {
            result.Append(roman);
            number %= value;
        }
    }
}
