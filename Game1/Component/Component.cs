using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.Scene;
    using Comora;
    using QuadTree;
    using Texture;

    public class Component : IComponent
    {
        public virtual void update(GameObject gameObject)
        {

        }

        public virtual void update(GameObject originGameObject, GameObject gameObject)
        {

        }

        public virtual void update(GameObject gameObject, Camera camera)
        {

        }

        public virtual void update(GameObject gameObject, QuadTree quadTree)
        {

        }

        public virtual void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime)
        {

        }

        public virtual void update(GameObject gameObject, QuadTree quadTre, SceneManager sceneManager)
        {

        }
    }
}
