using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State.Provider;
    using Texture;
    using Texture.GameObjectTextureDefinition;
    using System;
    using Texture.Animation;
    using System.Timers;

    public class ExplosionGraphicComponent : GraphicComponent
    {

        int SpriteIndex = 0;

        private float timeElapsed = 0;

        private bool IsLooping = true;
        private float timeToUpdate = 1f; // 1 second
        public int FramesPerSecond
        {
            set { timeToUpdate = (1f / value); }
        }
        

        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            string gameObjectStateString = GameObjectStateProvider.GetStateString(gameObject);


            ExplosionStanding explosionTextureDefinition = new ExplosionStanding();
            timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

            int totalSpritesToRender = explosionTextureDefinition.GetSriteTotal();

            if (timeElapsed > timeToUpdate) {
                timeElapsed -= timeToUpdate;

                if (SpriteIndex < totalSpritesToRender)
                {
                    SpriteIndex++;
                }
                else if (IsLooping) {
                    SpriteIndex = 0;

                    // gameObject.Destroyed = true;
                }
            }



            // Animation animation = new Animation(spriteRender, gameTime);

            // for (int i = 0; i < explosionTextureDefinition.GetSriteTotal(); i++)
            // {
            //    animation.AddSprite(gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(explosionTextureDefinition, i));
            // }
            // animation.Play();
            

            Sprite sprite = gameObject.AnimationContainer.GetSpriteBasedOnTextureDefinitionAndIndex(explosionTextureDefinition, SpriteIndex);

            spriteRender.Draw(sprite, gameObject.position);
        }

    }
}
