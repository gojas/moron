using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

namespace World.GameObject
{
    using World.GameObject.Factory;
    using Texture;
    using World.Scene;
    using QuadTree;
    using Comora;

    public class GameObjectManager
    {
        ContentManager contentManager;

        GameObjectContainer gameObjectContainer;
        GameObjectFactory gameObjectFactory;

        public List<GameObject> List;

        public GameObjectManager(ContentManager contentManager, SpriteManager spriteManager)
        {
            this.contentManager = contentManager;
            this.gameObjectFactory = new GameObjectFactory(spriteManager.GetSpriteContainerList());
            this.gameObjectContainer = new GameObjectContainer();

            List = new List<GameObject>();
        }

        public GameObject Get(int id)
        {
            // load container, and get from container here
            return gameObjectFactory.Get(id);
        }

        public void Load(int id)
        {
        
        }

        public List<GameObject> Get(SceneManager sceneManager, int fromPositionX, int fromPositionY)
        {
            int[,] matrix = sceneManager.Scene.GetGameObjectMatrix();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int offset_x = 0;
                if (IsOdd(row))
                {
                    offset_x = Sprite.TILE_TEXTURE_WIDTH / 2;
                }

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    int gameObjectId = matrix[row, column];

                    GameObject gameObject = gameObjectFactory.Get(gameObjectId);

                    gameObject.position.X = column * Sprite.TILE_TEXTURE_WIDTH + offset_x;
                    gameObject.position.Y = row * Sprite.TEXTURE_HEIGHT / 2;

                    // fix depth

                    List.Add(gameObject);
                }
            }

            return List;
        }

        public void Update(SceneManager sceneManager, QuadTree quadTree, Camera camera) // TODO IUpdateable
        {
            quadTree.clear();

            lock (List)
            {
                foreach (var gameObject in List)
                {
                    if (null != gameObject.ComponentContainer.GetPhysicsComponent())
                        quadTree.insert(gameObject);
                }
            }

            lock (List)
            {
                foreach (var gameObject in List.ToArray())
                {
                    /** checking the state of a game, did player hit the wall? **/
                    if (null != gameObject.ComponentContainer.GetPhysicsComponent())
                        gameObject.ComponentContainer.GetPhysicsComponent().update(gameObject, quadTree, sceneManager);

                    /** did player enter specific zone **/
                    if (null != gameObject.ComponentContainer.GetScriptComponent())
                        gameObject.ComponentContainer.GetScriptComponent().update(gameObject);

                    /** handle user input here **/
                    if (null != gameObject.ComponentContainer.GetInputComponent())
                        gameObject.ComponentContainer.GetInputComponent().update(gameObject, camera);
                }
            }
        }

        public void Draw(SpriteRender spriteRender, GameTime gameTime)
        {
            lock (List)
            {
                foreach (var gameObject in List)
                {
                    if (null != gameObject.ComponentContainer.GetGraphicComponent())
                        gameObject.ComponentContainer.GetGraphicComponent().update(gameObject, spriteRender, gameTime);
                }
            }
        }

        // not here!
        private bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

    }
}
