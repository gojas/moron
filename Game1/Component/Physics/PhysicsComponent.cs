using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.Scene;
    using QuadTree;
    using Core.Service;

    public class PhysicsComponent : Component
    {
        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {
            quadTree.getObjects(gameObject).ForEach((returnObject) => {

                Rectangle rect1 = new Rectangle((int)gameObject.position.X, (int)gameObject.position.Y, 128, 128);
                Rectangle rect2 = new Rectangle((int)returnObject.position.X, (int)returnObject.position.Y, 128, 128);

                if (CollisionDetection.AreRectanglesColliding(rect1, rect2))
                {
                    if (null != gameObject.ComponentContainer.GetScriptComponent() && returnObject is MoronGameObject)
                    {
                        gameObject.ComponentContainer.GetScriptComponent().update(gameObject, quadTree, sceneManager);
                    }
                }
            });
        }
    }
}
