namespace Component.Input.Command
{

    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandD : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingRight();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }
}
