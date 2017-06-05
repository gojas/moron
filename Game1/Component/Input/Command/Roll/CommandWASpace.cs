namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandWASpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingUpLeft();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandAWSpace : CommandWASpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceAW : CommandWASpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }

    public class CommandSpaceWA : CommandWASpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}




