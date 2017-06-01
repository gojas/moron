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

        public string Name { get; set; }

        public enum Prototype { Fixed, Static, Dynamic };
        public Prototype prototype { get; set; }

        public Sprite Sprite { get; set; }
        public GameObjectItemsContainer GameObjectItemsContainer { get; set; }
        public AnimationContainer AnimationContainer { get; set; }
        public ComponentContainer ComponentContainer { get; set; }
        public GameObjectState State { get; set; }

        public GameObjectStateContainer GameObjectStateContainer { get; set; }

        public float speed = 5;

        public bool Disabled = false;
        public bool Destroyed = false;

        public void Update()
        {

        }
    }
}