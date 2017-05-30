using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Core.Service
{
    using System;
    using Texture;

    public class IsometricCalculator
    {
        GraphicsDevice graphicsDevice;

        public IsometricCalculator(GraphicsDevice graphicsDevice)
        {
            this.graphicsDevice = graphicsDevice;
        }

        public Vector2 PositionToIso(int x, int y)
        {
            float positionX = (x - y) * Sprite.TEXTURE_WIDTH / 2;
            float positionY = (x + y) * Sprite.TEXTURE_HEIGHT / 2;

            return new Vector2(positionX, positionY);
        }

        public Vector2 GetTileCoordinates(Vector2 position, int textureHeight)
        {
            float xCoordinate = position.X / Sprite.TEXTURE_WIDTH;
            float yCoordinate = position.Y / Sprite.TILE_TEXTURE_HEIGHT / 2; // TEXTURE, not TILE

            return new Vector2((int)Math.Floor(xCoordinate), (int)Math.Floor(yCoordinate));
        }

}
}
