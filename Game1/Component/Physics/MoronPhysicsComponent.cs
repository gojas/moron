using Object;
using QuadTree;
using System.Collections.Generic;
using System.Diagnostics;

namespace Component
{
    public class MoronPhysicsComponent : PhysicsComponent
    {

        public override void update(GameObject gameObject, QuadTree.QuadTree quadTree)
        {
            QuadTreeObject quadTreeObject = new QuadTreeObject(gameObject.position.X, gameObject.position.Y, 10, 10);
            quadTree.insert(quadTreeObject);

            Debug.WriteLine(gameObject.position.X + " " + gameObject.position.Y);

            List<QuadTreeObject> objects = quadTree.retrieve(quadTreeObject);

            Debug.WriteLine(objects.Count);
        }
    }
}
