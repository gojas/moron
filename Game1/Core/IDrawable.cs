using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface IDrawable
{
    void Draw(SpriteBatch spriteBatch, Vector2 position);
}
