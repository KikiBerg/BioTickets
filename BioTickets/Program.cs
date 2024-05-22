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
                // Lägg till extra validering för använderns input
                // Försöker konvertera användarens input till en integer
                // Om det misslyckas, informera användaren och fortsätt loopen
                if (int.TryParse(Console.ReadLine(), out int input)) 
                {
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
                            Console.WriteLine("Din input var felaktig, försök igen!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Din input var inte rätt, ange enbart en siffra mellan 0-4.");
                }
            }
        }


    }
}




