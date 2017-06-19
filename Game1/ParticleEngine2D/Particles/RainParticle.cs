using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace ParticleEngine2D
{
    public class RainParticle : Particle
    {

        public RainParticle(Texture2D Texture, Vector2 Position) : base(Texture, Position)
        {
            Random random = new Random();

            this.Texture = Texture;
            this.Position = Position;
            this.Velocity = new Vector2(1f, 1f);
            this.TTL = 50 + random.Next(40);
            this.Color = Color.WhiteSmoke;
        }

        public override void Update()
        {
            Position += Velocity;
            Angle += AngularVelocity;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}