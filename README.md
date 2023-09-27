# checkTelefono
Consegna:
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungi 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare strunga vuota ""

Codice:
```C#
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
```C#

questo codice fornisce un metodo per verificare una serie di numeri di telefono alla ricerca del primo numero di telefono italiano valido. Esso pulisce i numeri da spazi e trattini, quindi verifica se soddisfano le condizioni specifiche per i numeri di telefono italiani. Se trova un numero valido, lo restituisce; altrimenti, restituisce una stringa vuota.
