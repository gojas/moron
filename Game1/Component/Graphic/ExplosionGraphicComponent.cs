using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Texture;
    using Texture.GameObjectTextureDefinition;
    using Texture.Animation;

    public class ExplosionGraphicComponent : GraphicComponent
    {
        Animation animation;

        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            ExplosionStanding explosionTextureDefinition = new ExplosionStanding();

            if (animation == null) {
                animation = new Animation(spriteRender, gameTime, 0.02f, gameObject.position);

                for (int i = 0; i < explosionTextureDefinition.GetSriteTotal(); i++)
                {
                    animation.AddSprite(gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(explosionTextureDefinition, i));
                }
            }

            if (animation.isFinished)
            {
                gameObject.Destroyed = true;
            }
            else {
                animation.Draw();
            }

            
            
            /**
            EmberStanding emberTextureDefinition = new EmberStanding();
            Sprite sprite = gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(emberTextureDefinition, 0);


            List<Texture2D> textures = new List<Texture2D>();
            textures.Add(sprite.Texture);
            ParticleEngine particleEngine = new ParticleEngine(textures, new Vector2(gameObject.position.X, gameObject.position.Y));

            // gameObject.position.X = gameObject.position.X + 1;
            particleEngine.EmitterLocation = gameObject.position;
            particleEngine.Update();
            particleEngine.Draw(spriteRender.SpriteBatch);
    **/
        }

    }
}
