using Microsoft.Xna.Framework;
using Component.Input;
using Component.Physics;
using Component.Graphic;

namespace Object
{
    public class GameObject : IGameObject
    {
        Vector2 position;
        InputComponent inputComponent;
        PhysicsComponent physicsComponent;
        GraphicComponent graphicComponent;

        public GameObject(
            InputComponent aInputComponent,
            PhysicsComponent aPhysicsComponent,
            GraphicComponent aGraphicComponent
        )
        {
            inputComponent = aInputComponent;
            physicsComponent = aPhysicsComponent;
            graphicComponent = aGraphicComponent;
        }

        public void updateInput()
        {
            inputComponent.update(this);
        }

        public void updatePhysics()
        {
            physicsComponent.update(this);
        }

        public void updateGraphic()
        {
            graphicComponent.update(this);
        }
    }
}
