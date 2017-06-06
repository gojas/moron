using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Texture;
    using World.GameObject.State.Provider;
    using Texture.GameObjectTextureDefinition;

    public class FixedBottomOriginGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime, float depth)
        {
            int originY = Sprite.TILE_TEXTURE_HEIGHT * 2 + 48;

            string gameObjectStateString = GameObjectStateProvider.GetStateString(gameObject);

            TextureDefinition textureDefinition = TextureDefinitionFactory.Get(gameObjectStateString);

            Sprite sprite = gameObject.AnimationContainer.getCurrentSprite(TextureDefinitionFactory.Get(gameObjectStateString), gameTime);
            sprite.Depth = depth;
            spriteRender.Draw(sprite, gameObject.position, new Vector2(0, originY));
        }
    }
}
