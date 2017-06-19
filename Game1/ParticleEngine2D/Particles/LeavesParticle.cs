using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace ParticleEngine2D
{
    public class LeavesParticle : Particle
    {
        Random random;

        public LeavesParticle() : base()
        {
            random = new Random();

            this.Texture = Texture;
            this.Position = Position;
            this.Velocity = new Vector2(1f, 1f);
            this.TTL = 50 + random.Next(40);
            this.Color = new Color(
                        (float)random.NextDouble(),
                        (float)random.NextDouble(),
                        (float)random.NextDouble());

            float randomBetween = (float)GetRandomNumber(4, 6); // falling in down-right direction
            float randomBetweenTo = (float)GetRandomNumber(0.8, 1.6); // falling in down-right direction

            this.Velocity = new Vector2(randomBetween, randomBetweenTo);
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}