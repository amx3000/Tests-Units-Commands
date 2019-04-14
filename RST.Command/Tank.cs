using System;

namespace RST.Command
{
    public class Tank : IUnit, ISupportMove, ISupportFire
    {
        public void Move(MoveCommand command)
        {
            Console.WriteLine($"Tank is moving");
        }
        public void Fire(FireCommand command)
        {
            Console.WriteLine($"Tank is firing");
        }
    }
}