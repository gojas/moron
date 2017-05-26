namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State;

    public class CommandAS : Command
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.X -= gameObject.speed;
            gameObject.position.Y += gameObject.speed;
            gameObject.state.currentMovementState = MovementState.WALKING_DOWN_LEFT;
        }
    }
}
