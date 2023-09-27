# checkTelefono
Consegna:
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungi 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare strunga vuota ""


using System;

public static class Telefono
{
    public static string Check(string[] input)
    {
        foreach (string numero in input)
        {
            string numeroPulito = RimuoviSpaziETrattini(numero);
            if (EUnNumeroDiTelefonoItaliano(numeroPulito))
            {
                return numero;
            }
        }
        return "";
    }
    private static string RimuoviSpaziETrattini(string numero)
    {
        return numero.Replace(" ", "").Replace("-", "");
    }
    private static bool EUnNumeroDiTelefonoItaliano(string numero)
    {
        if (numero.StartsWith("+39") && numero.Length == 13)
        {
            return true;
        }
        else if (numero.StartsWith("0039") && numero.Length == 14)
        {
            return true;
        }
        else if (numero.StartsWith("3") && numero.Length == 10)
        {
            return true;
        }

        return false;
    }
}
