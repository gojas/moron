using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.Scene;
    using QuadTree;
    using Microsoft.Xna.Framework.Input;

    public class ArrowPhysicsComponent : PhysicsComponent
    {
        Vector2 targetPosition;

        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {
            MouseState mouseState = Mouse.GetState();

            float mousePositionX = mouseState.Position.X;
            float mousePositionY = mouseState.Position.Y;

            Vector2 mousePosition = new Vector2(mousePositionX, mousePositionY);

            if(targetPosition == default(Vector2)) // if removed, some cool stuff will happen :D
                targetPosition = mousePosition;

            float distance = Vector2.Distance(gameObject.position, targetPosition);

            Vector2 direction = Vector2.Normalize(targetPosition - gameObject.position);

            gameObject.position += direction * 50;

            if (Vector2.Distance(targetPosition, gameObject.position) >= distance)
            {
                gameObject.Destroyed = true;
            }

            // nearby objects...
            quadTree.getObjects(gameObject).ForEach((returnObject) => {
                

            });

        }
    }
}
