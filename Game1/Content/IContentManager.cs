using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface IContentManager
{
    void LoadContent(GraphicsDevice graphicsDevice);

    void Update(GameTime gameTime);

    void Draw(GameTime gameTime);
}
