namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State;
    using World.GameObject.State.States;

    public class CommandA : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingLeft();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }
}



