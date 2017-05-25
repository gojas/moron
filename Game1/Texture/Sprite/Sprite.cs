using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{
    public class Sprite
    {
        public Texture2D Texture { get; private set; }

        public Rectangle SourceRectangle { get; private set; }

        public Vector2 Size { get; private set; }

        public Sprite(Texture2D texture, Rectangle sourceRect, Vector2 size)
        {
            this.Texture = texture;
            this.SourceRectangle = sourceRect;
            this.Size = size;
        }
    }
}