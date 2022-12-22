public class Binary
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
            return "0";
        string x = "";
        while (number > 0UL)
        {
            ulong a = number % 2UL;
            x = a.ToString() + x;
            number /= 2UL;
        }
        return x;
    }
}
