﻿namespace Component.Input.Command
{
    using World.GameObject;
    using World.GameObject.State.States;

    public class CommandWSpace : Command
    {
        public override void Update(GameObject gameObject)
        {
            State state = new StateRollingUp();

            gameObject.GameObjectStateContainer.Change(state);

            state.Update(gameObject);
        }
    }

    public class CommandSpaceW : CommandWSpace
    {
        public override void Update(GameObject gameObject)
        {
            base.Update(gameObject);
        }
    }
}
