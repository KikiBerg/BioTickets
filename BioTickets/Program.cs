﻿namespace BioTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool programIsRunning = true; // Variabel som styr om programmet ska fortsätta köra
            while (programIsRunning) // Oändlig loop för att hålla programmet vid liv tills användaren väljer att avsluta
            {
                Console.WriteLine("Välkommen till huvudmenyn! Navigera genom att skriva in siffror för att testa olika funktioner.");
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("0. Avsluta programmet");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Beräkna pris för ett sällskap");
                Console.WriteLine("3. Upprepa tio gånger");
                Console.WriteLine("4. Det tredje ordet");

                Console.Write("Vänligen ange ditt val: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Programmet avslutas");
                        programIsRunning = false; // loopen stoppas här och programmet avslutas 
                        break;
                    case "1":
                        // Kod för "Ungdom eller pensionär"
                        break;
                    case "2":
                        // Kod för "Beräkna pris för ett sällskap"
                        break;
                    case "3":
                        // Kod för "Upprepa tio gånger"
                        break;
                    case "4":
                        // Kod för "Det tredje ordet"
                        break;
                    default:
                        Console.WriteLine("Din input var felaktig, försök igen och ange enbart en siffra mellan 0-4.");
                        break;
                }
            }
        }

        static void JuniorOrSenior() 
        {
            Console.WriteLine("Ange din ålder: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age)) 
            { 
                if (age < 5 || age < 100) 
                {
                    Console.WriteLine("Du får gratis inträde!");
                }
                else if (age < 20) 
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr");
                }
            }
            else 
            {
                Console.WriteLine("Felaktig ålder, försök igen.");
            }
            
        }





    }
}




