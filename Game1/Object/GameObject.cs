using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Component;
using Texture;

namespace GameObject
{

    public class GameObject
    {

        public Vector2 position;

        public SpriteSheetContainer spriteSheetContainer;
        public ComponentContainer componentContainer;

        // huh hah?!
        public float speed = 5;

        public GameObject(
            SpriteSheetContainer spriteSheetContainer,
            ComponentContainer componentContainer
        )
        {
            this.spriteSheetContainer = spriteSheetContainer;
            this.componentContainer = componentContainer;
        }

        public ComponentContainer getComponentContainer()
        {
            return componentContainer;
        }
    }
}
