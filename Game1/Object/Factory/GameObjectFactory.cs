using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Object.List;

namespace Object.Factory
{
    using Game1;
    using System;
    using Component;
    using System.Reflection;
    using System.Linq;
    using System.Collections;

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
            PropertyInfo positionXPropertyInfo = type.GetProperty("positionX");
            PropertyInfo positionYPropertyInfo = type.GetProperty("positionY");
            PropertyInfo texturePropertyInfo = type.GetProperty("texture");


            object positionXPropertyInfoValue = positionXPropertyInfo.GetValue(gameObjectConfiguration, null);

            // set position
            Vector2 position = new Vector2(
                Convert.ToSingle(positionXPropertyInfo.GetValue(gameObjectConfiguration, null)),
                Convert.ToSingle(positionYPropertyInfo.GetValue(gameObjectConfiguration, null))
            );

            // set texture
            Texture2D texture = game.Content.Load<Texture2D>(texturePropertyInfo.GetValue(gameObjectConfiguration, null).ToString());


            // set components
            ComponentContainer componentContainer = new ComponentContainer();

            string[] componentsArray = ((IEnumerable)componentsPropertyInfo.GetValue(gameObjectConfiguration, null)).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            foreach (var componentName in componentsArray)
                componentContainer.add(getInputComponent(componentName.ToString()));

            // if gameObjectId has custom object let's say MoronGameObject, initialize it instead of abstract one
            return new GameObject(game.getSpriteBatch(), position, texture, componentContainer);
        }

        private Component getInputComponent(string componentName)
        {
            return Activator.CreateInstance(Type.GetType(COMPONENTS_NAMESPACE + "." + componentName)) as Component;
        }
    }
}