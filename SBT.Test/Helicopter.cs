using System;
using RST.Command;

namespace SBT.Test
{
    public class Helicopter : IUnit, ISupportMove, ISupportRotate
    {
        public void Move(MoveCommand command)
        {
            Console.WriteLine($"Helicopter is moving");
        }

        public void Rotate(RotateCommand command)
        {
            Console.WriteLine($"Helicopter is rotating");
        }
    }
}