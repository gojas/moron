using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{
    public class SpriteRender
    {
        public SpriteBatch SpriteBatch;

        public SpriteRender(SpriteBatch SpriteBatch)
        {
            this.SpriteBatch = SpriteBatch;
        }
        
        public void Draw(Sprite sprite, Vector2 position, Color? color = null)
        {

            SpriteBatch.Draw(
                sprite.Texture, 
                position, 
                null, 
                sprite.SourceRectangle, 
                new Vector2(0, sprite.SourceRectangle.Height), // sprite.SourceRectangle.Height render from bottom left corner
                0, 
                sprite.Size, 
                color, 
                SpriteEffects.None, 
                sprite.Depth
            );
        }
    }
}