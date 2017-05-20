using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Core.Model
{
    public class Player : AbstractModel
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;

        public Player(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
        }

        public override void Update()
        {
            KeyboardState state = Keyboard.GetState();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (var key in state.GetPressedKeys())
                sb.Append("Keys: ").Append(key).Append(" pressed ");

            if (sb.Length > 0)
                System.Diagnostics.Debug.WriteLine(sb.ToString());
            else
                System.Diagnostics.Debug.WriteLine("No keys pressed");

            if (state.IsKeyDown(Keys.D))
                position.X += speed;
            if (state.IsKeyDown(Keys.A))
                position.X -= speed;
            if (state.IsKeyDown(Keys.W))
                position.Y -= speed;
            if (state.IsKeyDown(Keys.S))
                position.Y += speed;
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}