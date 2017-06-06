using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State.Provider;
    using Texture;
    using Texture.GameObjectTextureDefinition;

    public class GraphicComponent : Component
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime)
        {
            string gameObjectStateString = GameObjectStateProvider.GetStateString(gameObject);
            
            TextureDefinition textureDefinition = TextureDefinitionFactory.Get(gameObjectStateString);

            // gameObject.state as first param
            Sprite sprite = gameObject.AnimationContainer.getCurrentSprite(TextureDefinitionFactory.Get(gameObjectStateString), gameTime);
            sprite.Depth = 0.4f;
            spriteRender.Draw(sprite, gameObject.position); // gameObjectHeight
        }
    }
}
