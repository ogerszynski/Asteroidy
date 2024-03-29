using System;

namespace AsteroidsGame
{
    class Statek : GameObject
    {
        public Statek(int x, int y) : base(x, y)
        {
        }

        public void MoveLeft()
        {
            if (X > 0)
                X -= 1;
        }

        public void MoveRight(int screenWidth)
        {
            if (X < screenWidth - 1)
                X += 1;
        }

        public void Shoot(List<GameObject> projectiles)
        {
            projectiles.Add(new Strzal(X, Y - 1));
        }
    }
}
