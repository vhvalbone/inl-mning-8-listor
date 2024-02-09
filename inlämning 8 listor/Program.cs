using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många koder vill du skriva in?");
        int antalKoder = Convert.ToInt32(Console.ReadLine());

        Dictionary<char, char> koder = new Dictionary<char, char>();

        // Läs in koder och lagra dem i en Dictionary
        for (int i = 0; i < antalKoder; i++)
        {
            Console.WriteLine("Skriv in kod " + (i + 1) + " på formen 'X Y':");
            string[] kodPar = Console.ReadLine().Split();
            char tecken1 = kodPar[0][0];
            char tecken2 = kodPar[1][0];
            koder[tecken1] = tecken2;
        }

        Console.WriteLine("Skriv in ditt hemliga meddelande:");
        string meddelande = Console.ReadLine();

        string avkodatMeddelande = AvkodaMeddelande(meddelande, koder);

        Console.WriteLine("Här är ditt avkodade meddelande:");
        Console.WriteLine(avkodatMeddelande);
    }

    static string AvkodaMeddelande(string meddelande, Dictionary<char, char> koder)
    {
        char[] teckenArray = meddelande.ToCharArray();

        for (int i = 0; i < teckenArray.Length; i++)
        {
            char tecken = teckenArray[i];
            if (koder.ContainsKey(tecken))
            {
                teckenArray[i] = koder[tecken];
            }
        }

        return new string(teckenArray);
    }
}
