using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Kysytään käyttäjältä lukua
            Console.Write("Anna luku: ");

            // Tehdään kertoluku muuttuja ja asetetaan sille arvo jonka käyttäjä on antanut
            int kertoluku = int.Parse(Console.ReadLine());

            // Tulostetaan kertotaulu sille luvulle
            Console.WriteLine("Kertotaulu luvulle " + kertoluku + ":");

            // for-silmukka
            for (int i = 1; i <= 10; i++)
            {
                // Käytetään kertolaskukaava metodia että saadaan tulos
                // Esim: 3 * 4 = 12
                // Esim: i / luku1 = i / kertoluku = vastaus
                Console.WriteLine(Kertolaskukaavalla(i, kertoluku));
            }
        }

        // Tämä metodi tuo vastauksen:
        // luku1 * luku2 == (Luku1 * Luku2)
        // eli 3 * 4 == (3*4)
        public static string Kertolaskukaavalla(int luku1, int luku2)
        {
            // Palautetaan luku1 * luku2 lasku
            return luku1 + " * " + luku2 + " = " + (luku1 * luku2);
        }
    }
}
