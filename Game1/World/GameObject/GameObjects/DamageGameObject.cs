namespace World.GameObject
{
    using World.GameObject.State;

    public class DamageGameObject : GameObject
    {
        public DamageGameObject()
        {
            this.GameObjectStateContainer = new GameObjectStateContainer(this);

        }
    }
}
