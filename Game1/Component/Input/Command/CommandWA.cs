namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State;

    public class CommandWA : Command
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.Y -= gameObject.speed;
            gameObject.position.X -= gameObject.speed;
            gameObject.state.currentMovementState = MovementState.WALKING_UP_LEFT;
        }
    }

}




