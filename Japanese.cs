public class Japanese
{

    public static string GetNumber(ulong number)
    {
        if (number == 0UL)
        {
            return "零";
        }
        else if (number == 1UL)
        {
            return "一";
        }
        else if (number == 2UL)
        {
            return "二";
        }
        else if (number == 3UL)
        {
            return "三";
        }
        else if (number == 4UL)
        {
            return "四";
        }
        else if (number == 5UL)
        {
            return "五";
        }
        else if (number == 6UL)
        {
            return "六";
        }
        else if (number == 7UL)
        {
            return "七";
        }
        else if (number == 8UL)
        {
            return "八";
        }
        else if (number == 9UL)
        {
            return "九";
        }
        else if (number == 10UL)
        {
            return "十";
        }
        else if (number < 20UL)
        {
            return "十" + Japanese.GetNumber(number % 10UL);
        }
        else if (number < 100UL && number % 10UL == 0UL)
        {
            return Japanese.GetNumber(number / 10UL) + "十";
        }
        else if (number < 100UL)
        {
            return Japanese.GetNumber(number / 10UL) + "十" + Japanese.GetNumber(number % 10UL);
        }
        else if (number == 100UL)
        {
            return "百";
        }
        else if (number < 200UL)
        {
            return "百" + Japanese.GetNumber(number % 100UL);
        }
        else if (number < 1000UL && number % 100UL == 0UL)
        {
            return Japanese.GetNumber(number / 100UL) + "百";
        }
        else if (number < 1000UL)
        {
            return Japanese.GetNumber(number / 100UL) + "百" + Japanese.GetNumber(number % 100UL);
        }
        else if (number == 1000UL)
        {
            return "千";
        }
        else if (number < 2000UL)
        {
            return "千" + Japanese.GetNumber(number % 1000UL);
        }
        else if (number < 10000UL && number % 1000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000UL) + "千";
        }
        else if (number < 10000UL)
        {
            return Japanese.GetNumber(number / 1000UL) + "千" + Japanese.GetNumber(number % 1000UL);
        }
        else if (number < 100000UL && number % 10000UL == 0UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万";
        }
        else if (number < 100000UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万" + Japanese.GetNumber(number % 10000UL);
        }
        else if (number < 1000000UL && number % 100000UL == 0UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万";
        }
        else if (number < 1000000UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万" + Japanese.GetNumber(number % 10000UL);
        }
        else if (number < 10000000UL && number % 1000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万";
        }
        else if (number < 10000000UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万" + Japanese.GetNumber(number % 10000UL);
        }
        else if (number < 100000000UL && number % 10000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万";
        }
        else if (number < 100000000UL)
        {
            return Japanese.GetNumber(number / 10000UL) + "万" + Japanese.GetNumber(number % 10000UL);
        }
        else if (number < 1000000000UL && number % 100000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億";
        }
        else if (number < 1000000000UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億" + Japanese.GetNumber(number % 100000000UL);
        }
        else if (number < 10000000000UL && number % 1000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億";
        }
        else if (number < 10000000000UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億" + Japanese.GetNumber(number % 100000000UL);
        }
        else if (number < 100000000000UL && number % 10000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億";
        }
        else if (number < 100000000000UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億" + Japanese.GetNumber(number % 100000000UL);
        }
        else if (number < 1000000000000UL && number % 100000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億";
        }
        else if (number < 1000000000000UL)
        {
            return Japanese.GetNumber(number / 100000000UL) + "億" + Japanese.GetNumber(number % 100000000UL);
        }
        else if (number < 10000000000000UL && number % 1000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆";
        }
        else if (number < 10000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆" + Japanese.GetNumber(number % 1000000000000UL);
        }
        else if (number < 100000000000000UL && number % 10000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆";
        }
        else if (number < 100000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆" + Japanese.GetNumber(number % 1000000000000UL);
        }
        else if (number < 1000000000000000UL && number % 100000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆";
        }
        else if (number < 1000000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆" + Japanese.GetNumber(number % 1000000000000UL);
        }
        else if (number < 10000000000000000UL && number % 1000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆";
        }
        else if (number < 10000000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000UL) + "兆" + Japanese.GetNumber(number % 1000000000000UL);
        }
        else if (number < 100000000000000000UL && number % 10000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 10000000000000000UL) + "京";
        }
        else if (number < 100000000000000000UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京" + Japanese.GetNumber(number % 100000000000000000UL);
        }
        else if (number < 1000000000000000000UL && number % 100000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京";
        }
        else if (number < 1000000000000000000UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京" + Japanese.GetNumber(number % 100000000000000000UL);
        }
        else if (number < 10000000000000000000UL && number % 1000000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京";
        }
        else if (number < 10000000000000000000UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京" + Japanese.GetNumber(number % 100000000000000000UL);
        }
        /*else if (number < 100000000000000000000UL && number % 10000000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京";
        }
        else if (number < 100000000000000000000UL)
        {
            return Japanese.GetNumber(number / 100000000000000000UL) + "京" + Japanese.GetNumber(number % 100000000000000000UL);
        }
        else if (number < 1000000000000000000000UL && number % 100000000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓";
        }
        else if (number < 1000000000000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓" + Japanese.GetNumber(number % 1000000000000000000000UL);
        }
        else if (number < 10000000000000000000000UL && number % 1000000000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓";
        }
        else if (number < 10000000000000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓" + Japanese.GetNumber(number % 1000000000000000000000UL);
        }
        else if (number < 100000000000000000000000UL && number % 10000000000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓";
        }
        else if (number < 100000000000000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓" + Japanese.GetNumber(number % 1000000000000000000000UL);
        }
        else if (number < 1000000000000000000000000UL && number % 100000000000000000000000UL == 0UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓";
        }
        else if (number < 1000000000000000000000000UL)
        {
            return Japanese.GetNumber(number / 1000000000000000000000UL) + "垓" + Japanese.GetNumber(number % 1000000000000000000000UL);
        } //ulong.MaxValue = 18446744073709551615 -> "CS1021: Die integrale Konstante ist zu groß."*/
        return "";
        // 秭; 穣; 溝; 澗; 正; 載; 極; 恒河沙; 阿僧祇; 那由他; 不可思議; 無量大数
        // https://de.wikipedia.org/wiki/Japanisches_Zahlensystem
        // https://en.wikipedia.org/wiki/Japanese_numerals
    }
}
