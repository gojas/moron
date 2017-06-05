namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandDSpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingRight();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandSpaceD : CommandDSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}



