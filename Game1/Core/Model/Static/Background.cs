using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Core.Model
{
    class Background : AbstractModel
    {
        Texture2D texture;

        public Background(Texture2D aTexture)
        {
            texture = aTexture;
        }

        public override void Update()
        {
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            
            spriteBatch.Draw(texture, new Rectangle(0, 0, 800, 480), Color.White);
        }

    }
}
