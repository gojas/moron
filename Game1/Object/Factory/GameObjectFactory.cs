using Component.Input;
using Component.Physics;
using Component.Graphic;

namespace Object.Factory
{
    using Game1;

    public class GameObjectFactory
    {
        Game1 game;

        public GameObjectFactory(Game1 aGame)
        {
            game = aGame;    
        }

        public GameObject get(string name)
        {
            // NOT like this! set texture based on model itself... Player model can have 'dude' texture :(

            switch (name)
            {
                case "moron":
                    //build for example MoronInputComponent() if exists, if not use InputComponent();
                    return new GameObject(new InputComponent(), new PhysicsComponent(), new GraphicComponent());

                    // testing yoooo
            }

            return new GameObject(new InputComponent(), new PhysicsComponent(), new GraphicComponent());
        }
    }
}