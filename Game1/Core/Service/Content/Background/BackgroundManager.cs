using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Core.Service.Factory;
using Core.Model;

namespace Core.Service.Content.Background
{
    using Game1;

    public class BackgroundManager : IContentManager
    {
        Game1 game;

        ModelFactory modelFactory;
        AbstractModel background;

        public BackgroundManager(Game1 game1)
        {
            game = game1;
        }

        public void loadContent()
        {
            modelFactory = ServiceContainer.GetService<ModelFactory>();

            background = modelFactory.get("background");
        }

        public void updateInput()
        {

        }

        public void updatePhysics()
        {

        }

        public void updateGraphic(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch, new Vector2(background.getXPosition(), background.getYPosition()));
        }
    }
}
