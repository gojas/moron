using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ParticleEngine2D
{
    public class ParticleFactory
    {
        public ContentManager contentManager;

        public ParticleFactory(ContentManager contentManager)
        {
            this.contentManager = contentManager;
        }

        public Particle Get(string particleName, Texture2D texture, Vector2 position)
        {
            Particle particle = GetParticle(particleName);

            particle.Texture = texture;
            particle.Position = position;

            return particle;
        }

        private Particle GetParticle(string name)
        {
            if (null == name)
                name = "Particle";

            return Activator.CreateInstance(Type.GetType("ParticleEngine2D." + name)) as Particle;
        }
    }
}