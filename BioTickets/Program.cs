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

            }


        }
    }
}
