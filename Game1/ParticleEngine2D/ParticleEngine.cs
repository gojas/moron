﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Core.Service;

namespace ParticleEngine2D
{
    public class ParticleEngine
    {
        private Random random;
        private string particleName = "Particle";
        private List<Particle> particles;
        private List<Texture2D> textures;
        private GameTime gameTime;
        private float timeElapsed = 0;
        private ParticleFactory particleFactory;

        public Rectangle EmitterRectangle { get; set; }

        public float Tick { get; set; }  = 0.01f; // 1f == 1 second
        public int TotalPerTick { get; set; } = 2; // how many particles should be generated on turn

        public ParticleEngine(string particleName, List<Texture2D> Textures, GameTime GameTime)
        {
            this.particleName = particleName;
            this.textures = Textures;
            this.particles = new List<Particle>();
            this.gameTime = GameTime;
            this.random = new Random();
            this.particleFactory = ServiceContainer.GetService<ParticleFactory>();
        }

        public void Update()
        {
            timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (timeElapsed > Tick)
            {
                timeElapsed -= Tick;

                for (int i = 0; i < TotalPerTick; i++)
                {
                    particles.Add(GenerateNewParticle());
                }

                for (int particle = 0; particle < particles.Count; particle++)
                {
                    particles[particle].TTL--;
                    particles[particle].Update();
                    if (particles[particle].TTL <= 0)
                    {
                        particles.RemoveAt(particle); // (GU): add effects
                        particle--;
                    }
                }
            }
        }

        private Particle GenerateNewParticle()
        {
            Texture2D texture = textures[random.Next(textures.Count)];
            Vector2 position = new Vector2(
                EmitterRectangle.X + random.Next(0, EmitterRectangle.Width), 
                EmitterRectangle.Y + random.Next(0, EmitterRectangle.Height)
            );

            return particleFactory.Get(particleName, texture, position);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Update();

            for (int index = 0; index < particles.Count; index++)
            {
                particles[index].Draw(spriteBatch);
            }
        }
    }
}