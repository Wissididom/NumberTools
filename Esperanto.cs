public class Esperanto {

    public static string GetNumber(ulong number) {
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
			return "dek " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 2)) && number % 10UL == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "dek";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 2))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "dek " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 2))) {
			return "cent";
		} else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 2))) {
			return "cent " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "cent";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "cent " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 3))) {
			return "mil";
		} else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 3))) {
			return "mil " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 3)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " mil";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " mil " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 4)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " mil";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " mil " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6)) && (number % ulong.Parse(Api.AppendMultiple("1", "0", 5))) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " mil";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " mil " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 6)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 7)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 9)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliardo";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " miliardo " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 10)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliardo";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " miliardo " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 11)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliardo";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " miliardo " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 12)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 13)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 14)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 15)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliardo";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " biliardo " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 16)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliardo";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " biliardo " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 17)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliardo";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " biliardo " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 18)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " triliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + " triliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 19)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " triliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + " triliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 20)) == 0UL) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " triliono";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21))) {
			return Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + " triliono " + Esperanto.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		}
        return "";
    }
}
