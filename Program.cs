namespace HængEnMand
{
    class Hang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Hangman spillet\nTryk på enter for at fortsætte!");
            while (Console.ReadKey().Key == ConsoleKey.Enter) 
            {
              Console.WriteLine("Tryk 1 for en spiller\ntryk 2 for 2 spillere!");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.WriteLine("Du har valgt singleplayer");
                    return;

                }
                else if (Console.ReadKey().Key == ConsoleKey.B)
                { 
                    Console.WriteLine("Du har valgt multiplayer");
                    return;

                }
            }            

        }  

    }
}

