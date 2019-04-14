using System;

namespace RST.Command
{
    public class Car : IUnit, ISupportMove
    {
        public void Move(MoveCommand command)
        {
            Console.WriteLine($"Car is moving");
        }
    }
}
