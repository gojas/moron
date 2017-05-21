using Microsoft.Xna.Framework.Input;

namespace Component.Input
{
    public class InputComponent : AbstractComponent
    {

        public override void update(IGameObject gameObject)
        {

            KeyboardState state = Keyboard.GetState();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // UPDATE gameObject.position


            // use Command Pattern
            // gameObject.update(command.up()) something like that
        }
    }
}
