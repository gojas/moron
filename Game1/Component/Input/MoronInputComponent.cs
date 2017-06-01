using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State;
    using World.GameObject.State.States;
    using World.GameObject.Item;
    using Game1;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Game1 game)
        {
            KeyboardState state = Keyboard.GetState();

            // gameObject.State.currentMovementState = MovementState.STANDING;

            string pressedKeysString = "";

            foreach (Keys pressedKey in state.GetPressedKeys())
            {
                pressedKeysString += pressedKey.ToString();
            }

            // jedi govna... set invalid keys!
            if (pressedKeysString.Length > 2)
            {
                pressedKeysString = "";
            }

            

           
            
            Command command = CommandFactory.Get(pressedKeysString);


            command.Update(gameObject);

            game.getCamera().Position = gameObject.position;


            



        }
    }
}
