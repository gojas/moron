using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using Comora;
    using World.GameObject.State.States;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Camera camera)
        {
            KeyboardState state = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            // gameObject.State.currentMovementState = MovementState.STANDING;

            
            /**
            if (mouseState.LeftButton == ButtonState.Pressed)
                pressedKeysString += "LeftMouse";

            if (mouseState.RightButton == ButtonState.Pressed)
                pressedKeysString += "RightMouse";

            **/

            Command command = CommandFactory.Get(state);



            


            command.Update(gameObject);

            camera.Position = gameObject.position;


            



        }
    }
}
