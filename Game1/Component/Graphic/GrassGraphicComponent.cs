using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Texture;
    using World.GameObject.State.Provider;
    using Texture.GameObjectTextureDefinition;
    using World.GameObject.State.States;

    public class GrassGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            string gameObjectStateString = GameObjectStateProvider.GetStateString(gameObject);

            TextureDefinition textureDefinition = TextureDefinitionFactory.Get(gameObjectStateString);

            gameObject.Color = gameObject.Damaged ? Color.Red : Color.White;

            // gameObject.state as first param
            Sprite sprite = gameObject.AnimationContainer.getCurrentSprite(TextureDefinitionFactory.Get(gameObjectStateString), gameTime);
            sprite.Depth = depth;

            gameObject.Color = Color.White;
            if (gameObject.GameObjectStateContainer.GetPrevious() is StateWaving) {
                gameObject.Color = Color.Red;
            }

            spriteRender.Draw(sprite, gameObject.position, gameObject.Color);
        }
    }
}
