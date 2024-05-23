using System;

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
                        JuniorOrSenior();
                        break;
                    case "2":
                        // Kod för "Beräkna pris för ett sällskap"
                        GroupFee();
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

        // Klass för "Ungdom eller pensionär"
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

        // Klass för "Beräkna pris för ett sällskap"
        static void GroupFee() 
        {
            Console.WriteLine("Hur många personer är ni i sällskapet? ");
            string personCountInput = Console.ReadLine();

            if (int.TryParse(personCountInput, out int personCount)) // Läsa och konvertera input för antal personer till en integer
            {
                int totalPrice = 0; // Variabel för att börja beräkningen av summan från 0
                for (int i = 1; i <= personCount; i++)
                {
                    Console.WriteLine($"Ange ålder för person {i}: ");
                    string ageInput = Console.ReadLine(); // Input av åldern läsas som en sträng
                    if (int.TryParse(ageInput, out int age)) // Åldern konverteras till en int, om möjligt
                    {
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

                Console.WriteLine($"Antal personer i sällskapet: {personCount} st");
                Console.WriteLine($"Totalkostnad för hela sällskapet: {totalPrice} kr");
            }
            else 
            {
                Console.WriteLine("Felaktig input av antal personer, försök igen.");
            }

            //Variabler i klass GroupFee():
            /*
             * personCountInput: sträng som lagrar antalet personer som användaren anger
             * personCount: heltalsvariabel som lagrar det konverterade värdet från personCountInput efter validering med int.TryParse
             * totalPrice: heltalsvariabel som summerar totalkostnaden för hela sällskapet
             * ageInput: sträng som lagrar åldern för varje person i sällskapet
             * age: heltalsvariabel som lagrar den konverterade åldern från ageInput efter validering med int.TryParse
             * ticketPrice: heltalsvariabel som lagrar biljettpriset baserat på personens ålder
             */
        }







    }
}




