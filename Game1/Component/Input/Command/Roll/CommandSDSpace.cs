namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandSDSpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingDownRight();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandDSSpace : CommandSDSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceDS : CommandSDSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceSD : CommandSDSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

}
