using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameObject.List;

namespace GameObject.Factory
{
    using Game1;
    using System;
    using Component;
    using System.Reflection;
    using System.Linq;
    using System.Collections;
    using Texture;

    public class GameObjectFactory
    {

        Game1 game;

        private const string COMPONENTS_NAMESPACE = "Component";

        public GameObjectFactory(Game1 aGame)
        {
            game = aGame;
        }

        public GameObject get(int gameObjectId)
        {
            object gameObjectConfiguration = GameObjectList.getById(gameObjectId);

            Type type = gameObjectConfiguration.GetType();

            PropertyInfo componentsPropertyInfo = type.GetProperty("components");
            PropertyInfo textureAtlasPropertyInfo = type.GetProperty("textureAtlas");

            // set position, for now here
            Vector2 position = new Vector2(
                300,
                300
            );

            // set texture

            /** REALLY BAD, INSTANTIATING TextureAtlasLoader and SpriteSheet for EVERY GAME OBJECT, YOU NUTS! **/
            TextureAtlasLoader textureAtlasLoader = new TextureAtlasLoader(game.Content);
            SpriteSheetContainer spriteSheetContainer = textureAtlasLoader.load(textureAtlasPropertyInfo.GetValue(gameObjectConfiguration, null).ToString());

            // set components
            ComponentContainer componentContainer = new ComponentContainer();

            string[] componentsArray = ((IEnumerable)componentsPropertyInfo.GetValue(gameObjectConfiguration, null)).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            foreach (var componentName in componentsArray)
                componentContainer.add(getInputComponent(componentName.ToString()));

            // if gameObjectId has custom object let's say MoronGameObject, initialize it instead of abstract one
            // big question remains. pass game instance here, or in ContentManager in update methods?
            return new GameObject(spriteSheetContainer, componentContainer);
        }

        private Component getInputComponent(string componentName)
        {
            return Activator.CreateInstance(Type.GetType(COMPONENTS_NAMESPACE + "." + componentName)) as Component;
        }
    }
}