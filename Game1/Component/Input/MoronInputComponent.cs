using Microsoft.Xna.Framework.Input;

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

            foreach (Keys pressedKey in state.GetPressedKeys()) {
                switch (pressedKey)
                {
                    case Keys.W: // up
                        gameObject.position.Y -= gameObject.speed;
                        gameObject.state.currentMovementState = MovementState.WALKING_UP;
                        break;
                    case Keys.S: // down
                        gameObject.position.Y += gameObject.speed;
                        gameObject.state.currentMovementState = MovementState.WALKING_DOWN;
                        break;
                    case Keys.A: // left
                        gameObject.position.X -= gameObject.speed;
                        gameObject.state.currentMovementState = MovementState.WALKING_LEFT;
                        break;
                    case Keys.D: // rigth
                        gameObject.position.X += gameObject.speed;
                        gameObject.state.currentMovementState = MovementState.WALKING_RIGHT;
                        break;
                    case Keys.G: // mouse click :S
                        // gameObject. = MovementState.WALKING_RIGHT;
                        break;
                }

            }
            System.Diagnostics.Debug.Write(gameObject.position);
            game.getCamera().Position = gameObject.position;
        }
    }
}
