using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Core.Service.Content.Background;
using Core.Service.Factory;
using Core.Model;
using Object;
using Object.Factory;
using Component;
using Component.Input;
using Component.Graphic;


namespace Core.Service.Content
{
    using Game1;
    using System.Collections.Generic;

    public class ContentManager : IContentManager
    {
        Game1 game;
        ModelFactory modelFactory;

        GameObject playerMoron;
        GameObjectFactory gameObjectFactory;

        AbstractModel player;
        AbstractModel brick;

        GameObjectContainer gameObjectContainer;

        BackgroundManager backgroundManager;

        public ContentManager(Game1 game1)
        {
            game = game1;

            backgroundManager = new BackgroundManager(game);

            gameObjectContainer = new GameObjectContainer();
        }

        public void loadContent()
        {
            modelFactory = ServiceContainer.GetService<ModelFactory>();

            gameObjectFactory = ServiceContainer.GetService<GameObjectFactory>();

            // load background
            backgroundManager.loadContent();

            // load player
            player = modelFactory.get("player");

            ComponentContainer compontentContainer = new ComponentContainer();
            compontentContainer.add(new MoronInputComponent());
            compontentContainer.add(new GraphicComponent());

            // my awesome player configuration -> use xml, json, simple array (work with memory, or not?)
            playerMoron = gameObjectFactory.get(compontentContainer);

            gameObjectContainer.add(playerMoron);

            


            // load rest of the shit
            brick = modelFactory.get("sprite").setXPosition(300).setYPosition(300);
        }

        public void updateInput()
        {
            // on game Update();
            backgroundManager.updateInput();

            player.Update();
            brick.Update();

            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                gameObject.getComponentContainer().getInputComponent().update(gameObject);
            });

            // GameObjectListManager list of gameObjects 
            // GameObjectListManager getObjectsWithInput.forEach -> update

            //playerMoron.updateInput();
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

            gameObjectContainer.getAll().ForEach((gameObject) =>
            {
                gameObject.getComponentContainer().getGraphicComponent().update(gameObject);
            });

            //playerMoron.updateGraphic();
        }
    }
}
