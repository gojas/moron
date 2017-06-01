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

                Rectangle bla1 = new Rectangle((int)gameObject.position.X + 50, (int)gameObject.position.Y + 22, 54, 44);
                Rectangle bla2 = new Rectangle((int)returnObject.position.X, (int)returnObject.position.Y, 128, 64);



                if (CollisionDetection.AreRectanglesColliding(bla1, bla2))
                {
                    // TODO :: make PlayerGameObject and run && return gameObject is PlayerGameObject
                    if (null != gameObject.ComponentContainer.GetScriptComponent() && null != returnObject.ComponentContainer.GetInputComponent())
                    {
                        gameObject.ComponentContainer.GetScriptComponent().update(gameObject, quadTree, sceneManager);
                    }
                }
            });
        }
    }
}
