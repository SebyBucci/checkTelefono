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
