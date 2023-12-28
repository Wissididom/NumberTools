public class Program
{

    public static void Main(string[] args)
    {
        ulong[] numbersToTest = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 32, 43, 54, 65, 76, 87, 98, 100, 123, 256, 300, 512, 1000, 1024,
            2000, 2048, 2100, 2125, 2512, 2600, 2790, 2999, 0x1000, 0x2000, 0x4000, 0x8000, 0x10000, 0x20000, 0x40000, 0x80000, 0x100000, 0x200000, 0x400000,
            0x800000, 0x1000000, 0x2000000, 0x4000000, 0x8000000, 0x10000000, 0x20000000, 0x40000000, 0x80000000, 0x100000000, 0x200000000, 0x400000000,
            0x800000000, 0x1000000000, 0x2000000000, 0x4000000000, 0x8000000000, 0x10000000000
        };
        if (args.Length > 1) {
            numbersToTest = new ulong[] {ulong.Parse(args[1])};
        }
        for (int i = 0; i < numbersToTest.Length; i++)
        {
            if (i > 55 && args[0].ToUpper() == "ROMAN") break;
            Console.WriteLine(numbersToTest[i] + ": " + Api.GetNumber((Api.Language) Enum.Parse(typeof(Api.Language), args[0].ToUpper()), numbersToTest[i]));
        }
    }
}
