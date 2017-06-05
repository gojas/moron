namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandAS : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateWalkingDownLeft();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandSA : CommandAS
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}
