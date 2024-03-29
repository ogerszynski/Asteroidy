using System;
using System.Collections.Generic;

namespace AsteroidsGame
{
    class Gameplay
    {
        private const int screenWidth = 80;
        private const int screenHeight = 24;
        private Statek playerShip;
        private List<Asteroidy> asteroids;
        private List<GameObject> projectiles;

        public Gameplay()
        {
            playerShip = new Statek(screenWidth / 2, screenHeight - 1);
            asteroids = new List<Asteroidy>();
            projectiles = new List<GameObject>();
        }

        public void Run()
        {
            while (true)
            {
                // Obsługa klawiszy klawiatury

                // Aktualizacja stanu gry

                // Wyświetlanie stanu gry

                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
