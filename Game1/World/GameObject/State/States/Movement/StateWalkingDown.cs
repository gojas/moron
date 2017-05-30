﻿namespace World.GameObject.State.States
{
    public class StateWalkingDown : StateWalking
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.Y += gameObject.speed;
        }

        public override void Reverse(GameObject gameObject)
        {
            gameObject.position.Y -= gameObject.speed;
        }
    }
}
