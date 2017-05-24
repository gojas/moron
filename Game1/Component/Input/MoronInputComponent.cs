using Microsoft.Xna.Framework.Input;

namespace Component
{
    using GameObject;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject)
        {
            base.update(gameObject);

            gameObject.getGame().getCamera().Position = gameObject.position;
        }
    }
}
