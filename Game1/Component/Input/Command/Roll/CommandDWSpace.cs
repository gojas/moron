namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandDWSpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingUpRight();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandWDSpace : CommandDWSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceWD : CommandDWSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceDW : CommandDWSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}
