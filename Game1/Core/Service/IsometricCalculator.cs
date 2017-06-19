using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Core.Service
{
    using System;
    using World.Terrain;

    public class IsometricCalculator
    {
        GraphicsDevice graphicsDevice;

        public IsometricCalculator(GraphicsDevice graphicsDevice)
        {
            this.graphicsDevice = graphicsDevice;
        }

        public Vector2 PositionToIso(int x, int y)
        {
            float positionX = (x - y) * Tile.WIDTH / 2;
            float positionY = (x + y) * Tile.HEIGHT / 2;

            return new Vector2(positionX, positionY);
        }

        public Vector2 GetTileCoordinates(Vector2 position)
        {
            float xCoordinate = position.X / Tile.WIDTH;
            float yCoordinate = position.Y / 64; // TEXTURE, not TILE

            return new Vector2((int)Math.Floor(xCoordinate), (int)Math.Floor(yCoordinate));
        }

}
}
