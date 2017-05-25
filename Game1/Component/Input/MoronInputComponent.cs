using Microsoft.Xna.Framework.Input;

namespace Component
{
    using World.GameObject;
    using Game1;

    public class MoronInputComponent : InputComponent
    {
        public override void update(GameObject gameObject, Game1 game)
        {
            KeyboardState state = Keyboard.GetState();

            foreach (Keys pressedKey in state.GetPressedKeys()) {
                switch (pressedKey)
                {
                    case Keys.W: // up
                        gameObject.position.Y -= gameObject.speed;
                        gameObject.state = State.STATE_WALKING_UP;
                        break;
                    case Keys.S: // down
                        gameObject.position.Y += gameObject.speed;
                        gameObject.state = State.STATE_WALKING_DOWN;
                        break;
                    case Keys.A: // left
                        gameObject.position.X -= gameObject.speed;
                        gameObject.state = State.STATE_WALKING_LEFT;
                        break;
                    case Keys.D: // rigth
                        gameObject.position.X += gameObject.speed;
                        gameObject.state = State.STATE_WALKING_RIGHT;
                        break;
                }

            }

            game.getCamera().Position = gameObject.position;
        }
    }
}
