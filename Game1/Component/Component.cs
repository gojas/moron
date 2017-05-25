using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Game1;
    using QuadTree;
    using Texture;

    public class Component : IComponent
    {
        public virtual void update(GameObject gameObject)
        {

        }

        public virtual void update(GameObject gameObject, Game1 game)
        {

        }

        public virtual void update(GameObject gameObject, QuadTree quadTree)
        {

        }

        public virtual void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime)
        {

        }
    }
}
