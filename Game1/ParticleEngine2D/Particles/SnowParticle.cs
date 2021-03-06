﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace ParticleEngine2D
{
    public class SnowParticle : Particle
    {
        Random random;

        public SnowParticle() : base()
        {
            random = new Random();
            
            this.TTL = random.Next(1, 500);
            this.Color = Color.WhiteSmoke;

            // 0.2 1 normal
            // 2 4 fast
            float randomBetween = (float)GetRandomNumber(0.2, 1); // falling in down-right direction
            float randomBetweenTo = (float)GetRandomNumber(0.8, 1.6); // falling in down-right direction

            this.Velocity = new Vector2(randomBetween, randomBetweenTo);
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}