using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Object.List;

namespace Object.Factory
{
    using Game1;
    using System;
    using Component;

    public class GameObjectFactory
    {

        Game1 game;


        public GameObjectFactory(Game1 aGame)
        {
            game = aGame;
        }

        public GameObject get(int gameObjectId)
        {
            Vector2 position = new Vector2(300, 400);
            Texture2D texture = game.Content.Load<Texture2D>("player");

            // add components yoooo
            ComponentContainer componentContainer = new ComponentContainer();

            foreach (var componentName in GameObjectList.getComponentsByIndex(0))
            {
                componentContainer.add(getInputComponent(componentName.ToString()));
            }

            // if gameObjectId has custom object let's say MoronGameObject, initialize it instead of abstract one
            GameObject gameObject = new GameObject(position, texture, componentContainer);

            // still figuring out if this is silly or not...
            gameObject.setSpriteBatch(game.getSpriteBatch());

            return gameObject;
        }

        private Component getInputComponent(string componentName)
        {
            return Activator.CreateInstance(Type.GetType("Component." + componentName)) as Component;
        }
    }
}