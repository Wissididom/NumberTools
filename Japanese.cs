public class Japanese {

    public static string GetNumber(ulong number) {
        if (number == 0UL) {
            return "零";
        } else if (number == 1UL) {
            return "一";
        } else if (number == 2UL) {
            return "二";
        } else if (number == 3UL) {
            return "三";
        } else if (number == 4UL) {
            return "四";
        } else if (number == 5UL) {
            return "五";
        } else if (number == 6UL) {
            return "六";
        } else if (number == 7UL) {
            return "七";
        } else if (number == 8UL) {
            return "八";
        } else if (number == 9UL) {
            return "九";
        } else if (number == 10UL) {
            return "十";
        } else if (number < 20UL) {
            return "十" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 2)) && number % 10UL == 0UL) {
            return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "十";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 2))) {
            return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "十" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 2))) {
            return "百";
        } else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 2))) {
            return "百" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 2)) == 0UL) {
            return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "百";
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 3))) {
            return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "百" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number == ulong.Parse(Api.AppendMultiple("1", "0", 3))) {
            return "千";
        } else if (number < ulong.Parse(Api.AppendMultiple("2", "0", 3))) {
            return "千" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
        } else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 3)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "千";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 4))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "千" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 4)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "万";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 5))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "万" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 5)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "万";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 6))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "万" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 6)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "万";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 7))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "万" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 7)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "万";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 8))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "万" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 8)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "億";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 9))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "億" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 9)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "億";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 10))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "億" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 10)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "億";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 11))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "億" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 11)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "億";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 12))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "億" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 12)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "兆";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 13))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "兆" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 13)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "兆";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 14))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "兆" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 14)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "兆";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 15))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "兆" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 15)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "兆";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 16))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "兆" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 16)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "京";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 17))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "京" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 17)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "京";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 18))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "京" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 18)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "京";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 19))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "京" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 19)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "京";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 20))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "京" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(4)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 20)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "垓";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 21))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 1))) + "垓" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(1)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 22)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 21)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "垓";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 22))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 2))) + "垓" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(2)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 23)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 22)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "垓";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 23))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 3))) + "垓" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(3)));
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 24)) && number % ulong.Parse(Api.AppendMultiple("1", "0", 23)) == 0UL) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "垓";
		} else if (number < ulong.Parse(Api.AppendMultiple("1", "0", 24))) {
			return Japanese.GetNumber(ulong.Parse(number.ToString().Substring(0, 4))) + "垓" + Japanese.GetNumber(ulong.Parse(number.ToString().Substring(4)));
		}
        return "";
        // 秭; 穣; 溝; 澗; 正; 載; 極; 恒河沙; 阿僧祇; 那由他; 不可思議; 無量大数
        // https://de.wikipedia.org/wiki/Japanisches_Zahlensystem
        // https://en.wikipedia.org/wiki/Japanese_numerals
    }
}
