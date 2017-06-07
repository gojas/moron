using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.Scene;
    using QuadTree;
    using Microsoft.Xna.Framework.Input;
    using Core.Service;

    public class ArrowPhysicsComponent : PhysicsComponent
    {
        Vector2 targetPosition;
        bool targetIsHit = false;

        public override void update(GameObject arrow, QuadTree quadTree, SceneManager sceneManager)
        {
            MouseState mouseState = Mouse.GetState();

            targetIsHit = false;

            float mousePositionX = mouseState.Position.X;
            float mousePositionY = mouseState.Position.Y;

            Vector2 mousePosition = new Vector2(mousePositionX, mousePositionY);

            if(targetPosition == default(Vector2)) // if removed, some cool stuff will happen :D
                targetPosition = mousePosition;

            float distance = Vector2.Distance(arrow.position, targetPosition);

            Vector2 direction = Vector2.Normalize(targetPosition - arrow.position);

            arrow.position += direction * 50;

            quadTree.getObjects(arrow).ForEach((returnObject) => {
                if (!(returnObject is DamageGameObject) && !(returnObject is MoronGameObject)) // FIIIIIIIX
                {
                    Rectangle arrowRectangle = new Rectangle((int)arrow.position.X, (int)arrow.position.Y, 128, 128);
                    Rectangle targetObjectRectangle = new Rectangle((int)returnObject.position.X, (int)returnObject.position.Y, 128, 64);

                    if (CollisionDetection.AreRectanglesColliding(arrowRectangle, targetObjectRectangle) && 
                        null != returnObject.ComponentContainer.GetHealthComponent()
                    )
                    {
                        returnObject.Damaged = true;
                        returnObject.ComponentContainer.GetHealthComponent().update(arrow, returnObject);
                        targetIsHit = true;
                         
                    }
                }

            });

            if (Vector2.Distance(targetPosition, arrow.position) >= distance || targetIsHit)
            {
                arrow.Destroyed = true;
            }

        }
    }
}
