using RST.Command;

namespace SBT.Test
{
    public class RotateCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is ISupportRotate rotatableUnit)
                rotatableUnit.Rotate(this);
        }
    }
}