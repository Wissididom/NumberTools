using System.Text;

public class Binary
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
            return "0";
        StringBuilder binaryRepresentation = new StringBuilder();
        while (number > 0UL)
        {
            binaryRepresentation.Insert(0, (number % 2UL).ToString());
            number /= 2UL;
        }
        return binaryRepresentation.ToString();
    }
}
