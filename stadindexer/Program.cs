using System;
using System.Collections;

namespace stadindexer
{
    class Program
    {
        private static string[] steden = new string[500];
        private static string[] inwoners = new string[500];
        
        private static int aantalSteden = -1;
        private static int keuze;

        private static string teBewerken;
        private static string teBewerkenNaam;
        private static string bewerkInwoners;

        private static string teVerwijderen;

        private static string teZoeken;
        static void Main()
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Write("MENU \n" +
                          "(1) Voeg een stad toe \n" +
                          "(2) Toon alle steden \n" +
                          "(3) Bewerk een stad \n" +
                          "(4) Verwijder een stad \n" +
                          "(5) Zoek een stad \n" +
                          "(0) Afsluiten \n" +
                          "Kies een optie: ");

            keuze = Convert.ToInt32(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    VoegStadToe();
                    break;
                case 2:
                    ToonAlleSteden();
                    break;
                case 3:
                    Console.Write("Welke stad wil je bewerken: ");
                    teBewerken = Console.ReadLine();
                    Console.Write("Nieuwe naam (Leeg laten voor geen verandering): ");
                    teBewerkenNaam = Console.ReadLine();
                    Console.Write("Nieuwe inwoners (Leeg laten voor geen verandering): ");
                    bewerkInwoners = Console.ReadLine();
                    
                    BewerkStad();
                    break;
                case 4:
                    Console.Write("Welke stad wil je verwijderen: ");
                    teVerwijderen = Console.ReadLine();
                    
                    VerwijderStad();
                    break;
                case 5:
                    Console.Write("Welke stad wil je zoeken: ");
                    teZoeken = Console.ReadLine();

                    ZoekStad();
                    break;
            }
        }
        private static void VoegStadToe()
        {
            aantalSteden++;
            Console.Write("Voer een stad in: ");
            steden[aantalSteden] = Console.ReadLine();
            Console.Write("Voer het aantal inwoners in: ");
            inwoners[aantalSteden] = Console.ReadLine();
            
            Menu();
        }
        private static void ToonAlleSteden()
        {

            for (int i = 0; i < 500; i++)
            {
                if (steden[i] != null)
                {
                    Console.WriteLine("{0} Inwoners: {1}", steden[i], inwoners[i]);
                }
            }
            
            Menu();
        }
        private static void BewerkStad()
        {
            if (teBewerkenNaam != "")
            {
                for (int i = 0; i < 500; i++)
                {
                    if (steden[i] == teBewerken)
                    {
                        steden[i] = teBewerkenNaam;
                    }
                }
            }

            if (bewerkInwoners != "")
            {
                for (int i = 0; i < 500; i++)
                {
                    if (steden[i] == teBewerken)
                    {
                        inwoners[i] = bewerkInwoners;
                    }
                }
            }

            Menu();
        }
        private static void VerwijderStad()
        {
            for (int i = 0; i < 500; i++)
            {
                if (steden[i] == teVerwijderen)
                {
                    steden[i] = null;
                    inwoners[i] = null;
                }
            }

            Menu();
        }
        private static void ZoekStad()
        {
            for (int i = 0; i < 500; i++)
            {
                if (steden[i] == teZoeken)
                {
                    Console.WriteLine("{0} Inwoners: {1}", steden[i], inwoners[i]);
                }
            }

            Menu();
        }
    }
}
