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

            // UPDATE gameObject.position


            // use Command Pattern
            // gameObject.update(command.up()) something like that
        }
    }
}
