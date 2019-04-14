namespace RST.Command
{
    public interface ICommand
    {
        void Execute(IUnit unit);
    }

    public class MoveCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is ISupportMove movableUnit)
                movableUnit.Move(this);
        }
    }

    public class FireCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is ISupportFire fireableUnit)
                fireableUnit.Fire(this);
        }
    }
}