using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Core.Service.Factory
{
    using Model;

    public class ModelFactory: IModelFactory
    {
        Game game;

        public ModelFactory(Game game1)
        {
            game = game1;
        }

        public AbstractModel get(string name)
        {
            // NOT like this! set texture based on model itself... Player model can have 'dude' texture :(
            Texture2D texture = game.Content.Load<Texture2D>(name);

            switch (name)
            {
                case "player":
                    return new Player(texture, 1, 8);
                case "background":
                    return new Background(texture);
                default:

                    // testing yoooo
                    Texture2D texture2 = game.Content.Load<Texture2D>("player");
                    return new Brick(texture2, 1, 8);
            }
        }
    }
}
