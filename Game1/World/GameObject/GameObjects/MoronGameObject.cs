namespace World.GameObject
{
    using World.GameObject.State;

    public class MoronGameObject: GameObject
    {
        

        public MoronGameObject()
        {
            this.GameObjectStateContainer = new GameObjectStateContainer(this);
            
        }
    }
}
