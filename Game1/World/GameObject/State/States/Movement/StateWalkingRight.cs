namespace World.GameObject.State.States
{
    public class StateWalkingRight : StateWalking
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.X += gameObject.speed;
        }

        public override void Reverse(GameObject gameObject)
        {
            gameObject.position.X -= gameObject.speed;
        }
    }
}
