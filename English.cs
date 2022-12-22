public class English {

    public static string GetNumber(ulong number) {
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
            return (English.GetNumber(ulong.Parse(number.ToString().Substring(1))) + "teen").Replace("tt", "t");
        } else if (number == 20UL) {
            return "Twenty";
        } else if (number < 30UL) {
            return "Twenty-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 30UL) {
            return "Thirty";
        } else if (number < 40UL) {
            return "Thirty-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 40UL) {
            return "Fourty";
        } else if (number < 50UL) {
            return "Fourty-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 50UL) {
            return "Fifty";
        } else if (number < 60UL) {
            return "Fifty-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 60UL) {
            return "Sixty";
        } else if (number < 70UL) {
            return "Sixty-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 70UL) {
            return "Seventy";
        } else if (number < 80UL) {
            return "Seventy-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 80UL) {
            return "Eighty";
        } else if (number < 90UL) {
            return "Eighty-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == 90UL) {
            return "Ninety";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 2U))) {
            return "Ninety-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Hundred";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Hundred-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 3U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Thousand";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Thousand-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 4U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Thousand";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Thousand-" + English.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 5U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Thousand";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Thousand-" + English.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 6U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Million";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Million-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 7U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Million";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Million-" + English.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Million";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Million-" + English.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 9U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Billion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Billion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 10U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Billion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Billion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 11U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Billion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Billion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 12U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Trillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Trillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 13U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Trillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Trillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 14U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Trillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Trillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 15U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quadrillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quadrillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 16U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quadrillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quadrillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 17U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quadrillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quadrillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 18U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quintillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "-Quintillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 19U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quintillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "-Quintillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(2)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21U)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 20U)) == 0UL) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quintillion";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21U))) {
            return English.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "-Quintillion-" + English.GetNumber(ulong.Parse(number.ToString().Substring(3)));
        }
        return "";
    }
}
