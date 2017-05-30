namespace World.GameObject.State
{
    using States;
    using System.Collections.Generic;

    public class GameObjectStateContainer
    {
        GameObject gameObject;

        public State State;

        public List<State> StateList = new List<State>();

        public GameObjectStateContainer(GameObject gameObject)
        {
            this.gameObject = gameObject;

            StateList.Add(new StateStanding());
        }

        public void Change(State state)
        {
            StateList.Clear();
            StateList.Add(state);
        }

        public State GetPrevious()
        {
            return StateList[0];
        }
    }

}
