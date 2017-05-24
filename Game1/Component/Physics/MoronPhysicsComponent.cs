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
            Debug.WriteLine(gameObject.position.X + " " + gameObject.position.Y);

            List<GameObject> objects = quadTree.getObjects(gameObject);


            objects.ForEach((returnObject) => {
                
            });

            Debug.Write(objects.Count);
        }
    }
}
