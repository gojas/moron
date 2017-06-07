using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Texture
{
    public class Sprite
    {
        public const int TILE_TEXTURE_WIDTH = 128;
        public const int TILE_TEXTURE_HEIGHT = 128;

        public const int TEXTURE_WIDTH = 128;
        public const int TEXTURE_HEIGHT = 72;

        public Texture2D Texture { get; private set; }

        public Rectangle SourceRectangle { get; private set; }

        public Vector2 Size { get; set; }

        public float Depth { get; set; }

        public Sprite(Texture2D Texture, Rectangle SourceRectangle, Vector2 Size, float Depth)
        {
            this.Texture = Texture;
            this.SourceRectangle = SourceRectangle;
            this.Size = Size;
            this.Depth = Depth;
        }
    }
}