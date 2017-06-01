using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface IContentManager
{
    void loadContent(GraphicsDevice graphicsDevice);

    void updateInput(GameTime gameTime);

    void updateGraphic(GameTime gameTime);
}
