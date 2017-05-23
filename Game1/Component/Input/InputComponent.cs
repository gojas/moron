using Microsoft.Xna.Framework.Input;
using Object;

namespace Component
{
    public class InputComponent : Component
    {

        public override void update(GameObject gameObject)
        {
            KeyboardState state = Keyboard.GetState();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (state.IsKeyDown(Keys.D))
                gameObject.position.X += gameObject.speed;
            if (state.IsKeyDown(Keys.A))
                gameObject.position.X -= gameObject.speed;
            if (state.IsKeyDown(Keys.W))
                gameObject.position.Y -= gameObject.speed;
            if (state.IsKeyDown(Keys.S))
                gameObject.position.Y += gameObject.speed;
        }
    }
}
