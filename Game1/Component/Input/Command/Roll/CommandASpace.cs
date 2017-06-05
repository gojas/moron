namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandASpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingLeft();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandSpaceA : CommandASpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}



