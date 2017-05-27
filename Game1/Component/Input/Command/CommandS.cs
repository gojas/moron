namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State;

    public class CommandS : Command
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.Y += gameObject.speed;
            gameObject.State.currentMovementState = MovementState.WALKING_DOWN;
        }
    }
}
