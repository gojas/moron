using Microsoft.Xna.Framework.Input;
using Object;

namespace Component
{
    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject)
        {
            base.update(gameObject);

            gameObject.getGame().getCamera().Position = gameObject.position;
        }
    }
}
