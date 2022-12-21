public class Program {

    public static void Main(string[] args) {
        /*ulong value = 123UL;
        Console.WriteLine(Api.GetRomanNumber(value));
        Console.WriteLine(Api.GetGermanNumber(value));
        Console.WriteLine(Api.GetEnglishNumber(value));
        Console.WriteLine(Api.GetDutchNumber(value));
        Console.WriteLine(Api.GetJapaneseNumber(value));
        Console.WriteLine(Api.GetEsperantoNumber(value));
        Console.WriteLine(Api.GetVampirschwesternNumber(value));
        Console.WriteLine(Api.GetBinaryNumber(value));
        Console.WriteLine(Api.GetHexNumber(value));*/
        for (ulong i = 0UL; i < ulong.Parse(Api.AppendMultiple("1", "0", 12U)); i++) {
            Console.WriteLine(i + ": " + Api.GetDutchNumber(i));
        }
    }
}
