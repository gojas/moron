namespace World.GameObject.State.States
{
    public class StateRollingUp : StateRolling
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.Y -= gameObject.speed + ROLLING_SPEED;
        }

        public override void Reverse(GameObject gameObject)
        {
            gameObject.position.Y += gameObject.speed + ROLLING_SPEED;
        }
    }
}
