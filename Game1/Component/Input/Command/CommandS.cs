namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandS : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingDown();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }
}
