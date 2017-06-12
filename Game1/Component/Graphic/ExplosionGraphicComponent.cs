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
                animation = new Animation(spriteRender, gameTime);

                for (int i = 0; i < explosionTextureDefinition.GetSriteTotal(); i++)
                {
                    animation.AddSprite(gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(explosionTextureDefinition, i));
                }
            }
                
            animation.Play();
        }

    }
}
