using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace ParticleEngine2D
{
    public class FireParticle : Particle
    {
        Random random;

        public FireParticle() : base()
        {
            random = new Random();

            this.Texture = Texture;
            this.Position = Position;
            this.TTL = 60 + random.Next(40);
            this.Color = new Color(250, 20, 20);

            float randomBetween = (float)GetRandomNumber(-0.01, -0.01); 
            float randomBetweenTo = (float)GetRandomNumber(-0.4, -0.4); 

            this.Velocity = new Vector2(randomBetween, randomBetweenTo);
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}