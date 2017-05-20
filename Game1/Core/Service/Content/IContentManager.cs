using Microsoft.Xna.Framework.Graphics;

public interface IContentManager
{
    void loadContent();

    void updateInput();

    void updatePhysics();

    void updateGraphic(SpriteBatch spriteBatch);
}
