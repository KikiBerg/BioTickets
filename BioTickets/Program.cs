using System;
using System.Security.Cryptography;

namespace BioTickets
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
                Console.WriteLine("2. Beräkna pris för ett sällskap samt få statistik för sällskapet");
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
                        JuniorOrSenior();
                        break;
                    case "2":
                        // Kod för "Beräkna pris för ett sällskap"
                        GroupFee();
                        break;
                    case "3":
                        // Kod för "Upprepa tio gånger"
                        RepeatTenTimes();
                        break;
                    case "4":
                        // Kod för "Det tredje ordet"
                        ThirdWordExtractor();
                        break;
                    default:
                        Console.WriteLine("Din input var felaktig, försök igen och ange enbart en siffra mellan 0-4.");
                        break;
                }
            }
        }

        // Klass för "Ungdom eller pensionär" case 1
        static void JuniorOrSenior() 
        {
            Console.WriteLine("Ange din ålder: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age)) 
            { 
                if (age < 5 || age > 100) 
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

        // Klass för "Beräkna pris för ett sällskap" case 2
        /* Utveckla klassen genom att beräkna statistik för
         * genomsnittsålder, yngsta och äldsta personen samt
         * antal barn, vuxna och pensionärer         
         */
        static void GroupFee() 
        {
            Console.WriteLine("Hur många personer är ni i sällskapet? ");
            string personCountInput = Console.ReadLine();

            if (int.TryParse(personCountInput, out int personCount)) // Läsa och konvertera input för antal personer till en integer
            {
                int totalPrice = 0; // Variabel för att börja beräkningen av summan från 0
                List<int> ages = new List<int>(); // Lista för att lagra åldrarna


                for (int i = 1; i <= personCount; i++)
                {
                    Console.WriteLine($"Ange ålder för person {i}: ");
                    string ageInput = Console.ReadLine(); // Input av åldern läsas som en sträng

                    if (int.TryParse(ageInput, out int age)) // Åldern konverteras till en int, om möjligt
                    {
                        ages.Add(age); // Åldern läggs till i listan

                        int ticketPrice; // Variabel för att spara biljettpriset

                        if (age < 5 || age > 100)
                        {
                            ticketPrice = 0;
                        }

                        else if (age < 20)
                        {
                            ticketPrice = 80;
                        }

                        else if (age > 64)
                        {
                            ticketPrice = 90;
                        }

                        else
                        {
                            ticketPrice = 120;
                        }

                        totalPrice += ticketPrice; // Lägger till biljettpriset till totalkostnaden
                    }
                    else 
                    {
                        Console.WriteLine("Felaktig input av ålder, försök igen.");
                        i--;
                    }
                    
                }

                // Statistika beräkningar här:
                int youngestAge = ages.Min();
                int oldestAge = ages.Max();
                double averageAge = ages.Average();

                // Räkna antalet barn, vuxna och pensionärer
                int numChildren = ages.Count(age => age < 20);
                int numAdults = ages.Count(age => age >= 20 && age <= 64);
                int numPensioners = ages.Count(age => age > 64);


                Console.WriteLine($"Antal personer i sällskapet: {personCount} st");
                Console.WriteLine($"Totalkostnad för hela sällskapet: {totalPrice} kr");
                Console.WriteLine($"Yngsta personen i det här sällskapet är: {youngestAge} år gammal");
                Console.WriteLine($"Äldsta personen i det här sällskapet är: {oldestAge} år gammal");
                Console.WriteLine($"Genomsnittsålder i det här sällskapet är: {averageAge}");
                Console.WriteLine($"Antal barn som finns: {numChildren} st");
                Console.WriteLine($"Antal vuxna som finns: {numAdults} st");
                Console.WriteLine($"Antal pensionärer som finns: {numPensioners} st");
            }
            else 
            {
                Console.WriteLine("Felaktig input, försök igen.");
            }


            //Variabler i klass GroupFee():
            /*
             * personCountInput: lagrar antalet personer som användaren anger (string)
             * personCount: Lagrar det konverterade värdet från personCountInput efter validering med int.TryParse (int)
             * totalPrice: Summerar totalkostnaden för hela sällskapet (int)
             * ages: Lagrar åldrarna på personerna i sällskapet (List<int>)
             * ageInput: Lagrar åldern för varje person i sällskapet (string)
             * age: Lagrar den konverterade åldern från ageInput efter validering med int.TryParse (int)
             * ticketPrice: Lagrar biljettpriset för en specifik person baserat på personens ålder (int)
             * youngestAge: Lagrar den yngsta åldern i sällskapet (int)
             * oldestAge: Lagrar den äldsta åldern i sällskapet (int)
             * averageAge: Lagrar genomsnittsåldern för sällskapet (double)
             * numChildren: Lagrar antalet barn (under 20 år) i sällskapet (int)
             * numAdults: Lagrar antalet vuxna (20-64 år) i sällskapet (int)
             * numPensioners: Lagrar antalet pensionärer (över 64 år) i sällskapet (int)
             */
        }

        // Klass för "Upprepa tio gånger" case 3
        static void RepeatTenTimes() 
        {
            Console.WriteLine("Ange en text: ");
            string input = Console.ReadLine();

            for (int i = 0; i<10; i++) 
            { 
                Console.Write(input);
            }
            Console.WriteLine();
        }

        // Klass för "Det tredje ordet" case 4
        static void ThirdWordExtractor()
        {
            Console.WriteLine("Ange en mening: ");
            string userSentence = Console.ReadLine();

            string[] words = userSentence.Split(' '); // Meningen delas upp i ord baserat på mellanslag och resultatet sparas i en array av strängar

            if (words.Length >= 3) // Kontrollera att arrayen words innehåller minst tre element
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}");
            }
            else
            {
                Console.WriteLine("Meningen skall innehålla minst tre ord.");
            }
        }



    }
}




