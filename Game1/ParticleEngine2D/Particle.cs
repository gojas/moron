using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace ParticleEngine2D
{
    public class Particle
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; } // particle speed
        public float Angle { get; set; }
        public float AngularVelocity { get; set; } // particle rotation
        public Color Color { get; set; }
        public float Size { get; set; }
        public int TTL { get; set; } // particle lifetime

        public Particle()
        {
            Random random = new Random();

            this.Texture = Texture;
            this.Position = Position;
            this.Velocity = new Vector2(
                                    1f * (float)(random.NextDouble() * 2 - 1),
                                    1f * (float)(random.NextDouble() * 2 - 1));
            this.Angle = 0;
            this.AngularVelocity = 0.1f * (float)(random.NextDouble() * 2 - 1);
            this.Color = new Color(
                        (float)random.NextDouble(),
                        (float)random.NextDouble(),
                        (float)random.NextDouble());

            this.Size = (float)random.NextDouble();
            this.TTL = 50 + random.Next(40);
        }

        public virtual void Update()
        {
            Position += Velocity;
            Angle += AngularVelocity;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            Vector2 origin = new Vector2(Texture.Width / 2, Texture.Height / 2);

            spriteBatch.Draw(Texture, Position, sourceRectangle, Color,
                Angle, origin, Size, SpriteEffects.None, 1f);
        }
    }
}