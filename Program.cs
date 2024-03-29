using System;

namespace AsteroidsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Gameplay game = new Gameplay();
            game.Run();

            Console.WriteLine("koniec gry, nacisnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
