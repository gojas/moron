﻿namespace Component.Input.Command
{

    using World.GameObject;
    using World.GameObject.State;

    public class CommandD : Command
    {
        public override void Update(GameObject gameObject)
        {
            gameObject.position.X += gameObject.speed;
            gameObject.state.currentMovementState = MovementState.WALKING_RIGHT;
        }
    }
}
