using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Object;

namespace Component
{
    public class MoronGraphicComponent : GraphicComponent
    {
        public override void update(GameObject gameObject)
        {

            int width = gameObject.texture.Width / 8;
            int height = gameObject.texture.Height / 1;
            int row = (int)((float)0 / (float)8);
            int column = 0 % 8;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)gameObject.position.X, (int)gameObject.position.Y, width, height);

            gameObject.getGame()
                    .getSpriteBatch()
                    .Draw(gameObject.texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
