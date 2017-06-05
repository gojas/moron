namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandASSpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingDownLeft();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandSASpace : CommandASSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceSA : CommandASSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceAS : CommandASSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}
