using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State.Provider;
    using Texture;
    using Texture.GameObjectTextureDefinition;

    public class MoronGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            string gameObjectStateString = GameObjectStateProvider.GetStateString(gameObject);


            TextureDefinition textureDefinition = TextureDefinitionFactory.Get(gameObjectStateString);

            // gameObject.state as first param
            Sprite sprite = gameObject.AnimationContainer.getCurrentSprite(TextureDefinitionFactory.Get(gameObjectStateString), gameTime);
            sprite.Depth = depth;
            spriteRender.Draw(sprite, gameObject.position, gameObject.Color);
        }
    }
}
