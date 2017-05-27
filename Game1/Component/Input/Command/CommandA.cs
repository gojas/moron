namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State;

    public class CommandA : Command
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.X -= gameObject.speed;
            gameObject.State.currentMovementState = MovementState.WALKING_LEFT;
        }
    }
}



