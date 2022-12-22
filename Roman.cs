public class Roman
{

    public static string GetNumber(ulong number)
    {
        string result = "";
        ulong m = number / 1000UL;
        for (ulong a = 0UL; a < m; a++)
        {
            result += "M";
        }
        number -= m * 1000UL;
        ulong d = number / 500UL;
        for (ulong a = 0UL; a < d; a++)
        {
            result += "D";
        }
        number -= d * 500UL;
        ulong c = number / 100UL;
        for (ulong a = 0UL; a < c; a++)
        {
            result += "C";
        }
        number -= c * 100UL;
        ulong l = number / 50UL;
        for (ulong a = 0UL; a < l; a++)
        {
            result += "L";
        }
        number -= l * 50UL;
        ulong x = number / 10UL;
        for (ulong a = 0UL; a < x; a++)
        {
            result += "X";
        }
        number -= x * 10UL;
        ulong v = number / 5UL;
        for (ulong a = 0UL; a < v; a++)
        {
            result += "V";
        }
        number -= v * 5UL;
        ulong i = number / 1UL;
        for (ulong a = 0UL; a < i; a++)
        {
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
}
