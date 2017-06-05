using System;
using System.Collections;
using System.Collections.Generic;

namespace World.GameObject.Factory
{
    using World.GameObject.Item;
    using Component;
    using GameObjects;
    using System.Linq;
    using Texture;
    using World.GameObject.State;
    

    public class GameObjectFactory
    {

        private readonly IDictionary<int, GameObject> objectPool;

        private const string GAME_OBJECTS_NAMESPACE = "World.GameObject";
        private const string COMPONENTS_NAMESPACE = "Component";
        private const string GAME_OBJECT_ITEM_NAMESPACE = "World.GameObject.Item";

        SpriteContainerList spriteContainerList;
        GameObject gameObject;

        public GameObjectFactory(SpriteContainerList spriteContainerList)
        {
            this.spriteContainerList = spriteContainerList;
            this.objectPool = new Dictionary<int, GameObject>();
        }

        public GameObject Get(int id)
        {

            if (objectPool.ContainsKey(id))
                return objectPool[id];

            // cache configuration, less reflection stuff!
            object gameObjectConfiguration = GameObjects.GetById(id);

            Type type = gameObjectConfiguration.GetType();


            object items = type.GetProperty("items").GetValue(gameObjectConfiguration, null);
            object components = type.GetProperty("components").GetValue(gameObjectConfiguration, null);
            object textureAtlases = type.GetProperty("textureAtlases").GetValue(gameObjectConfiguration, null);
            string customClass = type.GetProperty("customClass").GetValue(gameObjectConfiguration, null).ToString();

            string className = "GameObject";
            if (customClass != "")
                className = customClass;

            gameObject = getGameObject(className);

            gameObject.Name = type.GetProperty("name").GetValue(gameObjectConfiguration, null).ToString();

            setItems(items);
            setTextures(textureAtlases);
            setComponents(components);

            gameObject.State = new GameObjectState(gameObject);

            // FOR NOW!!!
            if (id == 0)
                gameObject.State.SetCurrentWeaponName("Pistol");

            gameObject.GameObjectStateContainer = new GameObjectStateContainer(gameObject);

            // string typeValue = type.GetProperty("type").GetValue(gameObjectConfiguration, null).ToString();

            objectPool.Add(id, gameObject);

            return gameObject;
        }

        private void setItems(object items)
        {
            string[] itemsArray = ((IEnumerable)items).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            if (itemsArray.Count() > 0) {
                gameObject.GameObjectItemsContainer = new GameObjectItemsContainer();

                foreach (var item in itemsArray)
                    gameObject.GameObjectItemsContainer.Add(item.ToString(), getGameObjectItem(item.ToString()));
            }
        }

        private void setTextures(object textures)
        {
            string[] textureAtlasesArray = ((IEnumerable)textures).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            if (textureAtlasesArray.Count() > 0)
            {
                gameObject.AnimationContainer = new AnimationContainer();

                foreach (var textureAtlasName in textureAtlasesArray)
                    gameObject.AnimationContainer.Add(textureAtlasName.ToString(), spriteContainerList.GetSpriteContainer(textureAtlasName.ToString()));
            }
        }

        private void setComponents(object components)
        {
            string[] componentsArray = ((IEnumerable)components).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();

            if (componentsArray.Count() > 0)
            {
                gameObject.ComponentContainer = new ComponentContainer();

                foreach (var component in componentsArray)
                    gameObject.ComponentContainer.Add(getComponent(component.ToString()));
            }
        }

        private GameObject getGameObject(string name)
        {
            return Activator.CreateInstance(Type.GetType(GAME_OBJECTS_NAMESPACE + "." + name)) as GameObject;
        }

        private Component getComponent(string componentName)
        {
            return Activator.CreateInstance(Type.GetType(COMPONENTS_NAMESPACE + "." + componentName)) as Component;
        }

        private GameObjectItem getGameObjectItem(string gameObjectName)
        {
            return Activator.CreateInstance(Type.GetType(GAME_OBJECT_ITEM_NAMESPACE + "." + gameObjectName)) as GameObjectItem;
        }

    }
}
