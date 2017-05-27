using Microsoft.Xna.Framework;
using Component;
using Texture;

namespace World.GameObject
{
    using World.GameObject.State;
    using World.GameObject.Item;

    public class GameObject
    {
        public Vector2 position;
        public float depth;

        public string name;

        public GameObjectItemsContainer gameObjectItemsContainer;
        public AnimationContainer animationContainer;
        public ComponentContainer componentContainer;
        public GameObjectState state;

        // huh hah?!
        public float speed = 5;

        public GameObject(
            GameObjectItemsContainer gameObjectItemsContainer,
            AnimationContainer animationContainer,
            ComponentContainer componentContainer
        )
        {
            this.gameObjectItemsContainer = gameObjectItemsContainer;
            this.animationContainer = animationContainer;
            this.componentContainer = componentContainer;
            this.state = new GameObjectState(this);
        }

        public ComponentContainer getComponentContainer()
        {
            return componentContainer;
        }

        public GameObjectItemsContainer GetItemsContainer()
        {
            return gameObjectItemsContainer;
        }

        public GameObjectItem GetPotionItem(string name)
        {
            return gameObjectItemsContainer.Get(name);
        }

        public GameObjectItem GetWeaponItem(string name)
        {
            return gameObjectItemsContainer.Get(name);
        }

        public GameObjectState getState()
        {
            return state;
        }
    }
}