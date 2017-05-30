namespace World.GameObject.State.States
{
    public class StateWalkingDownRight : StateWalking
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.X += gameObject.speed;
            gameObject.position.Y += gameObject.speed;
        }

        public override void Reverse(GameObject gameObject)
        {
            gameObject.position.X -= gameObject.speed;
            gameObject.position.Y -= gameObject.speed;
        }
    }
}
