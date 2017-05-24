using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{
    public class Sprite
    {
        public Texture2D Texture { get; private set; }

        public Rectangle SourceRectangle { get; private set; }

        public Vector2 Size { get; private set; }

        public Vector2 Origin { get; private set; }

        public Sprite(Texture2D texture, Rectangle sourceRect, Vector2 size)
        {
            this.Texture = texture;
            this.SourceRectangle = sourceRect;
            this.Size = size;
        }

        public Sprite(Texture2D texture, Rectangle sourceRect, Vector2 size, Vector2 pivotPoint)
        {
            this.Texture = texture;
            this.SourceRectangle = sourceRect;
            this.Size = size;
            this.Origin = new Vector2(sourceRect.Width * pivotPoint.X, sourceRect.Height * pivotPoint.Y);
        }
    }
}