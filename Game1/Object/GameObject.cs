using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Component;

namespace GameObject
{
    using Game1;

    public class GameObject
    {
        public Game1 game;
        public QuadTree.QuadTree quadTree;

        public Vector2 position;
        public Texture2D texture;
        public ComponentContainer componentContainer;

        // huh hah?!
        public float speed = 5;

        public GameObject(
            Game1 aGame,
            Vector2 aPosition,
            Texture2D aTexture,
            ComponentContainer aComponentContainer
        )
        {
            game = aGame;
            position = aPosition;
            texture = aTexture;
            componentContainer = aComponentContainer;
        }

        public ComponentContainer getComponentContainer()
        {
            return componentContainer;
        }

        public Game1 getGame()
        {
            return game;
        }
    }
}
