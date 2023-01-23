public class French {

    public static string GetNumber(ulong number) {
        if (number == 0UL) {
            return "Zéro";
        } else if (number == 1UL) {
            return "Un";
        } else if (number == 2UL) {
            return "Deux";
        } else if (number == 3UL) {
            return "Trois";
        } else if (number == 4UL) {
            return "Quatre";
        } else if (number == 5UL) {
            return "Cinq";
        } else if (number == 6UL) {
            return "Six";
        } else if (number == 7UL) {
            return "Sept";
        } else if (number == 8UL) {
            return "Huit";
        } else if (number == 9UL) {
            return "Neuf";
        } else if (number == 10UL) {
            return "Dix";
        } else if (number == 11UL) {
            return "Onze";
        } else if (number == 12UL) {
            return "Douze";
        } else if (number == 13UL) {
            return "Treize";
        } else if (number == 14UL) {
            return "Quatorze";
        } else if (number == 15UL) {
            return "Quinze";
        } else if (number == 16UL) {
            return "Seize";
        } else if (number == 17UL) {
            return "Dix-sept";
        } else if (number == 18UL) {
            return "Dix-huit";
        } else if (number == 19UL) {
            return "Dix-neuf";
        } else if (number == 20UL) {
            return "Vingt";
        } else if (number == 30UL) {
            return "Trente";
        } else if (number == 40UL) {
            return "Quarante";
        } else if (number == 50UL) {
            return "Cinquante";
        } else if (number == 60UL) {
            return "Soixante";
        } else if (number == 70UL) {
            return "Soixante-dix"; // or "Septante" in Belgium and Switzerland
        } else if (number == 80UL) {
            return "Quatre-vingts"; // or "Octante" in Belgium and Switzerland
        } else if (number == 90UL) {
            return "Quatre-vingt-dix"; // or "Nonante" in Belgium and Switzerland
        } else if (number < 100UL) {
            string un = "un";
            if (Math.Floor((double)number / 10UL) == 7)
                un = "onze";
            if (number % 10UL == 1UL)
                return French.GetNumber((number / 10UL) * 10UL) + " et " + un;
            else
                return French.GetNumber((number / 10UL) * 10UL) + "-" + French.GetNumber(number % 10UL).ToLower();
        } else if (number == 100UL) {
            return "Cent";
        } else if (number < 1000UL) {
            if (Math.Floor((double)number / 100) == 1)
                return ("Cent " + French.GetNumber(number % 100UL).ToLower().Replace("zéro" , "")).Trim();
            else if (number % 100UL == 1UL)
                return French.GetNumber(number / 100UL) + " cent un";
            else
                return French.GetNumber(number / 100UL) + " cents " + French.GetNumber(number % 100UL).ToLower().Replace("zéro", "");
        } else if (number == 1000UL) {
            return "Mille";
        } else if (number < 1000000UL) {
            if (Math.Floor((double)number / 1000UL) == 1)
                return ("Mille " + French.GetNumber(number % 1000UL).ToLower().Replace("zéro" , "")).Trim();
            else if (number % 1000UL == 1UL)
                return French.GetNumber(number / 1000UL) + " mille un";
            else
                return French.GetNumber(number / 1000UL) + " mille " + French.GetNumber(number % 1000UL).ToLower().Replace("zéro", "");
        } else if (number < 1000000000UL) {
            if (Math.Floor((double)number / 1000000) == 1)
                return ("Un million " + French.GetNumber(number % 1000000UL).ToLower().Replace("zéro" , "")).Trim();
            else if (number % 1000000UL == 1UL)
                return French.GetNumber(number / 1000000UL) + " million un";
            else
                return French.GetNumber(number / 1000000UL) + " million " + French.GetNumber(number % 1000000UL).ToLower().Replace("zéro", "");
        } else if (number < 1000000000000UL) {
            if (Math.Floor((double)number / 1000000000) == 1)
                return ("Un milliard " + French.GetNumber(number % 1000000000UL).ToLower().Replace("zéro" , "")).Trim();
            else if (number % 1000000000UL == 1UL)
                return French.GetNumber(number / 1000000000UL) + " milliard un";
            else
                return French.GetNumber(number / 1000000000UL) + " milliard " + French.GetNumber(number % 1000000000UL).ToLower().Replace("zéro", "");
        }
        return "";
    }
}
