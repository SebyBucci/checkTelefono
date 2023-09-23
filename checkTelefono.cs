using System;
using System.Text.RegularExpressions;

public static class Telefono
{
    public static string Check(string[] input)
    {
        foreach (string numero in input)
        {
            string numeroPulito = Regex.Replace(numero, @"[\s-]", "");
            if (numeroPulito.StartsWith("+39") && numeroPulito.Length == 13)
            {
                return numero;
            }
            else if (numeroPulito.StartsWith("0039") && numeroPulito.Length == 14)
            {
                return numero;
            }
            else if (numeroPulito.StartsWith("3") && numeroPulito.Length == 10)
            {
                return numero;
            }
        }
        return "";
    }
}
