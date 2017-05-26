namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State;

    public class CommandSD : Command
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.Y += gameObject.speed;
            gameObject.position.X += gameObject.speed;
            gameObject.state.currentMovementState = MovementState.WALKING_DOWN_RIGHT;
        }
    }
}
