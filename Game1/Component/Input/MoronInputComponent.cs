using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State;
    using World.GameObject.Item;
    using Game1;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Game1 game)
        {
            KeyboardState state = Keyboard.GetState();

            gameObject.state.currentMovementState = MovementState.STANDING;

            gameObject.state.SetCurrentWeaponName("Pistol");

            GameObjectItem weapon = gameObject.GetWeaponItem("Pistol");


            string bla = "";

            foreach (Keys pressedKey in state.GetPressedKeys()) {
                bla += pressedKey.ToString();
            }



            // Command 
            // CommandAW

            //CommandW

            Command command = CommandFactory.Get(bla);

            command.Update(gameObject);

            System.Diagnostics.Debug.Write(bla);
            game.getCamera().Position = gameObject.position;
        }
    }
}
