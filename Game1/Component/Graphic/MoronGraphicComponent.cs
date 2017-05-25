using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Texture;

    public class MoronGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime)
        {
            // gameObject.state as first param
            Sprite sprite = gameObject.animationContainer.getCurrentSprite("cowboy", gameObject.state, gameTime);

            spriteRender.Draw(sprite, gameObject.position);
        }
    }
}
