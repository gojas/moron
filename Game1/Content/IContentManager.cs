using Microsoft.Xna.Framework;

public interface IContentManager
{
    void loadContent();

    void updateInput(GameTime gameTime);

    void updateGraphic(GameTime gameTime);
}
