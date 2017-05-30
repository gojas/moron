namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandSD : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingDownRight();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }
}
