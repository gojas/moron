using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{
    public class SpriteRender
    {
        private SpriteBatch spriteBatch;

        public SpriteRender(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }
        
        public void Draw(Sprite sprite, Vector2 position, Color? color = null)
        {
            spriteBatch.Draw(
                texture: sprite.Texture,
                position: position,
                sourceRectangle: sprite.SourceRectangle,
                scale: sprite.Size,
                color: color);
        }
    }
}