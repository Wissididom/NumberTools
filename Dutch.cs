public class Dutch {

    public static string GetNumber(ulong number) {
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
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("vier", "veer").Replace("drie", "der") + "tien";
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
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1))).Replace("nul", "") + en + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1) + "0")).Replace("vier", "veer");
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "honderd";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U)) && number % 10UL == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "honderd " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "honderd en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 3U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "duizend";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "duizend " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))).Replace("een", "") + "duizend en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 3U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))).Replace("een", "") + "duizend";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))).Replace("een", "") + "duizend " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))).Replace("een", "") + "duizend en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))).Replace("een", "") + "duizend " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))).Replace("een", "") + "duizend en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 6U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljoen";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 5U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljoen " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljoen en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 6U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljoen";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 5U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljoen " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljoen en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 5U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljoen " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljoen en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 9U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljard";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljard " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miljard en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 9U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljard";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miljard " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljard en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8U)) == 0UL) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljard " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U))) {
            return Dutch.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miljard en " + Dutch.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        return "";
    }
}
