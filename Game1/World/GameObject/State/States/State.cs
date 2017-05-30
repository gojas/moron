namespace World.GameObject.State.States
{
    public class State
    {

        public virtual void Update(GameObject gameObject)
        {

        }

        public virtual void Reverse(GameObject gameObject)
        {

        }

        public string GetStateAsAString()
        {
            return GetType().Name.Replace(@"State", string.Empty);
        }
    }
}
