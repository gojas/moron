using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace World.Terrain
{
    public class Terrain
    {
        Texture2D Texture;
        Vector2 Position { get; set; }

        public Terrain(Texture2D Texture)
        {
            this.Texture = Texture;
        }



    }
}
