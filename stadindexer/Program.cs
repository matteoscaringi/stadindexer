using System;
using System.Collections;

namespace stadindexer
{
    class Program
    {
        private string[] steden = new string[500];
        private string[] inwoners = new string[500];
        
        private int aantalSteden = -1;
        private int keuze;

        private string teBewerken;
        private string teBewerkenNaam;
        private string bewerkInwoners;

        private string teVerwijderen;

        private string teZoeken;
        static void Main()
        {
            Program program = new Program();
            
            Menu();
        }

        private static void Menu()
        {
            Program program = new Program();
            
            Console.Write("MENU \n" +
                          "(1) Voeg een stad toe \n" +
                          "(2) Toon alle steden \n" +
                          "(3) Bewerk een stad \n" +
                          "(4) Verwijder een stad \n" +
                          "(5) Zoek een stad \n" +
                          "(0) Afsluiten \n" +
                          "Kies een optie: ");

            program.keuze = Convert.ToInt32(Console.ReadLine());

            switch (program.keuze)
            {
                case 1:
                    VoegStadToe();
                    break;
                case 2:
                    ToonAlleSteden();
                    break;
                case 3:
                    Console.Write("Welke stad wil je bewerken: ");
                    program.teBewerken = Console.ReadLine();
                    Console.Write("Nieuwe naam (Leeg laten voor geen verandering): ");
                    program.teBewerkenNaam = Console.ReadLine();
                    Console.Write("Nieuwe inwoners (Leeg laten voor geen verandering): ");
                    program.bewerkInwoners = Console.ReadLine();
                    
                    BewerkStad();
                    break;
                case 4:
                    Console.Write("Welke stad wil je verwijderen: ");
                    program.teVerwijderen = Console.ReadLine();
                    
                    VerwijderStad();
                    break;
                case 5:
                    ZoekStad();
                    break;
            }
        }
        private static void VoegStadToe()
        {
            Program program = new Program();

            Console.Write("Voer een stad in: ");
            program.steden[program.aantalSteden] = Console.ReadLine();
            Console.Write("Voer het aantal inwoners in: ");
            program.inwoners[program.aantalSteden] = Console.ReadLine();
            program.aantalSteden++; 
            Menu();
        }
        private static void ToonAlleSteden()
        {
            Program program = new Program();
            
            for (int i = 0; i <= 500; i++)
            {
                if (program.steden[i] != null)
                {
                    Console.WriteLine("{0} Inwoners: {1}", program.steden[i], program.inwoners[i]);
                }
            }
            
            Menu();
        }
        private static void BewerkStad()
        {
            Program program = new Program();

            if (program.teBewerkenNaam != "")
            {
                for (int i = 0; i < 500; i++)
                {
                    if (program.steden[i] == program.teBewerken)
                    {
                        program.steden[i] = program.teBewerkenNaam;
                    }
                }
            }

            if (program.bewerkInwoners != "")
            {
                for (int i = 0; i <= 500; i++)
                {
                    if (program.steden[i] == program.teBewerken)
                    {
                        program.inwoners[i] = program.bewerkInwoners;
                    }
                }
            }

            Menu();
        }
        private static void VerwijderStad()
        {
            Program program = new Program();

            for (int i = 0; i <= 500; i++)
            {
                if (program.steden[i] == program.teVerwijderen)
                {
                    program.steden[i] = null;
                    program.inwoners[i] = null;
                }
            }

            Menu();
        }
        private static void ZoekStad()
        {
            Program program = new Program();

            for (int i = 0; i <= 500; i++)
            {
                if (program.steden[i] == program.teZoeken)
                {
                    Console.WriteLine("{0} Inwoners: {1}", program.steden[i], program.inwoners[i]);
                }
            }

            Menu();
        }
    }
}
