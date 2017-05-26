using Microsoft.Xna.Framework.Content;
using System;
using System.Collections;
using System.Reflection;

namespace World.GameObject.Factory
{
    using World.GameObject.Item;
    using Component;
    using GameObjects;
    using System.Linq;
    using Texture;

    public class GameObjectFactory
    {
        private const string COMPONENTS_NAMESPACE = "Component";
        private const string GAME_OBJECT_ITEM_NAMESPACE = "World.GameObject.Item";

        ContentManager contentManager;

        public GameObjectFactory(ContentManager contentManager)
        {
            this.contentManager = contentManager;
        }

        public void Load(GameObjectContainer gameObjectContainer, int id)
        {
            object gameObjectConfiguration = GameObjects.getById(id);

            Type type = gameObjectConfiguration.GetType();

            PropertyInfo namePropertyInfo = type.GetProperty("name");
            PropertyInfo componentsPropertyInfo = type.GetProperty("components");
            PropertyInfo textureAtlasPropertyInfo = type.GetProperty("textureAtlases");
            PropertyInfo itemsPropertyInfo = type.GetProperty("items");

            // set items
            string[] itemsArray = ((IEnumerable)itemsPropertyInfo.GetValue(gameObjectConfiguration, null)).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            GameObjectItemsContainer gameObjectItemsContainer = new GameObjectItemsContainer();

            foreach (var item in itemsArray)
                gameObjectItemsContainer.Add(item.ToString(), getGameObjectItem(item.ToString()));


            // set texture
            string[] textureAtlasesArray = ((IEnumerable)textureAtlasPropertyInfo.GetValue(gameObjectConfiguration, null)).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            /** REALLY BAD, INSTANTIATING TextureAtlasLoader and SpriteSheet for EVERY GAME OBJECT, YOU NUTS! **/
            TextureAtlasLoader textureAtlasLoader = new TextureAtlasLoader(this.contentManager);
            AnimationContainer animationContainer = new AnimationContainer();

            foreach (var textureAtlasName in textureAtlasesArray)
                animationContainer.Add(textureAtlasName.ToString(), textureAtlasLoader.load(textureAtlasName.ToString()));

            // set components
            ComponentContainer componentContainer = new ComponentContainer();

            string[] componentsArray = ((IEnumerable)componentsPropertyInfo.GetValue(gameObjectConfiguration, null)).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            foreach (var componentName in componentsArray)
                componentContainer.add(getInputComponent(componentName.ToString()));

            GameObject gameObject = new GameObject(gameObjectItemsContainer, animationContainer, componentContainer);

            gameObject.name = namePropertyInfo.GetValue(gameObjectConfiguration, null).ToString();

            gameObjectContainer.Add(id, gameObject);
        }

        private Component getInputComponent(string componentName)
        {
            return Activator.CreateInstance(Type.GetType(COMPONENTS_NAMESPACE + "." + componentName)) as Component;
        }

        private GameObjectItem getGameObjectItem(string gameObjectName)
        {
            return Activator.CreateInstance(Type.GetType(GAME_OBJECT_ITEM_NAMESPACE + "." + gameObjectName)) as GameObjectItem;
        }

    }
}
