using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Component;

namespace Object
{
    public class GameObject : IGameObject
    {
        public SpriteBatch spriteBatch;

        public Vector2 position;
        public Texture2D texture;
        public ComponentContainer componentContainer;

        // huh hah?!
        public float speed = 5;

        public GameObject(
            Vector2 aPosition,
            Texture2D aTexture,
            ComponentContainer aComponentContainer
        )
        {
            position = aPosition;
            texture = aTexture;
            componentContainer = aComponentContainer;
        }

        public void update()
        {
            componentContainer.getAll().ForEach((component) =>
            {
                component.update(this);
            });
        }

        public ComponentContainer getComponentContainer()
        {
            return componentContainer;
        }

        public GameObject setSpriteBatch(SpriteBatch aSpriteBatch)
        {
            spriteBatch = aSpriteBatch;

            return this;
        }

        public SpriteBatch getSpriteBatch()
        {
            return spriteBatch;
        }
    }
}
