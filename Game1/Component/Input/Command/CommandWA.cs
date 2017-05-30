namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandWA : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingUpLeft();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

}




