using Microsoft.Xna.Framework;
using Microsoft.CSharp;

namespace Component
{
    using World.GameObject;
    using Texture;
    using Texture.GameObjectTextureDefinition;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Graphics;
    using ParticleEngine2D;
    using System;
    using System.Reflection;
    using Core.Service;

    public class SnowGraphicComponent : GraphicComponent
    {
        ParticleEngine particleEngine;

        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            EmberStanding emberTextureDefinition = new EmberStanding();
            Sprite sprite = gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(emberTextureDefinition, 0);

            if (null == particleEngine) {
                particleEngine = new ParticleEngine(
                    "SnowParticle",
                    new List<Texture2D>() { sprite.Texture }, 
                    gameTime
                );
                particleEngine.EmitterRectangle = new Rectangle(0, 0, 1000, 600); // (GU) : based on player set emitter location
            }
           
            particleEngine.Draw(spriteRender.SpriteBatch);
        }

    }
}
