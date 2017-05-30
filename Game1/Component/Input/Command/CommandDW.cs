namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandDW : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingUpRight();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }
}
