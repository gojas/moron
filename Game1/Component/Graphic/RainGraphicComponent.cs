using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Texture;
    using Texture.GameObjectTextureDefinition;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Graphics;
    using ParticleEngine2D;

    public class RainGraphicComponent : GraphicComponent
    {
        ParticleEngine particleEngine;

        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            
            EmberStanding emberTextureDefinition = new EmberStanding();
            Sprite sprite = gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(emberTextureDefinition, 0);

            if (particleEngine == null) {
                List<Texture2D> textures = new List<Texture2D>();
                textures.Add(sprite.Texture);
                
                particleEngine = new ParticleEngine(textures, gameTime);
                particleEngine.EmitterRectangle = new Rectangle(0, 0, 1000, 600);
            }
           
            particleEngine.Draw(spriteRender.SpriteBatch);
        }

    }
}
