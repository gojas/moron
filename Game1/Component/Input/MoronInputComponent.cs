using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using Comora;
    using Core.Service;
    using World.GameObject.State.States;
    using Microsoft.Xna.Framework;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Camera camera)
        {
            KeyboardState state = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            // gameObject.State.currentMovementState = MovementState.STANDING;



            if (mouseState.LeftButton == ButtonState.Pressed) {
                IsometricCalculator isometricCalculator = ServiceContainer.GetService<IsometricCalculator>();
                Vector2 gameObjectTileCordinates = isometricCalculator.GetTileCoordinates(gameObject.position, 128);


                System.Diagnostics.Debug.Write(gameObject.position.X + "\n");
                System.Diagnostics.Debug.Write(gameObject.position.Y + "\n");
                System.Diagnostics.Debug.Write(gameObjectTileCordinates + "\n");
            }
                
            /**
            if (mouseState.RightButton == ButtonState.Pressed)
                pressedKeysString += "RightMouse";

            **/

            Command command = CommandFactory.Get(state);



            


            command.Update(gameObject);

            camera.Position = gameObject.position;


            



        }
    }
}
