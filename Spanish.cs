public class Spanish {

    public static string GetNumber(ulong number) {
        if (number == 0UL) {
            return "cero";
        } else if (number == 1UL) {
            return "uno";
        } else if (number == 2UL) {
            return "dos";
        } else if (number == 3UL) {
            return "tres";
        } else if (number == 4UL) {
            return "cuatro";
        } else if (number == 5UL) {
            return "cinco";
        } else if (number == 6UL) {
            return "seis";
        } else if (number == 7UL) {
            return "siete";
        } else if (number == 8UL) {
            return "ocho";
        } else if (number == 9UL) {
            return "nueve";
        } else if (number == 10UL) {
            return "diez";
        } else if (number == 11UL) {
            return "once";
        } else if (number == 12UL) {
            return "doce";
        } else if (number == 13UL) {
            return "trece";
        } else if (number == 14UL) {
            return "catorce";
        } else if (number == 15UL) {
            return "quince";
        } else if (number == 16UL) {
            return "diez y seis";
        } else if (number == 17UL) {
            return "diez y siete";
        } else if (number == 18UL) {
            return "diez y ocho";
        } else if (number == 19UL) {
            return "diez y nueve";
        } else if (number == 20UL) {
            return "veinte";
        } else if (number == 30UL) {
            return "treinta";
        } else if (number == 40UL) {
            return "cuarenta";
        } else if (number == 50UL) {
            return "cincuenta";
        } else if (number == 60UL) {
            return "sesenta";
        } else if (number == 70UL) {
            return "setenta";
        } else if (number == 80UL) {
            return "ochenta";
        } else if (number == 90UL) {
            return "noventa";
        } else if (number < 100UL) {
            return Spanish.GetNumber((number / 10UL) * 10) + " y " + Spanish.GetNumber(number % 10UL);
        } else if (number == 100UL) {
            return "cien";
        } else if (number < 200UL) {
            return "ciento " + Spanish.GetNumber(number % 100UL);
        } else if (number < 1000UL) {
            return Spanish.GetNumber(number / 100UL) + " ciento " + Spanish.GetNumber(number % 100UL);
        } else if (number == 1000UL) {
            return "mil";
        } else if (number < 2000UL) {
            return "mil " + Spanish.GetNumber(number % 100UL);
        } else if (number < 10000UL) {
            return Spanish.GetNumber(number / 1000UL) + " mil " + Spanish.GetNumber(number % 1000UL);
        }
        return "";
    }
}
