using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State.Provider;
    using Texture;
    using Texture.GameObjectTextureDefinition;

    public class ArrowGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            string gameObjectStateString = GameObjectStateProvider.GetStateString(gameObject);

            TextureDefinition textureDefinition = TextureDefinitionFactory.Get(gameObjectStateString);

            // gameObject.state as first param
            Sprite sprite = gameObject.AnimationContainer.getCurrentSprite(TextureDefinitionFactory.Get(gameObjectStateString), gameTime);
            sprite.Depth = 0.6f;

            //based on arrow facing rotate the sprite
            sprite.Size = new Vector2(0.3f, 0.3f);
            spriteRender.Draw(sprite, gameObject.position);
        }
    }
}
