using Microsoft.Xna.Framework;

namespace Component
{
    using World.GameObject;
    using Texture;
    using World.GameObject.State.Provider;
    using Texture.GameObjectTextureDefinition;

    public class FixedGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject, SpriteRender spriteRender, GameTime gameTime)
        {
            // fixed gameObjects, like walls, crates... no animations components...
            // so find a way to not animate them at all... because this can lead to performance issues later on :)
            base.update(gameObject, spriteRender, gameTime);
        }
    }
}
