using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Core.Model
{
    public abstract class AbstractModel : IDrawable, IUpdateable
    {
        protected Vector2 position;

        protected float speed = 5;

        public abstract void Draw(SpriteBatch spriteBatch, Vector2 position);
        public abstract void Update();

        public AbstractModel setXPosition(float value)
        {
            this.position.X = value;

            return this;
        }

        public AbstractModel setYPosition(float value)
        {
            this.position.Y = value;

            return this;
        }

        public float getXPosition()
        {
            return this.position.X;
        }

        public float getYPosition()
        {
            return this.position.Y;
        }
    }
}
