using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Core.Service.Content.Background;
using Core.Service.Factory;
using Core.Model;
using Object;
using Object.Factory;



namespace Core.Service.Content
{
    using Game1;

    public class ContentManager : IContentManager
    {
        Game1 game;
        ModelFactory modelFactory;

        GameObject playerMoron;
        GameObjectFactory gameObjectFactory;

        AbstractModel player;
        AbstractModel brick;

        BackgroundManager backgroundManager;

        public ContentManager(Game1 game1)
        {
            game = game1;

            backgroundManager = new BackgroundManager(game);
        }

        public void loadContent()
        {
            modelFactory = ServiceContainer.GetService<ModelFactory>();

            gameObjectFactory = ServiceContainer.GetService<GameObjectFactory>();

            // load background
            backgroundManager.loadContent();

            // load player
            player = modelFactory.get("player");

            playerMoron = gameObjectFactory.get("moron");


            // load rest of the shit
            brick = modelFactory.get("sprite").setXPosition(300).setYPosition(300);
        }

        public void updateInput()
        {
            // on game Update();
            backgroundManager.updateInput();

            player.Update();
            brick.Update();

            playerMoron.updateInput();
        }

        public void updatePhysics()
        {
            System.Diagnostics.Debug.WriteLine(string.Concat(player.getXPosition(), player.getYPosition()));
        }

        public void updateGraphic(SpriteBatch spriteBatch)
        {

            backgroundManager.updateGraphic(spriteBatch);

            // on game Draw();
            player.Draw(spriteBatch, new Vector2(player.getXPosition(), player.getYPosition()));
            brick.Draw(spriteBatch, new Vector2(brick.getXPosition(), brick.getYPosition()));

            playerMoron.updateGraphic();
        }
    }
}
