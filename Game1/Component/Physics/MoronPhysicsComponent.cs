namespace Component
{
    using GameObject;
    using QuadTree;

    public class MoronPhysicsComponent : PhysicsComponent
    {
        public override void update(GameObject gameObject, QuadTree quadTree)
        {
            // nearby objects...
            quadTree.getObjects(gameObject).ForEach((returnObject) => {
                
            });
        }
    }
}
