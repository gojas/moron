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
        
        public void Draw(Sprite sprite, Vector2 position, Vector2 origin, Color? color = null)
        {
            spriteBatch.Draw(
                sprite.Texture, 
                position, 
                null, 
                sprite.SourceRectangle, 
                origin, 
                0, 
                sprite.Size, 
                color, 
                SpriteEffects.None, 
                sprite.Depth
            );
        }
    }
}