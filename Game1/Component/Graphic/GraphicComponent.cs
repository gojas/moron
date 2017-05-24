using Microsoft.Xna.Framework;

namespace Component
{
    using GameObject;
    using Texture;

    public class GraphicComponent : Component
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender)
        {
            Sprite sprite = gameObject.spriteSheetContainer.Sprite("cowboy_0_0");

            spriteRender.Draw(sprite, gameObject.position);
        }
    }
}
