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

            

           // Debug.Write(gameObject.position + "\n");

            //Debug.Write(quadTree.getObjects(gameObject).Count);

            // nearby objects...
            quadTree.getObjects(gameObject).ForEach((returnObject) => {

                if (!(returnObject is MoronGameObject) && !(returnObject.ComponentContainer.GetPhysicsComponent() is GrassPhysicsComponent)) { // DUNNO why this happens, check getObjects method..
                    Rectangle bla1 = new Rectangle((int)gameObject.position.X + 59, (int)gameObject.position.Y + 105, 10, 2); // player movement box, imagine rectangle at the bottom of the character
                    Rectangle bla2 = new Rectangle((int)returnObject.position.X, (int)returnObject.position.Y + 64 /* HEIGHT */, 128, 64);


                    if (CollisionDetection.AreRectanglesColliding(bla1, bla2))
                    {
                        gameObject.Color = Color.Red;
                        gameObject.GameObjectStateContainer.GetPrevious().Reverse(gameObject);
                        // if (null != returnObject.ComponentContainer.GetHealthComponent())
                        // returnObject.ComponentContainer.GetHealthComponent().update(gameObject, returnObject);
                    }
                    else {
                        gameObject.Color = Color.White;
                    }
                }

                
            });

            
        }
    }
}
