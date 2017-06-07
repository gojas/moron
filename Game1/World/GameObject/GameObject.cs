using Microsoft.Xna.Framework;
using Component;
using Texture;

namespace World.GameObject
{
    using World.GameObject.State;
    using World.GameObject.Item;
    using World.Scene;
    using QuadTree;

    public class GameObject: ISceneManagerAware, IQuadTreeAware
    {

        public GameObject()
        {

        }

        public Vector2 position;
        public float depth;

        public Color Color;

        public string Name { get; set; }

        public SceneManager SceneManager;
        public QuadTree QuadTree;

        public Sprite Sprite { get; set; }
        public GameObjectItemsContainer GameObjectItemsContainer { get; set; }
        public AnimationContainer AnimationContainer { get; set; }
        public ComponentContainer ComponentContainer { get; set; }
        public GameObjectState State { get; set; }

        public GameObjectStateContainer GameObjectStateContainer { get; set; }

        public float speed = 5; // for now here
        public float Health = 100; // for now here

        public bool Disabled = false;
        public bool Destroyed = false;

        public void Update()
        {

        }

        public virtual void FireRange()
        {
            // this.GameObjectItems.GetRange();


        }

        public void SetSceneManager(SceneManager sceneManager)
        {
            SceneManager = sceneManager;
        }

        public SceneManager GetSceneManager()
        {
            return SceneManager;
        }

        public void SetQuadTree(QuadTree quadTree)
        {
            QuadTree = quadTree;
        }

        public QuadTree GetQuadTree()
        {
            return QuadTree;
        }
    }
}