namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandSSpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingDown();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandSpaceS : CommandSSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}
