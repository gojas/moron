﻿namespace World.GameObject.State.States
{
    public class StateRollingRight : StateRolling
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.X += gameObject.speed + ROLLING_SPEED;
        }

        public override void Reverse(GameObject gameObject)
        {
            gameObject.position.X -= gameObject.speed + ROLLING_SPEED;
        }
    }
}
