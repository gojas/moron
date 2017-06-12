using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.Scene;
    using QuadTree;
    using Core.Service;
    using World.GameObject.State.States;

    public class GrassPhysicsComponent : PhysicsComponent
    {

        Vector2 defaultPosition;

        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {
            gameObject.GameObjectStateContainer.Change(new StateStanding()); // hm return state with easing somehow

            if (defaultPosition == default(Vector2))
                defaultPosition = gameObject.position;

            gameObject.position = defaultPosition;

            quadTree.getObjects(gameObject).ForEach((returnObject) => {

                // if gameObject->GetCollideBox().Position..
                Rectangle bla1 = new Rectangle((int)returnObject.position.X + 59, (int)returnObject.position.Y + 105, 10, 2); // player movement box, imagine rectangle at the bottom of the character
                Rectangle bla2 = new Rectangle((int)gameObject.position.X, (int)gameObject.position.Y + 64 /* HEIGHT */, 128, 64);

                if (CollisionDetection.AreRectanglesColliding(bla1, bla2))
                {

                    if (returnObject is MoronGameObject && returnObject.GameObjectStateContainer.GetPrevious() is StateWalking)
                    {
                        gameObject.GameObjectStateContainer.Change(new StateWaving());
                    }
                }
            });
        }
    }
}
