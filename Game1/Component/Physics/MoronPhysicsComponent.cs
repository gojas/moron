using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.Scene;
    using QuadTree;
    using Core.Service;


    public class MoronPhysicsComponent : PhysicsComponent
    {
        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {

            IsometricCalculator isometricCalculator = ServiceContainer.GetService<IsometricCalculator>();
            Vector2 gameObjectTileCordinates = isometricCalculator.GetTileCoordinates(gameObject.position, 72);

           // Debug.Write(gameObject.position + "\n");

            //Debug.Write(quadTree.getObjects(gameObject).Count);

            // nearby objects...
            quadTree.getObjects(gameObject).ForEach((returnObject) => {

                if (!(returnObject is MoronGameObject)) { // DUNNO why this happens, check getObjects method..
                    Rectangle bla1 = new Rectangle((int)gameObject.position.X, (int)gameObject.position.Y, 128, 64);
                    Rectangle bla2 = new Rectangle((int)returnObject.position.X, (int)returnObject.position.Y, 128, 64);


                    if (CollisionDetection.AreRectanglesColliding(bla1, bla2))
                    {
                        if (null != returnObject.ComponentContainer.GetHealthComponent())
                            returnObject.ComponentContainer.GetHealthComponent().update(gameObject, returnObject);
                    }
                }

                
            });

            
        }
    }
}
