using Microsoft.Xna.Framework.Input;

namespace Component
{
    using GameObject;
    using Game1;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Game1 game)
        {
            base.update(gameObject, game);

            game.getCamera().Position = gameObject.position;
        }
    }
}
